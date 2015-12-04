using System.Reflection;

namespace MagicBox.UnitTests.UWP
{
    /// <summary>
    /// Provides application-specific behavior to supplement the RunnerApplication class.
    /// </summary>
    public sealed partial class App
    {
        /// <summary>
        /// Set that the tests can be inside the main assembly.
        /// </summary>
        protected override void OnInitializeRunner()
        {
            AddTestAssembly(GetType().GetTypeInfo().Assembly);
        }
    }
}