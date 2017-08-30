using System;
using System.Collections.Generic;
using OpenQA.Selenium.Remote;
using Csharp.Nunit.Selenium.Client;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Csharp.Nunit.Selenium.Screens
{
	public class GoogleScreen : ScreenObject
	{

		public static string Url = "http://google.com";
		
		public GoogleScreen(RemoteWebDriver driver) : base(driver)
		{
			
		}
		
		
		// change to override
		public void Trait()
		{
			// todo: implement overrides
		}
		
		public GoogleScreen PerformSearch(string searchText)
		{
			searchBox.Clear();
			searchBox.SendKeys(searchText);
			searchBox.Submit();

			return this;
		}

		public GoogleScreen SelectResult(string expResult)
		{
			IWebElement link = FindResult(expResult);
			Assert.IsNotNull(link, $"Could not find link for: {expResult}");
			link.Click();

			return this;
		}

		private IWebElement FindResult(string expResult)
		{
			foreach (IWebElement link in searchResults)
			{
				if (link.Text.ToUpper().Contains(expResult.ToUpper())) {
					return link;
				}
			}
			return null;
		}

		[FindsBy(How = How.CssSelector, Using = "#lst-ib")]
		private IWebElement searchBox;

		[FindsBy(How = How.CssSelector, Using = "#ires .g .r a")]
		private IList<IWebElement> searchResults;
	}
}
