namespace MetaFrm.Maui.Essentials.ApplicationModel.Communication
{
    /// <summary>
    /// PhoneDialer
    /// </summary>
    public class PhoneDialer : Maui.ApplicationModel.Communication.IPhoneDialer
    {
        /// <summary>
        /// IsSupported
        /// </summary>
        public bool IsSupported => Microsoft.Maui.ApplicationModel.Communication.PhoneDialer.Default.IsSupported;

        /// <summary>
        /// Open
        /// </summary>
        /// <param name="number"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Open(string number)
        {
            Microsoft.Maui.ApplicationModel.Communication.PhoneDialer.Default.Open(number);
        }
    }
}