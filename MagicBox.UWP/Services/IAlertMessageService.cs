using System.Collections.Generic;
using System.Threading.Tasks;
using MagicBox.UWP.Models;

namespace MagicBox.UWP.Services
{
    /// <summary>
    /// Defines the methods that the alert message service must to provide.
    /// </summary>
    public interface IAlertMessageService
    {
        /// <summary>
        /// Show an alert message with a title and message.
        /// </summary>
        /// <param name="message">The message to show in alert.</param>
        /// <param name="title">The title of the alert message.</param>
        Task ShowAsync(string message, string title);

        /// <summary>
        /// Show an alert message with a title, message and buttons that execute commands.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="title">The title.</param>
        /// <param name="dialogCommands">The buttons that the alert message will show.</param>
        Task ShowAsync(string message, string title, IEnumerable<DialogCommand> dialogCommands);
    }
}