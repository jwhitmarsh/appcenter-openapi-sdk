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

    /// <summary>
    /// a stacktrace in a processed and prettyfied way
    /// </summary>
    public partial class Stacktrace
    {
        /// <summary>
        /// Initializes a new instance of the Stacktrace class.
        /// </summary>
        public Stacktrace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Stacktrace class.
        /// </summary>
        public Stacktrace(string title = default(string), string reason = default(string), IList<Thread> threads = default(IList<Thread>), Exception exception = default(Exception))
        {
            Title = title;
            Reason = reason;
            Threads = threads;
            Exception = exception;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "threads")]
        public IList<Thread> Threads { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exception")]
        public Exception Exception { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Threads != null)
            {
                foreach (var element in Threads)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Exception != null)
            {
                Exception.Validate();
            }
        }
    }
}
