using System.Globalization;
using System;
using System.Collections.Generic;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Provides a base implementation for splitting a collection of items into groups.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection to be split.</typeparam>
    /// <typeparam name="X">The type used to determine the value of each element for splitting purposes.</typeparam>
    public abstract class Splitter<T, X> where X : struct, IComparable, IConvertible
    {
        // Keep track of the iteration state
        private int index;

        private List<T>? items;

        /// <summary>
        /// Initializes a new instance of the <see cref="Splitter{T, X}"/> class with the specified items.
        /// </summary>
        /// <param name="items">The collection of items to be processed by the splitter.</param>
        public Splitter(IEnumerable<T> items)
        {
            this.items = items is null ? null : [.. items];
        }

        /// <summary>
        /// Gets or sets the list of items to be processed by the splitter.
        /// </summary>
        public List<T>? Items
        {
            get => items;
            set
            {
                items = value;
                Reset(); // Reset progress if data changes
            }
        }

        /// <summary>
        /// Retrieves a value associated with the specified item.
        /// </summary>
        /// <param name="item">The item for which to retrieve the value.</param>
        /// <returns>The value associated with the provided item.</returns>
        public abstract X GetValue(T? item);

        /// <summary>
        /// Returns the next chunk of items that don't exceed the maxValue.
        /// Returns null when no more items are available.
        /// </summary>
        /// <param name="maxValue">The maximum value allowed for the next chunk.</param>
        /// <returns>The next list of items that fit within the specified maximum value, or null if no more items remain.</returns>
        public List<T>? Next(X maxValue)
        {
            // Return null instead of an empty list to signal the end of the collection
            if (items == null || index >= items.Count)
            {
                return null;
            }

            List<T> currentValues = [];
            double currentSize = 0;
            double maxValue_Temp = System.Convert.ToDouble(maxValue, CultureInfo.CurrentCulture);

            while (index < items.Count)
            {
                T item = items[index];
                double itemSize = System.Convert.ToDouble(GetValue(item), CultureInfo.CurrentCulture);

                if (currentSize + itemSize > maxValue_Temp && currentValues.Count > 0)
                {
                    // We don't increment _currentIndex here,
                    // so this item will be the start of the next chunk.
                    break;
                }

                currentValues.Add(item);
                currentSize += itemSize;
                index++;
            }

            return currentValues;
        }

        /// <summary>
        /// Resets the internal iterator index to the beginning.
        /// </summary>
        public void Reset()
        {
            index = 0;
        }

        /// <summary>
        /// Splits the items into multiple lists based on the provided maximum value.
        /// </summary>
        /// <param name="maxValue">The maximum value allowed for each split list.</param>
        /// <returns>A list of lists containing the split items, or null if the operation cannot be completed.</returns>
        public List<List<T>>? Split(X maxValue)
        {
            if (items is null)
            {
                return null;
            }

            // Optional: Backup current index if you want Split to be non-destructive
            int previousIndex = index;

            Reset();

            List<List<T>> result = [];

            while (true)
            {
                List<T>? chunk = Next(maxValue);

                if (chunk is null || chunk.Count == 0)
                {
                    break;
                }

                result.Add(chunk);
            }

            // Restore index or leave at the end
            index = previousIndex;
            return result;
        }
    }
}