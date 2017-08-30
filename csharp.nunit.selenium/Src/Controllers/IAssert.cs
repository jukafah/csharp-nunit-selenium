namespace Csharp.Nunit.Selenium.Controllers
{
    public interface IAssert
    {
        void AreEqual(string expectedValue, string actualValue);
    }
}