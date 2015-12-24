using System.Threading.Tasks;
using MagicBox.UWP.Interfaces;
using MagicBox.UWP.Services;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace MagicBox.UWP.Tests.Services
{
    /// <summary>
    /// Set of methods that are used to test the <see cref="IFileReaderService"/>.
    /// </summary>
    [TestClass]
    public class FileReaderServiceFixture : ITestable
    {
        private IFileReaderService _fileReaderService;

        [TestInitialize]
        public void Initialize()
        {
            _fileReaderService = new FileReaderService();
        }

        [TestMethod]
        public void VerifyInitialization()
        {
            Assert.IsNotNull(_fileReaderService);
        }

        /// <summary>
        /// Checks the behavior of the get file after a user choice a file from a picker.
        /// </summary>
        [TestMethod]
        public async Task VerifyGetFileFromFilePickerAsync()
        {
            await Task.Delay(3000);
        }

    }
}