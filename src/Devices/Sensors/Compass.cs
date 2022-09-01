using MetaFrm.Extensions;

namespace MetaFrm.Maui.Devices.Sensors
{
    /// <summary>
    /// Compass
    /// </summary>
    public class Compass : ICompass
    {
        private CompassChanged CompassChanged;

        /// <summary>
        /// CompassChangedEvent
        /// </summary>
        public event CompassChanged CompassChangedEvent
        {
            add
            {
                this.CompassChanged += value;

                try
                {
                    try
                    {
                        Microsoft.Maui.Devices.Sensors.Compass.Default.ReadingChanged -= Compass_ReadingChanged;
                    }
                    catch (Exception)
                    {
                    }
                    Microsoft.Maui.Devices.Sensors.Compass.Default.ReadingChanged += Compass_ReadingChanged;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    Microsoft.Maui.Devices.Sensors.Compass.ReadingChanged -= Compass_ReadingChanged;
                }
                catch (Exception)
                {
                }

                this.CompassChanged -= value;
            }
        }

        private void Compass_ReadingChanged(object sender, Microsoft.Maui.Devices.Sensors.CompassChangedEventArgs e) => this.CompassChanged?.Invoke(sender, new CompassChangedEventArgs(new CompassData(e.Reading.HeadingMagneticNorth)));

        /// <summary>
        /// CompassIsSupported
        /// </summary>
        public bool IsSupported => Microsoft.Maui.Devices.Sensors.Compass.Default.IsSupported;

        /// <summary>
        /// CompassIsMonitoring
        /// </summary>
        public bool IsMonitoring => Microsoft.Maui.Devices.Sensors.Compass.Default.IsMonitoring;

        /// <summary>
        /// CompassStart
        /// </summary>
        /// <param name="sensorSpeed"></param>
        public void CompassStart(SensorSpeed sensorSpeed) => Microsoft.Maui.Devices.Sensors.Compass.Default.Start(sensorSpeed.EnumParse<Microsoft.Maui.Devices.Sensors.SensorSpeed>());

        /// <summary>
        /// CompassStop
        /// </summary>
        public void CompassStop() => Microsoft.Maui.Devices.Sensors.Compass.Default.Stop();
    }
}