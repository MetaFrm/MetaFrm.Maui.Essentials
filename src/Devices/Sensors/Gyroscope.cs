using MetaFrm.Extensions;

namespace MetaFrm.Maui.Devices.Sensors
{
    /// <summary>
    /// Gyroscope
    /// </summary>
    public class Gyroscope : IGyroscope
    {
        private GyroscopeChanged GyroscopeChanged;

        /// <summary>
        /// GyroscopeChangedEvent
        /// </summary>
        public event GyroscopeChanged GyroscopeChangedEvent
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

        private void Gyroscope_ReadingChanged(object sender, Microsoft.Maui.Devices.Sensors.GyroscopeChangedEventArgs e) => this.GyroscopeChanged?.Invoke(sender, new GyroscopeChangedEventArgs(new GyroscopeData(e.Reading.AngularVelocity.X, e.Reading.AngularVelocity.Y, e.Reading.AngularVelocity.Z)));

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
        public void GyroscopeStart(SensorSpeed sensorSpeed) => Microsoft.Maui.Devices.Sensors.Gyroscope.Default.Start(sensorSpeed.EnumParse<Microsoft.Maui.Devices.Sensors.SensorSpeed>());

        /// <summary>
        /// GyroscopeStop
        /// </summary>
        public void GyroscopeStop() => Microsoft.Maui.Devices.Sensors.Gyroscope.Default.Stop();
    }
}