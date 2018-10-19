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
    /// Google notification configuration.
    /// </summary>
    [Newtonsoft.Json.JsonObject("gcm_config")]
    public partial class NotificationConfigGoogle : NotificationConfig
    {
        /// <summary>
        /// Initializes a new instance of the NotificationConfigGoogle class.
        /// </summary>
        public NotificationConfigGoogle()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NotificationConfigGoogle class.
        /// </summary>
        /// <param name="googleApiKey">GCM API key.</param>
        public NotificationConfigGoogle(string googleApiKey)
        {
            GoogleApiKey = googleApiKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets GCM API key.
        /// </summary>
        [JsonProperty(PropertyName = "google_api_key")]
        public string GoogleApiKey { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (GoogleApiKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GoogleApiKey");
            }
        }
    }
}
