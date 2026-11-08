namespace DiGi.Core.Parameter.Classes
{
    /// <summary>Contains settings for setting a parameter value.</summary>
    public class SetValueSettings
    {
        /// <summary>Initializes a new instance of the SetValueSettings class.</summary>
        public SetValueSettings()
        {
        }

        /// <summary>Initializes a new instance of the SetValueSettings class with specified options.</summary>
        /// <param name="tryConvert">Whether to attempt conversion if types do not match.</param>
        /// <param name="checkAccessType">Whether to check for write access permissions.</param>
        public SetValueSettings(bool tryConvert, bool checkAccessType)
        {
            TryConvert = tryConvert;
            CheckAccessType = checkAccessType;
        }

        /// <summary>Gets or sets a value indicating whether the access type should be checked during assignment.</summary>
        public bool CheckAccessType { get; set; } = true;

        /// <summary>Gets or sets a value indicating whether to attempt conversion of the value during assignment.</summary>
        public bool TryConvert { get; set; }
    }
}