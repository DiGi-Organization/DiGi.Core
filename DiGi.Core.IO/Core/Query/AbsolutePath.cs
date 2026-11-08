namespace DiGi.Core.IO
{
    public static partial class Query
    {
        /// <summary>
        /// Combines a directory path and a relative path to create an absolute path.
        /// </summary>
        /// <param name="directory">The base directory path.</param>
        /// <param name="relativePath">The relative path to combine with the directory.</param>
        /// <returns>The resulting absolute path string.</returns>
        public static string? AbsolutePath(this string? directory, string? relativePath)
        {
            if (string.IsNullOrWhiteSpace(directory) || string.IsNullOrWhiteSpace(relativePath))
            {
                return null;
            }

            string directory_Temp = directory!.Trim();
            if (directory_Temp.EndsWith("\\", StringComparison.CurrentCulture))
            {
                directory_Temp = directory_Temp.Substring(0, directory_Temp.Length - 1);
            }

            string relativePath_Temp = relativePath!.Trim();
            if (relativePath_Temp.EndsWith("\\", StringComparison.CurrentCulture))
            {
                relativePath_Temp = relativePath_Temp.Substring(0, relativePath_Temp.Length - 1);
            }

            return System.IO.Path.GetFullPath(System.IO.Path.Combine(directory_Temp, relativePath_Temp));
        }
    }
}