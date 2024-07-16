using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.ApplicationModel
{
    /// <summary>
    /// Represents information about the application.
    /// </summary>
    public class AppInfo : Maui.ApplicationModel.IAppInfo
    {
        /// <summary>
        /// Gets the application package name or identifier.
        /// The package name or identifier.
        /// </summary>
        /// <remarks>On Android and iOS, this is the application package name. On UWP, this is the application GUID.</remarks>
        public string PackageName => Microsoft.Maui.ApplicationModel.AppInfo.Current.PackageName;

        /// <summary>
        /// Gets the application name.
        /// The application name.
        /// </summary>
        public string Name => Microsoft.Maui.ApplicationModel.AppInfo.Current.Name;

        /// <summary>
        /// Gets the application version.
        /// The application version.
        /// </summary>
        public string VersionString => Microsoft.Maui.ApplicationModel.AppInfo.Current.VersionString;

        /// <summary>
        /// Gets the application version.
        /// The application version.
        /// </summary>
        public Version Version => Microsoft.Maui.ApplicationModel.AppInfo.Current.Version;

        /// <summary>
        /// Gets the application build number.
        /// The application build number.
        /// </summary>
        public string BuildString => Microsoft.Maui.ApplicationModel.AppInfo.Current.BuildString;

        /// <summary>
        /// Gets the detected Theme of the system or application.
        /// The Theme.
        /// </summary>
        /// <remarks>For platforms or platform versions which aren't supported, Unspecified is returned.</remarks>
        public Maui.ApplicationModel.AppTheme RequestedTheme => Microsoft.Maui.ApplicationModel.AppInfo.Current.RequestedTheme.EnumParse<Maui.ApplicationModel.AppTheme>();

        /// <summary>
        /// PackagingModel
        /// </summary>
        public Maui.ApplicationModel.AppPackagingModel PackagingModel => Microsoft.Maui.ApplicationModel.AppInfo.Current.PackagingModel.EnumParse<Maui.ApplicationModel.AppPackagingModel>();

        /// <summary>
        /// 
        /// </summary>
        public Maui.ApplicationModel.LayoutDirection RequestedLayoutDirection => Microsoft.Maui.ApplicationModel.AppInfo.Current.RequestedLayoutDirection.EnumParse<Maui.ApplicationModel.LayoutDirection>();

        /// <summary>
        /// Open the settings menu or page for the application.
        /// </summary>
        public void ShowSettingsUI() => Microsoft.Maui.ApplicationModel.AppInfo.Current.ShowSettingsUI();
    }
}