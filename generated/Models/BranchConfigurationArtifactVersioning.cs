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
    /// The versioning configuration for artifacts built for this branch
    /// </summary>
    public partial class BranchConfigurationArtifactVersioning
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BranchConfigurationArtifactVersioning class.
        /// </summary>
        public BranchConfigurationArtifactVersioning()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BranchConfigurationArtifactVersioning class.
        /// </summary>
        /// <param name="buildNumberFormat">Possible values include: 'buildId',
        /// 'timestamp'</param>
        public BranchConfigurationArtifactVersioning(string buildNumberFormat = default(string))
        {
            BuildNumberFormat = buildNumberFormat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'buildId', 'timestamp'
        /// </summary>
        [JsonProperty(PropertyName = "buildNumberFormat")]
        public string BuildNumberFormat { get; set; }

    }
}
