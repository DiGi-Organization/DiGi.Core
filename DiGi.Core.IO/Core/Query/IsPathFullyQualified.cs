using System.IO;

namespace DiGi.Core.IO
{
    public static partial class Query
    {
        /// <summary>
        /// Checks if a path is fully qualified (absolute).
        /// </summary>
        /// <param name="path">The path to check.</param>
        /// <returns>True if the path is fully qualified; otherwise, false.</returns>
        public static bool IsPathFullyQualified(string? path)
        {
            string root = Path.GetPathRoot(path);
            if (string.IsNullOrWhiteSpace(root))
            {
                return false;
            }

            return root.StartsWith(@"\\", StringComparison.CurrentCulture) || root.EndsWith(@"\", StringComparison.CurrentCulture) && root != @"\";
        }
    }
}