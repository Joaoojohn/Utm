using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class UrlTests
    {
        private const string _InvalidUrl = "SociedadeEsportivaPalmeiras";
        private const string _ValidUrl = "https://www.palmeirasstore.com/";

        [TestMethod]
        [ExpectedException(typeof(InvalidUrlException))]
        public void GivenAInvalidURLShouldReturnAnException() => new Url(_InvalidUrl);

        [TestMethod]
        public void GivenAValidURLShouldNotThrowException()
        {
            new Url(_ValidUrl);
            Assert.IsTrue(true);
        }

        [TestMethod]
        [DataRow(" ", true)]
        [DataRow("http", true)]
        [DataRow("Palmeiras", true)]
        [DataRow("https://www.palmeirasstore.com/", false)]
        public void TestingMultipleURLs(string link, bool expectedException)
        {
            if (expectedException)
            {
                try
                {
                    new Url(link);

                    Assert.Fail();
                }
                catch (InvalidUrlException)
                {
                    Assert.IsTrue(true);
                }
            }
            else
            {
                new Url(link);
                Assert.IsTrue(true);
            }
        }
    }
}
