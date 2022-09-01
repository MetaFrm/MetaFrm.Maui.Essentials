using MetaFrm.Extensions;

namespace MetaFrm.Maui.Devices
{
    /// <summary>
    /// Represents information about the device.
    /// </summary>
    public class DeviceInfo : IDeviceInfo
    {
        /// <summary>
        /// Gets the model of the device.
        /// Device model.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets the manufacturer of the device.
        /// Device manufacturer.
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Gets the name of the device.
        /// The name of the device (often specified by the user).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the version of the operating system.
        /// The version of the operating system.
        /// </summary>
        public string VersionString { get; set; }

        /// <summary>
        /// Gets the version of the operating system.
        /// The device operating system.
        /// </summary>
        public Version Version { get; set; }

        /// <summary>
        /// Gets the platform or operating system of the device.
        /// </summary>
        public DevicePlatform Platform { get; set; } = DevicePlatform.Unknown;

        /// <summary>
        /// Gets the idiom of the device.
        /// The idiom.
        /// </summary>
        public DeviceIdiom Idiom { get; set; } = DeviceIdiom.Unknown;

        /// <summary>
        /// Gets the type of device the application is running on.
        /// The device type.
        /// </summary>
        public DeviceType DeviceType { get; set; } = DeviceType.Unknown;

        /// <summary>
        /// The device platform that the application is running on.
        /// </summary>
        public DeviceInfo()
        {
            DevicePlatform devicePlatform;

            devicePlatform = Microsoft.Maui.Devices.DeviceInfo.Platform.EnumParse<DevicePlatform>();

            if ((Factory.DeviceInfo != null ? Factory.DeviceInfo.Platform : Factory.Platform) != devicePlatform)
                throw new Exception("Factory.Init DevicePlatform setting is incorrect.");

            this.Model = Microsoft.Maui.Devices.DeviceInfo.Model;
            this.Manufacturer = Microsoft.Maui.Devices.DeviceInfo.Manufacturer;
            this.Name = Microsoft.Maui.Devices.DeviceInfo.Name;
            this.VersionString = Microsoft.Maui.Devices.DeviceInfo.VersionString;
            this.Version = Microsoft.Maui.Devices.DeviceInfo.Version;
            this.Platform = devicePlatform;
            this.Idiom = Microsoft.Maui.Devices.DeviceInfo.Idiom.EnumParse<DeviceIdiom>();
            this.DeviceType = Microsoft.Maui.Devices.DeviceInfo.DeviceType.EnumParse<DeviceType>();

            Factory.DeviceInfo = this;
        }
    }
}