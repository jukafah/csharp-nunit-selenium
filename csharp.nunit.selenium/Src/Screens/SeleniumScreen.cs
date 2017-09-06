using Csharp.Nunit.Selenium.Controllers;
using Csharp.Nunit.Selenium.Screens;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Screens
{
    public class SeleniumScreen : ScreenObject<SeleniumScreen>
    {
        private readonly RemoteWebDriver driver;
        
        public SeleniumScreen(RemoteWebDriver driver) : base(driver)
        {
            
        }

        public override SeleniumScreen Trait()
        {
            throw new System.NotImplementedException();
        }
    }
}