using System;
using Csharp.Nunit.Selenium.Controllers;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Screens
{
    public abstract class ScreenObject<T>
    {
        private readonly RemoteWebDriver driver;
        
        protected ScreenObject(RemoteWebDriver driver)
        {
            this.driver = driver;
        }

        public IContext Given()
        {
            return new ContextController(driver);
        }

        public T EnterText(string field, string text)
        {
            IWebElement elem = GetElement(field);
            elem.SendKeys("blah");
        }

        public IWebElement GetElement(string element)
        {
            throw new NotImplementedException();
        }
    }
}