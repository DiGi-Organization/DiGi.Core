using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Provides a base class for background tasks with status tracking and event notifications.
    /// </summary>
    public abstract class BackgroundTask : IBackgroundTask
    {
        /// <summary>
        /// Object used for thread synchronization.
        /// </summary>
        protected readonly object lockObject = new();

        /// <summary>
        /// Stores any exception that occurred during task execution.
        /// </summary>
        protected Exception? exception;

        /// <summary>
        /// Measures the execution time of the task.
        /// </summary>
        private readonly Stopwatch stopwatch = new();

        /// <summary>
        /// Indicates whether the task is currently running.
        /// </summary>
        private bool isRunning;

        /// <summary>
        /// Indicates whether the last task execution succeeded.
        /// </summary>
        private bool isSucceeded = true;

        /// <summary>
        /// Occurs when the task has started execution.
        /// </summary>
        public event EventHandler? Started;

        /// <summary>
        /// Occurs when the task is about to start execution.
        /// </summary>
        public event EventHandler? Starting;

        /// <summary>
        /// Occurs when the task has stopped execution.
        /// </summary>
        public event EventHandler? Stopped;

        /// <summary>
        /// Occurs when the task is about to stop execution.
        /// </summary>
        public event EventHandler? Stopping;

        /// <summary>
        /// Gets the current status of the background task.
        /// </summary>
        public BackgroundTaskStatus BackgroundTaskStatus
        {
            get
            {
                if (IsRunning)
                {
                    return BackgroundTaskStatus.Running;
                }

                if (IsCompleted)
                {
                    if (exception is not null || !isSucceeded)
                    {
                        return BackgroundTaskStatus.Failed;
                    }

                    return BackgroundTaskStatus.Completed;
                }

                return BackgroundTaskStatus.Idle;
            }
        }

        /// <summary>
        /// Gets the exception that caused the task to fail, or null if the task succeeded.
        /// </summary>
        public Exception? Exception => exception;

        /// <summary>
        /// Gets the total execution time of the last run.
        /// </summary>
        public TimeSpan ExecutionTimeSpan => stopwatch.Elapsed;

        /// <summary>
        /// Gets a value indicating whether the task has completed.
        /// </summary>
        public bool IsCompleted => Task?.IsCompleted ?? false;

        /// <summary>
        /// Gets a value indicating whether the task is currently running.
        /// </summary>
        public bool IsRunning => isRunning;

        /// <summary>
        /// Gets a value indicating whether the last task execution succeeded.
        /// </summary>
        public bool IsSucceeded => isSucceeded;

        /// <summary>
        /// Gets or sets the underlying task associated with this background task.
        /// </summary>
        protected Task? Task { get; set; }

        /// <summary>
        /// Gets a value indicating whether the task was cancelled before it reported failure.
        /// <para>The base implementation is always false. A cancelable task overrides it, so that a run stopped
        /// by its operator - which reports failure only because its cancellation was requested - is not wrapped
        /// as a <see cref="BackgroundTaskFailureException"/>.</para>
        /// </summary>
        protected virtual bool WasCanceled => false;

        /// <summary>
        /// Starts the background task execution.
        /// </summary>
        public virtual void Start()
        {
            lock (lockObject)
            {
                if (isRunning)
                {
                    return;
                }

                OnStarting();

                exception = null;
                isRunning = true;
                isSucceeded = true;

                // Reset and start the stopwatch before launching the task
                stopwatch.Restart();

                Task = Task.Run(async () =>
                {
                    try
                    {
                        OnStarted();
                        isSucceeded = await ExecuteAsync();
                    }
                    catch (Exception exception_Temp)
                    {
                        exception = exception_Temp;
                    }
                    finally
                    {
                        // A task that reports failure without throwing and without being cancelled refused
                        // deliberately, and the reason it logged - if it logged one - exists only in the log
                        // file, invisible on the task row. Wrapping it here gives every such failure a message
                        // the row can show on hover and the wrapper can log, without each task having to throw.
                        if (exception is null && !isSucceeded && !WasCanceled)
                        {
                            exception = new BackgroundTaskFailureException("The task reported failure without an exception - a reason, if one was logged, is in the logs folder beside the application");
                        }

                        OnStopping();

                        // Stop the measurement as soon as the execution finishes
                        stopwatch.Stop();

                        lock (lockObject)
                        {
                            isRunning = false;
                        }

                        OnStopped();
                    }
                });
            }
        }

        /// <summary>
        /// When overridden in a derived class, defines the work to be executed by the background task.
        /// </summary>
        /// <returns>True if the task succeeded; otherwise, false.</returns>
        protected abstract Task<bool> ExecuteAsync();

        /// <summary>
        /// Raises the Started event.
        /// </summary>
        protected virtual void OnStarted() => Started?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the Starting event.
        /// </summary>
        protected virtual void OnStarting() => Starting?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the Stopped event.
        /// </summary>
        protected virtual void OnStopped() => Stopped?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the Stopping event.
        /// </summary>
        protected virtual void OnStopping() => Stopping?.Invoke(this, EventArgs.Empty);
    }
}