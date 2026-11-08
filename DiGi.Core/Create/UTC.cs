using DiGi.Core.Enums;
using System.Globalization;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a UTC offset from the given float value.</summary>
        /// <param name="timeOffset">The float representation of the UTC offset.</param>
        /// <returns>A <see cref="Enums.UTC"/> instance representing the specified offset.</returns>
        public static UTC UTC(float timeOffset)
        {
            return UTC(System.Convert.ToDouble(timeOffset));
        }

        /// <summary>Creates a UTC offset from the given double value.</summary>
        /// <param name="timeOffset">The double representation of the UTC offset.</param>
        /// <returns>A <see cref="Enums.UTC"/> instance representing the specified offset.</returns>
        public static UTC UTC(double timeOffset)
        {
            if (double.IsNaN(timeOffset))
            {
                return Enums.UTC.Undefined;
            }

            foreach (UTC uTC in System.Enum.GetValues(typeof(UTC)))
            {
                double timeOffset_Temp = uTC.TimeOffset();
                if (timeOffset.Equals(timeOffset_Temp))
                {
                    return uTC;
                }
            }

            return Enums.UTC.Undefined;
        }

        /// <summary>Creates a UTC offset from the given string value.</summary>
        /// <param name="value">The string representation of the UTC offset.</param>
        /// <returns>A <see cref="Enums.UTC"/> instance representing the specified offset.</returns>
        public static UTC UTC(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Enums.UTC.Undefined;
            }

            if (Enums.UTC.Undefined.ToString().ToUpper(CultureInfo.CurrentCulture).Equals(value.ToUpper(CultureInfo.CurrentCulture).Trim(), StringComparison.Ordinal))
            {
                return Enums.UTC.Undefined;
            }

            UTC result = Query.Enum<UTC>(value);
            if (result != Enums.UTC.Undefined)
            {
                return result;
            }

            if (Query.TryConvert(value, out double timeOffset))
            {
                result = UTC(timeOffset);
                if (result != Enums.UTC.Undefined)
                {
                    return result;
                }
            }

            return Enums.UTC.Undefined;
        }
    }
}