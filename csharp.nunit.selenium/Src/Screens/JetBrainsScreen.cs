using Csharp.Nunit.Selenium.Controllers;
using Csharp.Nunit.Selenium.Screens;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Screens
{
    public class JetBrainsScreen : ScreenObject<JetBrainsScreen>, IScreen<JetBrainsScreen>
    {
        public JetBrainsScreen(RemoteWebDriver driver) : base(driver)
        {
            
        }

        public JetBrainsScreen Trait()
        {
            throw new System.NotImplementedException();
        }

        public JetBrainsScreen Navigate()
        {
            throw new System.NotImplementedException();
        }
    }
}