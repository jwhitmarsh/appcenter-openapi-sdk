// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OrganizationRequest
    {
        /// <summary>
        /// Initializes a new instance of the OrganizationRequest class.
        /// </summary>
        public OrganizationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrganizationRequest class.
        /// </summary>
        /// <param name="displayName">The display name of the
        /// organization</param>
        /// <param name="name">The name of the organization used in
        /// URLs</param>
        public OrganizationRequest(string displayName = default(string), string name = default(string))
        {
            DisplayName = displayName;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the display name of the organization
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the name of the organization used in URLs
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}