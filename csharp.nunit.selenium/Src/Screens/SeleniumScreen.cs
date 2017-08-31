using Csharp.Nunit.Selenium.Controllers;
using Csharp.Nunit.Selenium.Screens;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Screens
{
    public class SeleniumScreen : ScreenController, IScreen<SeleniumScreen>
    {
        private readonly RemoteWebDriver driver;
        
        public SeleniumScreen(RemoteWebDriver driver) : base(driver)
        {
            
        }
    }
}