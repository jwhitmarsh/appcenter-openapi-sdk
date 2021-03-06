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
    /// Google Play connection secrets this should be the JSON file data which
    /// is provided by google play
    /// </summary>
    public partial class GooglePlayConnectionSecretRequest : SharedConnectionRequest
    {
        /// <summary>
        /// Initializes a new instance of the GooglePlayConnectionSecretRequest
        /// class.
        /// </summary>
        public GooglePlayConnectionSecretRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GooglePlayConnectionSecretRequest
        /// class.
        /// </summary>
        /// <param name="data">google secret details</param>
        /// <param name="displayName">display name of shared connection</param>
        /// <param name="credentialType">credential type of the shared
        /// connection. Values can be credentials|certificate. Possible values
        /// include: 'credentials', 'certificate'</param>
        public GooglePlayConnectionSecretRequest(object data, string displayName = default(string), string credentialType = default(string))
            : base(displayName, credentialType)
        {
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets google secret details
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Data == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Data");
            }
        }
    }
}
