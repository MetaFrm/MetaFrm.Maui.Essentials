namespace MetaFrm.Maui.Essentials.Media
{
    /// <summary>
    /// Media
    /// </summary>
    public class MediaPicker : Maui.Media.IMediaPicker
    {
        /// <summary>
        /// Gets a value indicating whether capturing media is supported on this device.
        /// </summary>
        public bool IsCaptureSupported { get; }

        /// <summary>
        /// Opens the media browser to select photos.
        /// </summary>
        /// <param name="options">Pick options to use.</param>
        /// <returns>A list of <see cref="FileResult"/> objects containing details of the picked photos. When the operation was cancelled by the user, this will return an empty list.</returns>
        /// <remarks>
        /// <para>On Android, not all picker user interfaces enforce the <see cref="MediaPickerOptions.SelectionLimit"/>.</para>
        /// <para>On Windows, <see cref="MediaPickerOptions.SelectionLimit"/> is not supported.</para>
        /// <para>Implement your own logic to ensure that the limit is maintained and/or notify the user on these platforms.</para>
        /// </remarks>
        public async Task<List<Maui.Storage.FileResult>> PickPhotosAsync(Maui.Media.MediaPickerOptions? options = null)
        {
            List<Maui.Storage.FileResult> fileResults = [];

            List<FileResult> photo = await Microsoft.Maui.Media.MediaPicker.Default.PickPhotosAsync(options == null ? null : new() { Title = options.Title });

            foreach (FileResult item in photo)
                fileResults.Add(new Maui.Storage.FileResult(item.FullPath, item.ContentType));

            return fileResults;
        }

        /// <summary>
        /// Opens the camera to take a photo.
        /// </summary>
        /// <param name="options">Pick options to use.</param>
        /// <returns>A <see cref="FileResult"/> object containing details of the captured photo. When the operation was cancelled by the user, this will return <see langword="null"/>.</returns>
        public async Task<Maui.Storage.FileResult?> CapturePhotoAsync(Maui.Media.MediaPickerOptions? options = null)
        {
            FileResult? photo = await Microsoft.Maui.Media.MediaPicker.Default.CapturePhotoAsync(options == null ? null : new() { Title = options.Title});

            if (photo != null)
                return new Maui.Storage.FileResult(photo.FullPath, photo.FullPath);

            return null;
        }

        /// <summary>
        /// Opens the media browser to select videos.
        /// </summary>
        /// <param name="options">Pick options to use.</param>
        /// <returns>A list of <see cref="FileResult"/> objects containing details of the picked videos. When the operation was cancelled by the user, this will return an empty list.</returns>
        /// <remarks>
        /// <para>On Android, not all picker user interfaces enforce the <see cref="MediaPickerOptions.SelectionLimit"/>.</para>
        /// <para>On Windows, <see cref="MediaPickerOptions.SelectionLimit"/> is not supported.</para>
        /// <para>Implement your own logic to ensure that the limit is maintained and/or notify the user on these platforms.</para>
        /// </remarks>
        public async Task<List<Maui.Storage.FileResult>> PickVideosAsync(Maui.Media.MediaPickerOptions? options = null)
        {
            List<Maui.Storage.FileResult> fileResults = [];

            List<FileResult> photo = await Microsoft.Maui.Media.MediaPicker.Default.PickVideosAsync(options == null ? null : new() { Title = options.Title });

            foreach (FileResult item in photo)
                fileResults.Add(new Maui.Storage.FileResult(item.FullPath, item.ContentType));

            return fileResults;
        }

        /// <summary>
        /// Opens the camera to take a video.
        /// </summary>
        /// <param name="options">Pick options to use.</param>
        /// <returns>A <see cref="FileResult"/> object containing details of the captured video. When the operation was cancelled by the user, this will return <see langword="null"/>.</returns>
        public async Task<Maui.Storage.FileResult?> CaptureVideoAsync(Maui.Media.MediaPickerOptions? options = null)
        {
            FileResult? photo = await Microsoft.Maui.Media.MediaPicker.Default.CaptureVideoAsync(options == null ? null : new() { Title = options.Title });

            if (photo != null)
                return new Maui.Storage.FileResult(photo.FullPath, photo.ContentType);

            return null;
        }
    }
}