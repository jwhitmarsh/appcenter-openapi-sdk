// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PatchReleaseRequest
    {
        /// <summary>
        /// Initializes a new instance of the PatchReleaseRequest class.
        /// </summary>
        public PatchReleaseRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatchReleaseRequest class.
        /// </summary>
        /// <param name="status">updated status of release</param>
        /// <param name="destPublishId">Destination Publish Id</param>
        /// <param name="errorDetails">failure error details from store</param>
        /// <param name="errorContextId">contextId for failed error
        /// message</param>
        /// <param name="wrapPackageUrl">package url for wrapping
        /// request</param>
        /// <param name="isWrapperRequest">request is for wrapping or
        /// not</param>
        public PatchReleaseRequest(string status = default(string), string destPublishId = default(string), string errorDetails = default(string), string errorContextId = default(string), string wrapPackageUrl = default(string), bool? isWrapperRequest = default(bool?))
        {
            Status = status;
            DestPublishId = destPublishId;
            ErrorDetails = errorDetails;
            ErrorContextId = errorContextId;
            WrapPackageUrl = wrapPackageUrl;
            IsWrapperRequest = isWrapperRequest;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets updated status of release
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets destination Publish Id
        /// </summary>
        [JsonProperty(PropertyName = "dest_publish_id")]
        public string DestPublishId { get; set; }

        /// <summary>
        /// Gets or sets failure error details from store
        /// </summary>
        [JsonProperty(PropertyName = "error_details")]
        public string ErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets contextId for failed error message
        /// </summary>
        [JsonProperty(PropertyName = "error_contextId")]
        public string ErrorContextId { get; set; }

        /// <summary>
        /// Gets or sets package url for wrapping request
        /// </summary>
        [JsonProperty(PropertyName = "wrap_package_url")]
        public string WrapPackageUrl { get; set; }

        /// <summary>
        /// Gets or sets request is for wrapping or not
        /// </summary>
        [JsonProperty(PropertyName = "is_wrapper_request")]
        public bool? IsWrapperRequest { get; set; }

    }
}
