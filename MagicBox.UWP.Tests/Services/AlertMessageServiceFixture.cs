using MagicBox.UWP.Interfaces;
using MagicBox.UWP.Services;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace MagicBox.UWP.Tests.Services
{
    /// <summary>
    /// The set of methods to verify all behaviors for the service of alert messages.
    /// </summary>
    [TestClass]
    public sealed class AlertMessageServiceFixture : ITestable
    {
        private IAlertMessageService _alertMessageService;

        [TestInitialize]
        public void Initialize()
        {
            _alertMessageService = new AlertMessageService();
        }

        [TestMethod]
        public void VerifyInitialization()
        {
            Assert.IsNotNull(_alertMessageService);
        }
    }
}