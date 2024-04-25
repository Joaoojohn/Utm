using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects.Exceptions;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class CampaingTests
    {
        [TestMethod]
        [DataRow("", "", "", true)]
        [DataRow("source", "", "", true)]
        [DataRow("source", "medium", "", true)]
        [DataRow("source", "medium", "name", false)]
        public void MandatoryParameters(string source, string medium, string name, bool expectedException)
        {
            if (expectedException)
            {
                try
                {
                    new Campaign(source, medium, name);

                    Assert.Fail();
                }
                catch (InvalidCampaignException)
                {
                    Assert.IsTrue(true);
                }
            }
            else
            {
                new Campaign(source, medium, name);
                Assert.IsTrue(true);
            }
        }
    }
}
