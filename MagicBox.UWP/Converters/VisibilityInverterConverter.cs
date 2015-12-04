using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace MagicBox.UWP.Converters
{
    /// <summary>
    /// Inverter by two-way binding a <see cref="Visibility"/> value.
    /// </summary>
    /// <remarks>
    /// in:                             out:
    /// Visibility.Visible              Visibility.Collapsed
    /// Visibility.Collapsed            Visibility.Visible
    /// </remarks>
    public class VisibilityInverterConverter : IValueConverter
    {
        /// <summary>
        /// Converter a valid Visibility value in its inverted value.
        /// </summary>
        /// <param name="value">A valid <see cref="Visibility"/> value.</param>
        /// <param name="targetType">The type for <see cref="Visibility"/>.</param>
        /// <param name="parameter">This parameter can be used to change the default logic flow.</param>
        /// <param name="language">The current language on the app.</param>
        /// <returns>The inversed value for the Visibility entered.</returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (!(value is Visibility))
            {
                throw new ArgumentException("the value must be a Windows.UI.Xaml.Visibility object");
            }

            var visibility = (Visibility)value;

            return (visibility == Visibility.Collapsed) ? Visibility.Visible : Visibility.Collapsed;
        }

        /// <summary>
        /// Already not implemented once that this method is called when target updates source object.
        /// </summary>
        /// <param name="value">A <see cref="Visibility"/> value.</param>
        /// <param name="targetType">The type indicator to the <see cref="Visibility"/> type.</param>
        /// <param name="parameter">This parameter can be used to change the default logic flow.</param>
        /// <param name="language">The current language on the app.</param>
        /// <returns>A new object of a <see cref="NotImplementedException"/>.</returns>
        /// <exception cref="NotImplementedException">I don't see a situation in that this can be used or invoked.</exception>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}