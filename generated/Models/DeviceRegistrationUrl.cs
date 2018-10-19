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
    /// The url that can be navigated to in order to start the device
    /// registration process.
    /// </summary>
    public partial class DeviceRegistrationUrl
    {
        /// <summary>
        /// Initializes a new instance of the DeviceRegistrationUrl class.
        /// </summary>
        public DeviceRegistrationUrl()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeviceRegistrationUrl class.
        /// </summary>
        /// <param name="registrationUrl">The url that can be navigated to in
        /// order to start the device registration process.</param>
        public DeviceRegistrationUrl(string registrationUrl)
        {
            RegistrationUrl = registrationUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the url that can be navigated to in order to start the
        /// device registration process.
        /// </summary>
        [JsonProperty(PropertyName = "registration_url")]
        public string RegistrationUrl { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RegistrationUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RegistrationUrl");
            }
        }
    }
}