using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace MagicBox.UWP.Services
{
    /// <summary>
    /// A helper class that provides methods to read files.
    /// </summary>
    public class FileReaderService : IFileReaderService
    {
        public async Task<StorageFile> GetFileFromFilePickerAsync(IEnumerable<string> extensionsToShow)
        {
            var filePicker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.Thumbnail,
                SuggestedStartLocation = PickerLocationId.DocumentsLibrary
            };

            foreach (var extension in extensionsToShow)
            {
                filePicker.FileTypeFilter.Add(extension);
            }

            return await filePicker.PickSingleFileAsync();
        }

        public async Task<StorageFile> GetFileFromInstalledFolderAsync(string path)
        {
            return await Package.Current.InstalledLocation.GetFileAsync(path);
        }

        public async Task<T> LoadObjectFromJsonFileAsync<T>(string jsonPath)
        {
            var jsonFile = await ReadTextFileFromInstalledFolderAsync(jsonPath);

            return JsonConvert.DeserializeObject<T>(jsonFile);
        }

        public async Task<string> ReadTextFileFromInstalledFolderAsync(string path)
        {
            var file = await GetFileFromInstalledFolderAsync(path);

            return await FileIO.ReadTextAsync(file);
        }

        public async Task<IEnumerable<string>> ReadTextLinesFromFilePickerAsync()
        {
            var textFile = await GetFileFromFilePickerAsync(new[] { ".txt" });

            return await FileIO.ReadLinesAsync(textFile);
        }
    }
}