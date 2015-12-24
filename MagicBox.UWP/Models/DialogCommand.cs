using System;

namespace MagicBox.UWP.Models
{
    /// <summary>
    /// A button that is showed on a alert message.
    /// </summary>
    public sealed class DialogCommand
    {
        /// <summary>
        /// Represents the identifier of the command.
        /// </summary>
        public object Id { get; set; }

        /// <summary>
        /// Represents the display name for the button.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Represents the action that is invoked when the button is tapped.
        /// </summary>
        public Action Invoked { get; set; }
    }
}
