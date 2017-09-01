using Csharp.Nunit.Selenium.Controllers;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Screens
{
    public class Screen : ScreenObject<Screen>, IScreen<Screen>
    {
        private RemoteWebDriver driver;

        public Screen(RemoteWebDriver driver) : base(driver)
        {
            
        }

        public Screen Trait()
        {
            return this;
        }

        public Screen Navigate()
        {
            throw new System.NotImplementedException();
        }
    }
}