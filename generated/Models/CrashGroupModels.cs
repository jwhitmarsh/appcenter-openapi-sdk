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

    public partial class CrashGroupModels
    {
        /// <summary>
        /// Initializes a new instance of the CrashGroupModels class.
        /// </summary>
        public CrashGroupModels()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CrashGroupModels class.
        /// </summary>
        public CrashGroupModels(long? crashCount = default(long?), IList<CrashGroupModel> modelsProperty = default(IList<CrashGroupModel>))
        {
            CrashCount = crashCount;
            ModelsProperty = modelsProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "crash_count")]
        public long? CrashCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "models")]
        public IList<CrashGroupModel> ModelsProperty { get; set; }

    }
}
