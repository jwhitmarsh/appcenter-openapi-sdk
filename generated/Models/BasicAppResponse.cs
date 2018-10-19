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

    public partial class BasicAppResponse
    {
        /// <summary>
        /// Initializes a new instance of the BasicAppResponse class.
        /// </summary>
        public BasicAppResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BasicAppResponse class.
        /// </summary>
        /// <param name="id">The unique ID (UUID) of the app</param>
        /// <param name="displayName">The display name of the app</param>
        /// <param name="name">The name of the app used in URLs</param>
        /// <param name="os">The OS the app will be running on. Possible values
        /// include: 'Android', 'iOS', 'macOS', 'Tizen', 'tvOS', 'Windows',
        /// 'Custom'</param>
        /// <param name="description">The description of the app</param>
        /// <param name="iconUrl">The string representation of the URL pointing
        /// to the app's icon</param>
        /// <param name="iconSource">The string representation of the source of
        /// the app's icon</param>
        public BasicAppResponse(System.Guid id, string displayName, string name, string os, Owner owner, string description = default(string), string iconUrl = default(string), string iconSource = default(string))
        {
            Id = id;
            Description = description;
            DisplayName = displayName;
            IconUrl = iconUrl;
            IconSource = iconSource;
            Name = name;
            Os = os;
            Owner = owner;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique ID (UUID) of the app
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the description of the app
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the display name of the app
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the string representation of the URL pointing to the
        /// app's icon
        /// </summary>
        [JsonProperty(PropertyName = "icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// Gets or sets the string representation of the source of the app's
        /// icon
        /// </summary>
        [JsonProperty(PropertyName = "icon_source")]
        public string IconSource { get; set; }

        /// <summary>
        /// Gets or sets the name of the app used in URLs
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the OS the app will be running on. Possible values
        /// include: 'Android', 'iOS', 'macOS', 'Tizen', 'tvOS', 'Windows',
        /// 'Custom'
        /// </summary>
        [JsonProperty(PropertyName = "os")]
        public string Os { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public Owner Owner { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Os == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Os");
            }
            if (Owner == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Owner");
            }
            if (Owner != null)
            {
                Owner.Validate();
            }
        }
    }
}