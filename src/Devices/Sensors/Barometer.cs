using MetaFrm.Extensions;

namespace MetaFrm.Maui.Devices.Sensors
{
    /// <summary>
    /// Maui Essentials Device
    /// </summary>
    public class Barometer : IBarometer
    {
        private BarometerChanged BarometerChanged;

        /// <summary>
        /// BarometerChangedEvent
        /// </summary>
        public event BarometerChanged BarometerChangedEvent
        {
            add
            {
                this.BarometerChanged += value;

                try
                {
                    try
                    {
                        Microsoft.Maui.Devices.Sensors.Barometer.Default.ReadingChanged -= Barometer_ReadingChanged;
                    }
                    catch (Exception)
                    {
                    }
                    Microsoft.Maui.Devices.Sensors.Barometer.Default.ReadingChanged += Barometer_ReadingChanged;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    Microsoft.Maui.Devices.Sensors.Barometer.ReadingChanged -= Barometer_ReadingChanged;
                }
                catch (Exception)
                {
                }

                this.BarometerChanged -= value;
            }
        }

        private void Barometer_ReadingChanged(object sender, Microsoft.Maui.Devices.Sensors.BarometerChangedEventArgs e) => this.BarometerChanged?.Invoke(sender, new BarometerChangedEventArgs(new BarometerData(e.Reading.PressureInHectopascals)));

        /// <summary>
        /// BarometerIsSupported
        /// </summary>
        public bool IsSupported => Microsoft.Maui.Devices.Sensors.Barometer.Default.IsSupported;

        /// <summary>
        /// BarometerIsMonitoring
        /// </summary>
        public bool IsMonitoring => Microsoft.Maui.Devices.Sensors.Barometer.Default.IsMonitoring;

        /// <summary>
        /// BarometerStart
        /// </summary>
        /// <param name="sensorSpeed"></param>
        public void BarometerStart(SensorSpeed sensorSpeed) => Microsoft.Maui.Devices.Sensors.Barometer.Default.Start(sensorSpeed.EnumParse<Microsoft.Maui.Devices.Sensors.SensorSpeed>());

        /// <summary>
        /// BarometerStop
        /// </summary>
        public void BarometerStop() => Microsoft.Maui.Devices.Sensors.Barometer.Default.Stop();
    }
}