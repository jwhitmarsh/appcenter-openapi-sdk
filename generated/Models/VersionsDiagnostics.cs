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

    public partial class VersionsDiagnostics
    {
        /// <summary>
        /// Initializes a new instance of the VersionsDiagnostics class.
        /// </summary>
        public VersionsDiagnostics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VersionsDiagnostics class.
        /// </summary>
        /// <param name="versions">list of version count</param>
        /// <param name="total">the total count of versions</param>
        public VersionsDiagnostics(IList<VersionDiagnostics> versions = default(IList<VersionDiagnostics>), long? total = default(long?))
        {
            Versions = versions;
            Total = total;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of version count
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public IList<VersionDiagnostics> Versions { get; set; }

        /// <summary>
        /// Gets or sets the total count of versions
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public long? Total { get; set; }

    }
}
