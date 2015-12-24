using System.Threading.Tasks;

namespace MagicBox.UWP.Interfaces
{
    /// <summary>
    /// Defines the methods to doing test on a converter using a asynchronous context.
    /// </summary>
    public interface IConverterTestableAsync
    {
        /// <summary>
        /// Defines the action to test the operation of a testable converter, in its Converter method, but this routine is executed in the UI thread.
        /// </summary>
        Task VerifyConverterAsync();

        /// <summary>
        /// Defines the storyboard for test the operation of the method ConverterBack of a testable converter, but this routine is executed in the UI thread.
        /// </summary>
        Task VerifyConverterBackAsync();
    }
}