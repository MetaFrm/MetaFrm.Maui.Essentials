using MetaFrm.Extensions;

namespace MetaFrm.Maui.Devices.Sensors
{
    /// <summary>
    /// Geolocation
    /// </summary>
    public class Geolocation : IGeolocation
    {
        /// <summary>
        /// GetLastKnownLocationAsync
        /// </summary>
        /// <returns></returns>
        public async Task<Location> GetLastKnownLocationAsync()
        {
            Microsoft.Maui.Devices.Sensors.Location locationOrg = await Microsoft.Maui.Devices.Sensors.Geolocation.Default.GetLastKnownLocationAsync();

            Location location = new(locationOrg.Latitude, locationOrg.Longitude, locationOrg.Timestamp)
            {
                Altitude = locationOrg.Altitude,
                Course = locationOrg.Course,
                Speed = locationOrg.Speed,
                ReducedAccuracy = locationOrg.ReducedAccuracy,
                VerticalAccuracy = locationOrg.VerticalAccuracy,
                Accuracy = locationOrg.Accuracy,
                IsFromMockProvider = locationOrg.IsFromMockProvider,
                AltitudeReferenceSystem = locationOrg.AltitudeReferenceSystem.EnumParse<AltitudeReferenceSystem>()
            };

            return location;
        }

        /// <summary>
        /// GetLocationAsync
        /// </summary>
        /// <returns></returns>
        public async Task<Location> GetLocationAsync()
        {
            Microsoft.Maui.Devices.Sensors.Location locationOrg = await Microsoft.Maui.Devices.Sensors.Geolocation.Default.GetLocationAsync();

            Location location = new(locationOrg.Latitude, locationOrg.Longitude, locationOrg.Timestamp)
            {
                Altitude = locationOrg.Altitude,
                Course = locationOrg.Course,
                Speed = locationOrg.Speed,
                ReducedAccuracy = locationOrg.ReducedAccuracy,
                VerticalAccuracy = locationOrg.VerticalAccuracy,
                Accuracy = locationOrg.Accuracy,
                IsFromMockProvider = locationOrg.IsFromMockProvider,
                AltitudeReferenceSystem = locationOrg.AltitudeReferenceSystem.EnumParse<AltitudeReferenceSystem>()
            };

            return location;
        }

        /// <summary>
        /// GetLocationAsync
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Location> GetLocationAsync(GeolocationRequest request)
        {
            Microsoft.Maui.Devices.Sensors.Location locationOrg = await Microsoft.Maui.Devices.Sensors.Geolocation.Default.GetLocationAsync(new Microsoft.Maui.Devices.Sensors.GeolocationRequest(request.DesiredAccuracy.EnumParse<Microsoft.Maui.Devices.Sensors.GeolocationAccuracy>(), request.Timeout));

            Location location = new(locationOrg.Latitude, locationOrg.Longitude, locationOrg.Timestamp)
            {
                Altitude = locationOrg.Altitude,
                Course = locationOrg.Course,
                Speed = locationOrg.Speed,
                ReducedAccuracy = locationOrg.ReducedAccuracy,
                VerticalAccuracy = locationOrg.VerticalAccuracy,
                Accuracy = locationOrg.Accuracy,
                IsFromMockProvider = locationOrg.IsFromMockProvider,
                AltitudeReferenceSystem = locationOrg.AltitudeReferenceSystem.EnumParse<AltitudeReferenceSystem>()
            };

            return location;
        }

        /// <summary>
        /// GetLocationAsync
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancelToken"></param>
        /// <returns></returns>
        public async Task<Location> GetLocationAsync(GeolocationRequest request, CancellationToken cancelToken)
        {
            Microsoft.Maui.Devices.Sensors.Location locationOrg = await Microsoft.Maui.Devices.Sensors.Geolocation.Default.GetLocationAsync(new Microsoft.Maui.Devices.Sensors.GeolocationRequest(request.DesiredAccuracy.EnumParse<Microsoft.Maui.Devices.Sensors.GeolocationAccuracy>(), request.Timeout), cancelToken);

            Location location = new(locationOrg.Latitude, locationOrg.Longitude, locationOrg.Timestamp)
            {
                Altitude = locationOrg.Altitude,
                Course = locationOrg.Course,
                Speed = locationOrg.Speed,
                ReducedAccuracy = locationOrg.ReducedAccuracy,
                VerticalAccuracy = locationOrg.VerticalAccuracy,
                Accuracy = locationOrg.Accuracy,
                IsFromMockProvider = locationOrg.IsFromMockProvider,
                AltitudeReferenceSystem = locationOrg.AltitudeReferenceSystem.EnumParse<AltitudeReferenceSystem>()
            };

            return location;
        }
    }
}