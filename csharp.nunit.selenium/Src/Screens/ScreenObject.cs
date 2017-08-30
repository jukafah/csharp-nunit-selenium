using System;
using Csharp.Nunit.Selenium.Controllers;
using NUnit.Framework;
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

        public IScreen NavigateTo()
        {
            return new ScreenController(driver);
        }

        public IActions Actions()
        {
            return new ActionsController(driver);
        }

        public String CurrentUrl()
        {
            return driver.Url;
        }

        public IAssert Assert()
        {
            return new AssertController();
        }
        
    }
}