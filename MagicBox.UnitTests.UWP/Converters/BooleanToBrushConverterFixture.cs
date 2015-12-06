using MagicBox.UWP.Converters;
using MagicBox.UWP.Helpers;
using System;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Xunit;

namespace MagicBox.UnitTests.UWP.Converters
{
    /// <summary>
    /// The test class for the converter of a boolean to a brush value.
    /// </summary>
    public sealed class BooleanToBrushConverterFixture
    {
        private BooleanToBrushConverter _converter;
        private Color _falseColor;
        private Color _trueColor;

        /// <summary>
        /// Initializes the converter.
        /// </summary>
        public BooleanToBrushConverterFixture()
        {
            _trueColor = Colors.Black;
            _falseColor = Colors.White;

            _converter = new BooleanToBrushConverter
            {
                OnFalseColor = _falseColor,
                OnTrueColor = _trueColor
            };
        }

        /// <summary>
        /// Verify if a bool value is being converted for the correct brush value.
        /// </summary>
        [Fact]
        public async Task VerifyConverterAsync()
        {
            await UiHelper.ExecuteOnUiThreadAsync(() =>
            {
                _converter = new BooleanToBrushConverter();
                var actual = _converter.Convert(true, typeof(SolidColorBrush), null, string.Empty);
                var expected = new SolidColorBrush(_trueColor);

                Assert.Equal(expected, actual);

                actual = _converter.Convert(false, typeof(SolidColorBrush), null, string.Empty);
                expected = new SolidColorBrush(_falseColor);

                Assert.Equal(expected, actual);
            });


        }

        /// <summary>
        /// Verify if the brush value is being converted for the correct bool value.
        /// </summary>
        [Fact]
        public async Task VerifyConverterBackAsync()
        {
            await UiHelper.ExecuteOnUiThreadAsync(() =>
            {
                var actual = _converter.Convert(new SolidColorBrush(_trueColor), typeof(bool), null, string.Empty);

                Assert.Equal(true, actual);

                actual = _converter.Convert(new SolidColorBrush(_falseColor), typeof(bool), null, string.Empty);

                Assert.Equal(false, actual);
            });
        }

        /// <summary>
        /// Verifies whether the validation of type of value argument is working.
        /// </summary>
        [Fact]
        public void VerifyConverterBackValidation()
        {
            Assert.Throws<ArgumentException>(() => _converter.ConvertBack(null, typeof(SolidColorBrush), null, string.Empty));
            Assert.Throws<ArgumentException>(() => _converter.ConvertBack(_trueColor, typeof(SolidColorBrush), null, string.Empty));
        }

        /// <summary>
        /// Verifies whether the validation of type of value argument is working.
        /// </summary>
        [Fact]
        public void VerifyConverterValidation()
        {
            Assert.Throws<ArgumentException>(() => _converter.Convert(null, typeof(SolidColorBrush), null, string.Empty));
            Assert.Throws<ArgumentException>(() => _converter.Convert(_trueColor, typeof(SolidColorBrush), null, string.Empty));
        }

        /// <summary>
        /// Verifies whether the values to true and false statements are valid.
        /// </summary>
        [Fact]
        public void VerifyInitialization()
        {
            Assert.Equal(_falseColor, _converter.OnFalseColor);
            Assert.Equal(_trueColor, _converter.OnTrueColor);
        }
    }
}