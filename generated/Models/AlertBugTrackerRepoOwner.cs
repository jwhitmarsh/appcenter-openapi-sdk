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
    /// Repository owner object
    /// </summary>
    public partial class AlertBugTrackerRepoOwner
    {
        /// <summary>
        /// Initializes a new instance of the AlertBugTrackerRepoOwner class.
        /// </summary>
        public AlertBugTrackerRepoOwner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertBugTrackerRepoOwner class.
        /// </summary>
        public AlertBugTrackerRepoOwner(string name = default(string), string id = default(string), string login = default(string))
        {
            Name = name;
            Id = id;
            Login = login;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "login")]
        public string Login { get; set; }

    }
}
