using MagicBox.UWP.Converters;
using MagicBox.UWP.Tests.Interfaces;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace MagicBox.UWP.Tests.Converters
{
    /// <summary>
    /// The test class for <see cref="StringToVisibilityConverter"/>.
    /// </summary>
    [TestClass]
    public sealed class StringToVisibliityConverterFixture : IConverterTestable, ITestable
    {
        private IValueConverter _converter;

        [TestInitialize]
        public void Initialize()
        {
            _converter = new StringToVisibilityConverter();
        }

        [TestMethod]
        public void VerifyConverter()
        {
            var actual = _converter.Convert(null, typeof(Visibility), null, string.Empty);

            Assert.AreEqual(Visibility.Collapsed, actual);

            actual = _converter.Convert("a simple sentence", typeof(Visibility), null, string.Empty);

            Assert.AreEqual(Visibility.Visible, actual);

            Assert.ThrowsException<ArgumentException>(() => _converter.Convert(new object(), typeof(Visibility), null, string.Empty));
        }

        [TestMethod]
        public void VerifyConverterBack()
        {
            Assert.ThrowsException<NotImplementedException>(() => _converter.ConvertBack(null, typeof(Visibility), null, string.Empty));
        }

        [TestMethod]
        public void VerifyInitialization()
        {
            Assert.IsNotNull(_converter);
        }
    }
}