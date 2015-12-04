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
    public class VisibilityInverterConverterFixture : IDisposable
    {
        private IValueConverter _converter;

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

            Action testCode = () => _converter.Convert(null, typeof (Visibility), null, string.Empty);

            Assert.Throws<ArgumentException>(testCode);
        }

        /// <summary>
        /// Verify the behaviors on the ConverterBack method call.
        /// </summary>
        [Fact]
        public void VerifyConverterBack()
        {
            Action testCode =
                () => _converter.ConvertBack(Visibility.Collapsed, typeof (Visibility), null, string.Empty);

            Assert.Throws<NotImplementedException>(testCode);
        }
    }
}