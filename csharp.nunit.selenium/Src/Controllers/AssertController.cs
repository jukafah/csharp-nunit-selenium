using NUnit.Framework;

namespace Csharp.Nunit.Selenium.Controllers
{
    public class AssertController : IAssert
    {
        public void AreEqual(string expectedValue, string actualValue)
        {
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}