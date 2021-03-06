// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SubmitDsrOperationRequest
    {
        /// <summary>
        /// Initializes a new instance of the SubmitDsrOperationRequest class.
        /// </summary>
        public SubmitDsrOperationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubmitDsrOperationRequest class.
        /// </summary>
        /// <param name="request">Possible values include: 'Delete', 'Purge',
        /// 'UndoDelete', 'Export'</param>
        /// <param name="operationId">The DSR operation ID provided by the GDPR
        /// coordinator. Used for tracking only.</param>
        public SubmitDsrOperationRequest(string request = default(string), string accountId = default(string), string appId = default(string), string operationId = default(string))
        {
            Request = request;
            AccountId = accountId;
            AppId = appId;
            OperationId = operationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Delete', 'Purge',
        /// 'UndoDelete', 'Export'
        /// </summary>
        [JsonProperty(PropertyName = "request")]
        public string Request { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets the DSR operation ID provided by the GDPR coordinator.
        /// Used for tracking only.
        /// </summary>
        [JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; set; }

    }
}
