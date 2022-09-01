using MetaFrm.Extensions;

namespace MetaFrm.Maui.Devices.Sensors
{
    /// <summary>
    /// Maui Essentials Device
    /// </summary>
    public class Magnetometer : IMagnetometer
    {
        private MagnetometerChanged MagnetometerChanged;

        /// <summary>
        /// MagnetometerChangedEvent
        /// </summary>
        public event MagnetometerChanged MagnetometerChangedEvent
        {
            add
            {
                this.MagnetometerChanged += value;

                try
                {
                    try
                    {
                        Microsoft.Maui.Devices.Sensors.Magnetometer.Default.ReadingChanged -= Magnetometer_ReadingChanged;
                    }
                    catch (Exception)
                    {
                    }
                    Microsoft.Maui.Devices.Sensors.Magnetometer.Default.ReadingChanged += Magnetometer_ReadingChanged;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    Microsoft.Maui.Devices.Sensors.Magnetometer.ReadingChanged -= Magnetometer_ReadingChanged;
                }
                catch (Exception)
                {
                }

                this.MagnetometerChanged -= value;
            }
        }

        private void Magnetometer_ReadingChanged(object sender, Microsoft.Maui.Devices.Sensors.MagnetometerChangedEventArgs e) => this.MagnetometerChanged?.Invoke(sender, new MagnetometerChangedEventArgs(new MagnetometerData(e.Reading.MagneticField.X, e.Reading.MagneticField.Y, e.Reading.MagneticField.Z)));

        /// <summary>
        /// MagnetometerIsSupported
        /// </summary>
        public bool IsSupported => Microsoft.Maui.Devices.Sensors.Magnetometer.Default.IsSupported;

        /// <summary>
        /// MagnetometerIsMonitoring
        /// </summary>
        public bool IsMonitoring => Microsoft.Maui.Devices.Sensors.Magnetometer.Default.IsMonitoring;

        /// <summary>
        /// MagnetometerStart
        /// </summary>
        /// <param name="sensorSpeed"></param>
        public void MagnetometerStart(SensorSpeed sensorSpeed) => Microsoft.Maui.Devices.Sensors.Magnetometer.Default.Start(sensorSpeed.EnumParse<Microsoft.Maui.Devices.Sensors.SensorSpeed>());

        /// <summary>
        /// MagnetometerStop
        /// </summary>
        public void MagnetometerStop() => Microsoft.Maui.Devices.Sensors.Magnetometer.Default.Stop();
    }
}