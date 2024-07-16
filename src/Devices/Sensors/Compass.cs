using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.Devices.Sensors
{
    /// <summary>
    /// Compass
    /// </summary>
    public class Compass : Maui.Devices.Sensors.ICompass
    {
        private Maui.Devices.Sensors.CompassChanged? CompassChanged;

        /// <summary>
        /// CompassChangedEvent
        /// </summary>
        public event Maui.Devices.Sensors.CompassChanged CompassChangedEvent
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

        private void Compass_ReadingChanged(object? sender, CompassChangedEventArgs e) => this.CompassChanged?.Invoke(sender, new Maui.Devices.Sensors.CompassChangedEventArgs(new Maui.Devices.Sensors.CompassData(e.Reading.HeadingMagneticNorth)));

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
        public void CompassStart(Maui.Devices.Sensors.SensorSpeed sensorSpeed) => Microsoft.Maui.Devices.Sensors.Compass.Default.Start(sensorSpeed.EnumParse<SensorSpeed>());

        /// <summary>
        /// CompassStop
        /// </summary>
        public void CompassStop() => Microsoft.Maui.Devices.Sensors.Compass.Default.Stop();
    }
}