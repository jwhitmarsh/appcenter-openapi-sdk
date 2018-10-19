// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VSTS account with projects list and user info
    /// </summary>
    public partial class VSTSAccount
    {
        /// <summary>
        /// Initializes a new instance of the VSTSAccount class.
        /// </summary>
        public VSTSAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VSTSAccount class.
        /// </summary>
        /// <param name="accountId">Account id</param>
        /// <param name="accountUri">Account uri</param>
        /// <param name="accountName">Account name</param>
        /// <param name="accountType">Account type</param>
        /// <param name="accountStatus">Account status</param>
        /// <param name="projects">Account projects</param>
        public VSTSAccount(string accountId = default(string), string accountUri = default(string), string accountName = default(string), string accountType = default(string), string accountStatus = default(string), VSTSProfile user = default(VSTSProfile), IList<VSTSProject> projects = default(IList<VSTSProject>))
        {
            AccountId = accountId;
            AccountUri = accountUri;
            AccountName = accountName;
            AccountType = accountType;
            AccountStatus = accountStatus;
            User = user;
            Projects = projects;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets account id
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets account uri
        /// </summary>
        [JsonProperty(PropertyName = "accountUri")]
        public string AccountUri { get; set; }

        /// <summary>
        /// Gets or sets account name
        /// </summary>
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets account type
        /// </summary>
        [JsonProperty(PropertyName = "accountType")]
        public string AccountType { get; set; }

        /// <summary>
        /// Gets or sets account status
        /// </summary>
        [JsonProperty(PropertyName = "accountStatus")]
        public string AccountStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public VSTSProfile User { get; set; }

        /// <summary>
        /// Gets or sets account projects
        /// </summary>
        [JsonProperty(PropertyName = "projects")]
        public IList<VSTSProject> Projects { get; set; }

    }
}