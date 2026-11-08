using System.Text;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Escapes a scalar value for use as a segment of a reference string.
        /// <para>Only the grammar metacharacters are escaped: the escape character itself, each character of
        /// <see cref="Constants.Reference.Separator"/>, and the nesting delimiters. Every other character - including
        /// quotes, brackets and unicode - is a literal and passes through untouched.</para>
        /// <para>The mapping is prefix-free and invertible by <see cref="Unescaped(string?)"/>. Because a literal
        /// escape character is always doubled, no real value can render as <see cref="Constants.Reference.Null"/>.</para>
        /// </summary>
        /// <param name="value">The scalar value to escape.</param>
        /// <returns>The escaped value, or <see cref="Constants.Reference.Null"/> when <paramref name="value"/> is null.</returns>
        public static string Escaped(this string? value)
        {
            if (value == null)
            {
                return Constants.Reference.Null;
            }

            if (value.Length == 0)
            {
                return string.Empty;
            }

            StringBuilder stringBuilder = new(value.Length);

            for (int i = 0; i < value.Length; i++)
            {
                char @char = value[i];

                if (@char == Constants.Reference.Escape[0]
                    || @char == Constants.Reference.Separator[0]
                    || @char == Constants.Reference.NestingStart[0]
                    || @char == Constants.Reference.NestingEnd[0])
                {
                    stringBuilder.Append(Constants.Reference.Escape[0]);
                }

                stringBuilder.Append(@char);
            }

            return stringBuilder.ToString();
        }
    }
}