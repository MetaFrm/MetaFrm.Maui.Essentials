using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.Devices
{
    /// <summary>
    /// Represents information about the device.
    /// </summary>
    public class DeviceInfo : Maui.Devices.IDeviceInfo
    {
        /// <summary>
        /// Gets the model of the device.
        /// Device model.
        /// </summary>
        public string? Model { get; set; }

        /// <summary>
        /// Gets the manufacturer of the device.
        /// Device manufacturer.
        /// </summary>
        public string? Manufacturer { get; set; }

        /// <summary>
        /// Gets the name of the device.
        /// The name of the device (often specified by the user).
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets the version of the operating system.
        /// The version of the operating system.
        /// </summary>
        public string? VersionString { get; set; }

        /// <summary>
        /// Gets the version of the operating system.
        /// The device operating system.
        /// </summary>
        public Version? Version { get; set; }

        /// <summary>
        /// Gets the platform or operating system of the device.
        /// </summary>
        public Maui.Devices.DevicePlatform Platform { get; set; } = Maui.Devices.DevicePlatform.Unknown;

        /// <summary>
        /// Gets the idiom of the device.
        /// The idiom.
        /// </summary>
        public Maui.Devices.DeviceIdiom Idiom { get; set; } = Maui.Devices.DeviceIdiom.Unknown;

        /// <summary>
        /// Gets the type of device the application is running on.
        /// The device type.
        /// </summary>
        public Maui.Devices.DeviceType DeviceType { get; set; } = Maui.Devices.DeviceType.Unknown;

        /// <summary>
        /// The device platform that the application is running on.
        /// </summary>
        public DeviceInfo()
        {
            Maui.Devices.DevicePlatform devicePlatform;

            devicePlatform = Microsoft.Maui.Devices.DeviceInfo.Platform.EnumParse<Maui.Devices.DevicePlatform>();

            if (Factory.Platform != devicePlatform)
            {
                MetaFrmException exception = new("Factory.Init DevicePlatform setting is incorrect.");

                Factory.Logger.Error(exception, "(Factory.Platform{0} != devicePlatform{0})", Factory.Platform, devicePlatform);

                throw exception;
            }

            this.Model = Microsoft.Maui.Devices.DeviceInfo.Model;
            this.Manufacturer = Microsoft.Maui.Devices.DeviceInfo.Manufacturer;
            this.Name = Microsoft.Maui.Devices.DeviceInfo.Name;
            this.VersionString = Microsoft.Maui.Devices.DeviceInfo.VersionString;
            this.Version = Microsoft.Maui.Devices.DeviceInfo.Version;
            this.Platform = devicePlatform;
            this.Idiom = Microsoft.Maui.Devices.DeviceInfo.Idiom.EnumParse<Maui.Devices.DeviceIdiom>();
            this.DeviceType = Microsoft.Maui.Devices.DeviceInfo.DeviceType.EnumParse<Maui.Devices.DeviceType>();
        }
    }
}