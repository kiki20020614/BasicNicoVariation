using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BasicNicoVariation
{
    [TestFixture]
    public class BasicNicoVariationTest
    {
        [Test]
        public void WhenKeyMessageAreEmpty_ReturnEmpty()
        {
            var key = string.Empty;
            var message = string.Empty;
            var nico = new Nico(key, message);

            var expected = string.Empty;

            Assert.AreEqual(expected, nico.Variation());
        }
    }
}
