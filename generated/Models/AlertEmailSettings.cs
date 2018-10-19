// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Alerting Email Settings
    /// </summary>
    public partial class AlertEmailSettings
    {
        /// <summary>
        /// Initializes a new instance of the AlertEmailSettings class.
        /// </summary>
        public AlertEmailSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertEmailSettings class.
        /// </summary>
        /// <param name="settings">The settings the user has for the
        /// app</param>
        public AlertEmailSettings(IList<EventSetting> settings)
        {
            Settings = settings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the settings the user has for the app
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public IList<EventSetting> Settings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Settings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Settings");
            }
            if (Settings != null)
            {
                foreach (var element in Settings)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
