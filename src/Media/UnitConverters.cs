namespace MetaFrm.Maui.Media
{
    /// <summary>
    /// UnitConverters
    /// </summary>
    public class UnitConverters : IUnitConverters
    {
        /// <summary>
        /// Atmospheres to Pascals
        /// </summary>
        /// <param name="atm">Atmospheres to convert</param>
        /// <returns>The pascals value</returns>
        /// <remarks>To be added.</remarks>
        public double AtmospheresToPascals(double atm) { return Microsoft.Maui.Media.UnitConverters.AtmospheresToPascals(atm); }

        /// <summary>
        /// Celsius to Fahrenheit
        /// </summary>
        /// <param name="celsius">The temperature in celsius to convert</param>
        /// <returns>The temperature in fahrenheit</returns>
        /// <remarks>To be added.</remarks>
        public double CelsiusToFahrenheit(double celsius) { return Microsoft.Maui.Media.UnitConverters.CelsiusToFahrenheit(celsius); }

        /// <summary>
        /// Celsius to Kelvin
        /// </summary>
        /// <param name="celsius">The temperature in Celsius to convert</param>
        /// <returns>The temperature in Kelvin</returns>
        /// <remarks>To be added.</remarks>
        public double CelsiusToKelvin(double celsius) { return Microsoft.Maui.Media.UnitConverters.CelsiusToKelvin(celsius); }

        /// <summary>
        /// Calulate the distance between two coordinate in kilometers
        /// </summary>
        /// <param name="lat1">First latitude</param>
        /// <param name="lon1">First longitude</param>
        /// <param name="lat2">Second latitude</param>
        /// <param name="lon2">Second longitude</param>
        /// <returns>Distance in kilometers</returns>
        /// <remarks>To be added.</remarks>
        public double CoordinatesToKilometers(double lat1, double lon1, double lat2, double lon2) { return Microsoft.Maui.Media.UnitConverters.CoordinatesToKilometers(lat1, lon1, lat2, lon2); }

        /// <summary>
        /// Calulate the distance between two coordinate in miles
        /// </summary>
        /// <param name="lat1">First latitude</param>
        /// <param name="lon1">First longitude</param>
        /// <param name="lat2">Second latitude</param>
        /// <param name="lon2">Second longitude</param>
        /// <returns>Distance in miles</returns>
        /// <remarks>To be added.</remarks>
        public double CoordinatesToMiles(double lat1, double lon1, double lat2, double lon2) { return Microsoft.Maui.Media.UnitConverters.CoordinatesToMiles(lat1, lon1, lat2, lon2); }

        /// <summary>
        /// Converte degrees per second to hertz
        /// </summary>
        /// <param name="degrees">The degrees to convert</param>
        /// <returns>Value in hertz</returns>
        /// <remarks>To be added.</remarks>
        public double DegreesPerSecondToHertz(double degrees) { return Microsoft.Maui.Media.UnitConverters.DegreesPerSecondToHertz(degrees); }

        /// <summary>
        /// Convert degrees per second to radians per second
        /// </summary>
        /// <param name="degrees">Degrees to convert</param>
        /// <returns>Value in radians</returns>
        /// <remarks>To be added.</remarks>
        public double DegreesPerSecondToRadiansPerSecond(double degrees) { return Microsoft.Maui.Media.UnitConverters.DegreesPerSecondToRadiansPerSecond(degrees); }

        /// <summary>
        /// Convert degrees to radian
        /// </summary>
        /// <param name="degrees">Degrees to convert</param>
        /// <returns>The value in radians</returns>
        /// <remarks>To be added.</remarks>
        public double DegreesToRadians(double degrees) { return Microsoft.Maui.Media.UnitConverters.DegreesToRadians(degrees); }

        /// <summary>
        /// Converter fahrenheit to celsius
        /// </summary>
        /// <param name="fahrenheit">The value in fahrenheit to convert</param>
        /// <returns>The value in celsius</returns>
        /// <remarks>To be added.</remarks>
        public double FahrenheitToCelsius(double fahrenheit) { return Microsoft.Maui.Media.UnitConverters.FahrenheitToCelsius(fahrenheit); }

        /// <summary>
        /// Convert hectopascals to kilopascals
        /// </summary>
        /// <param name="hpa">Hectopascals to convert</param>
        /// <returns>The value in kilopascals</returns>
        /// <remarks>To be added.</remarks>
        public double HectopascalsToKilopascals(double hpa) { return Microsoft.Maui.Media.UnitConverters.HectopascalsToKilopascals(hpa); }

        /// <summary>
        /// Convert hectopascals to pascals
        /// </summary>
        /// <param name="hpa">The value to convert in Hectopascals</param>
        /// <returns>The value in pascals</returns>
        /// <remarks>To be added.</remarks>
        public double HectopascalsToPascals(double hpa) { return Microsoft.Maui.Media.UnitConverters.HectopascalsToPascals(hpa); }

        /// <summary>
        /// Convert hertz to degrees per second
        /// </summary>
        /// <param name="hertz">The value in hertz to convert</param>
        /// <returns>The value in degrees per second</returns>
        /// <remarks>To be added.</remarks>
        public double HertzToDegreesPerSecond(double hertz) { return Microsoft.Maui.Media.UnitConverters.HertzToDegreesPerSecond(hertz); }

        /// <summary>
        /// Convert hertz to radians per second
        /// </summary>
        /// <param name="hertz">The value in hertz to convert</param>
        /// <returns>The value in radians per second</returns>
        /// <remarks>To be added.</remarks>
        public double HertzToRadiansPerSecond(double hertz) { return Microsoft.Maui.Media.UnitConverters.HertzToRadiansPerSecond(hertz); }

        /// <summary>
        /// International survey foot defined as exactly 0.3048 meters by convention in 1959.
        /// This is the most common modern foot measure.
        /// </summary>
        /// <param name="internationalFeet"></param>
        /// <returns></returns>
        public double InternationalFeetToMeters(double internationalFeet) { return Microsoft.Maui.Media.UnitConverters.InternationalFeetToMeters(internationalFeet); }

        /// <summary>
        /// Convert kelvin to celsius
        /// </summary>
        /// <param name="kelvin">The kelvin value to convert</param>
        /// <returns>The value in celsius</returns>
        /// <remarks>To be added.</remarks>
        public double KelvinToCelsius(double kelvin) { return Microsoft.Maui.Media.UnitConverters.KelvinToCelsius(kelvin); }

        /// <summary>
        /// Convert kilograms to pounds
        /// </summary>
        /// <param name="kilograms">The value in kilograms to convert</param>
        /// <returns>The value in pounds.</returns>
        /// <remarks>To be added.</remarks>
        public double KilogramsToPounds(double kilograms) { return Microsoft.Maui.Media.UnitConverters.KilogramsToPounds(kilograms); }

        /// <summary>
        /// Convert kilometers to miles
        /// </summary>
        /// <param name="kilometers">The kilometers to convert</param>
        /// <returns>The value in miles.</returns>
        /// <remarks>To be added.</remarks>
        public double KilometersToMiles(double kilometers) { return Microsoft.Maui.Media.UnitConverters.KilometersToMiles(kilometers); }

        /// <summary>
        /// Convert kilopascals to hectopascals
        /// </summary>
        /// <param name="kpa">The value in kilopascals to convert</param>
        /// <returns>The value in hectopascals</returns>
        /// <remarks>To be added.</remarks>
        public double KilopascalsToHectopascals(double kpa) { return Microsoft.Maui.Media.UnitConverters.KilopascalsToHectopascals(kpa); }

        /// <summary>
        /// Convert kilopascals to pascals
        /// </summary>
        /// <param name="kpa">The value in kilopascals to convert</param>
        /// <returns>The value in pascals</returns>
        /// <remarks>To be added.</remarks>
        public double KilopascalsToPascals(double kpa) { return Microsoft.Maui.Media.UnitConverters.KilopascalsToPascals(kpa); }

        /// <summary>
        /// International survey foot defined as exactly 0.3048 meters by convention in 1959.
        /// This is the most common modern foot measure.
        /// </summary>
        /// <param name="meters"></param>
        /// <returns></returns>
        public double MetersToInternationalFeet(double meters) { return Microsoft.Maui.Media.UnitConverters.MetersToInternationalFeet(meters); }

        /// <summary>
        /// Exactly 1200/3937 meters by definition. In decimal terms approximately 0.304
        /// 800 609 601 219 meters. Variation from the common international foot of exactly
        /// 0.3048 meters may only be considerable over large survey distances.
        /// </summary>
        /// <param name="meters"></param>
        /// <returns></returns>
        public double MetersToUSSurveyFeet(double meters) { return Microsoft.Maui.Media.UnitConverters.MetersToUSSurveyFeet(meters); }

        /// <summary>
        /// Convert miles to kilometers
        /// </summary>
        /// <param name="miles">The value in miles to convert</param>
        /// <returns>The value in kilometers</returns>
        /// <remarks>To be added.</remarks>
        public double MilesToKilometers(double miles) { return Microsoft.Maui.Media.UnitConverters.MilesToKilometers(miles); }

        /// <summary>
        /// Convert miles to meters
        /// </summary>
        /// <param name="miles">The value in miles to convert</param>
        /// <returns>The value in meters</returns>
        /// <remarks>To be added.</remarks>
        public double MilesToMeters(double miles) { return Microsoft.Maui.Media.UnitConverters.MilesToMeters(miles); }

        /// <summary>
        /// Convert pascals to atmospheres
        /// </summary>
        /// <param name="pascals">The value in pascals to convert</param>
        /// <returns>The value in atmospheres</returns>
        /// <remarks>To be added.</remarks>
        public double PascalsToAtmospheres(double pascals) { return Microsoft.Maui.Media.UnitConverters.PascalsToAtmospheres(pascals); }

        /// <summary>
        /// Convert pounds to kilograms
        /// </summary>
        /// <param name="pounds">The value in pounds to convert</param>
        /// <returns>The value in kilograms</returns>
        /// <remarks>To be added.</remarks>
        public double PoundsToKilograms(double pounds) { return Microsoft.Maui.Media.UnitConverters.PoundsToKilograms(pounds); }

        /// <summary>
        /// Convert pounds to stones
        /// </summary>
        /// <param name="pounds">The value in pounds to convert</param>
        /// <returns>The value in stones</returns>
        /// <remarks>To be added.</remarks>
        public double PoundsToStones(double pounds) { return Microsoft.Maui.Media.UnitConverters.PoundsToStones(pounds); }

        /// <summary>
        /// Convert radians per second to degrees per second
        /// </summary>
        /// <param name="radians">The value of radians per second to convert</param>
        /// <returns>The value in degrees per second</returns>
        /// <remarks>To be added.</remarks>
        public double RadiansPerSecondToDegreesPerSecond(double radians) { return Microsoft.Maui.Media.UnitConverters.RadiansPerSecondToDegreesPerSecond(radians); }

        /// <summary>
        /// Convert radians per second to hertz
        /// </summary>
        /// <param name="radians">The value of radians per second to convert</param>
        /// <returns>The value in hertz</returns>
        /// <remarks>To be added.</remarks>
        public double RadiansPerSecondToHertz(double radians) { return Microsoft.Maui.Media.UnitConverters.RadiansPerSecondToHertz(radians); }

        /// <summary>
        /// Convert radians to degrees
        /// </summary>
        /// <param name="radians">The value in radians to convert</param>
        /// <returns>The value in degrees</returns>
        /// <remarks>To be added.</remarks>
        public double RadiansToDegrees(double radians) { return Microsoft.Maui.Media.UnitConverters.RadiansToDegrees(radians); }

        /// <summary>
        /// Convert stones to pounds
        /// </summary>
        /// <param name="stones">The value in stones to convert</param>
        /// <returns>The value in pounds</returns>
        /// <remarks>To be added.</remarks>
        public double StonesToPounds(double stones) { return Microsoft.Maui.Media.UnitConverters.StonesToPounds(stones); }

        /// <summary>
        /// Exactly 1200/3937 meters by definition. In decimal terms approximately 0.304
        /// 800 609 601 219 meters. Variation from the common international foot of exactly
        /// 0.3048 meters may only be considerable over large survey distances.
        /// </summary>
        /// <param name="usFeet"></param>
        /// <returns></returns>
        public double USSurveyFeetToMeters(double usFeet) { return Microsoft.Maui.Media.UnitConverters.USSurveyFeetToMeters(usFeet); }
    }
}