namespace MetaFrm.Maui.Storage
{
    /// <summary>
    /// Provides an easy way to access the locations for device folders.
    /// </summary>
    public class FileSystem : IFileSystem
    {
        /// <summary>
        /// Gets the location where temporary data can be stored.
        /// The location where temporary data can be stored.
        /// </summary>
        /// <remarks>This location usually is not visible to the user, is not backed up, and may be cleared at any time.</remarks>
        public string CacheDirectory => Microsoft.Maui.Storage.FileSystem.Current.CacheDirectory;

        /// <summary>
        /// Gets the location where app data can be stored.
        /// The location where app data can be stored.
        /// </summary>
        /// <remarks>This location usually is not visible to the user, and is backed up.</remarks>
        public string AppDataDirectory => Microsoft.Maui.Storage.FileSystem.Current.AppDataDirectory;

        /// <summary>
        /// AppPackageFileExistsAsync
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public async Task<bool> AppPackageFileExistsAsync(string filename) 
        {
            return await Microsoft.Maui.Storage.FileSystem.Current.AppPackageFileExistsAsync(filename);
        }

        /// <summary>
        /// Opens a stream to a file contained within the app package.
        /// </summary>
        /// <param name="filename">the name of the file to load from the app package.</param>
        /// <returns>Returns a stream to the file.</returns>
        public async Task<Stream> OpenAppPackageFileAsync(string filename)
        {
            return await Microsoft.Maui.Storage.FileSystem.Current.OpenAppPackageFileAsync(filename);
        }
    }
}