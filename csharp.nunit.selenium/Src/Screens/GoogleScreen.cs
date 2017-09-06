using System;
using System.Collections.Generic;
using System.Linq;
using Csharp.Nunit.Selenium.Controllers;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.PageObjects;

namespace Csharp.Nunit.Selenium.Screens
{
	public class GoogleScreen : ScreenObject<GoogleScreen>
	{
		public GoogleScreen(RemoteWebDriver driver) : base(driver)
		{
			
		}

		public override string Url => "http://google.com";

		public override GoogleScreen Trait()
		{
			throw new NotImplementedException();
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
			FindResult(expResult).Click();
			return this;
		}

		private IWebElement FindResult(string expResult)
		{
			return searchResults
				.Single(result => result.Text.Equals(expResult, StringComparison.InvariantCultureIgnoreCase));
		}

		[FindsBy(How = How.CssSelector, Using = "#lst-ib")]
		private IWebElement searchBox;

		[FindsBy(How = How.CssSelector, Using = "#ires .g .r a")]
		private IList<IWebElement> searchResults;
	}
}
