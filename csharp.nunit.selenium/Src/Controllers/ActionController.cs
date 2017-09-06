using Csharp.Nunit.Selenium.Screens;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Controllers
{
    public class ActionController : IAction<ActionController>
    {
        private readonly RemoteWebDriver driver;

        public ActionController(RemoteWebDriver driver)
        {
            this.driver = driver;
        }


        public ActionController Navigate()
        {
            throw new System.NotImplementedException();
        }

        public ActionController Navigate(string destination)
        {
            throw new System.NotImplementedException();
        }
    }
}