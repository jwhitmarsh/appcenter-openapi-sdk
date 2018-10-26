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

    public partial class PostRepositoryProviderMappingRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PostRepositoryProviderMappingRequest class.
        /// </summary>
        public PostRepositoryProviderMappingRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PostRepositoryProviderMappingRequest class.
        /// </summary>
        /// <param name="externalAccountId">Id of user in the external provider
        /// service</param>
        /// <param name="accountId">App Center account id to link to this
        /// provider and external id</param>
        public PostRepositoryProviderMappingRequest(string externalAccountId, System.Guid accountId)
        {
            ExternalAccountId = externalAccountId;
            AccountId = accountId;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for PostRepositoryProviderMappingRequest class.
        /// </summary>
        static PostRepositoryProviderMappingRequest()
        {
            Provider = "github";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of user in the external provider service
        /// </summary>
        [JsonProperty(PropertyName = "external_account_id")]
        public string ExternalAccountId { get; set; }

        /// <summary>
        /// Gets or sets app Center account id to link to this provider and
        /// external id
        /// </summary>
        [JsonProperty(PropertyName = "account_id")]
        public System.Guid AccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public static string Provider { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ExternalAccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ExternalAccountId");
            }
        }
    }
}