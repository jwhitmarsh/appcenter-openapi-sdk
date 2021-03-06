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
    /// Defines headers for ExportRequest operation.
    /// </summary>
    public partial class DataSubjectRightExportRequestHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataSubjectRightExportRequestHeaders class.
        /// </summary>
        public DataSubjectRightExportRequestHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DataSubjectRightExportRequestHeaders class.
        /// </summary>
        /// <param name="location">Link to get details about the
        /// export.</param>
        public DataSubjectRightExportRequestHeaders(string location = default(string))
        {
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets link to get details about the export.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
