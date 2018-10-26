// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GetOrCreateRepositoryProviderMappingRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetOrCreateRepositoryProviderMappingRequest class.
        /// </summary>
        public GetOrCreateRepositoryProviderMappingRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GetOrCreateRepositoryProviderMappingRequest class.
        /// </summary>
        /// <param name="externalAccountName">The account name given by the
        /// external provider. If provided, create an organization and the
        /// mapping. If not, create mapping with user.</param>
        public GetOrCreateRepositoryProviderMappingRequest(string externalAccountName = default(string))
        {
            ExternalAccountName = externalAccountName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the account name given by the external provider. If
        /// provided, create an organization and the mapping. If not, create
        /// mapping with user.
        /// </summary>
        [JsonProperty(PropertyName = "external_account_name")]
        public string ExternalAccountName { get; set; }

    }
}