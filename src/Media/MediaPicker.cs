namespace MetaFrm.Maui.Essentials.Media
{
    /// <summary>
    /// Media
    /// </summary>
    public class MediaPicker : Maui.Media.IMediaPicker
    {
        /// <summary>
        /// IsCaptureSupported
        /// </summary>
        public bool MediaPickerIsCaptureSupported => Microsoft.Maui.Media.MediaPicker.Default.IsCaptureSupported;

        /// <summary>
        /// CapturePhotoAsync
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Maui.Storage.FileResult> CapturePhotoAsync(Maui.Media.MediaPickerOptions? options = null)
        {
            FileResult? photo = await Microsoft.Maui.Media.MediaPicker.Default.CapturePhotoAsync(options == null ? null : new() { Title = options.Title});

            if (photo != null)
                return new Maui.Storage.FileResult(photo.FullPath);

            return new Maui.Storage.FileResult(string.Empty);
        }

        /// <summary>
        /// CaptureVideoAsync
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<Maui.Storage.FileResult> CaptureVideoAsync(Maui.Media.MediaPickerOptions? options = null)
        {
            FileResult? photo = await Microsoft.Maui.Media.MediaPicker.Default.CaptureVideoAsync(options == null ? null : new() { Title = options.Title });

            if (photo != null)
                return new Maui.Storage.FileResult(photo.FullPath);

            return new Maui.Storage.FileResult(string.Empty);
        }

        /// <summary>
        /// PickPhotoAsync
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<Maui.Storage.FileResult> PickPhotoAsync(Maui.Media.MediaPickerOptions? options = null)
        {
            FileResult? photo = await Microsoft.Maui.Media.MediaPicker.Default.PickPhotoAsync(options == null ? null : new() { Title = options.Title });

            if (photo != null)
                return new Maui.Storage.FileResult(photo.FullPath);

            return new Maui.Storage.FileResult(string.Empty);
        }

        /// <summary>
        /// PickVideoAsync
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<Maui.Storage.FileResult> PickVideoAsync(Maui.Media.MediaPickerOptions? options = null)
        {
            FileResult? photo = await Microsoft.Maui.Media.MediaPicker.Default.PickVideoAsync(options == null ? null : new() { Title = options.Title });

            if (photo != null)
                return new Maui.Storage.FileResult(photo.FullPath);

            return new Maui.Storage.FileResult(string.Empty);
        }
    }
}