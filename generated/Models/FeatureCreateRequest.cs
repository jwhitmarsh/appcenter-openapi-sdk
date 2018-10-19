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

    public partial class FeatureCreateRequest
    {
        /// <summary>
        /// Initializes a new instance of the FeatureCreateRequest class.
        /// </summary>
        public FeatureCreateRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FeatureCreateRequest class.
        /// </summary>
        /// <param name="name">The unique name of the feature</param>
        /// <param name="displayName">The full (friendly) name of the
        /// feature.</param>
        /// <param name="state">The state of the feature</param>
        /// <param name="description">The friendly name of the feature</param>
        public FeatureCreateRequest(string name, string displayName, int? state = default(int?), string description = default(string))
        {
            Name = name;
            DisplayName = displayName;
            State = state;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique name of the feature
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the full (friendly) name of the feature.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the state of the feature
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public int? State { get; set; }

        /// <summary>
        /// Gets or sets the friendly name of the feature
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
        }
    }
}
