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
        [TestCase("", "", "")]
        [TestCase("a", "a", "a")]
        public void WhenHaveKeyMessageValue_ReturnByVariation(string key, string message, string expectedValue)
        {
            var nico = new Nico(key, message);

            var expected = expectedValue;

            Assert.AreEqual(expected, nico.Variation());
        }
    }
}
