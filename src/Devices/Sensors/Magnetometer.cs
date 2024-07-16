using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.Devices.Sensors
{
    /// <summary>
    /// Maui Essentials Device
    /// </summary>
    public class Magnetometer : Maui.Devices.Sensors.IMagnetometer
    {
        private Maui.Devices.Sensors.MagnetometerChanged? MagnetometerChanged;

        /// <summary>
        /// MagnetometerChangedEvent
        /// </summary>
        public event Maui.Devices.Sensors.MagnetometerChanged MagnetometerChangedEvent
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

        private void Magnetometer_ReadingChanged(object? sender, MagnetometerChangedEventArgs e) => this.MagnetometerChanged?.Invoke(sender, new Maui.Devices.Sensors.MagnetometerChangedEventArgs(new Maui.Devices.Sensors.MagnetometerData(e.Reading.MagneticField.X, e.Reading.MagneticField.Y, e.Reading.MagneticField.Z)));

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
        public void MagnetometerStart(Maui.Devices.Sensors.SensorSpeed sensorSpeed) => Microsoft.Maui.Devices.Sensors.Magnetometer.Default.Start(sensorSpeed.EnumParse<SensorSpeed>());

        /// <summary>
        /// MagnetometerStop
        /// </summary>
        public void MagnetometerStop() => Microsoft.Maui.Devices.Sensors.Magnetometer.Default.Stop();
    }
}