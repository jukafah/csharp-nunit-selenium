using Csharp.Nunit.Selenium.Screens;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Controllers
{
    public class ContextController : IContext
    {
        private readonly RemoteWebDriver driver;

        public ContextController(RemoteWebDriver driver)
        {
            this.driver = driver;
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