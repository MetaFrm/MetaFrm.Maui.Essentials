namespace MetaFrm.Maui.Essentials.ApplicationModel
{
    /// <summary>
    /// Provides an easy way to track an app's version on a device.
    /// </summary>
    public class VersionTracking : Maui.ApplicationModel.IVersionTracking
    {
        /// <summary>
        /// Gets a value indicating whether this is the first time this app has ever been launched on this device.
        /// </summary>
        public bool IsFirstLaunchEver => Microsoft.Maui.ApplicationModel.VersionTracking.IsFirstLaunchEver;

        /// <summary>
        /// Gets a value indicating if this is the first launch of the app for the current version number.
        /// </summary>
        public bool IsFirstLaunchForCurrentVersion => Microsoft.Maui.ApplicationModel.VersionTracking.IsFirstLaunchForCurrentVersion;

        /// <summary>
        /// Gets a value indicating if this is the first launch of the app for the current build number.
        /// </summary>
        public bool IsFirstLaunchForCurrentBuild => Microsoft.Maui.ApplicationModel.VersionTracking.IsFirstLaunchForCurrentBuild;

        /// <summary>
        /// Gets the current version number of the app.
        /// </summary>
        public string CurrentVersion => Microsoft.Maui.ApplicationModel.VersionTracking.CurrentVersion;
        /// <summary>
        /// Gets the current build of the app.
        /// </summary>
        public string CurrentBuild => Microsoft.Maui.ApplicationModel.VersionTracking.CurrentBuild;

        /// <summary>
        /// Gets the version number for the previously run version.
        /// </summary>
        public string? PreviousVersion => Microsoft.Maui.ApplicationModel.VersionTracking.PreviousVersion;

        /// <summary>
        /// Gets the build number for the previously run version.
        /// </summary>
        public string? PreviousBuild => Microsoft.Maui.ApplicationModel.VersionTracking.PreviousBuild;

        /// <summary>
        /// Gets the version number of the first version of the app that was installed on this device.
        /// </summary>
        public string? FirstInstalledVersion => Microsoft.Maui.ApplicationModel.VersionTracking.FirstInstalledVersion;

        /// <summary>
        /// Gets the build number of first version of the app that was installed on this device.
        /// </summary>
        public string? FirstInstalledBuild => Microsoft.Maui.ApplicationModel.VersionTracking.FirstInstalledBuild;

        /// <summary>
        /// Gets the collection of version numbers of the app that ran on this device.
        /// </summary>
        public IEnumerable<string> VersionHistory => Microsoft.Maui.ApplicationModel.VersionTracking.VersionHistory;

        /// <summary>
        /// Gets the collection of build numbers of the app that ran on this device.
        /// </summary>
        public IEnumerable<string> BuildHistory => Microsoft.Maui.ApplicationModel.VersionTracking.BuildHistory;

        /// <summary>
        /// Determines if this is the first launch of the app for a specified build number.
        /// </summary>
        /// <param name="build">The build number.</param>
        /// <returns>Returns true if this is the first launch of the app for the specified build number; otherwise false.</returns>
        public bool IsFirstLaunchForBuild(string build) => Microsoft.Maui.ApplicationModel.VersionTracking.IsFirstLaunchForBuild(build);

        /// <summary>
        /// Determines if this is the first launch of the app for a specified version number.
        /// </summary>
        /// <param name="version">The version number.</param>
        /// <returns>Returns true if this is the first launch of the app for the specified version number; otherwise false.</returns>
        public bool IsFirstLaunchForVersion(string version) => Microsoft.Maui.ApplicationModel.VersionTracking.IsFirstLaunchForVersion(version);

        /// <summary>
        /// Starts tracking version information.
        /// </summary>
        public void Track() => Microsoft.Maui.ApplicationModel.VersionTracking.Track();
    }
}