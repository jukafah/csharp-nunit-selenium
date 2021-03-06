﻿using Csharp.Nunit.Selenium.Screens;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium
{
    public class SeleniumScreen : ScreenObject
    {
        private readonly RemoteWebDriver driver;
        
        public SeleniumScreen(RemoteWebDriver driver) : base(driver)
        {
            
        }
    }
}