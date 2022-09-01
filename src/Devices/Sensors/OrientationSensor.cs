using MetaFrm.Extensions;

namespace MetaFrm.Maui.Devices.Sensors
{
    /// <summary>
    /// OrientationSensor
    /// </summary>
    public class OrientationSensor : IOrientationSensor
    {
        private OrientationSensorChanged OrientationSensorChanged;

        /// <summary>
        /// OrientationSensorChangedEvent
        /// </summary>
        public event OrientationSensorChanged OrientationSensorChangedEvent
        {
            add
            {
                this.OrientationSensorChanged += value;

                try
                {
                    try
                    {
                        Microsoft.Maui.Devices.Sensors.OrientationSensor.Default.ReadingChanged -= OrientationSensor_ReadingChanged;
                    }
                    catch (Exception)
                    {
                    }
                    Microsoft.Maui.Devices.Sensors.OrientationSensor.Default.ReadingChanged += OrientationSensor_ReadingChanged;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    Microsoft.Maui.Devices.Sensors.OrientationSensor.ReadingChanged -= OrientationSensor_ReadingChanged;
                }
                catch (Exception)
                {
                }

                this.OrientationSensorChanged -= value;
            }
        }

        private void OrientationSensor_ReadingChanged(object sender, Microsoft.Maui.Devices.Sensors.OrientationSensorChangedEventArgs e) => this.OrientationSensorChanged?.Invoke(sender, new OrientationSensorChangedEventArgs(new OrientationSensorData(e.Reading.Orientation.X, e.Reading.Orientation.Y, e.Reading.Orientation.Z, e.Reading.Orientation.W)));

        /// <summary>
        /// OrientationSensorIsSupported
        /// </summary>
        public bool IsSupported => Microsoft.Maui.Devices.Sensors.OrientationSensor.Default.IsSupported;

        /// <summary>
        /// OrientationSensorIsMonitoring
        /// </summary>
        public bool IsMonitoring => Microsoft.Maui.Devices.Sensors.OrientationSensor.Default.IsMonitoring;

        /// <summary>
        /// OrientationSensorStart
        /// </summary>
        /// <param name="sensorSpeed"></param>
        public void OrientationSensorStart(SensorSpeed sensorSpeed) => Microsoft.Maui.Devices.Sensors.OrientationSensor.Default.Start(sensorSpeed.EnumParse<Microsoft.Maui.Devices.Sensors.SensorSpeed>());

        /// <summary>
        /// OrientationSensorStop
        /// </summary>
        public void OrientationSensorStop() => Microsoft.Maui.Devices.Sensors.OrientationSensor.Default.Stop();
    }
}