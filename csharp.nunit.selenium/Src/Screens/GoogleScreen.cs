using System;
using System.Collections.Generic;
using Csharp.Nunit.Selenium.Controllers;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.PageObjects;

namespace Csharp.Nunit.Selenium.Screens
{
	public class GoogleScreen : ScreenController<GoogleScreen>, IScreen<GoogleScreen>
	{
		public const string Url = "http://google.com";

		public GoogleScreen(RemoteWebDriver driver) : base(driver)
		{

		}
		
		public GoogleScreen Trait()
		{
			throw new NotImplementedException();
		}

		public GoogleScreen Navigate()
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
