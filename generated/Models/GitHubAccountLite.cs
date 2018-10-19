// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The GitHub Installation
    /// </summary>
    public partial class GitHubAccountLite
    {
        /// <summary>
        /// Initializes a new instance of the GitHubAccountLite class.
        /// </summary>
        public GitHubAccountLite()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GitHubAccountLite class.
        /// </summary>
        /// <param name="id">GitHub Account Id</param>
        /// <param name="login">GitHub Account Login Name</param>
        /// <param name="type">GitHub Account Type</param>
        /// <param name="url">GitHub Account Url</param>
        public GitHubAccountLite(string id = default(string), string login = default(string), string type = default(string), string url = default(string))
        {
            Id = id;
            Login = login;
            Type = type;
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets gitHub Account Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets gitHub Account Login Name
        /// </summary>
        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }

        /// <summary>
        /// Gets or sets gitHub Account Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets gitHub Account Url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }
}