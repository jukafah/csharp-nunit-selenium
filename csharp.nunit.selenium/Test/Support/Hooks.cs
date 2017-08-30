using System;
using Csharp.Nunit.Selenium.Data;
using Csharp.Nunit.Selenium.Test.Config;
using Csharp.Nunit.Selenium.Test.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Support
{
	[TestFixture]
	public class Hooks
	{
		private RemoteWebDriver driver;
		private DriverFactory driverFactory;
		private TestData testData;

		[OneTimeSetUp]
		public void BeforeAll()
		{
			Console.Out.WriteLine("BeforeAll");
			Configuration config = new Configuration();
			this.driverFactory = new DriverFactory(config.uri, config.deviceMap);
		}
		
		[SetUp]
		public void SetUp()
		{
			driver = driverFactory.CreateDriver();
			// todo: testdata
		}

		[TearDown]
		public void TearDown()
		{
			driver?.Dispose();
		}

		public RemoteWebDriver GetDriver()
		{
			return driver;
		}

		public TestData GetTestData()
		{
			return testData;
		}
			
	}

}
