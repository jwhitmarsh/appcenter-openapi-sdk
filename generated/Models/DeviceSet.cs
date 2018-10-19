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
    /// Device Set
    /// </summary>
    /// <remarks>
    /// The name and devices of the device set
    /// </remarks>
    public partial class DeviceSet
    {
        /// <summary>
        /// Initializes a new instance of the DeviceSet class.
        /// </summary>
        public DeviceSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeviceSet class.
        /// </summary>
        /// <param name="id">Identifier of the device set</param>
        /// <param name="name">Name of the device set</param>
        /// <param name="manufacturerCount">The number of manufacturers in the
        /// device set's device selection</param>
        /// <param name="slug">Slug of the device set</param>
        /// <param name="osVersionCount">The number of os versions in the
        /// device set's device selection</param>
        public DeviceSet(string id, string name, DeviceSetOwner owner, IList<DeviceSetConfiguration> deviceConfigurations, double? manufacturerCount = default(double?), string slug = default(string), double? osVersionCount = default(double?))
        {
            Id = id;
            ManufacturerCount = manufacturerCount;
            Name = name;
            Slug = slug;
            Owner = owner;
            OsVersionCount = osVersionCount;
            DeviceConfigurations = deviceConfigurations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets identifier of the device set
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the number of manufacturers in the device set's device
        /// selection
        /// </summary>
        [JsonProperty(PropertyName = "manufacturerCount")]
        public double? ManufacturerCount { get; set; }

        /// <summary>
        /// Gets or sets name of the device set
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets slug of the device set
        /// </summary>
        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public DeviceSetOwner Owner { get; set; }

        /// <summary>
        /// Gets or sets the number of os versions in the device set's device
        /// selection
        /// </summary>
        [JsonProperty(PropertyName = "osVersionCount")]
        public double? OsVersionCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceConfigurations")]
        public IList<DeviceSetConfiguration> DeviceConfigurations { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Owner == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Owner");
            }
            if (DeviceConfigurations == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DeviceConfigurations");
            }
            if (Owner != null)
            {
                Owner.Validate();
            }
        }
    }
}