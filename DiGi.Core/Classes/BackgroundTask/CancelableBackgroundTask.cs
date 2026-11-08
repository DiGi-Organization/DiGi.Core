using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Provides a base class for background tasks that can be canceled during execution.
    /// </summary>
    [SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "The token source exists only for one run: Start disposes the previous one and Cleanup disposes it when the run ends.")]
    public abstract class CancelableBackgroundTask : BackgroundTask, ICancelableBackgroundTask
    {
        /// <summary>
        /// Source for controlling cancellation of the background task.
        /// </summary>
        private CancellationTokenSource? cancellationTokenSource;

        /// <summary>
        /// Indicates whether the last run was cancelled through this task's own source.
        /// </summary>
        private bool isCanceled;

        /// <summary>
        /// Occurs when the task has been canceled.
        /// </summary>
        public event EventHandler? Canceled;

        /// <summary>
        /// Occurs when the task is being canceled.
        /// </summary>
        public event EventHandler? Cancelling;

        /// <summary>
        /// Gets the current status of the cancelable background task.
        /// <para>A run stopped by <see cref="Stop"/> or <see cref="StopAsync"/> reports
        /// <see cref="CancelableBackgroundTaskStatus.Canceled"/> until the next <see cref="Start"/>.</para>
        /// </summary>
        public CancelableBackgroundTaskStatus CancelableBackgroundTaskStatus
        {
            get
            {
                if (IsRunning)
                {
                    return CancelableBackgroundTaskStatus.Running;
                }

                if (IsCompleted)
                {
                    if (IsCanceled)
                    {
                        return CancelableBackgroundTaskStatus.Canceled;
                    }

                    if (Exception is not null || !IsSucceeded)
                    {
                        return CancelableBackgroundTaskStatus.Failed;
                    }

                    return CancelableBackgroundTaskStatus.Completed;
                }

                return CancelableBackgroundTaskStatus.Idle;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the task was cancelled before it reported failure.
        /// <para>Read while the run is still finishing - <see cref="Stop"/> and <see cref="StopAsync"/> await the
        /// run before they clean the source up - so a run stopped by its operator is recognized as cancelled and
        /// is not wrapped as a <see cref="BackgroundTaskFailureException"/> for having returned false.</para>
        /// <para>Only a cancellation requested through this task's own source counts: an
        /// <see cref="OperationCanceledException"/> raised inside the run for another reason, such as a request
        /// timeout, is a failure and is kept in <see cref="BackgroundTask.Exception"/>.</para>
        /// </summary>
        protected override bool WasCanceled => cancellationTokenSource?.IsCancellationRequested ?? false;

        /// <summary>
        /// Gets a value indicating whether the last run ended because <see cref="Stop"/> or <see cref="StopAsync"/>
        /// requested its cancellation.
        /// <para>A fault is not a cancellation: an <see cref="OperationCanceledException"/> this task's source did not
        /// request, such as a request timeout, leaves it false. Reset by <see cref="Start"/>.</para>
        /// </summary>
        public bool IsCanceled
        {
            get
            {
                lock (lockObject)
                {
                    return isCanceled;
                }
            }
        }

        /// <summary>
        /// Starts the background task execution synchronously.
        /// </summary>
        public override void Start()
        {
            lock (lockObject)
            {
                if (IsRunning)
                {
                    return;
                }

                // A run that completed on its own was never cleaned up by Stop/StopAsync - dispose its source
                // before it is replaced, or every restart after a natural completion leaks one.
                cancellationTokenSource?.Dispose();

                isCanceled = false;
                cancellationTokenSource = new CancellationTokenSource();

                base.Start();
            }
        }

        /// <summary>
        /// Stops the background task synchronously by canceling and waiting for completion.
        /// </summary>
        public void Stop()
        {
            CancellationTokenSource? cancellationTokenSource_Temp;
            Task? task_Temp;

            lock (lockObject)
            {
                cancellationTokenSource_Temp = cancellationTokenSource;
                task_Temp = Task;
            }

            if (cancellationTokenSource_Temp == null || task_Temp == null)
            {
                return;
            }

            OnStopping();
            cancellationTokenSource_Temp.Cancel();

            try
            {
                task_Temp.GetAwaiter().GetResult();
                if (cancellationTokenSource_Temp.IsCancellationRequested)
                {
                    OnCanceled();
                }
            }
            catch (OperationCanceledException)
            {
                OnCanceled();
            }
            finally
            {
                Cleanup();
                OnStopped();
            }
        }

        /// <summary>
        /// Stops the background task asynchronously by canceling and waiting for completion.
        /// </summary>
        /// <returns>A task that represents the asynchronous stop operation.</returns>
        public async Task StopAsync()
        {
            CancellationTokenSource? cancellationTokenSource_Temp;
            Task? task_Temp;

            lock (lockObject)
            {
                cancellationTokenSource_Temp = cancellationTokenSource;
                task_Temp = Task;
            }

            if (cancellationTokenSource_Temp == null || task_Temp == null)
            {
                return;
            }

            OnCancelling();

            cancellationTokenSource_Temp.Cancel();

            try
            {
                await task_Temp;
                if (cancellationTokenSource_Temp.IsCancellationRequested)
                {
                    OnCanceled();
                }
            }
            catch (OperationCanceledException)
            {
                OnCanceled();
            }
            finally
            {
                Cleanup();
            }
        }

        /// <summary>
        /// Executes the background task with cancellation support.
        /// <para>An <see cref="OperationCanceledException"/> is treated as a cancellation only when this task's
        /// source requested it (<see cref="Stop"/> or <see cref="StopAsync"/>). Any other one - a request timeout,
        /// a callee's own linked source - is stored in <see cref="BackgroundTask.Exception"/> like any fault, so
        /// the real cause reaches the task row instead of the generic <see cref="BackgroundTaskFailureException"/>.</para>
        /// </summary>
        /// <returns>True if the task succeeded; otherwise, false.</returns>
        protected override async Task<bool> ExecuteAsync()
        {
            if (cancellationTokenSource == null)
            {
                return false;
            }

            try
            {
                bool result = await ExecuteAsync(cancellationTokenSource.Token);
                if (cancellationTokenSource.IsCancellationRequested)
                {
                    // The run noticed the stop and returned without throwing.
                    MarkCanceled();
                }

                return result;
            }
            catch (OperationCanceledException) when (cancellationTokenSource.IsCancellationRequested)
            {
                // Canceled by Stop/StopAsync - reported through Canceled, not as a fault.
                MarkCanceled();
            }
            catch (Exception exception_Temp)
            {
                // Includes an OperationCanceledException this task's source did not request, such as a request
                // timeout: a failure the operator has to see, not a cancellation.
                exception = exception_Temp;
            }

            return false;
        }

        /// <summary>
        /// When overridden in a derived class, defines the work to be executed with a cancellation token.
        /// </summary>
        /// <param name="token">The cancellation token to observe.</param>
        /// <returns>True if the task succeeded; otherwise, false.</returns>
        protected abstract Task<bool> ExecuteAsync(CancellationToken token);

        /// <summary>
        /// Raises the Canceled event.
        /// </summary>
        protected virtual void OnCanceled() => Canceled?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the Cancelling event.
        /// </summary>
        protected virtual void OnCancelling() => Cancelling?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Disposes the cancellation token source.
        /// <para>The completed task is kept, so the status reports the outcome of the last run until the next
        /// <see cref="Start"/>.</para>
        /// </summary>
        private void Cleanup()
        {
            lock (lockObject)
            {
                cancellationTokenSource?.Dispose();
                cancellationTokenSource = null;
            }
        }

        /// <summary>
        /// Records that the current run was cancelled through this task's own source.
        /// </summary>
        private void MarkCanceled()
        {
            lock (lockObject)
            {
                isCanceled = true;
            }
        }
    }
}