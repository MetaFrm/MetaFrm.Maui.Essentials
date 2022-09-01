namespace MetaFrm.Maui.ApplicationModel.Communication
{
    /// <summary>
    /// Email
    /// </summary>
    public class Email : IEmail
    {
        /// <summary>
        /// IsComposeSupported
        /// </summary>
        public bool IsComposeSupported => Microsoft.Maui.ApplicationModel.Communication.Email.Default.IsComposeSupported;

        /// <summary>
        /// EmailComposeAsync
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task EmailComposeAsync(EmailMessage message)
        {
            await Microsoft.Maui.ApplicationModel.Communication.Email.Default.ComposeAsync(new Microsoft.Maui.ApplicationModel.Communication.EmailMessage(message.Subject, message.Body, message.To.ToArray()));
        }
    }
}