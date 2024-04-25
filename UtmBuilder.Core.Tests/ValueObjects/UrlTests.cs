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
        [TestMethod]
        [ExpectedException(typeof(InvalidUrlException))]
        public void GivenAInvalidURLShouldReturnAnException() => new Url("SociedadeEsportivaPalmeiras");

        [TestMethod]
        public void GivenAValidURLShouldNotThrowException()
        {
            new Url("https://www.palmeirasstore.com/");
            Assert.IsTrue(true);
        }
    }
}
