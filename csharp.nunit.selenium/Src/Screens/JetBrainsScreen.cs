using Csharp.Nunit.Selenium.Controllers;
using Csharp.Nunit.Selenium.Screens;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Screens
{
    public class JetBrainsScreen : ScreenObject<JetBrainsScreen>
    {
        public JetBrainsScreen(RemoteWebDriver driver) : base(driver)
        {
            
        }

        public override string Url => "https://www.jetbrains.com/";

        public override JetBrainsScreen Trait()
        {
            throw new System.NotImplementedException();
        }
    }
}