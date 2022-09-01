namespace MetaFrm.Maui.ApplicationModel
{
    /// <summary>
    /// Launches an application specified by the passed uri.
    /// </summary>
    /// <remarks>Has to be a valid System.Uri</remarks>
    public class Launcher : ILauncher
    {
        /// <summary>
        /// Queries if device supports opening the uri scheme
        /// </summary>
        /// <param name="uri">string uri scheme</param>
        /// <returns>True if opening is supported, otherwise false</returns>
        /// <remarks>May throw System.UriFormatException if uri is malformed</remarks>
        public async Task<bool> CanOpenAsync(string uri)
        {
            return await Microsoft.Maui.ApplicationModel.Launcher.Default.CanOpenAsync(uri);
        }

        /// <summary>
        /// Queries if device supports opening the uri scheme
        /// </summary>
        /// <param name="uri">uri scheme</param>
        /// <returns>True if opening is supported, otherwise false</returns>
        /// <remarks>May throw System.UriFormatException if uri is malformed</remarks>
        public async Task<bool> CanOpenAsync(Uri uri)
        {
            return await Microsoft.Maui.ApplicationModel.Launcher.Default.CanOpenAsync(uri);
        }

        /// <summary>
        /// Launches the app specified by the uri scheme
        /// </summary>
        /// <param name="uri">string uri scheme</param>
        /// <returns></returns>
        /// <remarks>May throw System.UriFormatException if uri is malformed. Verify if the uri scheme is supported before calling this method</remarks>
        public async Task<bool> OpenAsync(string uri)
        {
            return await Microsoft.Maui.ApplicationModel.Launcher.Default.OpenAsync(uri);
        }

        /// <summary>
        /// Launches the app specified by the uri scheme
        /// </summary>
        /// <param name="uri">uri scheme</param>
        /// <returns></returns>
        /// <remarks>May throw System.UriFormatException if uri is malformed. Verify if the uri scheme is supported before calling this method</remarks>
        public async Task<bool> OpenAsync(Uri uri)
        {
            return await Microsoft.Maui.ApplicationModel.Launcher.Default.OpenAsync(uri);
        }

        /// <summary>
        /// Requests to open a file in an application based on content type.
        /// </summary>
        /// <param name="request">Request that contains information on the file to open.</param>
        /// <returns></returns>
        public async Task<bool> OpenAsync(OpenFileRequest request)
        {
            if (DeviceInfo.Platform == DevicePlatform.iOS && DeviceInfo.Idiom == DeviceIdiom.Tablet)
            {
                if (request.PresentationSourceBounds == null)
                    return await Microsoft.Maui.ApplicationModel.Launcher.Default.OpenAsync(new Microsoft.Maui.ApplicationModel.OpenFileRequest(request.Title, new Microsoft.Maui.Storage.ReadOnlyFile(request.File.FullPath, request.File.ContentType)));
                else
                    return await Microsoft.Maui.ApplicationModel.Launcher.Default.OpenAsync(new Microsoft.Maui.ApplicationModel.OpenFileRequest(request.Title, new Microsoft.Maui.Storage.ReadOnlyFile(request.File.FullPath, request.File.ContentType))
                    {
                        PresentationSourceBounds = new Rect((double)request.PresentationSourceBounds?.X, (double)request.PresentationSourceBounds?.Y, (double)request.PresentationSourceBounds?.Width, (double)request.PresentationSourceBounds?.Height)
                    });
            }
            else
                return await Microsoft.Maui.ApplicationModel.Launcher.Default.OpenAsync(new Microsoft.Maui.ApplicationModel.OpenFileRequest(request.Title, new Microsoft.Maui.Storage.ReadOnlyFile(request.File.FullPath, request.File.ContentType)));
        }

        /// <summary>
        /// Launches the app specified by the uri scheme and returns if it was supported or not
        /// </summary>
        /// <param name="uri">string uri scheme</param>
        /// <returns>True if opening is supported, otherwise false</returns>
        /// <remarks>May throw System.UriFormatException if uri is malformed</remarks>
        public async Task<bool> TryOpenAsync(string uri)
        {
            return await Microsoft.Maui.ApplicationModel.Launcher.Default.TryOpenAsync(uri);
        }

        /// <summary>
        /// Launches the app specified by the uri scheme and returns if it was supported or not
        /// </summary>
        /// <param name="uri">uri scheme</param>
        /// <returns>True if opening is supported, otherwise false</returns>
        /// <remarks>May throw System.UriFormatException if uri is malformed</remarks>
        public async Task<bool> TryOpenAsync(Uri uri)
        {
            return await Microsoft.Maui.ApplicationModel.Launcher.Default.TryOpenAsync(uri);
        }
    }
}