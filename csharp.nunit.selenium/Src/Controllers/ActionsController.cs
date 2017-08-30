using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Controllers
{
    public class ActionsController : IActions
    {
        private readonly RemoteWebDriver driver;

        public ActionsController(RemoteWebDriver driver)
        {
            this.driver = driver;
        }
        
        public IActions Click(string element)
        {
            // todo: getElement
            throw new System.NotImplementedException();
        }

        public IActions EnterText(string text, string element)
        {
            // todo: getElement
            throw new System.NotImplementedException();
        }
    }
}