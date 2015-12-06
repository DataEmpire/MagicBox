using MagicBox.UWP.Converters;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace MagicBox.UWP.Tests.Converters
{
    /// <summary>
    /// The validation tests for the <see cref="VisibilityInverterConverter"/>.
    /// </summary>
    [TestClass]
    public sealed class VisibilityInverterConverterFixture
    {
        private IValueConverter _converter;

        /// <summary>
        /// Initializes the converter object.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            _converter = new VisibilityInverterConverter();
        }

        /// <summary>
        /// Verify if the inverter of an Visibility value it is working.
        /// </summary>
        [TestMethod]
        public void VerifyConverter()
        {
            var expected = Visibility.Collapsed;
            var actual = _converter.Convert(Visibility.Visible, typeof(Visibility), null, string.Empty);

            Assert.AreEqual(expected, actual);

            expected = Visibility.Visible;
            actual = _converter.Convert(Visibility.Collapsed, typeof(Visibility), null, string.Empty);

            Assert.AreEqual(expected, actual);

            Assert.ThrowsException<ArgumentException>(() => _converter.Convert(null, typeof(Visibility), null, string.Empty));
        }

        /// <summary>
        /// Verify the behaviors on the ConverterBack method call.
        /// </summary>
        [TestMethod]
        public void VerifyConverterBack()
        {
            Assert.ThrowsException<NotImplementedException>(() => _converter.ConvertBack(Visibility.Collapsed, typeof(Visibility), null, string.Empty));
        }
    }
}