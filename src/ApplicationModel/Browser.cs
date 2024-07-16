using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.ApplicationModel
{
    /// <summary>
    /// Provides a way to display a web page inside an app.
    /// </summary>
    public class Browser : Maui.ApplicationModel.IBrowser
    {
        /// <summary>
        /// Open the browser to specified uri.
        /// </summary>
        /// <param name="uri">Uri to launch.</param>
        /// <returns>Completed task when browser is launched, but not necessarily closed. Result indicates if launching was successful or not.</returns>
        public async Task<bool> OpenAsync(string uri) => await Microsoft.Maui.ApplicationModel.Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred.EnumParse<BrowserLaunchMode>());

        /// <summary>
        /// Open the browser to specified uri.
        /// </summary>
        /// <param name="uri">Uri to launch.</param>
        /// <param name="launchMode">How to launch the browser.</param>
        /// <returns>Completed task when browser is launched, but not necessarily closed. Result indicates if launching was successful or not.</returns>
        public async Task<bool> OpenAsync(string uri, Maui.ApplicationModel.BrowserLaunchMode launchMode) => await Microsoft.Maui.ApplicationModel.Browser.Default.OpenAsync(uri, launchMode.EnumParse<BrowserLaunchMode>());

        /// <summary>
        /// Open the browser to specified uri.
        /// </summary>
        /// <param name="uri">Uri to launch.</param>
        /// <param name="options">Launch options for the browser.</param>
        /// <returns>Completed task when browser is launched, but not necessarily closed. Result indicates if launching was successful or not.</returns>
        public async Task<bool> OpenAsync(string uri, Maui.ApplicationModel.BrowserLaunchOptions options) => await Microsoft.Maui.ApplicationModel.Browser.Default.OpenAsync(uri, new BrowserLaunchOptions()
        {
            PreferredToolbarColor = options.PreferredToolbarColor == null ? null : Color.FromRgba(options.PreferredToolbarColor.Value.R, options.PreferredToolbarColor.Value.G, options.PreferredToolbarColor.Value.B, options.PreferredToolbarColor.Value.A),
            PreferredControlColor = options.PreferredControlColor == null ? null : Color.FromRgba(options.PreferredControlColor.Value.R, options.PreferredControlColor.Value.G, options.PreferredControlColor.Value.B, options.PreferredControlColor.Value.A),
            LaunchMode = options.LaunchMode.EnumParse<BrowserLaunchMode>(),
            TitleMode = options.TitleMode.EnumParse<BrowserTitleMode>(),
            Flags = options.Flags.EnumParse<BrowserLaunchFlags>()
        });

        /// <summary>
        /// Open the browser to specified uri.
        /// </summary>
        /// <param name="uri">Uri to launch.</param>
        /// <returns>Completed task when browser is launched, but not necessarily closed. Result indicates if launching was successful or not.</returns>
        public async Task<bool> OpenAsync(Uri uri) => await Microsoft.Maui.ApplicationModel.Browser.Default.OpenAsync(uri);

        /// <summary>
        /// Open the browser to specified uri.
        /// </summary>
        /// <param name="uri">Uri to launch.</param>
        /// <param name="launchMode">How to launch the browser.</param>
        /// <returns>Completed task when browser is launched, but not necessarily closed. Result indicates if launching was successful or not.</returns>
        public async Task<bool> OpenAsync(Uri uri, Maui.ApplicationModel.BrowserLaunchMode launchMode) => await Microsoft.Maui.ApplicationModel.Browser.Default.OpenAsync(uri, launchMode.EnumParse<BrowserLaunchMode>());

        /// <summary>
        /// Open the browser to specified uri.
        /// </summary>
        /// <param name="uri">Uri to launch.</param>
        /// <param name="options">Launch options for the browser.</param>
        /// <returns>Completed task when browser is launched, but not necessarily closed. Result indicates if launching was successful or not.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> OpenAsync(Uri uri, Maui.ApplicationModel.BrowserLaunchOptions options) => await Microsoft.Maui.ApplicationModel.Browser.Default.OpenAsync(uri, new BrowserLaunchOptions()
        {
            PreferredToolbarColor = options.PreferredToolbarColor == null ? null : Color.FromRgba(options.PreferredToolbarColor.Value.R, options.PreferredToolbarColor.Value.G, options.PreferredToolbarColor.Value.B, options.PreferredToolbarColor.Value.A),
            PreferredControlColor = options.PreferredControlColor == null ? null : Color.FromRgba(options.PreferredControlColor.Value.R, options.PreferredControlColor.Value.G, options.PreferredControlColor.Value.B, options.PreferredControlColor.Value.A),
            LaunchMode = options.LaunchMode.EnumParse<BrowserLaunchMode>(),
            TitleMode = options.TitleMode.EnumParse<BrowserTitleMode>(),
            Flags = options.Flags.EnumParse<BrowserLaunchFlags>()
        });
    }
}