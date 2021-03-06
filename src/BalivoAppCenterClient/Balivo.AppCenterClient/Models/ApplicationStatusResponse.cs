// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The status information from Itunes portal
    /// </summary>
    public partial class ApplicationStatusResponse
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationStatusResponse class.
        /// </summary>
        public ApplicationStatusResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationStatusResponse class.
        /// </summary>
        /// <param name="versionType">The type of version being returned
        /// (production/edit/test flight).</param>
        /// <param name="version">The version of the application</param>
        public ApplicationStatusResponse(string versionType, string version = default(string))
        {
            VersionType = versionType;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of version being returned
        /// (production/edit/test flight).
        /// </summary>
        [JsonProperty(PropertyName = "version_type")]
        public string VersionType { get; set; }

        /// <summary>
        /// Gets or sets the version of the application
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VersionType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VersionType");
            }
        }
    }
}
