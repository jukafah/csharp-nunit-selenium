using System;
using System.Reflection;
using Csharp.Nunit.Selenium.Controllers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Screens
{
    public abstract class ScreenObject<T>
    {
        private readonly RemoteWebDriver driver;
//        private abstract const string testString;
        
        protected ScreenObject(RemoteWebDriver driver)
        {
            this.driver = driver;
        }
        
        public abstract string Url { get; }

        public abstract T Trait();
//
        public IScreens NavigateTo()
        {
            return new NavigationController(driver);
        }
    }
}