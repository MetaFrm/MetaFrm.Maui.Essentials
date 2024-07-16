using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.Devices.Sensors
{
    /// <summary>
    /// Maui Essentials Device
    /// </summary>
    public class Barometer : Maui.Devices.Sensors.IBarometer
    {
        private Maui.Devices.Sensors.BarometerChanged? BarometerChanged;

        /// <summary>
        /// BarometerChangedEvent
        /// </summary>
        public event Maui.Devices.Sensors.BarometerChanged BarometerChangedEvent
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

        private void Barometer_ReadingChanged(object? sender, BarometerChangedEventArgs e) => this.BarometerChanged?.Invoke(sender, new Maui.Devices.Sensors.BarometerChangedEventArgs(new Maui.Devices.Sensors.BarometerData(e.Reading.PressureInHectopascals)));

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
        public void BarometerStart(Maui.Devices.Sensors.SensorSpeed sensorSpeed) => Microsoft.Maui.Devices.Sensors.Barometer.Default.Start(sensorSpeed.EnumParse<SensorSpeed>());

        /// <summary>
        /// BarometerStop
        /// </summary>
        public void BarometerStop() => Microsoft.Maui.Devices.Sensors.Barometer.Default.Stop();
    }
}