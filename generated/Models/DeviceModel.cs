// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DeviceModel
    {
        /// <summary>
        /// Initializes a new instance of the DeviceModel class.
        /// </summary>
        public DeviceModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeviceModel class.
        /// </summary>
        public DeviceModel(string name = default(string), string manufacturer = default(string), string model = default(string), string platform = default(string), DeviceDimensions dimensions = default(DeviceDimensions), DeviceResolution resolution = default(DeviceResolution), string releaseDate = default(string), string formFactor = default(string), DeviceScreenSize screenSize = default(DeviceScreenSize), DeviceCpu cpu = default(DeviceCpu), DeviceMemory memory = default(DeviceMemory), double? screenRotation = default(double?), DeviceFrame deviceFrame = default(DeviceFrame), double? availabilityCount = default(double?))
        {
            Name = name;
            Manufacturer = manufacturer;
            Model = model;
            Platform = platform;
            Dimensions = dimensions;
            Resolution = resolution;
            ReleaseDate = releaseDate;
            FormFactor = formFactor;
            ScreenSize = screenSize;
            Cpu = cpu;
            Memory = memory;
            ScreenRotation = screenRotation;
            DeviceFrame = deviceFrame;
            AvailabilityCount = availabilityCount;
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
        [JsonProperty(PropertyName = "manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "model")]
        public string Model { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public DeviceDimensions Dimensions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resolution")]
        public DeviceResolution Resolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "releaseDate")]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formFactor")]
        public string FormFactor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "screenSize")]
        public DeviceScreenSize ScreenSize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu")]
        public DeviceCpu Cpu { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        public DeviceMemory Memory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "screenRotation")]
        public double? ScreenRotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceFrame")]
        public DeviceFrame DeviceFrame { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "availabilityCount")]
        public double? AvailabilityCount { get; set; }

    }
}
