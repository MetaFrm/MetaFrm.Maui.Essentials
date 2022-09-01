namespace MetaFrm.Maui.ApplicationModel.Communication
{
    /// <summary>
    /// Sms
    /// </summary>
    public class Sms : ISms
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
        public async void ComposeAsync(SmsMessage message)
        {
            await Microsoft.Maui.ApplicationModel.Communication.Sms.Default.ComposeAsync(new Microsoft.Maui.ApplicationModel.Communication.SmsMessage(message.Body, message.Recipients));
        }
    }
}