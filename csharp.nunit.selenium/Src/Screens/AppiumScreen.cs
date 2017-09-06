using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace Csharp.Nunit.Selenium.Screens
{
    public class AppiumScreen : ScreenObject<AppiumScreen>
    {
        public AppiumScreen(RemoteWebDriver driver) : base(driver)
        {

        }

        public override string Url => "http://appium.io";

        public override AppiumScreen Trait()
        {
            throw new NotImplementedException();
        }

        public override AppiumScreen Home()
        {
            throw new NotImplementedException();
        }

        public override AppiumScreen Navigate()
        {
            throw new NotImplementedException();
            /// add a `To` method and subsequent locations??
        }

        
        [FindsBy(How = How.CssSelector, Using = ".navbar .container-fluid .navbar-header .navbar-brand")]
        private IWebElement trait;
    }
}