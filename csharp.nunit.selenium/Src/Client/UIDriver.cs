using System;
using Csharp.Nunit.Selenium.Screens;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace Csharp.Nunit.Selenium.Client
{
	// todo: implement
	public abstract class UIDriver
	{
		private readonly RemoteWebDriver driver;
		
		public UIDriver(RemoteWebDriver driver)
		{
			this.driver = driver;
			PageFactory.InitElements(driver, this);
		}
	
//		public UIDriver NavigateTo(string destination)
//		{
//			driver.Navigate().GoToUrl(destination);
//			return this;
//		}

		public UIDriver CheckUrl(string expectedUrl)
		{
			Assert.AreEqual(expectedUrl, driver.Url);
			return this;
		}
	}
}
