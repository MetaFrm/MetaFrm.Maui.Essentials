using MetaFrm.Extensions;

namespace MetaFrm.Maui.Devices
{
    /// <summary>
    /// HapticFeedback
    /// </summary>
    public class HapticFeedback : IHapticFeedback
    {
        /// <summary>
        /// HapticFeedback IsSupported
        /// </summary>
        public bool IsSupported => Microsoft.Maui.Devices.HapticFeedback.Default.IsSupported;

        /// <summary>
        /// HapticFeedbackPerform
        /// </summary>
        /// <param name="type"></param>
        public void HapticFeedbackPerform(HapticFeedbackType type) => Microsoft.Maui.Devices.HapticFeedback.Default.Perform(type.EnumParse<Microsoft.Maui.Devices.HapticFeedbackType>());
    }
}