// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Crash
    {
        /// <summary>
        /// Initializes a new instance of the Crash class.
        /// </summary>
        public Crash()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Crash class.
        /// </summary>
        public Crash(string crashId, System.DateTime timestamp, string version, string build, string device, string osVersion, string userName, CrashDetails details = default(CrashDetails), string displayId = default(string), string deviceName = default(string), string osType = default(string), Stacktrace stacktrace = default(Stacktrace), string userEmail = default(string))
        {
            Details = details;
            CrashId = crashId;
            DisplayId = displayId;
            Timestamp = timestamp;
            Version = version;
            Build = build;
            Device = device;
            DeviceName = deviceName;
            OsVersion = osVersion;
            OsType = osType;
            Stacktrace = stacktrace;
            UserName = userName;
            UserEmail = userEmail;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public CrashDetails Details { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "crash_id")]
        public string CrashId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_id")]
        public string DisplayId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime Timestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "build")]
        public string Build { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "device")]
        public string Device { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "os_type")]
        public string OsType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stacktrace")]
        public Stacktrace Stacktrace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CrashId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CrashId");
            }
            if (Version == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Version");
            }
            if (Build == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Build");
            }
            if (Device == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Device");
            }
            if (OsVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OsVersion");
            }
            if (UserName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UserName");
            }
            if (Details != null)
            {
                Details.Validate();
            }
            if (Stacktrace != null)
            {
                Stacktrace.Validate();
            }
        }
    }
}
