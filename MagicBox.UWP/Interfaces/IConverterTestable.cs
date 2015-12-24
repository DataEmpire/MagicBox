namespace MagicBox.UWP.Interfaces
{
    /// <summary>
    /// Defines the method that I should to implement when I want to test a converter class.
    /// </summary>
    public interface IConverterTestable
    {
        /// <summary>
        /// Defines the action to test the operation of a testable converter, in its Converter method.
        /// </summary>
        void VerifyConverter();

        /// <summary>
        /// Defines the storyboard for test the operation of the method ConverterBack of a testable converter.
        /// </summary>
        void VerifyConverterBack();
    }
}