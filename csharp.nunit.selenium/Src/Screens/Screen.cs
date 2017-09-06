using Csharp.Nunit.Selenium.Controllers;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Screens
{
    public class Screen : ScreenObject<Screen>
    {
        public Screen(RemoteWebDriver driver) : base(driver)
        {
            
        }

        public override string Url { get; }

        public override Screen Trait()
        {
            throw new System.NotImplementedException();
        }
    }
}