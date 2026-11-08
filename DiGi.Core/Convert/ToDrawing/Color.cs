using System;
using System.Drawing;
using System.Globalization;

namespace DiGi.Core
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a uint color value (ARGB) to a System.Drawing.Color.
        /// </summary>
        /// <param name="uint">The unsigned integer ARGB color value.</param>
        /// <returns>The converted System.Drawing.Color.</returns>
        public static Color ToDrawing(uint @uint)
        {
            byte a = (byte)(@uint >> 24);
            byte b = (byte)(@uint >> 16);
            byte g = (byte)(@uint >> 8);
            byte r = (byte)(@uint >> 0);
            return Color.FromArgb(a, r, g, b);
        }

        /// <summary>
        /// Converts an int color value (RGB) to a System.Drawing.Color with optional alpha.
        /// </summary>
        /// <param name="int">The integer RGB color value.</param>
        /// <param name="alpha">The alpha channel value.</param>
        /// <returns>The converted System.Drawing.Color.</returns>
        public static Color ToDrawing(int @int, byte alpha = 255)
        {
            byte b = (byte)(@int >> 16);
            byte g = (byte)(@int >> 8);
            byte r = (byte)(@int >> 0);
            return Color.FromArgb(alpha, r, g, b);
        }

        /// <summary>
        /// Converts a color string (named, hex, or alpha hex) to a System.Drawing.Color.
        /// </summary>
        /// <param name="value">The color string to convert.</param>
        /// <returns>The converted System.Drawing.Color, or Color.Empty if parsing fails.</returns>
        public static Color ToDrawing(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Color.Empty;
            }

            string clean = value!.Trim();

            // 1. Try Named Color
            Color namedColor = Color.FromName(clean);
            if (namedColor.ToArgb() != 0 || string.Equals(clean, "Transparent", StringComparison.OrdinalIgnoreCase))
            {
                return namedColor;
            }

            // 2. Try Hex Parsing
            if (clean.StartsWith("#", StringComparison.CurrentCulture))
            {
                string hex = clean.Substring(1);

                // Handle shorthand CSS hex (e.g., #FFF or #F00)
                if (hex.Length == 3)
                {
                    hex = new string([hex[0], hex[0], hex[1], hex[1], hex[2], hex[2]]);
                }
                else if (hex.Length == 4)
                {
                    hex = new string([hex[0], hex[0], hex[1], hex[1], hex[2], hex[2], hex[3], hex[3]]);
                }

                if (hex.Length == 6)
                {
                    if (int.TryParse(hex.Substring(0, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int r) &&
                        int.TryParse(hex.Substring(2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int g) &&
                        int.TryParse(hex.Substring(4, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int b))
                    {
                        return Color.FromArgb(255, r, g, b);
                    }
                }
                else if (hex.Length == 8)
                {
                    // Preserve the RGBA convention of the original implementation
                    if (int.TryParse(hex.Substring(0, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int r) &&
                        int.TryParse(hex.Substring(2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int g) &&
                        int.TryParse(hex.Substring(4, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int b) &&
                        int.TryParse(hex.Substring(6, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int a))
                    {
                        return Color.FromArgb(a, r, g, b);
                    }
                }
            }

            return Color.Empty;
        }

        /// <summary>
        /// Converts a DiGi.Core.Classes.Color to a System.Drawing.Color.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted System.Drawing.Color.</returns>
        public static Color ToDrawing(this Classes.Color? color)
        {
            if (color is null)
            {
                return Color.Empty;
            }

            return Color.FromArgb(color.Alpha, color.Red, color.Green, color.Blue);
        }
    }
}