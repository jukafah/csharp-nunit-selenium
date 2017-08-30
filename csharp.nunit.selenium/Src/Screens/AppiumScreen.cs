using System.Collections.Generic;
using Csharp.Nunit.Selenium.Screens;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace Csharp.Nunit.Selenium
{
    public class AppiumScreen : ScreenObject
    {
        public AppiumScreen(RemoteWebDriver driver) : base(driver)
        {

        }
        

        
        [FindsBy(How = How.CssSelector, Using = ".navbar .container-fluid .navbar-header .navbar-brand")]
        private IWebElement trait;
    }
}