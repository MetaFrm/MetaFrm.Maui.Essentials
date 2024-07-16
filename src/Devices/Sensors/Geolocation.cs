using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.Devices.Sensors
{
    /// <summary>
    /// Geolocation
    /// </summary>
    public class Geolocation : Maui.Devices.Sensors.IGeolocation
    {
        /// <summary>
        /// GetLastKnownLocationAsync
        /// </summary>
        /// <returns></returns>
        public async Task<Maui.Devices.Sensors.Location?> GetLastKnownLocationAsync()
        {
            Location? locationOrg = await Microsoft.Maui.Devices.Sensors.Geolocation.Default.GetLastKnownLocationAsync();

            if (locationOrg != null)
                return new(locationOrg.Latitude, locationOrg.Longitude, locationOrg.Timestamp)
                {
                    Altitude = locationOrg.Altitude,
                    Course = locationOrg.Course,
                    Speed = locationOrg.Speed,
                    ReducedAccuracy = locationOrg.ReducedAccuracy,
                    VerticalAccuracy = locationOrg.VerticalAccuracy,
                    Accuracy = locationOrg.Accuracy,
                    IsFromMockProvider = locationOrg.IsFromMockProvider,
                    AltitudeReferenceSystem = locationOrg.AltitudeReferenceSystem.EnumParse<Maui.Devices.Sensors.AltitudeReferenceSystem>()
                };

            return null;
        }

        /// <summary>
        /// GetLocationAsync
        /// </summary>
        /// <returns></returns>
        public async Task<Maui.Devices.Sensors.Location?> GetLocationAsync()
        {
            Location? locationOrg = await Microsoft.Maui.Devices.Sensors.Geolocation.Default.GetLocationAsync();

            if (locationOrg != null)
                return new(locationOrg.Latitude, locationOrg.Longitude, locationOrg.Timestamp)
                {
                    Altitude = locationOrg.Altitude,
                    Course = locationOrg.Course,
                    Speed = locationOrg.Speed,
                    ReducedAccuracy = locationOrg.ReducedAccuracy,
                    VerticalAccuracy = locationOrg.VerticalAccuracy,
                    Accuracy = locationOrg.Accuracy,
                    IsFromMockProvider = locationOrg.IsFromMockProvider,
                    AltitudeReferenceSystem = locationOrg.AltitudeReferenceSystem.EnumParse<Maui.Devices.Sensors.AltitudeReferenceSystem>()
                };

            return null;
        }

        /// <summary>
        /// GetLocationAsync
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Maui.Devices.Sensors.Location?> GetLocationAsync(Maui.Devices.Sensors.GeolocationRequest request)
        {
            Location? locationOrg = await Microsoft.Maui.Devices.Sensors.Geolocation.Default.GetLocationAsync(new GeolocationRequest(request.DesiredAccuracy.EnumParse<GeolocationAccuracy>(), request.Timeout));

            if (locationOrg != null)
                return new(locationOrg.Latitude, locationOrg.Longitude, locationOrg.Timestamp)
                {
                    Altitude = locationOrg.Altitude,
                    Course = locationOrg.Course,
                    Speed = locationOrg.Speed,
                    ReducedAccuracy = locationOrg.ReducedAccuracy,
                    VerticalAccuracy = locationOrg.VerticalAccuracy,
                    Accuracy = locationOrg.Accuracy,
                    IsFromMockProvider = locationOrg.IsFromMockProvider,
                    AltitudeReferenceSystem = locationOrg.AltitudeReferenceSystem.EnumParse<Maui.Devices.Sensors.AltitudeReferenceSystem>()
                };

            return null;
        }

        /// <summary>
        /// GetLocationAsync
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancelToken"></param>
        /// <returns></returns>
        public async Task<Maui.Devices.Sensors.Location?> GetLocationAsync(Maui.Devices.Sensors.GeolocationRequest request, CancellationToken cancelToken)
        {
            Location? locationOrg = await Microsoft.Maui.Devices.Sensors.Geolocation.Default.GetLocationAsync(new GeolocationRequest(request.DesiredAccuracy.EnumParse<GeolocationAccuracy>(), request.Timeout), cancelToken);

            if (locationOrg != null)
                return new(locationOrg.Latitude, locationOrg.Longitude, locationOrg.Timestamp)
                {
                    Altitude = locationOrg.Altitude,
                    Course = locationOrg.Course,
                    Speed = locationOrg.Speed,
                    ReducedAccuracy = locationOrg.ReducedAccuracy,
                    VerticalAccuracy = locationOrg.VerticalAccuracy,
                    Accuracy = locationOrg.Accuracy,
                    IsFromMockProvider = locationOrg.IsFromMockProvider,
                    AltitudeReferenceSystem = locationOrg.AltitudeReferenceSystem.EnumParse<Maui.Devices.Sensors.AltitudeReferenceSystem>()
                };

            return null;
        }
    }
}