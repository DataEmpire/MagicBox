using MagicBox.UWP.Converters;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Xunit;

namespace MagicBox.UnitTests.UWP.Converters
{
    /// <summary>
    /// The validation tests for the <see cref="VisibilityInverterConverter"/>.
    /// </summary>
    public sealed class VisibilityInverterConverterFixture : IDisposable
    {
        private IValueConverter _converter;

        /// <summary>
        /// Initializes the converter object.
        /// </summary>
        public VisibilityInverterConverterFixture()
        {
            _converter = new VisibilityInverterConverter();
        }

        /// <summary>
        /// Clear all fields.
        /// </summary>
        public void Dispose()
        {
            _converter = null;
        }

        /// <summary>
        /// Verify if the inverter of an Visibility value it is working.
        /// </summary>
        [Fact]
        public void VerifyConverter()
        {
            var expected = Visibility.Collapsed;
            var actual = _converter.Convert(Visibility.Visible, typeof(Visibility), null, string.Empty);

            Assert.Equal(expected, actual);

            expected = Visibility.Visible;
            actual = _converter.Convert(Visibility.Collapsed, typeof(Visibility), null, string.Empty);

            Assert.Equal(expected, actual);

            Assert.Throws<ArgumentException>(() => _converter.Convert(null, typeof(Visibility), null, string.Empty));
        }

        /// <summary>
        /// Verify the behaviors on the ConverterBack method call.
        /// </summary>
        [Fact]
        public void VerifyConverterBack()
        {
            Assert.Throws<NotImplementedException>(() => _converter.ConvertBack(Visibility.Collapsed, typeof(Visibility), null, string.Empty));
        }
    }
}