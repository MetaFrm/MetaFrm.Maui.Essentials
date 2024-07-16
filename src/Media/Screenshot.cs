namespace MetaFrm.Maui.Essentials.Media
{
    /// <summary>
    /// Screenshot
    /// </summary>
    public class Screenshot : Maui.Media.IScreenshot
    {
        /// <summary>
        /// ScreenshotIsCaptureSupported
        /// </summary>
        public bool ScreenshotIsCaptureSupported => Microsoft.Maui.Media.Screenshot.Default.IsCaptureSupported;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Maui.Media.IScreenshotResult> CaptureAsync()
        {
            IScreenshotResult screen = await Microsoft.Maui.Media.Screenshot.Default.CaptureAsync();

            return new ScreenshotResult() { ScreenshotResultOrg = screen };
        }
    }
}