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
    /// Configuration for export to Blob Storage with customer linked
    /// subscription.
    /// </summary>
    [Newtonsoft.Json.JsonObject("blob_storage_linked_subscription")]
    public partial class ExportConfigurationBlobStorageLinkedSubscription : ExportBlobConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ExportConfigurationBlobStorageLinkedSubscription class.
        /// </summary>
        public ExportConfigurationBlobStorageLinkedSubscription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ExportConfigurationBlobStorageLinkedSubscription class.
        /// </summary>
        /// <param name="subscriptionId">Id of customer subscription linked in
        /// App Center</param>
        /// <param name="resourceName">The resource name on azure</param>
        /// <param name="resourceGroup">The resource group name on
        /// azure</param>
        /// <param name="blobPathFormatKind">The path to the blob when enum set
        /// to 'WithoutAppId' is 'year/month/day/hour/minute' and when set to
        /// 'WithAppId' is 'appId/year/month/day/hour/minute'. Possible values
        /// include: 'WithoutAppId', 'WithAppId'</param>
        public ExportConfigurationBlobStorageLinkedSubscription(string subscriptionId, IList<ExportEntity?> exportEntities = default(IList<ExportEntity?>), string resourceName = default(string), string resourceGroup = default(string), BlobPathFormatKind? blobPathFormatKind = default(BlobPathFormatKind?))
            : base(exportEntities, resourceName, resourceGroup, blobPathFormatKind)
        {
            SubscriptionId = subscriptionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of customer subscription linked in App Center
        /// </summary>
        [JsonProperty(PropertyName = "subscription_id")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubscriptionId");
            }
        }
    }
}
