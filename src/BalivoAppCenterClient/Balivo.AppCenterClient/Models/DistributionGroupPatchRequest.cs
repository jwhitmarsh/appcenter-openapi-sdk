// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DistributionGroupPatchRequest
    {
        /// <summary>
        /// Initializes a new instance of the DistributionGroupPatchRequest
        /// class.
        /// </summary>
        public DistributionGroupPatchRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DistributionGroupPatchRequest
        /// class.
        /// </summary>
        /// <param name="name">The name of the distribution group</param>
        /// <param name="isPublic">Whether the distribution group is
        /// public</param>
        public DistributionGroupPatchRequest(string name = default(string), bool? isPublic = default(bool?))
        {
            Name = name;
            IsPublic = isPublic;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the distribution group
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets whether the distribution group is public
        /// </summary>
        [JsonProperty(PropertyName = "is_public")]
        public bool? IsPublic { get; set; }

    }
}