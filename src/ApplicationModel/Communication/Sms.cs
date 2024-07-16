namespace MetaFrm.Maui.Essentials.ApplicationModel.Communication
{
    /// <summary>
    /// Sms
    /// </summary>
    public class Sms : Maui.ApplicationModel.Communication.ISms
    {
        /// <summary>
        /// IsSupported
        /// </summary>
        public bool IsSupported => throw new NotImplementedException();

        /// <summary>
        /// ComposeAsync
        /// </summary>
        /// <param name="message"></param>
        /// <exception cref="NotImplementedException"></exception>
        public async void ComposeAsync(Maui.ApplicationModel.Communication.SmsMessage? message)
        {
            if (message != null)
                await Microsoft.Maui.ApplicationModel.Communication.Sms.Default.ComposeAsync(new SmsMessage(message.Body ?? "", message.Recipients));
            else
                await Microsoft.Maui.ApplicationModel.Communication.Sms.Default.ComposeAsync(null);
        }
    }
}