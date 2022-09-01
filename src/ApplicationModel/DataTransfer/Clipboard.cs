namespace MetaFrm.Maui.ApplicationModel.DataTransfer
{
    /// <summary>
    /// Provides a way to work with text on the device clipboard.
    /// </summary>
    public class Clipboard : IClipboard
    {
        /// <summary>
        /// Gets a value indicating whether there is any text on the clipboard.
        /// </summary>
        public bool HasText => Microsoft.Maui.ApplicationModel.DataTransfer.Clipboard.Default.HasText;

        event EventHandler ClipboardContentChanged;

        /// <summary>
        /// Fires when the clipboard content changes.
        /// </summary>
        public event EventHandler ClipboardContentChangedEvent
        {
            add
            {
                this.ClipboardContentChanged += value;

                try
                {
                    try
                    {
                        Microsoft.Maui.ApplicationModel.DataTransfer.Clipboard.Default.ClipboardContentChanged -= Clipboard_ClipboardContentChanged;
                    }
                    catch (Exception)
                    {
                    }
                    Microsoft.Maui.ApplicationModel.DataTransfer.Clipboard.Default.ClipboardContentChanged += Clipboard_ClipboardContentChanged;
                }
                catch (Exception)
                {
                }
            }
            remove
            {
                try
                {
                    Microsoft.Maui.ApplicationModel.DataTransfer.Clipboard.Default.ClipboardContentChanged -= Clipboard_ClipboardContentChanged;
                }
                catch (Exception)
                {
                }

                this.ClipboardContentChanged -= value;
            }
        }

        private void Clipboard_ClipboardContentChanged(object sender, EventArgs e) => this.ClipboardContentChanged?.Invoke(sender, e);

        /// <summary>
        /// Returns any text that is on the clipboard.
        /// </summary>
        /// <returns>Returns text that is on the clipboard, or null if there is none.</returns>
        public async Task<string> GetTextAsync() => await Microsoft.Maui.ApplicationModel.DataTransfer.Clipboard.Default.GetTextAsync();

        /// <summary>
        /// Sets the contents of the clipboard to be the specified text.
        /// </summary>
        /// <param name="text">The text to put on the clipboard.</param>
        /// <returns>Returns text that is on the clipboard, or null if there is none.</returns>
        /// <remarks>This method returns immediately and does not guarentee that the text is on the clipboard by the time this method returns</remarks>
        public async Task SetTextAsync(string text) => await Microsoft.Maui.ApplicationModel.DataTransfer.Clipboard.Default.SetTextAsync(text);
    }
}