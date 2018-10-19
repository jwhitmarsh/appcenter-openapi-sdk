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

    /// <summary>
    /// List of export configurations
    /// </summary>
    public partial class ExportConfigurationListResult
    {
        /// <summary>
        /// Initializes a new instance of the ExportConfigurationListResult
        /// class.
        /// </summary>
        public ExportConfigurationListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExportConfigurationListResult
        /// class.
        /// </summary>
        /// <param name="total">the total count of exports</param>
        public ExportConfigurationListResult(IList<ExportConfigurationResult> values, long? total = default(long?), string nextLink = default(string))
        {
            Values = values;
            Total = total;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<ExportConfigurationResult> Values { get; set; }

        /// <summary>
        /// Gets or sets the total count of exports
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public long? Total { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Values == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Values");
            }
            if (Values != null)
            {
                foreach (var element in Values)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}