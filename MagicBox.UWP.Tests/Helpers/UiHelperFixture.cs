using MagicBox.UWP.Helpers;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MagicBox.UWP.Tests.Helpers
{
    /// <summary>
    /// The test suite for the <see cref="UiHelper"/>.
    /// </summary>
    [TestClass]
    public sealed class UiHelperFixture
    {
        /// <summary>
        /// Verifies whether the action is executing in different thread.
        /// </summary>
        [TestMethod]
        public async Task VerifyExecuteOnUiThreadIsDiferentMainThreadAsync()
        {
            SynchronizationContext.SetSynchronizationContext(new SynchronizationContext());
            SynchronizationContext uiSynchronizationContext = null;

            await UiHelper.ExecuteOnUiThreadAsync(() => uiSynchronizationContext = SynchronizationContext.Current);

            Assert.IsNotNull(uiSynchronizationContext);

            Assert.AreNotEqual(SynchronizationContext.Current, uiSynchronizationContext);
        }
    }
}