using DiGi.Core.Parameter.Enums;
using System;
using System.Diagnostics.CodeAnalysis;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Contains metadata and properties for a parameter definition.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    [SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "Public attribute applied across the workspace by this name; renaming is a breaking change.")]
    public class ParameterProperties : Attribute
    {
        private readonly AccessType accessType = AccessType.ReadWrite;
        private readonly string? description;
        private readonly string? groupName;
        private readonly string? name;
        private readonly string? uniqueId;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterProperties"/> class with a unique identifier and name.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        public ParameterProperties(string? uniqueId, string? name)
        {
            this.uniqueId = uniqueId;
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterProperties"/> class with a unique identifier, name, and description.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="description">The description of the parameter.</param>
        public ParameterProperties(string? uniqueId, string? name, string? description)
        {
            this.uniqueId = uniqueId;
            this.name = name;
            this.description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterProperties"/> class with a unique identifier, name, description, and access type.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="description">The description of the parameter.</param>
        /// <param name="accessType">The access type of the parameter.</param>
        public ParameterProperties(string? uniqueId, string? name, string? description, AccessType accessType)
        {
            this.uniqueId = uniqueId;
            this.name = name;
            this.description = description;
            this.accessType = accessType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterProperties"/> class with full metadata including group name.
        /// </summary>
        /// <param name="uniqueId">The unique identifier for the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="description">The description of the parameter.</param>
        /// <param name="accessType">The access type of the parameter.</param>
        /// <param name="groupName">The name of the group to which the parameter belongs.</param>
        public ParameterProperties(string? uniqueId, string? name, string? description, AccessType accessType, string? groupName)
        {
            this.uniqueId = uniqueId;
            this.name = name;
            this.description = description;
            this.accessType = accessType;
            this.groupName = groupName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterProperties"/> class with a specified name.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        public ParameterProperties(string? name)
        {
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterProperties"/> class with a name, description, and access type.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="description">The description of the parameter.</param>
        /// <param name="accessType">The access type of the parameter.</param>
        public ParameterProperties(string? name, string? description, AccessType accessType)
        {
            this.name = name;
            this.description = description;
            this.accessType = accessType;
        }

        /// <summary>
        /// Gets or sets the access level of the parameter.
        /// </summary>
        public AccessType AccessType
        {
            get
            {
                return accessType;
            }
        }

        /// <summary>
        /// Gets or sets the description of the parameter.
        /// </summary>
        public string? Description
        {
            get
            {
                return description;
            }
        }

        /// <summary>
        /// Gets or sets the name of the group this parameter belongs to.
        /// </summary>
        public string? GroupName
        {
            get
            {
                return groupName;
            }
        }

        /// <summary>
        /// Gets or sets the display name of the parameter.
        /// </summary>
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Gets or sets a unique string identifier for the object.
        /// </summary>
        public string? UniqueId
        {
            get
            {
                return uniqueId ?? name;
            }
        }
    }
}