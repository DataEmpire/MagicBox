using MagicBox.UWP.Services;
using MagicBox.UWP.Tests.Interfaces;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace MagicBox.UWP.Tests.Services
{
    /// <summary>
    /// The test class for input pane service.
    /// </summary>
    [TestClass]
    public class InputPaneServiceFixture : ITestable
    {
        private IInputPaneService _inputPaneService;

        [TestInitialize]
        public void Initialize()
        {
            _inputPaneService = new InputPaneService();
        }

        [TestMethod]
        public void VerifyInitialization()
        {
            Assert.IsNotNull(_inputPaneService);
        }
    }
}