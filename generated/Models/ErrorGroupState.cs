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

    public partial class ErrorGroupState
    {
        /// <summary>
        /// Initializes a new instance of the ErrorGroupState class.
        /// </summary>
        public ErrorGroupState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorGroupState class.
        /// </summary>
        /// <param name="state">Possible values include: 'open', 'closed',
        /// 'ignored'</param>
        public ErrorGroupState(string state, string annotation = default(string))
        {
            State = state;
            Annotation = annotation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'open', 'closed', 'ignored'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "annotation")]
        public string Annotation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (State == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "State");
            }
        }
    }
}
