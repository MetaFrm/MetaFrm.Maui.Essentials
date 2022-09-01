namespace MetaFrm.Maui.Media
{
    /// <summary>
    /// Screenshot
    /// </summary>
    public class Screenshot : IScreenshot
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
        public async Task<IScreenshotResult> CaptureAsync()
        {
            Microsoft.Maui.Media.IScreenshotResult screen = await Microsoft.Maui.Media.Screenshot.Default.CaptureAsync();

            return new ScreenshotResult() { ScreenshotResultOrg = screen };
        }
    }
}