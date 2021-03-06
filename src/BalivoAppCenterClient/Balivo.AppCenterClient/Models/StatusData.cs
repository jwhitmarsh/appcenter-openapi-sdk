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
    /// Status Data from store
    /// </summary>
    public partial class StatusData
    {
        /// <summary>
        /// Initializes a new instance of the StatusData class.
        /// </summary>
        public StatusData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StatusData class.
        /// </summary>
        /// <param name="status">status from store</param>
        /// <param name="storetype">store type</param>
        /// <param name="track">track information from store</param>
        /// <param name="version">version of the app from store</param>
        public StatusData(string status = default(string), string storetype = default(string), string track = default(string), string version = default(string))
        {
            Status = status;
            Storetype = storetype;
            Track = track;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets status from store
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets store type
        /// </summary>
        [JsonProperty(PropertyName = "storetype")]
        public string Storetype { get; set; }

        /// <summary>
        /// Gets or sets track information from store
        /// </summary>
        [JsonProperty(PropertyName = "track")]
        public string Track { get; set; }

        /// <summary>
        /// Gets or sets version of the app from store
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}
