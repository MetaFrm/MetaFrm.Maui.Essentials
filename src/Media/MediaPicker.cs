namespace MetaFrm.Maui.Media
{
    /// <summary>
    /// Media
    /// </summary>
    public class MediaPicker : IMediaPicker
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
        public async Task<Storage.FileResult> CapturePhotoAsync(MediaPickerOptions options = null)
        {
            Microsoft.Maui.Storage.FileResult photo = await Microsoft.Maui.Media.MediaPicker.Default.CapturePhotoAsync();

            if (photo != null)
                return new Storage.FileResult(photo.FullPath);

            return null;
        }

        /// <summary>
        /// CaptureVideoAsync
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<Storage.FileResult> CaptureVideoAsync(MediaPickerOptions options = null)
        {
            Microsoft.Maui.Storage.FileResult photo = await Microsoft.Maui.Media.MediaPicker.Default.CaptureVideoAsync();

            if (photo != null)
                return new Storage.FileResult(photo.FullPath);

            return null;
        }

        /// <summary>
        /// PickPhotoAsync
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<Storage.FileResult> PickPhotoAsync(MediaPickerOptions options = null)
        {
            Microsoft.Maui.Storage.FileResult photo = await Microsoft.Maui.Media.MediaPicker.Default.PickPhotoAsync();

            if (photo != null)
                return new Storage.FileResult(photo.FullPath);

            return null;
        }

        /// <summary>
        /// PickVideoAsync
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<Storage.FileResult> PickVideoAsync(MediaPickerOptions options = null)
        {
            Microsoft.Maui.Storage.FileResult photo = await Microsoft.Maui.Media.MediaPicker.Default.PickVideoAsync();

            if (photo != null)
                return new Storage.FileResult(photo.FullPath);

            return null;
        }
    }
}