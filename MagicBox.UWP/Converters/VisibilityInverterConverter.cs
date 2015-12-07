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
    public sealed class VisibilityInverterConverter : IValueConverter
    {
        /// <summary>
        /// Converter a valid Visibility value in its inverted value.
        /// </summary>
        /// <param name="value">A valid <see cref="Visibility"/> value.</param>
        /// <param name="targetType">The type for <see cref="Visibility"/>.</param>
        /// <param name="parameter">A parameter that can be used to change the normal flow of logic in the method.</param>
        /// <param name="language">The language to be used on converter scope.</param>
        /// <returns>The inversed value for the Visibility entered.</returns>
        /// <exception cref="ArgumentException">When the value parameter is not a Visibility object.</exception>
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
        /// Not implemented yet.
        /// </summary>
        /// <param name="value">A value.</param>
        /// <param name="targetType">The type indicator to the <see cref="Visibility"/> type.</param>
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