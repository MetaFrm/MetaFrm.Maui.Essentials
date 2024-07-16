namespace MetaFrm.Maui.Essentials.Devices
{
    /// <summary>
    /// Vibration
    /// </summary>
    public class Vibration : Maui.Devices.IVibration
    {
        /// <summary>
        /// IsSupported
        /// </summary>
        public bool IsSupported => Microsoft.Maui.Devices.Vibration.Default.IsSupported;

        /// <summary>
        /// Vibrate
        /// </summary>
        public void Vibrate()
        {
            Microsoft.Maui.Devices.Vibration.Default.Vibrate();
        }

        /// <summary>
        /// Vibrate
        /// </summary>
        /// <param name="duration"></param>
        public void Vibrate(TimeSpan duration)
        {
            Microsoft.Maui.Devices.Vibration.Default.Vibrate(duration);
        }

        /// <summary>
        /// Cancel
        /// </summary>
        public void Cancel()
        {
            Microsoft.Maui.Devices.Vibration.Default.Cancel();
        }
    }
}