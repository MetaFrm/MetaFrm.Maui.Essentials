namespace MetaFrm.Maui.Essentials.ApplicationModel.DataTransfer
{
    /// <summary>
    /// Share data such as text and uris to other applications.
    /// </summary>
    public class Share : Maui.ApplicationModel.DataTransfer.IShare
    {
        /// <summary>
        /// Show the share user interface to share text.
        /// </summary>
        /// <param name="text">Text to share.</param>
        /// <returns>Task when completed.</returns>
        public async Task RequestAsync(string text)
        {
            await Microsoft.Maui.ApplicationModel.DataTransfer.Share.RequestAsync(text);
        }

        /// <summary>
        /// Show the share user interface to share text with a title.
        /// </summary>
        /// <param name="text">Text to share.</param>
        /// <param name="title">Title for the share user interface.</param>
        /// <returns>Task when completed.</returns>
        public async Task RequestAsync(string text, string title)
        {
            await Microsoft.Maui.ApplicationModel.DataTransfer.Share.RequestAsync(text, title);
        }

        /// <summary>
        /// Show the share user interface to share text or uri.
        /// </summary>
        /// <param name="request">Share request with options.</param>
        /// <returns>Task when completed.</returns>
        public async Task RequestAsync(Maui.ApplicationModel.DataTransfer.ShareTextRequest request)
        {
            await Microsoft.Maui.ApplicationModel.DataTransfer.Share.RequestAsync(new ShareTextRequest()
            {
                Text = request.Text,
                Title = request.Title,
                PresentationSourceBounds = new Rect(request.PresentationSourceBounds.X, request.PresentationSourceBounds.Y, request.PresentationSourceBounds.Width, request.PresentationSourceBounds.Height),
                Subject = request.Subject,
                Uri = request.Uri
            });
        }

        /// <summary>
        /// Show the user interface to share a file.
        /// </summary>
        /// <param name="request">File request to share.</param>
        /// <returns>Task when completed.</returns>
        public async Task RequestAsync(Maui.ApplicationModel.DataTransfer.ShareFileRequest request)
        {
            await Microsoft.Maui.ApplicationModel.DataTransfer.Share.RequestAsync(new ShareFileRequest()
            {
                Title = request.Title,
                File = request.File != null ? new ShareFile(request.File.FullPath, request.File.ContentType) : null
            });
        }

        /// <summary>
        /// Show the user interface to share a multiple files.
        /// </summary>
        /// <param name="request">Multiple Files request to share.</param>
        /// <returns>Task when completed.</returns>
        public async Task RequestAsync(Maui.ApplicationModel.DataTransfer.ShareMultipleFilesRequest request)
        {
            List<ShareFile>? files = null;

            if (request.Files != null)
            {
                files = [];
                foreach (Maui.ApplicationModel.DataTransfer.ShareFile shareFile in request.Files)
                    files.Add(new ShareFile(shareFile.FullPath, shareFile.ContentType));
            }

            await Microsoft.Maui.ApplicationModel.DataTransfer.Share.RequestAsync(new ShareMultipleFilesRequest()
            {
                Title = request.Title,
                Files = files
            });
        }
    }
}