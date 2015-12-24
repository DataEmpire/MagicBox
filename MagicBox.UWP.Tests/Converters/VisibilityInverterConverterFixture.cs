using MagicBox.UWP.Converters;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using MagicBox.UWP.Interfaces;

namespace MagicBox.UWP.Tests.Converters
{
    /// <summary>
    /// The validation tests for the <see cref="VisibilityInverterConverter"/>.
    /// </summary>
    [TestClass]
    public sealed class VisibilityInverterConverterFixture : IConverterTestable, ITestable
    {
        private IValueConverter _converter;

        [TestInitialize]
        public void Initialize()
        {
            _converter = new VisibilityInverterConverter();
        }

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

        [TestMethod]
        public void VerifyConverterBack()
        {
            Assert.ThrowsException<NotImplementedException>(() => _converter.ConvertBack(Visibility.Collapsed, typeof(Visibility), null, string.Empty));
        }

        [TestMethod]
        public void VerifyInitialization()
        {
            Assert.IsNotNull(_converter);
        }
    }
}