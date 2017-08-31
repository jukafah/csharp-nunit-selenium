using Csharp.Nunit.Selenium.Controllers;
using Csharp.Nunit.Selenium.Screens;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Screens
{
    public class JetBrainsScreen : ScreenController, IScreen<JetBrainsScreen>
    {
        public JetBrainsScreen(RemoteWebDriver driver) : base(driver)
        {
            
        }
        
    }
}