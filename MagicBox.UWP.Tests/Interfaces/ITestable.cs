namespace MagicBox.UWP.Tests.Interfaces
{
    /// <summary>
    /// Defines the method to all fixture class for a test class.
    /// </summary>
    public interface ITestable
    {
        /// <summary>
        /// The atributes initialization that is required for the current test class.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Defines the routine of checks to the initialization of required attributes.
        /// </summary>
        /// <remarks>General, the check if the attributes are not equal to null value.</remarks>
        void VerifyInitialization();
    }
}