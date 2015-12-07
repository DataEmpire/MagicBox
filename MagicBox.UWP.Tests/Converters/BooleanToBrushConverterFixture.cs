using MagicBox.UWP.Converters;
using MagicBox.UWP.Helpers;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace MagicBox.UWP.Tests.Converters
{
    /// <summary>
    /// The test class for the converter of a boolean to a brush value.
    /// </summary>
    [TestClass]
    public sealed class BooleanToBrushConverterFixture
    {
        private BooleanToBrushConverter _converter;
        private Color _falseColor;
        private Color _trueColor;

        /// <summary>
        /// Initializes the converter and colors for this test.
        /// </summary>
        [TestInitialize]
        public void Initialize()
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
        /// Verify if a bool value is being converted for the correct brush value, also verifies the validation of input value.
        /// </summary>
        [TestMethod]
        public async Task VerifyConverterAsync()
        {
            await UiHelper.ExecuteOnUiThreadAsync(() =>
            {
                var actual = (SolidColorBrush) _converter.Convert(true, typeof(SolidColorBrush), null, string.Empty);
                var expected = new SolidColorBrush(_trueColor);

                Assert.AreEqual(expected.Color, actual.Color);

                actual = (SolidColorBrush)_converter.Convert(false, typeof(SolidColorBrush), null, string.Empty) as SolidColorBrush;
                expected = new SolidColorBrush(_falseColor);

                Assert.AreEqual(expected.Color, actual.Color);

                Assert.ThrowsException<ArgumentException>(() => _converter.Convert(null, typeof(SolidColorBrush), null, string.Empty));
                Assert.ThrowsException<ArgumentException>(() => _converter.Convert(_trueColor, typeof(SolidColorBrush), null, string.Empty));
            });
        }

        /// <summary>
        /// Verify if the brush value is being converted for the correct bool value, also verifies whether the input values are correct.
        /// </summary>
        [TestMethod]
        public async Task VerifyConverterBackAsync()
        {
            await UiHelper.ExecuteOnUiThreadAsync(() =>
            {
                var actual = _converter.ConvertBack(new SolidColorBrush(_trueColor), typeof(bool), null, string.Empty);

                Assert.AreEqual(true, actual);

                actual = _converter.ConvertBack(new SolidColorBrush(_falseColor), typeof(bool), null, string.Empty);

                Assert.AreEqual(false, actual);

                Assert.ThrowsException<ArgumentException>(() => _converter.ConvertBack(null, typeof(SolidColorBrush), null, string.Empty));
                Assert.ThrowsException<ArgumentException>(() => _converter.ConvertBack(_trueColor, typeof(SolidColorBrush), null, string.Empty));
            });
        }

        /// <summary>
        /// Verifies whether the values to true and false statements are valid, and that the converter is not null value.
        /// </summary>
        [TestMethod]
        public void VerifyInitialization()
        {
            Assert.IsNotNull(_converter);
            Assert.AreEqual(_falseColor, _converter.OnFalseColor);
            Assert.AreEqual(_trueColor, _converter.OnTrueColor);
        }
    }
}