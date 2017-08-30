using System;
using Csharp.Nunit.Selenium.Screens;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Controllers
{
    public class ScreenController : IScreen
    {
        private readonly RemoteWebDriver driver;

        public ScreenController(RemoteWebDriver driver)
        {
            this.driver = driver;
        }

        private void GoTo(string destination)
        {
            driver.Navigate().GoToUrl(destination);
        }

        public GoogleScreen GoogleScreen()
        {
            return new GoogleScreen(driver);
        }

        public SeleniumScreen SeleniumScreen()
        {
            return new SeleniumScreen(driver);
        }

        public AppiumScreen AppiumScreen()
        {
            return new AppiumScreen(driver);
        }

        public JetBrainsScreen JetBrainsScreen()
        {
            return new JetBrainsScreen(driver);
        }
    }
}