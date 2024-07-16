using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.Devices.Sensors
{
    /// <summary>
    /// Gyroscope
    /// </summary>
    public class Gyroscope : Maui.Devices.Sensors.IGyroscope
    {
        private Maui.Devices.Sensors.GyroscopeChanged? GyroscopeChanged;

        /// <summary>
        /// GyroscopeChangedEvent
        /// </summary>
        public event Maui.Devices.Sensors.GyroscopeChanged GyroscopeChangedEvent
        {
            add
            {
                this.GyroscopeChanged += value;

                try
                {
                    try
                    {
                        Microsoft.Maui.Devices.Sensors.Gyroscope.Default.ReadingChanged -= Gyroscope_ReadingChanged;
                    }
                    catch (Exception)
                    {
                    }
                    Microsoft.Maui.Devices.Sensors.Gyroscope.Default.ReadingChanged += Gyroscope_ReadingChanged;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    Microsoft.Maui.Devices.Sensors.Gyroscope.ReadingChanged -= Gyroscope_ReadingChanged;
                }
                catch (Exception)
                {
                }

                this.GyroscopeChanged -= value;
            }
        }

        private void Gyroscope_ReadingChanged(object? sender, GyroscopeChangedEventArgs e) => this.GyroscopeChanged?.Invoke(sender, new Maui.Devices.Sensors.GyroscopeChangedEventArgs(new Maui.Devices.Sensors.GyroscopeData(e.Reading.AngularVelocity.X, e.Reading.AngularVelocity.Y, e.Reading.AngularVelocity.Z)));

        /// <summary>
        /// GyroscopeIsSupported
        /// </summary>
        public bool IsSupported => Microsoft.Maui.Devices.Sensors.Gyroscope.Default.IsSupported;

        /// <summary>
        /// GyroscopeIsMonitoring
        /// </summary>
        public bool IsMonitoring => Microsoft.Maui.Devices.Sensors.Gyroscope.Default.IsMonitoring;

        /// <summary>
        /// GyroscopeStart
        /// </summary>
        /// <param name="sensorSpeed"></param>
        public void GyroscopeStart(Maui.Devices.Sensors.SensorSpeed sensorSpeed) => Microsoft.Maui.Devices.Sensors.Gyroscope.Default.Start(sensorSpeed.EnumParse<SensorSpeed>());

        /// <summary>
        /// GyroscopeStop
        /// </summary>
        public void GyroscopeStop() => Microsoft.Maui.Devices.Sensors.Gyroscope.Default.Stop();
    }
}