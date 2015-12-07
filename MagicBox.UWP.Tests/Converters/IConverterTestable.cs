using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace MagicBox.UWP.Tests.Converters
{
    /// <summary>
    /// Defines the method that I should to implement when I want to test a converter class.
    /// </summary>
    public interface IConverterTestable
    {
        /// <summary>
        /// The atributes initialization that is required for the current test class.
        /// </summary>
        [TestInitialize]
        void Initialize();

        /// <summary>
        /// Defines the action to test the operation of a testable converter, in its Converter method.
        /// </summary>
        [TestMethod]
        void VerifyConverter();

        /// <summary>
        /// Defines the storyboard for test the operation of the method ConverterBack of a testable converter.
        /// </summary>
        [TestMethod]
        void VerifyConverterBack();

        /// <summary>
        /// Defines the routine of checks to the initialization of required attributes.
        /// </summary>
        /// <remarks>General, the check if the attributes are not equal to null value.</remarks>
        [TestMethod]
        void VerifyInitialization();
    }
}