using MetaFrm.Extensions;

namespace MetaFrm.Maui.Media
{
    /// <summary>
    /// ScreenshotResult
    /// </summary>
    public class ScreenshotResult : IScreenshotResult
    {
        /// <summary>
        /// ScreenshotResult
        /// </summary>
        public Microsoft.Maui.Media.IScreenshotResult ScreenshotResultOrg;

        /// <summary>
        /// Width
        /// </summary>
        public int Width => ScreenshotResultOrg.Width;

        /// <summary>
        /// Height
        /// </summary>
        public int Height => ScreenshotResultOrg.Height;

        /// <summary>
        /// CopyToAsync
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="format"></param>
        /// <param name="quality"></param>
        /// <returns></returns>
        public Task CopyToAsync(Stream destination, ScreenshotFormat format = ScreenshotFormat.Png, int quality = 100) => ScreenshotResultOrg.CopyToAsync(destination, format.EnumParse<Microsoft.Maui.Media.ScreenshotFormat>(), quality);

        /// <summary>
        /// OpenReadAsync
        /// </summary>
        /// <param name="format"></param>
        /// <param name="quality"></param>
        /// <returns></returns>
        public Task<Stream> OpenReadAsync(ScreenshotFormat format = ScreenshotFormat.Png, int quality = 100) => ScreenshotResultOrg.OpenReadAsync(format.EnumParse<Microsoft.Maui.Media.ScreenshotFormat>(), quality);
    }
}