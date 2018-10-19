// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Itunes teams details .
    /// </summary>
    public partial class AllItunesAppsResponse
    {
        /// <summary>
        /// Initializes a new instance of the AllItunesAppsResponse class.
        /// </summary>
        public AllItunesAppsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AllItunesAppsResponse class.
        /// </summary>
        /// <param name="appleId">apple id for app team id.</param>
        /// <param name="bundleId">bundle identifier of app</param>
        /// <param name="name">App Name</param>
        /// <param name="iconUrl">url for the app icon from app store</param>
        public AllItunesAppsResponse(string appleId = default(string), string bundleId = default(string), string name = default(string), string iconUrl = default(string))
        {
            AppleId = appleId;
            BundleId = bundleId;
            Name = name;
            IconUrl = iconUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets apple id for app team id.
        /// </summary>
        [JsonProperty(PropertyName = "apple_id")]
        public string AppleId { get; set; }

        /// <summary>
        /// Gets or sets bundle identifier of app
        /// </summary>
        [JsonProperty(PropertyName = "bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// Gets or sets app Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets url for the app icon from app store
        /// </summary>
        [JsonProperty(PropertyName = "iconUrl")]
        public string IconUrl { get; set; }

    }
}
