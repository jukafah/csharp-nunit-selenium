using Csharp.Nunit.Selenium.Controllers;
using Csharp.Nunit.Selenium.Screens;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Screens
{
    public class SeleniumScreen : ScreenObject<SeleniumScreen>, IScreen<SeleniumScreen>
    {
        private readonly RemoteWebDriver driver;
        
        public SeleniumScreen(RemoteWebDriver driver) : base(driver)
        {
            
        }

        public SeleniumScreen Trait()
        {
            throw new System.NotImplementedException();
        }

        public SeleniumScreen Navigate()
        {
            throw new System.NotImplementedException();
        }
    }
}