using System;
using Csharp.Nunit.Selenium.Screens;
using Csharp.Nunit.Selenium.Support;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Test
{
    [TestFixture]
    public class GoogleSearch : Hooks
    {
        private Screen screen;
        
        [SetUp]
        public void SetUp()
        {
            var driver = GetDriver();
            this.screen = new Screen(driver);
        }
        
        private object[] SearchTest =
        {
            new object[] 
                { "http://www.google.com", "appium", "Appium", "http://appium.io" },
            // todo: needs to be nunit
            new object[]
                { "http://www.google.com", "Cucumber Java", "Cucumber JVM", "https://cucumber.io/docs/reference/jvm" },
            new object[]
                { "http://www.google.com", "Selenium", "Selenium - Web Browser Automation", "http://www.seleniumhq.org/" },
            new object[] 
                { "http://www.google.com", "Rider", "Rider IDEA", "https://www.jetbrains.com/idea/" }
        };

        [TestCaseSource("SearchTest")]
        public void SearchTests(string homepage, string searchTerm, string expectedUrl)
        {
            screen
                .NavigateTo()
            .GoogleScreen()
                .PerformSearch(searchTerm)
                .SelectResult(searchTerm)
                .CheckUrl(expectedUrl);
        }
    }
}