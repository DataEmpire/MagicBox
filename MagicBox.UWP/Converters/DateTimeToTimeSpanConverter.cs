using System;
using Windows.UI.Xaml.Data;

namespace MagicBox.UWP.Converters
{
    /// <summary>
    /// Converter a DateTime value to its correspondent in TimeSpan value.
    /// </summary>
    public sealed class DateTimeToTimeSpanConverter : IValueConverter
    {
        /// <summary>
        /// Convert a DateTime value to TimeSpan.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType">The type indicator of TimeSpan.</param>
        /// <param name="parameter">A parameter that can be used to change the normal flow of logic in the method.</param>
        /// <param name="language">The language to be used on converter scope.</param>
        /// <returns>A TimeSpan object.</returns>
        /// <remarks>In case of the value is null, the DateTime to consider is the right now time.</remarks>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            DateTime dateTime;

            try
            {
                dateTime = (DateTime)value;
            }
            catch (Exception)
            {
                dateTime = DateTime.Now;
            }

            return dateTime.TimeOfDay;
        }

        /// <summary>
        /// Convert back from a TimeSpan value to DateTime object.
        /// </summary>
        /// <param name="value">A TimeSpan value.</param>
        /// <param name="targetType">The type indicator of TimeSpan.</param>
        /// <param name="parameter">A parameter that can be used to change the normal flow of logic in the method.</param>
        /// <param name="language">The language to be used on converter scope.</param>
        /// <returns>A DateTime object.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            TimeSpan timeSpan;

            try
            {
                timeSpan = (TimeSpan)value;
            }
            catch (Exception)
            {
                timeSpan = new TimeSpan(DateTime.Now.Ticks);
            }

            var dateTime = DateTime.Today;

            return dateTime.Add(timeSpan);
        }
    }
}