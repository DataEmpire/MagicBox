using MagicBox.UWP.Converters;
using MagicBox.UWP.Interfaces;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using Windows.UI.Xaml.Data;

namespace MagicBox.UWP.Tests.Converters
{
    /// <summary>
    /// A test class for <seealso cref="DateTimeToTimeSpanConverter"/>.
    /// </summary>
    [TestClass]
    public sealed class DateTimeToTimeSpanConverterFixture : IConverterTestable, ITestable
    {
        private IValueConverter _converter;

        [TestInitialize]
        public void Initialize()
        {
            _converter = new DateTimeToTimeSpanConverter();
        }

        [TestMethod]
        public void VerifyConverter()
        {
            var mockedValue = new DateTime(2014, 09, 18, 14, 22, 20);
            var actual = (TimeSpan)_converter.Convert(mockedValue, typeof(TimeSpan), null, string.Empty);
            var expected = new TimeSpan(14, 22, 20);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyConverterBack()
        {
            var mockedValue = new TimeSpan(14, 22, 20);
            var actual = (DateTime)_converter.ConvertBack(mockedValue, typeof(TimeSpan), null, string.Empty);
            var expected = DateTime.Today.Add(new TimeSpan(14, 22, 20));

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyInitialization()
        {
            Assert.IsNotNull(_converter);
        }
    }
}