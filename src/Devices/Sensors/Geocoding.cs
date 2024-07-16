using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.Devices.Sensors
{
    /// <summary>
    /// Geocoding
    /// </summary>
    public class Geocoding : Maui.Devices.Sensors.IGeocoding
    {
        /// <summary>
        /// GetLocationsAsync
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Maui.Devices.Sensors.Location>> GetLocationsAsync(string address)
        {
            List<Maui.Devices.Sensors.Location> locationsList = new();
            IEnumerable<Location> locations = await Microsoft.Maui.Devices.Sensors.Geocoding.Default.GetLocationsAsync(address);

            foreach (Location locationOrg in locations)
            {
                Maui.Devices.Sensors.Location location1 = new(locationOrg.Latitude, locationOrg.Longitude, locationOrg.Timestamp)
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
        public async Task<IEnumerable<Maui.Devices.Sensors.Placemark>> GetPlacemarksAsync(double latitude, double longitude)
        {
            List<Maui.Devices.Sensors.Placemark> placemark = new();
            IEnumerable<Placemark> placemarks = await Microsoft.Maui.Devices.Sensors.Geocoding.Default.GetPlacemarksAsync(latitude, longitude);

            foreach (Placemark placemarkOrg in placemarks)
            {
                Maui.Devices.Sensors.Placemark placemark1 = new()
                {
                    Location = new Maui.Devices.Sensors.Location(placemarkOrg.Location.Latitude, placemarkOrg.Location.Longitude, placemarkOrg.Location.Timestamp)
                    {
                        Altitude = placemarkOrg.Location.Altitude,
                        Course = placemarkOrg.Location.Course,
                        Speed = placemarkOrg.Location.Speed,
                        ReducedAccuracy = placemarkOrg.Location.ReducedAccuracy,
                        VerticalAccuracy = placemarkOrg.Location.VerticalAccuracy,
                        Accuracy = placemarkOrg.Location.Accuracy,
                        IsFromMockProvider = placemarkOrg.Location.IsFromMockProvider,
                        AltitudeReferenceSystem = placemarkOrg.Location.AltitudeReferenceSystem.EnumParse<Maui.Devices.Sensors.AltitudeReferenceSystem>()
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
        public double CalculateDistance(double latitudeStart, double longitudeStart, double latitudeEnd, double longitudeEnd, Maui.Devices.Sensors.DistanceUnits units) => Location.CalculateDistance(latitudeStart, longitudeStart, latitudeEnd, longitudeEnd, units.EnumParse<DistanceUnits>());

        /// <summary>
        /// Calculate distance between two locations.
        /// </summary>
        /// <param name="locationStart">Start location to calculate from.</param>
        /// <param name="locationEnd">End location to calculate from.</param>
        /// <param name="units">Units to return.</param>
        /// <returns>Distance between two locations in the unit selected.</returns>
        public double CalculateDistance(Maui.Devices.Sensors.Location locationStart, Maui.Devices.Sensors.Location locationEnd, Maui.Devices.Sensors.DistanceUnits units) => Location.CalculateDistance(new Location(locationStart.Latitude, locationStart.Longitude, locationStart.Timestamp)
                                                        , new Location(locationEnd.Latitude, locationEnd.Longitude, locationEnd.Timestamp)
                                                        , units.EnumParse<DistanceUnits>());

        /// <summary>
        /// Calculate distance between two locations.
        /// </summary>
        /// <param name="locationStart">Start location to calculate from.</param>
        /// <param name="latitudeEnd">End latitude to calculate from.</param>
        /// <param name="longitudeEnd">End longitude to calculate from.</param>
        /// <param name="units">Unit to use.</param>
        /// <returns>Distance calculated.</returns>
        public double CalculateDistance(Maui.Devices.Sensors.Location locationStart, double latitudeEnd, double longitudeEnd, Maui.Devices.Sensors.DistanceUnits units) => Location.CalculateDistance(new Location(locationStart.Latitude, locationStart.Longitude, locationStart.Timestamp)
                                                        , latitudeEnd, longitudeEnd
                                                        , units.EnumParse<DistanceUnits>());

        /// <summary>
        /// Calculate distance between two locations.
        /// </summary>
        /// <param name="latitudeStart">Start latitude to calculate from.</param>
        /// <param name="longitudeStart">Start longitude to calculate from.</param>
        /// <param name="locationEnd">End location to calculate from.</param>
        /// <param name="units">Unit to return.</param>
        /// <returns>Distance calculated.</returns>
        public double CalculateDistance(double latitudeStart, double longitudeStart, Maui.Devices.Sensors.Location locationEnd, Maui.Devices.Sensors.DistanceUnits units)=> Location.CalculateDistance(latitudeStart, longitudeStart
                                            , new Location(locationEnd.Latitude, locationEnd.Longitude, locationEnd.Timestamp)
                                            , units.EnumParse<DistanceUnits>());
    }
}