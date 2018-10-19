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

    public partial class XamarinSolution
    {
        /// <summary>
        /// Initializes a new instance of the XamarinSolution class.
        /// </summary>
        public XamarinSolution()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the XamarinSolution class.
        /// </summary>
        /// <param name="path">Path to solution</param>
        /// <param name="configurations">Solution configurations</param>
        /// <param name="defaultConfiguration">Solution default
        /// configuration</param>
        public XamarinSolution(string path, IList<string> configurations, string defaultConfiguration = default(string))
        {
            Path = path;
            Configurations = configurations;
            DefaultConfiguration = defaultConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets path to solution
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets solution configurations
        /// </summary>
        [JsonProperty(PropertyName = "configurations")]
        public IList<string> Configurations { get; set; }

        /// <summary>
        /// Gets or sets solution default configuration
        /// </summary>
        [JsonProperty(PropertyName = "defaultConfiguration")]
        public string DefaultConfiguration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Path == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Path");
            }
            if (Configurations == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Configurations");
            }
        }
    }
}
