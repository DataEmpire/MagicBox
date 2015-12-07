using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using MagicBox.UWP.Converters;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace MagicBox.UWP.Tests.Converters
{
    /// <summary>
    /// The test class for <see cref="StringToVisibilityConverter"/>.
    /// </summary>
    [TestClass]
    public sealed class StringToVisibilityConverterFixture
    {
        private IValueConverter _converter;

        /// <summary>
        /// Initializes the converter.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            _converter = new StringToVisibilityConverter();
        }

        /// <summary>
        /// Verifies the string to visibility converter operation is working properly.
        /// </summary>
        [TestMethod]
        public void VerifyConverter()
        {
            
        }


        
    }
}
