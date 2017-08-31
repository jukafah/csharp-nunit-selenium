using System;
using Csharp.Nunit.Selenium.Screens;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Controllers
{
    public abstract class ScreenController<T> : IController
    {
        private readonly RemoteWebDriver driver;
        
        protected ScreenController(RemoteWebDriver driver)
        {
            this.driver = driver;
        }

        public GoogleScreen GoogleScreen()
        {
            return new GoogleScreen(driver);
        }

        public SeleniumScreen SeleniumScreen()
        {
            return new SeleniumScreen(driver);
        }

        public AppiumScreen AppiumScreen()
        {
            return new AppiumScreen(driver);
        }

        public JetBrainsScreen JetBrainsScreen()
        {
            return new JetBrainsScreen(driver);
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