namespace DiGi.Core.Parameter.Classes
{
    /// <summary>Contains settings for retrieving a parameter value.</summary>
    public class GetValueSettings
    {
        /// <summary>Initializes a new instance of the GetValueSettings class.</summary>
        public GetValueSettings()
        {
        }

        /// <summary>Initializes a new instance of the GetValueSettings class with specified options.</summary>
        /// <param name="tryConvert">Whether to attempt conversion if types do not match.</param>
        /// <param name="checkAccessType">Whether to check for read access permissions.</param>
        public GetValueSettings(bool tryConvert, bool checkAccessType)
        {
            TryConvert = tryConvert;
            CheckAccessType = checkAccessType;
        }

        /// <summary>Gets or sets a value indicating whether the access type should be checked during retrieval.</summary>
        public bool CheckAccessType { get; set; } = true;

        /// <summary>Gets or sets a value indicating whether to attempt conversion of the value during retrieval.</summary>
        public bool TryConvert { get; set; }
    }
}