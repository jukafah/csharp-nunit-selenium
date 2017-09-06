using Csharp.Nunit.Selenium.Screens;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Controllers
{
    public class NavigationController : IScreens
    {
        private readonly RemoteWebDriver driver;

        public NavigationController(RemoteWebDriver driver)
        {
            this.driver = driver;
        }

        public GoogleScreen Google(string destination = GoogleScreen.Url)
        {
            
        }

        public SeleniumScreen Selenium(string destination = SeleniumScreen.Url)
        {
            return new SeleniumScreen(driver);
        }

        public AppiumScreen Appium(string destination = AppiumScreen.Url)
        {
            return new AppiumScreen(driver);
        }

        public JetBrainsScreen JetBrains(string destination = JetBrainsScreen.Url)
        {
            return new JetBrainsScreen(driver);
        }

        public Screen Url(string destination)
        {
            GoToUrl(destination);
            return new Screen(driver);
        }

        private void GoToUrl(string destination)
        {
            driver.Navigate().GoToUrl(destination);
        }
    }
}