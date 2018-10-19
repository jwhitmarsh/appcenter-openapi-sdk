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
    /// Queue configured in build definition
    /// </summary>
    public partial class BuildAgentQueueResponse
    {
        /// <summary>
        /// Initializes a new instance of the BuildAgentQueueResponse class.
        /// </summary>
        public BuildAgentQueueResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuildAgentQueueResponse class.
        /// </summary>
        /// <param name="buildDefinition">Name of the build definition</param>
        /// <param name="name">Name of the queue</param>
        public BuildAgentQueueResponse(string buildDefinition = default(string), string name = default(string))
        {
            BuildDefinition = buildDefinition;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the build definition
        /// </summary>
        [JsonProperty(PropertyName = "buildDefinition")]
        public string BuildDefinition { get; set; }

        /// <summary>
        /// Gets or sets name of the queue
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
