using MetaFrm.Extensions;

namespace MetaFrm.Maui.Essentials.Storage
{
    /// <summary>
    /// Lets the user pick a file from the device's storage.
    /// </summary>
    public class FilePicker : Maui.Storage.IFilePicker
    {
        /// <summary>
        /// Starts file picker for selecting files.
        /// </summary>
        /// <param name="options">File picker options to use; may be null</param>
        /// <returns>File picking result object, or null when picking was cancelled by the user.</returns>
        /// <remarks>File types can be specified in order to limit files that can be selected, using
        /// a PickOptions object. Note that this method may re-throw platform specific exceptions
        /// that occured during file picking. When calling PickAsync() again while showing
        /// a file picker, the Task object that was returned from the first call is cancelled.
        /// Be sure to also handle the TaskCanceledException in this case.</remarks>
        public async Task<Maui.Storage.FileResult?> PickAsync(Maui.Storage.PickOptions? options = null)
        {
            FilePickerFileType filePickerFileType;

            if (options != null && options.FileTypes != null && options.FileTypes.FileTypes != null)
            {
                Dictionary<DevicePlatform, IEnumerable<string>> fileTypes = new();

                foreach (var type in options.FileTypes.FileTypes)
                    fileTypes.Add(type.Key.EnumParse<DevicePlatform>(), type.Value);

                filePickerFileType = new FilePickerFileType(fileTypes);

                var result = await Microsoft.Maui.Storage.FilePicker.Default.PickAsync(new PickOptions() { PickerTitle = options.PickerTitle, FileTypes = filePickerFileType });

                if (result != null)
                    return new Maui.Storage.FileResult(result.FullPath, result.ContentType);
                else
                    return null;
            }
            else
            {
                var result = await Microsoft.Maui.Storage.FilePicker.Default.PickAsync();

                if (result != null)
                    return new Maui.Storage.FileResult(result.FullPath, result.ContentType);
                else
                    return null;
            }
        }

        /// <summary>
        /// Starts file picker for selecting a single file.
        /// </summary>
        /// <param name="options">File picker options to use; may be null</param>
        /// <returns>File picking result object, or null when picking was cancelled by the user.</returns>
        /// <remarks>File types can be specified in order to limit files that can be selected, using
        /// a PickOptions object. Note that this method may re-throw platform specific exceptions
        /// that occured during file picking. When calling PickMultipleAsync() again while
        /// showing a file picker, the Task object that was returned from the first call
        /// is cancelled. Be sure to also handle the TaskCanceledException in this case.</remarks>
        public async Task<IEnumerable<Maui.Storage.FileResult>> PickMultipleAsync(Maui.Storage.PickOptions? options = null)
        {
            FilePickerFileType filePickerFileType;

            if (options != null && options.FileTypes != null && options.FileTypes.FileTypes != null)
            {
                Dictionary<DevicePlatform, IEnumerable<string>> fileTypes = new();

                foreach (var type in options.FileTypes.FileTypes)
                    fileTypes.Add(type.Key.EnumParse<DevicePlatform>(), type.Value);

                filePickerFileType = new FilePickerFileType(fileTypes);

                var resultPickMultiple = await Microsoft.Maui.Storage.FilePicker.Default.PickMultipleAsync(new PickOptions() { PickerTitle = options.PickerTitle, FileTypes = filePickerFileType });

                if (resultPickMultiple != null)
                {
                    List<Maui.Storage.FileResult> results = new();

                    foreach (var type in resultPickMultiple)
                        results.Add(new Maui.Storage.FileResult(type.FullPath, type.ContentType));

                    return results;
                }
                else
                    return new List<Maui.Storage.FileResult>();
            }
            else
            {
                var resultPickMultiple = await Microsoft.Maui.Storage.FilePicker.Default.PickMultipleAsync();

                if (resultPickMultiple != null)
                {
                    List<Maui.Storage.FileResult> results = new();

                    foreach (var type in resultPickMultiple)
                        results.Add(new Maui.Storage.FileResult(type.FullPath, type.ContentType));

                    return results;
                }
                else
                    return new List<Maui.Storage.FileResult>();
            }
        }
    }
}