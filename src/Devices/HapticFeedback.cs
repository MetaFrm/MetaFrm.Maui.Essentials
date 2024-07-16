using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.Devices
{
    /// <summary>
    /// HapticFeedback
    /// </summary>
    public class HapticFeedback : Maui.Devices.IHapticFeedback
    {
        /// <summary>
        /// HapticFeedback IsSupported
        /// </summary>
        public bool IsSupported => Microsoft.Maui.Devices.HapticFeedback.Default.IsSupported;

        /// <summary>
        /// HapticFeedbackPerform
        /// </summary>
        /// <param name="type"></param>
        public void HapticFeedbackPerform(Maui.Devices.HapticFeedbackType type) => Microsoft.Maui.Devices.HapticFeedback.Default.Perform(type.EnumParse<HapticFeedbackType>());
    }
}