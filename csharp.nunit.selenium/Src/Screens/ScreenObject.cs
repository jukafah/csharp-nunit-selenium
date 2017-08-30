using System;
using Csharp.Nunit.Selenium.Client;
using Csharp.Nunit.Selenium.Controllers;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Screens
{
    public class ScreenObject : UIDriver
    {
        private readonly RemoteWebDriver driver;
        
        public ScreenObject(RemoteWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IScreen NavigateTo(String destination)
        {
            return new ScreenController(driver);
        }
    }
}