using System;

namespace DiGi.Core.IO
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the relative path from one directory to another.
        /// </summary>
        /// <param name="relativeTo">The base directory to calculate the relative path from.</param>
        /// <param name="path">The target path to make relative.</param>
        /// <returns>The calculated relative path, or null if it cannot be determined.</returns>
        public static string? RelativePath(string? relativeTo, string? path)
        {
            if (string.IsNullOrWhiteSpace(relativeTo) || string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            string relativeTo_Temp = relativeTo!.Trim();
            if (relativeTo_Temp.EndsWith("\\", StringComparison.CurrentCulture))
            {
                relativeTo_Temp = relativeTo_Temp.Substring(0, relativeTo_Temp.Length - 1);
            }

            string path_Temp = path!.Trim();
            if (path_Temp.EndsWith("\\", StringComparison.CurrentCulture))
            {
                path_Temp = path_Temp.Substring(0, path_Temp.Length - 1);
            }

            if (relativeTo_Temp.Equals(path_Temp, StringComparison.Ordinal))
            {
                return ".";
            }

            Uri uri_RelativeTo = new(relativeTo.EndsWith("\\", StringComparison.CurrentCulture) ? relativeTo : relativeTo + "\\");
            Uri uri = new(path_Temp);

            return Uri.UnescapeDataString(uri_RelativeTo.MakeRelativeUri(uri).ToString().Replace('/', '\\'));

            //if (path_Temp.StartsWith(relativeTo))
            //{
            //    return path_Temp.Substring(relativeTo_Temp.Length + 1);
            //}

            //return path;
        }
    }
}