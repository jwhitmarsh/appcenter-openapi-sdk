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
    /// Audience definition.
    /// </summary>
    public partial class AudienceBlobResult
    {
        /// <summary>
        /// Initializes a new instance of the AudienceBlobResult class.
        /// </summary>
        public AudienceBlobResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AudienceBlobResult class.
        /// </summary>
        /// <param name="url">Location of the audience blob.</param>
        public AudienceBlobResult(string url = default(string))
        {
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets location of the audience blob.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }
}
