// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Commit
    {
        /// <summary>
        /// Initializes a new instance of the Commit class.
        /// </summary>
        public Commit()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Commit class.
        /// </summary>
        /// <param name="sha">The commit SHA</param>
        /// <param name="url">The URL to the commit</param>
        public Commit(string sha = default(string), string url = default(string))
        {
            Sha = sha;
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the commit SHA
        /// </summary>
        [JsonProperty(PropertyName = "sha")]
        public string Sha { get; set; }

        /// <summary>
        /// Gets or sets the URL to the commit
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

    }
}
