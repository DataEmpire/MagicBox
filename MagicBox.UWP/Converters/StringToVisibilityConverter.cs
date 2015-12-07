using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace MagicBox.UWP.Converters
{
    /// <summary>
    /// A converter from a string value and a correspondent Visibility value.
    /// </summary>
    public sealed class StringToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Converts a string value to a Visibility object correspondent.
        /// </summary>
        /// <param name="value">The string value.</param>
        /// <param name="targetType">A type indicator for Visibility class.</param>
        /// <param name="parameter">A parameter that can be used to change the normal flow of logic in the method.</param>
        /// <param name="language">The language to be used on converter scope.</param>
        /// <returns>A visibility object correspondent from the string value passed.</returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value != null)
            {
                if (!(value is string))
                {
                    throw new ArgumentException("the value must be a string value");
                }
            }

            var valueAsString = (string)value;

            return (string.IsNullOrWhiteSpace(valueAsString)) ? Visibility.Collapsed : Visibility.Visible;
        }

        /// <summary>
        /// Not implemented yet.
        /// </summary>
        /// <param name="value">A value.</param>
        /// <param name="targetType">A type indicator for Visibility class.</param>
        /// <param name="parameter">A parameter that can be used to change the normal flow of logic in the method.</param>
        /// <param name="language">The language to be used on converter scope.</param>
        /// <returns>A new object of a <see cref="NotImplementedException"/>.</returns>
        /// <exception cref="NotImplementedException">This method is not implemented yet.</exception>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException("this method already is not accept a TwoWay binding mode");
        }
    }
}