using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Screens
{
    public class Screen : ScreenObject
    {
        private RemoteWebDriver driver;
        
        public Screen(RemoteWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
    }
}