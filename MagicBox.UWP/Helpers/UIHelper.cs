using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.UI.Core;

namespace MagicBox.UWP.Helpers
{
    /// <summary>
    /// A helper class that contains methods to execute on UI thread on UI context.
    /// </summary>
    public static class UiHelper
    {
        /// <summary>
        /// Executes a action on the UI thread.
        /// </summary>
        /// <param name="dispatchedHandler">The action to execute on UI thread.</param>
        /// <param name="priority">The execution priority.</param>
        /// <returns>Returns the asynchronous action.</returns>
        public static IAsyncAction ExecuteOnUiThreadAsync(DispatchedHandler dispatchedHandler, CoreDispatcherPriority priority = CoreDispatcherPriority.Normal)
        {
            return CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(priority, dispatchedHandler);
        }
    }
}