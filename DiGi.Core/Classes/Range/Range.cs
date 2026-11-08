using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>Represents a closed interval between a minimum and maximum value of type T.</summary>
    /// <typeparam name="T">The type of the values in the range.</typeparam>
    public class Range<T> : SerializableObject
    {
        [JsonInclude, JsonPropertyName("Max")]
        private T? max;

        [JsonInclude, JsonPropertyName("Min")]
        private T? min;

        /// <summary>
        /// Initializes a new instance of the <see cref="Range{T}"/> class with specified boundary values.
        /// </summary>
        /// <param name="value_1">The first boundary value.</param>
        /// <param name="value_2">The second boundary value.</param>
        public Range(T? value_1, T? value_2)
        {
            if (value_1 as dynamic <= value_2 as dynamic)
            {
                min = value_1;
                max = value_2;
            }
            else
            {
                min = value_2;
                max = value_1;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Range{T}"/> class by copying an existing range.
        /// </summary>
        /// <param name="range">The existing range to copy.</param>
        public Range(Range<T>? range)
        {
            if (range is not null)
            {
                min = range.min;
                max = range.max;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Range{T}"/> class based on a collection of values.
        /// </summary>
        /// <param name="values">The collection of values to use for initializing the range.</param>
        public Range(IEnumerable<T>? values)
        {
            if (values != null)
            {
                dynamic? min = null;
                dynamic? max = null;
                foreach (T value in values)
                {
                    if (value == null)
                    {
                        continue;
                    }

                    if (min == null)
                    {
                        min = value;
                        max = value;
                    }
                    else
                    {
                        if ((value as dynamic) < min)
                        {
                            min = value;
                        }

                        if ((value as dynamic) > max)
                        {
                            max = value;
                        }
                    }
                }

                if (min != null)
                {
                    this.min = min;
                }

                if (max != null)
                {
                    this.max = max;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Range{T}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the range from.</param>
        public Range(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the length of the range.
        /// </summary>
        [JsonIgnore]
        public virtual T Length
        {
            get
            {
                return (Max as dynamic) - (Min as dynamic);
            }
        }

        /// <summary>
        /// Gets the maximum value of the range.
        /// </summary>
        [JsonIgnore]
        public T Max
        {
            get
            {
                return max!;
            }
        }

        /// <summary>
        /// Gets the minimum value of the range.
        /// </summary>
        [JsonIgnore]
        public T Min
        {
            get
            {
                return min!;
            }
        }

        /// <summary>
        /// Compares the specified <see cref="Range{T}"/> with another object for inequality.
        /// </summary>
        /// <param name="range">The <see cref="Range{T}"/> instance to compare.</param>
        /// <param name="object">The object to compare with the range.</param>
        /// <returns><see langword="true"/> if the objects are not equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(Range<T>? range, object? @object)
        {
            return !(range == @object);
        }

        /// <summary>
        /// Compares the specified <see cref="Range{T}"/> with another object for equality.
        /// </summary>
        /// <param name="range">The <see cref="Range{T}"/> instance to compare.</param>
        /// <param name="object">The object to compare with the range.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(Range<T>? range, object? @object)
        {
            if (range is null)
            {
                if (@object is null)
                {
                    return true;
                }

                return false;
            }

            return range.Equals(@object);
        }

        /// <summary>
        /// Adds a value to the range and returns true if the range was expanded.
        /// </summary>
        /// <param name="value">The value to add.</param>
        /// <returns>True if the range was expanded; otherwise, false.</returns>
        public bool Add(T value)
        {
            bool result = false;

            if ((value as dynamic) > (max as dynamic))
            {
                max = value;
                result = true;
            }

            if ((value as dynamic) < (min as dynamic))
            {
                min = value;
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Expands the current range to include another range and returns true if the range was modified.
        /// </summary>
        /// <param name="value">The range to add.</param>
        /// <returns>True if the range was modified; otherwise, false.</returns>
        public bool Add(Range<T>? value)
        {
            bool result = false;
            if (value is null)
            {
                return false;
            }

            if ((value.max as dynamic) > (max as dynamic))
            {
                max = value.max;
                result = true;
            }

            if ((value.min as dynamic) < (min as dynamic))
            {
                min = value.min;
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current range.
        /// </summary>
        /// <param name="object">The object to compare with the current range.</param>
        /// <returns>True if the specified object is equal to the current range; otherwise, false.</returns>
        public override bool Equals(object? @object)
        {
            return @object is Range<T> range &&
                   EqualityComparer<T>.Default.Equals(range.min!, min!) &&
                   EqualityComparer<T>.Default.Equals(range.max!, max!);
        }

        /// <summary>
        /// Gets the hash code for the current type reference.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + (min is null ? 0 : EqualityComparer<T>.Default.GetHashCode(min));
            hash = (hash * 7) + (max is null ? 0 : EqualityComparer<T>.Default.GetHashCode(max));
            return hash;
        }

        /// <summary>
        /// Determines whether a specified value is contained within the range.
        /// </summary>
        /// <param name="value">The value to check for containment.</param>
        /// <returns>True if the value is contained within the range; otherwise, false.</returns>
        public bool In(T value)
        {
            return (value as dynamic) <= (max as dynamic) && (value as dynamic) >= (min as dynamic);
        }

        /// <summary>
        /// Determines whether a specified value is contained within the range, considering a given tolerance.
        /// </summary>
        /// <param name="value">The value to check for containment.</param>
        /// <param name="tolerance">The tolerance value to use during the containment check.</param>
        /// <returns>True if the specified value is contained within the range; otherwise, false.</returns>
        public bool In(T value, T tolerance)
        {
            return (value as dynamic) <= (max as dynamic + tolerance as dynamic) && (value as dynamic) >= (min as dynamic - tolerance as dynamic);
        }

        /// <summary>
        /// Determines whether another range is entirely contained within this range.
        /// </summary>
        /// <param name="range">The range to check for containment.</param>
        /// <returns>True if the specified range is contained within this range; otherwise, false.</returns>
        public bool In(Range<T>? range)
        {
            if (range is null)
            {
                return false;
            }

            return (range.min as dynamic) >= (min as dynamic) && (range.max as dynamic) <= (max as dynamic);
        }

        /// <summary>
        /// Determines whether another range is contained within this range, considering a given tolerance.
        /// </summary>
        /// <param name="range">The range to check for containment.</param>
        /// <param name="tolerance">The tolerance value to use during the containment check.</param>
        /// <returns>True if the specified range is contained within this range; otherwise, false.</returns>
        public bool In(Range<T>? range, T tolerance)
        {
            if (range is null)
            {
                return false;
            }

            return (range.min as dynamic) >= (min as dynamic - tolerance as dynamic) && (range.max as dynamic) <= (max as dynamic + tolerance as dynamic);
        }

        /// <summary>
        /// Determines whether the current range intersects with another specified range.
        /// </summary>
        /// <param name="range">The range to check for intersection.</param>
        /// <returns>True if the ranges intersect; otherwise, false.</returns>
        public bool Intersect(Range<T>? range)
        {
            return !Out(range);
        }

        /// <summary>
        /// Determines whether the current range intersects with another specified range, considering a given tolerance.
        /// </summary>
        /// <param name="range">The range to check for intersection.</param>
        /// <param name="tolerance">The tolerance value to use during the intersection check.</param>
        /// <returns>True if the ranges intersect; otherwise, false.</returns>
        public bool Intersect(Range<T>? range, T tolerance)
        {
            return !Out(range, tolerance);
        }

        /// <summary>
        /// Determines whether the specified range is in range (intersects or is within tolerance) of the current range.
        /// </summary>
        /// <param name="range">The range to check.</param>
        /// <param name="tolerance">The tolerance value to consider.</param>
        /// <returns>True if the ranges intersect or are within the specified tolerance; otherwise, false.</returns>
        public bool InRange(Range<T>? range, T tolerance)
        {
            return !Out(range, tolerance);
        }

        /// <summary>
        /// Determines whether a specified value is outside the boundaries of the range.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the specified value is outside the boundaries of the range; otherwise, false.</returns>
        public bool Out(T value)
        {
            return !In(value);
        }

        /// <summary>
        /// Determines whether a specified value is outside the boundaries of the range, considering a given tolerance.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="tolerance">The tolerance value to consider.</param>
        /// <returns>True if the specified value is outside the boundaries of the range; otherwise, false.</returns>
        public bool Out(T value, T tolerance)
        {
            return !In(value, tolerance);
        }

        /// <summary>
        /// Determines whether another range is completely outside this range.
        /// </summary>
        /// <param name="range">The range to check.</param>
        /// <returns>True if the specified range is completely outside this range; otherwise, false.</returns>
        public bool Out(Range<T>? range)
        {
            if (range is null)
            {
                return false;
            }

            return (range.min as dynamic) >= (max as dynamic) || (range.max as dynamic) <= (min as dynamic);
        }

        /// <summary>
        /// Determines whether another range is completely outside this range, considering a given tolerance.
        /// </summary>
        /// <param name="range">The range to check.</param>
        /// <param name="tolerance">The tolerance value to consider.</param>
        /// <returns>True if the specified range is completely outside this range; otherwise, false.</returns>
        public bool Out(Range<T>? range, T tolerance)
        {
            if (range is null)
            {
                return false;
            }

            return (range.min as dynamic) > (max as dynamic + tolerance as dynamic) || (range.max as dynamic) < (min as dynamic - tolerance as dynamic);
        }

        /// <summary>
        /// Returns a string representation of the current range.
        /// </summary>
        /// <returns>A string that represents the current range.</returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "[{0}, {1}]", min, max);
        }
    }
}