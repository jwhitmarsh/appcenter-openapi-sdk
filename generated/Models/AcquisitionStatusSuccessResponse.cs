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

    public partial class AcquisitionStatusSuccessResponse
    {
        /// <summary>
        /// Initializes a new instance of the AcquisitionStatusSuccessResponse
        /// class.
        /// </summary>
        public AcquisitionStatusSuccessResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AcquisitionStatusSuccessResponse
        /// class.
        /// </summary>
        /// <param name="code">The code indicating the status</param>
        /// <param name="message">The message indicating the status</param>
        public AcquisitionStatusSuccessResponse(string code, string message)
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the code indicating the status
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the message indicating the status
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
        }
    }
}
