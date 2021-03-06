// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AzureSubscriptionUpdateBillableRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureSubscriptionUpdateBillableRequest class.
        /// </summary>
        public AzureSubscriptionUpdateBillableRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureSubscriptionUpdateBillableRequest class.
        /// </summary>
        /// <param name="isBillable">Billable status of the
        /// subscription</param>
        public AzureSubscriptionUpdateBillableRequest(bool isBillable)
        {
            IsBillable = isBillable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets billable status of the subscription
        /// </summary>
        [JsonProperty(PropertyName = "is_billable")]
        public bool IsBillable { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
