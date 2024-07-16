using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.Media
{
    /// <summary>
    /// ScreenshotResult
    /// </summary>
    public class ScreenshotResult : Maui.Media.IScreenshotResult
    {
        /// <summary>
        /// ScreenshotResult
        /// </summary>
        public IScreenshotResult? ScreenshotResultOrg;

        /// <summary>
        /// Width
        /// </summary>
        public int Width => ScreenshotResultOrg == null ? throw new Exception("ScreenshotResult is null") : ScreenshotResultOrg.Width;

        /// <summary>
        /// Height
        /// </summary>
        public int Height =>  ScreenshotResultOrg == null ? throw new Exception("ScreenshotResult is null") : ScreenshotResultOrg.Height;

        /// <summary>
        /// CopyToAsync
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="format"></param>
        /// <param name="quality"></param>
        /// <returns></returns>
        public Task CopyToAsync(Stream destination, Maui.Media.ScreenshotFormat format = Maui.Media.ScreenshotFormat.Png, int quality = 100)
            => ScreenshotResultOrg == null ? throw new Exception("ScreenshotResult is null") : ScreenshotResultOrg.CopyToAsync(destination, format.EnumParse<ScreenshotFormat>(), quality);

        /// <summary>
        /// OpenReadAsync
        /// </summary>
        /// <param name="format"></param>
        /// <param name="quality"></param>
        /// <returns></returns>
        public Task<Stream> OpenReadAsync(Maui.Media.ScreenshotFormat format = Maui.Media.ScreenshotFormat.Png, int quality = 100)
            => ScreenshotResultOrg == null ? throw new Exception("ScreenshotResult is null") : ScreenshotResultOrg.OpenReadAsync(format.EnumParse<ScreenshotFormat>(), quality);
    }
}