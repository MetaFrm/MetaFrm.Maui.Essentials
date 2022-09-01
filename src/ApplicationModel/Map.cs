using MetaFrm.Extensions;

namespace MetaFrm.Maui.ApplicationModel
{
    /// <summary>
    /// Map
    /// </summary>
    public class Map : IMap
    {
        /// <summary>
        /// Open the installed application to a specific location.
        /// </summary>
        /// <param name="location">Location to open on maps.</param>
        /// <returns>Task to be completed.</returns>
        public async Task OpenAsync(Devices.Sensors.Location location) => await Microsoft.Maui.ApplicationModel.Map.OpenAsync(new Microsoft.Maui.Devices.Sensors.Location(location.Longitude, location.Longitude, location.Timestamp));

        /// <summary>
        /// Open the installed application to a specific location with launch options.
        /// </summary>
        /// <param name="location">Location to open maps to.</param>
        /// <param name="options">Launch options to use.</param>
        /// <returns>Task to be completed.</returns>
        public async Task OpenAsync(Devices.Sensors.Location location, MapLaunchOptions options) => await Microsoft.Maui.ApplicationModel.Map.OpenAsync(new Microsoft.Maui.Devices.Sensors.Location(location.Longitude, location.Longitude, location.Timestamp)
                , new Microsoft.Maui.ApplicationModel.MapLaunchOptions() { Name = options.Name, NavigationMode = options.NavigationMode.EnumParse<Microsoft.Maui.ApplicationModel.NavigationMode>() });

        /// <summary>
        /// Open the installed application to a specific location.
        /// </summary>
        /// <param name="latitude">Latitude to open to.</param>
        /// <param name="longitude">Longitude to open to.</param>
        /// <returns>Task to be completed.</returns>
        public async Task OpenAsync(double latitude, double longitude) => await Microsoft.Maui.ApplicationModel.Map.OpenAsync(latitude, longitude);

        /// <summary>
        /// Open the installed application to a specific location.
        /// </summary>
        /// <param name="latitude">Latitude to open to.</param>
        /// <param name="longitude">Longitude to open to.</param>
        /// <param name="options">Launch options to use.</param>
        /// <returns>Task to be completed.</returns>
        public async Task OpenAsync(double latitude, double longitude, MapLaunchOptions options) => await Microsoft.Maui.ApplicationModel.Map.OpenAsync(latitude, longitude, new Microsoft.Maui.ApplicationModel.MapLaunchOptions() { Name = options.Name, NavigationMode = options.NavigationMode.EnumParse<Microsoft.Maui.ApplicationModel.NavigationMode>() });

        /// <summary>
        /// Open the installed application to a specific placemark.
        /// </summary>
        /// <param name="placemark">Placemark to open on maps.</param>
        /// <returns>Task to be completed.</returns>
        public async Task OpenAsync(Devices.Sensors.Placemark placemark) => await Microsoft.Maui.ApplicationModel.Map.OpenAsync(new Microsoft.Maui.Devices.Sensors.Placemark()
        {
            Location = new Microsoft.Maui.Devices.Sensors.Location(placemark.Location.Longitude, placemark.Location.Longitude, placemark.Location.Timestamp),
            CountryCode = placemark.CountryCode,
            CountryName = placemark.CountryName,
            FeatureName = placemark.FeatureName,
            PostalCode = placemark.PostalCode,
            SubLocality = placemark.SubLocality,
            Thoroughfare = placemark.Thoroughfare,
            SubThoroughfare = placemark.SubThoroughfare,
            Locality = placemark.Locality,
            AdminArea = placemark.AdminArea,
            SubAdminArea = placemark.SubAdminArea
        });

        /// <summary>
        /// Open the installed application to a specific placemark with launch options.
        /// </summary>
        /// <param name="placemark">Placemark to open maps to.</param>
        /// <param name="options">Launch options to use.</param>
        /// <returns>Task to be completed.</returns>
        public async Task OpenAsync(Devices.Sensors.Placemark placemark, ApplicationModel.MapLaunchOptions options) => await Microsoft.Maui.ApplicationModel.Map.OpenAsync(new Microsoft.Maui.Devices.Sensors.Placemark()
        {
            Location = new Microsoft.Maui.Devices.Sensors.Location(placemark.Location.Longitude, placemark.Location.Longitude, placemark.Location.Timestamp),
            CountryCode = placemark.CountryCode,
            CountryName = placemark.CountryName,
            FeatureName = placemark.FeatureName,
            PostalCode = placemark.PostalCode,
            SubLocality = placemark.SubLocality,
            Thoroughfare = placemark.Thoroughfare,
            SubThoroughfare = placemark.SubThoroughfare,
            Locality = placemark.Locality,
            AdminArea = placemark.AdminArea,
            SubAdminArea = placemark.SubAdminArea
        }, new Microsoft.Maui.ApplicationModel.MapLaunchOptions() { Name = options.Name, NavigationMode = options.NavigationMode.EnumParse<Microsoft.Maui.ApplicationModel.NavigationMode>() });

        /// <summary>
        /// TryOpenAsync
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public async Task<bool> TryOpenAsync(Devices.Sensors.Location location) => await Microsoft.Maui.ApplicationModel.Map.TryOpenAsync(new Microsoft.Maui.Devices.Sensors.Location(location.Longitude, location.Longitude, location.Timestamp));

        /// <summary>
        /// TryOpenAsync
        /// </summary>
        /// <param name="location"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<bool> TryOpenAsync(Devices.Sensors.Location location, MapLaunchOptions options) => await Microsoft.Maui.ApplicationModel.Map.TryOpenAsync(new Microsoft.Maui.Devices.Sensors.Location(location.Longitude, location.Longitude, location.Timestamp)
                , new Microsoft.Maui.ApplicationModel.MapLaunchOptions() { Name = options.Name, NavigationMode = options.NavigationMode.EnumParse<Microsoft.Maui.ApplicationModel.NavigationMode>() });

        /// <summary>
        /// TryOpenAsync
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        public async Task<bool> TryOpenAsync(double latitude, double longitude) => await Microsoft.Maui.ApplicationModel.Map.TryOpenAsync(latitude, longitude);

        /// <summary>
        /// TryOpenAsync
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<bool> TryOpenAsync(double latitude, double longitude, MapLaunchOptions options) => await Microsoft.Maui.ApplicationModel.Map.TryOpenAsync(latitude, longitude
                , new Microsoft.Maui.ApplicationModel.MapLaunchOptions() { Name = options.Name, NavigationMode = options.NavigationMode.EnumParse<Microsoft.Maui.ApplicationModel.NavigationMode>() });

        /// <summary>
        /// TryOpenAsync
        /// </summary>
        /// <param name="placemark"></param>
        /// <returns></returns>
        public async Task<bool> TryOpenAsync(Devices.Sensors.Placemark placemark) => await Microsoft.Maui.ApplicationModel.Map.TryOpenAsync(new Microsoft.Maui.Devices.Sensors.Placemark()
        {
            Location = new Microsoft.Maui.Devices.Sensors.Location(placemark.Location.Longitude, placemark.Location.Longitude, placemark.Location.Timestamp),
            CountryCode = placemark.CountryCode,
            CountryName = placemark.CountryName,
            FeatureName = placemark.FeatureName,
            PostalCode = placemark.PostalCode,
            SubLocality = placemark.SubLocality,
            Thoroughfare = placemark.Thoroughfare,
            SubThoroughfare = placemark.SubThoroughfare,
            Locality = placemark.Locality,
            AdminArea = placemark.AdminArea,
            SubAdminArea = placemark.SubAdminArea
        });

        /// <summary>
        /// TryOpenAsync
        /// </summary>
        /// <param name="placemark"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<bool> TryOpenAsync(Devices.Sensors.Placemark placemark, MapLaunchOptions options) => await Microsoft.Maui.ApplicationModel.Map.TryOpenAsync(new Microsoft.Maui.Devices.Sensors.Placemark()
        {
            Location = new Microsoft.Maui.Devices.Sensors.Location(placemark.Location.Longitude, placemark.Location.Longitude, placemark.Location.Timestamp),
            CountryCode = placemark.CountryCode,
            CountryName = placemark.CountryName,
            FeatureName = placemark.FeatureName,
            PostalCode = placemark.PostalCode,
            SubLocality = placemark.SubLocality,
            Thoroughfare = placemark.Thoroughfare,
            SubThoroughfare = placemark.SubThoroughfare,
            Locality = placemark.Locality,
            AdminArea = placemark.AdminArea,
            SubAdminArea = placemark.SubAdminArea
        }, new Microsoft.Maui.ApplicationModel.MapLaunchOptions() { Name = options.Name, NavigationMode = options.NavigationMode.EnumParse<Microsoft.Maui.ApplicationModel.NavigationMode>() });
    }
}