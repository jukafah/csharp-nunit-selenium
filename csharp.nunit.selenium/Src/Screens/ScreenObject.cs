using System;
using Csharp.Nunit.Selenium.Controllers;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Screens
{
    public abstract class ScreenObject
    {
        private readonly RemoteWebDriver driver;
        
        protected ScreenObject(RemoteWebDriver driver)
        {
            this.driver = driver;
        }

        public ScreenController NavigateTo()
        {
            return new ScreenController(driver);
        }
    }
}