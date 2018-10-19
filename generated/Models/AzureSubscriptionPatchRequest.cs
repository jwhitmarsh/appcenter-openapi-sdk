// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AzureSubscriptionPatchRequest
    {
        /// <summary>
        /// Initializes a new instance of the AzureSubscriptionPatchRequest
        /// class.
        /// </summary>
        public AzureSubscriptionPatchRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureSubscriptionPatchRequest
        /// class.
        /// </summary>
        /// <param name="isBilling">If the subscription is used for
        /// billing</param>
        public AzureSubscriptionPatchRequest(bool isBilling)
        {
            IsBilling = isBilling;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if the subscription is used for billing
        /// </summary>
        [JsonProperty(PropertyName = "is_billing")]
        public bool IsBilling { get; set; }

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
