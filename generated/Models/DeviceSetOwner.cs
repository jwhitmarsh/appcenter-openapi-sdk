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
    /// Device Set Owner
    /// </summary>
    /// <remarks>
    /// The owner of a device set
    /// </remarks>
    public partial class DeviceSetOwner
    {
        /// <summary>
        /// Initializes a new instance of the DeviceSetOwner class.
        /// </summary>
        public DeviceSetOwner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeviceSetOwner class.
        /// </summary>
        /// <param name="type">Type of account</param>
        /// <param name="id">Account ID</param>
        /// <param name="name">Name of the account</param>
        /// <param name="displayName">Display name of the account</param>
        public DeviceSetOwner(string type, string id, string name, string displayName = default(string))
        {
            Type = type;
            Id = id;
            DisplayName = displayName;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of account
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets account ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets display name of the account
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets name of the account
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
