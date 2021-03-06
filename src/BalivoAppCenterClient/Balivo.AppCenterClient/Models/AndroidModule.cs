// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AndroidModule
    {
        /// <summary>
        /// Initializes a new instance of the AndroidModule class.
        /// </summary>
        public AndroidModule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AndroidModule class.
        /// </summary>
        /// <param name="name">Name of the Android module</param>
        /// <param name="productFlavors">The product flavors of the Android
        /// module</param>
        /// <param name="buildVariants">The detected build variants of the
        /// Android module (matrix of product flavor + build type
        /// (debug|release))</param>
        /// <param name="buildTypes">The detected build types fo the Android
        /// module</param>
        /// <param name="isRoot">Whether the module is at the root level of the
        /// project</param>
        public AndroidModule(string name, IList<string> productFlavors = default(IList<string>), IList<string> buildVariants = default(IList<string>), IList<string> buildTypes = default(IList<string>), bool? isRoot = default(bool?))
        {
            Name = name;
            ProductFlavors = productFlavors;
            BuildVariants = buildVariants;
            BuildTypes = buildTypes;
            IsRoot = isRoot;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Android module
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the product flavors of the Android module
        /// </summary>
        [JsonProperty(PropertyName = "productFlavors")]
        public IList<string> ProductFlavors { get; set; }

        /// <summary>
        /// Gets or sets the detected build variants of the Android module
        /// (matrix of product flavor + build type (debug|release))
        /// </summary>
        [JsonProperty(PropertyName = "buildVariants")]
        public IList<string> BuildVariants { get; set; }

        /// <summary>
        /// Gets or sets the detected build types fo the Android module
        /// </summary>
        [JsonProperty(PropertyName = "buildTypes")]
        public IList<string> BuildTypes { get; set; }

        /// <summary>
        /// Gets or sets whether the module is at the root level of the project
        /// </summary>
        [JsonProperty(PropertyName = "isRoot")]
        public bool? IsRoot { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
