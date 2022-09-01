﻿using MetaFrm.Extensions;

namespace MetaFrm.Maui.Devices.Sensors
{
    /// <summary>
    /// Maui Essentials Device
    /// </summary>
    public class Accelerometer : IAccelerometer
    {
        private AccelerometerChanged AccelerometerChanged;

        /// <summary>
        /// AccelerometerChanged
        /// </summary>
        public event AccelerometerChanged AccelerometerChangedEvent
        {
            add
            {
                this.AccelerometerChanged += value;

                try
                {
                    try
                    {
                        Microsoft.Maui.Devices.Sensors.Accelerometer.Default.ReadingChanged -= Accelerometer_ReadingChanged;
                    }
                    catch (Exception)
                    {
                    }
                    Microsoft.Maui.Devices.Sensors.Accelerometer.Default.ReadingChanged += Accelerometer_ReadingChanged;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    Microsoft.Maui.Devices.Sensors.Accelerometer.ReadingChanged -= Accelerometer_ReadingChanged;
                }
                catch (Exception)
                {
                }

                this.AccelerometerChanged -= value;
            }
        }

        private void Accelerometer_ReadingChanged(object sender, Microsoft.Maui.Devices.Sensors.AccelerometerChangedEventArgs e) => this.AccelerometerChanged?.Invoke(sender, new AccelerometerChangedEventArgs(new AccelerometerData(e.Reading.Acceleration.X, e.Reading.Acceleration.Y, e.Reading.Acceleration.Z)));

        private EventHandler ShakeDetected;

        /// <summary>
        /// ShakeDetectedEvent
        /// </summary>
        public event EventHandler ShakeDetectedEvent
        {
            add
            {
                this.ShakeDetected += value;

                try
                {
                    try
                    {
                        Microsoft.Maui.Devices.Sensors.Accelerometer.ShakeDetected -= Accelerometer_ShakeDetected;
                    }
                    catch (Exception)
                    {
                    }
                    Microsoft.Maui.Devices.Sensors.Accelerometer.ShakeDetected += Accelerometer_ShakeDetected;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    Microsoft.Maui.Devices.Sensors.Accelerometer.ShakeDetected -= Accelerometer_ShakeDetected;
                }
                catch (Exception)
                {
                }

                this.ShakeDetected -= value;
            }
        }

        private void Accelerometer_ShakeDetected(object sender, EventArgs e) => this.ShakeDetected?.Invoke(sender, e);

        /// <summary>
        /// AccelerometerIsSupported
        /// </summary>
        public bool IsSupported => Microsoft.Maui.Devices.Sensors.Accelerometer.Default.IsSupported;

        /// <summary>
        /// AccelerometerIsMonitoring
        /// </summary>
        public bool IsMonitoring => Microsoft.Maui.Devices.Sensors.Accelerometer.Default.IsMonitoring;

        /// <summary>
        /// AccelerometerStart
        /// </summary>
        /// <param name="sensorSpeed"></param>
        public void AccelerometerStart(SensorSpeed sensorSpeed) => Microsoft.Maui.Devices.Sensors.Accelerometer.Default.Start(sensorSpeed.EnumParse<Microsoft.Maui.Devices.Sensors.SensorSpeed>());

        /// <summary>
        /// AccelerometerStop
        /// </summary>
        public void AccelerometerStop() => Microsoft.Maui.Devices.Sensors.Accelerometer.Default.Stop();
    }
}