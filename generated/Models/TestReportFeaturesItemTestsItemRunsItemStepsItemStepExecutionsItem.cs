// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TestReportFeaturesItemTestsItemRunsItemStepsItemStepExecutionsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TestReportFeaturesItemTestsItemRunsItemStepsItemStepExecutionsItem
        /// class.
        /// </summary>
        public TestReportFeaturesItemTestsItemRunsItemStepsItemStepExecutionsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// TestReportFeaturesItemTestsItemRunsItemStepsItemStepExecutionsItem
        /// class.
        /// </summary>
        public TestReportFeaturesItemTestsItemRunsItemStepsItemStepExecutionsItem(string deviceSnapshotId = default(string), string status = default(string), double? timestamp = default(double?))
        {
            DeviceSnapshotId = deviceSnapshotId;
            Status = status;
            Timestamp = timestamp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "device_snapshot_id")]
        public string DeviceSnapshotId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public double? Timestamp { get; set; }

    }
}
