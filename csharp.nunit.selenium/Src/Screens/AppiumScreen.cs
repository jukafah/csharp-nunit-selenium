using System.Collections.Generic;
using Csharp.Nunit.Selenium.Controllers;
using Csharp.Nunit.Selenium.Screens;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace Csharp.Nunit.Selenium.Screens
{
    public class AppiumScreen : ScreenObject<AppiumScreen>, IScreen<AppiumScreen>
    {
        public AppiumScreen(RemoteWebDriver driver) : base(driver)
        {

        }
        

        
        [FindsBy(How = How.CssSelector, Using = ".navbar .container-fluid .navbar-header .navbar-brand")]
        private IWebElement trait;

        public AppiumScreen Trait()
        {
            throw new System.NotImplementedException();
        }

        public AppiumScreen Navigate()
        {
            throw new System.NotImplementedException();
        }
    }
}