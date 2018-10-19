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

    public partial class CustomProperty
    {
        /// <summary>
        /// Initializes a new instance of the CustomProperty class.
        /// </summary>
        public CustomProperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomProperty class.
        /// </summary>
        public CustomProperty(string name)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
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
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Name != null)
            {
                if (Name.Length > 128)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 128);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(Name, "^[a-zA-Z][a-zA-Z0-9\\-_]*$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Name", "^[a-zA-Z][a-zA-Z0-9\\-_]*$");
                }
            }
        }
    }
}
