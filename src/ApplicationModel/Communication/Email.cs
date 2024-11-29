namespace MetaFrm.Maui.Essentials.ApplicationModel.Communication
{
    /// <summary>
    /// Email
    /// </summary>
    public class Email : Maui.ApplicationModel.Communication.IEmail
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
        public async Task EmailComposeAsync(Maui.ApplicationModel.Communication.EmailMessage? message)
        {
            if (message != null)
            {
                if (message.To != null)
                {
                    string[] to = [.. message.To];

                    await Microsoft.Maui.ApplicationModel.Communication.Email.Default.ComposeAsync(new EmailMessage(message.Subject ?? "", message?.Body ?? "", to));
                }
                else
                    await Microsoft.Maui.ApplicationModel.Communication.Email.Default.ComposeAsync(new EmailMessage(message.Subject ?? "", message?.Body ?? ""));
            }
            else
                await Microsoft.Maui.ApplicationModel.Communication.Email.Default.ComposeAsync(null);
        }
    }
}