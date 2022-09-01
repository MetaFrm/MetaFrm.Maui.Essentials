namespace MetaFrm.Maui.Devices.Sensors
{
    /// <summary>
    /// Flashlight
    /// </summary>
    public class Flashlight : IFlashlight
    {
        /// <summary>
        /// FlashlightTurnOnAsync
        /// </summary>
        /// <returns></returns>
        public async Task FlashlightTurnOnAsync()
        {
            await Microsoft.Maui.Devices.Flashlight.Default.TurnOnAsync();
        }

        /// <summary>
        /// FlashlightTurnOffAsync
        /// </summary>
        /// <returns></returns>
        public async Task FlashlightTurnOffAsync()
        {
            await Microsoft.Maui.Devices.Flashlight.Default.TurnOffAsync();
        }
    }
}