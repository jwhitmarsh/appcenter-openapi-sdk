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
    /// Generic result for any alerting API operation
    /// </summary>
    public partial class AlertOperationResult
    {
        /// <summary>
        /// Initializes a new instance of the AlertOperationResult class.
        /// </summary>
        public AlertOperationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertOperationResult class.
        /// </summary>
        /// <param name="requestId">Unique request identifier for
        /// tracking</param>
        public AlertOperationResult(string requestId)
        {
            RequestId = requestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique request identifier for tracking
        /// </summary>
        [JsonProperty(PropertyName = "request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RequestId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RequestId");
            }
        }
    }
}
