using MetaFrm.Extensions;

namespace MetaFrm.Maui.Devices.Sensors
{
    /// <summary>
    /// Geocoding
    /// </summary>
    public class Geocoding : IGeocoding
    {
        /// <summary>
        /// GetLocationsAsync
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Location>> GetLocationsAsync(string address)
        {
            IList<Location> locationsList = new List<Location>();
            IEnumerable<Microsoft.Maui.Devices.Sensors.Location> locations = await Microsoft.Maui.Devices.Sensors.Geocoding.Default.GetLocationsAsync(address);

            foreach (Microsoft.Maui.Devices.Sensors.Location locationOrg in locations)
            {
                Location location1 = new(locationOrg.Latitude, locationOrg.Longitude, locationOrg.Timestamp)
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
                locationsList.Add(location1);
            }

            return locationsList;
        }

        /// <summary>
        /// GetPlacemarksAsync
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Placemark>> GetPlacemarksAsync(double latitude, double longitude)
        {
            IList<Placemark> placemark = new List<Placemark>();
            IEnumerable<Microsoft.Maui.Devices.Sensors.Placemark> placemarks = await Microsoft.Maui.Devices.Sensors.Geocoding.Default.GetPlacemarksAsync(latitude, longitude);

            foreach (Microsoft.Maui.Devices.Sensors.Placemark placemarkOrg in placemarks)
            {
                Placemark placemark1 = new()
                {
                    Location = new Location(placemarkOrg.Location.Latitude, placemarkOrg.Location.Longitude, placemarkOrg.Location.Timestamp)
                    {
                        Altitude = placemarkOrg.Location.Altitude,
                        Course = placemarkOrg.Location.Course,
                        Speed = placemarkOrg.Location.Speed,
                        ReducedAccuracy = placemarkOrg.Location.ReducedAccuracy,
                        VerticalAccuracy = placemarkOrg.Location.VerticalAccuracy,
                        Accuracy = placemarkOrg.Location.Accuracy,
                        IsFromMockProvider = placemarkOrg.Location.IsFromMockProvider,
                        AltitudeReferenceSystem = placemarkOrg.Location.AltitudeReferenceSystem.EnumParse<AltitudeReferenceSystem>()
                    },
                    CountryCode = placemarkOrg.CountryCode,
                    CountryName = placemarkOrg.CountryName,
                    FeatureName = placemarkOrg.FeatureName,
                    PostalCode = placemarkOrg.PostalCode,
                    SubLocality = placemarkOrg.SubLocality,
                    Thoroughfare = placemarkOrg.Thoroughfare,
                    SubThoroughfare = placemarkOrg.SubThoroughfare,
                    Locality = placemarkOrg.Locality,
                    AdminArea = placemarkOrg.AdminArea,
                    SubAdminArea = placemarkOrg.SubAdminArea,
                };

                placemark.Add(placemark1);
            }

            return placemark;
        }

        /// <summary>
        /// Calculate distance between two locations.
        /// </summary>
        /// <param name="latitudeStart">Start latitude to calculate from.</param>
        /// <param name="longitudeStart">Start longitude to calculate from.</param>
        /// <param name="latitudeEnd">End latitude to calculate from.</param>
        /// <param name="longitudeEnd">End longitude to calculate from.</param>
        /// <param name="units">Units to return.</param>
        /// <returns>Distance between two locations in the unit selected.</returns>
        public double CalculateDistance(double latitudeStart, double longitudeStart, double latitudeEnd, double longitudeEnd, DistanceUnits units) => Microsoft.Maui.Devices.Sensors.Location.CalculateDistance(latitudeStart, longitudeStart, latitudeEnd, longitudeEnd, units.EnumParse<Microsoft.Maui.Devices.Sensors.DistanceUnits>());

        /// <summary>
        /// Calculate distance between two locations.
        /// </summary>
        /// <param name="locationStart">Start location to calculate from.</param>
        /// <param name="locationEnd">End location to calculate from.</param>
        /// <param name="units">Units to return.</param>
        /// <returns>Distance between two locations in the unit selected.</returns>
        public double CalculateDistance(Location locationStart, Location locationEnd, DistanceUnits units) => Microsoft.Maui.Devices.Sensors.Location.CalculateDistance(new Microsoft.Maui.Devices.Sensors.Location(locationStart.Latitude, locationStart.Longitude, locationStart.Timestamp)
                                                        , new Microsoft.Maui.Devices.Sensors.Location(locationEnd.Latitude, locationEnd.Longitude, locationEnd.Timestamp)
                                                        , units.EnumParse<Microsoft.Maui.Devices.Sensors.DistanceUnits>());

        /// <summary>
        /// Calculate distance between two locations.
        /// </summary>
        /// <param name="locationStart">Start location to calculate from.</param>
        /// <param name="latitudeEnd">End latitude to calculate from.</param>
        /// <param name="longitudeEnd">End longitude to calculate from.</param>
        /// <param name="units">Unit to use.</param>
        /// <returns>Distance calculated.</returns>
        public double CalculateDistance(Location locationStart, double latitudeEnd, double longitudeEnd, DistanceUnits units) => Microsoft.Maui.Devices.Sensors.Location.CalculateDistance(new Microsoft.Maui.Devices.Sensors.Location(locationStart.Latitude, locationStart.Longitude, locationStart.Timestamp)
                                                        , latitudeEnd, longitudeEnd
                                                        , units.EnumParse<Microsoft.Maui.Devices.Sensors.DistanceUnits>());

        /// <summary>
        /// Calculate distance between two locations.
        /// </summary>
        /// <param name="latitudeStart">Start latitude to calculate from.</param>
        /// <param name="longitudeStart">Start longitude to calculate from.</param>
        /// <param name="locationEnd">End location to calculate from.</param>
        /// <param name="units">Unit to return.</param>
        /// <returns>Distance calculated.</returns>
        public double CalculateDistance(double latitudeStart, double longitudeStart, Location locationEnd, DistanceUnits units)=> Microsoft.Maui.Devices.Sensors.Location.CalculateDistance(latitudeStart, longitudeStart
                                            , new Microsoft.Maui.Devices.Sensors.Location(locationEnd.Latitude, locationEnd.Longitude, locationEnd.Timestamp)
                                            , units.EnumParse<Microsoft.Maui.Devices.Sensors.DistanceUnits>());
    }
}