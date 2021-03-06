// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IntuneGroupValue
    {
        /// <summary>
        /// Initializes a new instance of the IntuneGroupValue class.
        /// </summary>
        public IntuneGroupValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntuneGroupValue class.
        /// </summary>
        /// <param name="id">the id of the Group</param>
        /// <param name="displayName">the display name of the group</param>
        public IntuneGroupValue(string id = default(string), string displayName = default(string))
        {
            Id = id;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the Group
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name of the group
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

    }
}
