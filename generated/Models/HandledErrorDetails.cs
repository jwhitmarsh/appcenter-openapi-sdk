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

    public partial class HandledErrorDetails : HandledError
    {
        /// <summary>
        /// Initializes a new instance of the HandledErrorDetails class.
        /// </summary>
        public HandledErrorDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HandledErrorDetails class.
        /// </summary>
        /// <param name="appLaunchTimestamp">Timestamp when the app was
        /// launched, example: '2017-03-13T18:05:42Z'.
        /// </param>
        /// <param name="carrierName">Carrier name (for mobile devices).
        /// </param>
        /// <param name="jailbreak">Flag indicating if device is jailbroken
        /// </param>
        public HandledErrorDetails(string errorId = default(string), System.DateTime? timestamp = default(System.DateTime?), string deviceName = default(string), string osVersion = default(string), string osType = default(string), string country = default(string), string language = default(string), string name = default(string), IList<HandledErrorReasonFrame> reasonFrames = default(IList<HandledErrorReasonFrame>), System.DateTime? appLaunchTimestamp = default(System.DateTime?), string carrierName = default(string), bool? jailbreak = default(bool?), IDictionary<string, string> properties = default(IDictionary<string, string>))
            : base(errorId, timestamp, deviceName, osVersion, osType, country, language)
        {
            Name = name;
            ReasonFrames = reasonFrames;
            AppLaunchTimestamp = appLaunchTimestamp;
            CarrierName = carrierName;
            Jailbreak = jailbreak;
            Properties = properties;
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
        [JsonProperty(PropertyName = "reasonFrames")]
        public IList<HandledErrorReasonFrame> ReasonFrames { get; set; }

        /// <summary>
        /// Gets or sets timestamp when the app was launched, example:
        /// '2017-03-13T18:05:42Z'.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "appLaunchTimestamp")]
        public System.DateTime? AppLaunchTimestamp { get; set; }

        /// <summary>
        /// Gets or sets carrier name (for mobile devices).
        ///
        /// </summary>
        [JsonProperty(PropertyName = "carrierName")]
        public string CarrierName { get; set; }

        /// <summary>
        /// Gets or sets flag indicating if device is jailbroken
        ///
        /// </summary>
        [JsonProperty(PropertyName = "jailbreak")]
        public bool? Jailbreak { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

    }
}
