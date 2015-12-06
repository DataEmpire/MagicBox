using System;
using static System.Convert;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace MagicBox.UWP.Converters
{
    /// <summary>
    /// Converts a boolean value to a setted brush value.
    /// </summary>
    public sealed class BooleanToBrushConverter : IValueConverter
    {
        /// <summary>
        /// The color that must be used when the boolean value is False.
        /// </summary>
        public Color OnFalseColor { get; set; } = Colors.Transparent;

        /// <summary>
        /// Color that will be used when the bool value is equal to True.
        /// </summary>
        public Color OnTrueColor { get; set; } = Colors.White;

        /// <summary>
        /// Converts a boolean value to the equivalent brush value.
        /// </summary>
        /// <param name="value">The bool value.</param>
        /// <param name="targetType">The type indicator for SolidColorBrush.</param>
        /// <param name="parameter">A parameter that can be used to change the normal flow of logic.</param>
        /// <param name="language">The language to be used on converter scope.</param>
        /// <returns>A brush value correspondent with the boolean inputted.</returns>
        /// <exception cref="ArgumentException">When the value parameter is not a boolean value.</exception>

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (!(value is bool))
            {
                throw new ArgumentException("the value must be a boolean value");
            }

            bool source;

            try
            {
                source = ToBoolean(value);
            }
            catch (Exception)
            {
                source = false;
            }

            var color = (source == true) ? OnTrueColor : OnFalseColor;

            return new SolidColorBrush(color);
        }

        /// <summary>
        /// Converts a SolidColorBrush value to its equivalent bool value.
        /// </summary>
        /// <param name="value">The brush value.</param>
        /// <param name="targetType">The type indicator of bool value.</param>
        /// <param name="parameter">A parameter that can be used to change the normal flow of logic.</param>
        /// <param name="language">The language to be used on converter scope.</param>
        /// <returns>A boolean value that is correspondent with the brush inputted.</returns>
        /// <exception cref="ArgumentException">When the value parameter is not a SolidColorBrush object.</exception>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (!(value is SolidColorBrush))
            {
                throw new ArgumentException("the value must be a Windows.UI.Xaml.Media.SolidColorBrush object");
            }

            SolidColorBrush brush;

            try
            {
                brush = (SolidColorBrush) value;
            }
            catch (Exception)
            {
                brush = new SolidColorBrush(OnFalseColor);
            }

            return (brush.Color == OnTrueColor) ? true : false;
        }
    }
}