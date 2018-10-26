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

    /// <summary>
    /// The information for a single iOS device
    /// </summary>
    public partial class DeviceInfoResponse
    {
        /// <summary>
        /// Initializes a new instance of the DeviceInfoResponse class.
        /// </summary>
        public DeviceInfoResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeviceInfoResponse class.
        /// </summary>
        /// <param name="udid">The Unique Device IDentifier of the
        /// device</param>
        /// <param name="model">The model identifier of the device, in the
        /// format iDeviceM,N</param>
        /// <param name="deviceName">The device description, in the format
        /// "iPhone 7 Plus (A1784)"</param>
        /// <param name="osBuild">The last known OS version running on the
        /// device</param>
        /// <param name="osVersion">The last known OS version running on the
        /// device</param>
        /// <param name="status">The provisioning status of the device.</param>
        /// <param name="fullDeviceName">A combination of the device model name
        /// and the owner name.</param>
        /// <param name="serial">The device's serial number. Always empty or
        /// undefined at present.</param>
        /// <param name="imei">The device's International Mobile Equipment
        /// Identity number. Always empty or undefined at present.</param>
        /// <param name="ownerId">The user ID of the device owner.</param>
        /// <param name="registeredAt">Timestamp of when the device was
        /// registered in ISO format.</param>
        public DeviceInfoResponse(string udid, string model, string deviceName, string osBuild, string osVersion, string status, string fullDeviceName = default(string), string serial = default(string), string imei = default(string), string ownerId = default(string), string registeredAt = default(string))
        {
            Udid = udid;
            Model = model;
            DeviceName = deviceName;
            FullDeviceName = fullDeviceName;
            OsBuild = osBuild;
            OsVersion = osVersion;
            Serial = serial;
            Imei = imei;
            OwnerId = ownerId;
            Status = status;
            RegisteredAt = registeredAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Unique Device IDentifier of the device
        /// </summary>
        [JsonProperty(PropertyName = "udid")]
        public string Udid { get; set; }

        /// <summary>
        /// Gets or sets the model identifier of the device, in the format
        /// iDeviceM,N
        /// </summary>
        [JsonProperty(PropertyName = "model")]
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the device description, in the format "iPhone 7 Plus
        /// (A1784)"
        /// </summary>
        [JsonProperty(PropertyName = "device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// Gets or sets a combination of the device model name and the owner
        /// name.
        /// </summary>
        [JsonProperty(PropertyName = "full_device_name")]
        public string FullDeviceName { get; set; }

        /// <summary>
        /// Gets or sets the last known OS version running on the device
        /// </summary>
        [JsonProperty(PropertyName = "os_build")]
        public string OsBuild { get; set; }

        /// <summary>
        /// Gets or sets the last known OS version running on the device
        /// </summary>
        [JsonProperty(PropertyName = "os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// Gets or sets the device's serial number. Always empty or undefined
        /// at present.
        /// </summary>
        [JsonProperty(PropertyName = "serial")]
        public string Serial { get; set; }

        /// <summary>
        /// Gets or sets the device's International Mobile Equipment Identity
        /// number. Always empty or undefined at present.
        /// </summary>
        [JsonProperty(PropertyName = "imei")]
        public string Imei { get; set; }

        /// <summary>
        /// Gets or sets the user ID of the device owner.
        /// </summary>
        [JsonProperty(PropertyName = "owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the provisioning status of the device.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets timestamp of when the device was registered in ISO
        /// format.
        /// </summary>
        [JsonProperty(PropertyName = "registered_at")]
        public string RegisteredAt { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Udid == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Udid");
            }
            if (Model == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Model");
            }
            if (DeviceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DeviceName");
            }
            if (OsBuild == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OsBuild");
            }
            if (OsVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OsVersion");
            }
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
        }
    }
}