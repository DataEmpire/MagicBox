using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Storage;

namespace MagicBox.UWP.Services
{
    /// <summary>
    /// Define os métodos quqe o serviço para leitura de arquivo deve conter.
    /// </summary>
    public interface IFileReaderService
    {
        /// <summary>
        /// Calls the file picker and asks for the user select a file.
        /// </summary>
        /// <param name="extensionsToShow">Extensions that picker should show to the user.</param>
        /// <returns>The file that the user picks.</returns>
        Task<StorageFile> GetFileFromFilePickerAsync(IEnumerable<string> extensionsToShow);

        /// <summary>
        /// Help to get a file stored in the installed folder in a asynchronous way.
        /// </summary>
        /// <param name="path">File path.</param>
        /// <returns>A object of the type <see cref="StorageFile"/>.</returns>
        Task<StorageFile> GetFileFromInstalledFolderAsync(string path);

        /// <summary>
        /// Generic method to load data to object from a JSON file.
        /// </summary>
        /// <param name="jsonPath">The json path.</param>
        /// <returns>Returns the <see cref="Task"/> that indicates the task status.</returns>
        Task<T> LoadObjectFromJsonFileAsync<T>(string jsonPath);

        /// <summary>
        /// Read a file from the installed folder in a asynchronous way.
        /// </summary>
        /// <param name="path">File path.</param>
        /// <returns>The file content.</returns>
        Task<string> ReadTextFileFromInstalledFolderAsync(string path);

        /// <summary>
        /// Read the file that the user open with the file picker.
        /// </summary>
        /// <returns>The content from the file, all its lines.</returns>
        Task<IEnumerable<string>> ReadTextLinesFromFilePickerAsync();
    }
}