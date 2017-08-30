using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Test.Support
{
	public class DriverFactory
	{
		private readonly DesiredCapabilities desiredCapabilities;
		private readonly Uri uri;
		protected readonly string platform;

		public DriverFactory(String uri, Dictionary<string, object> deviceMap)
		{
			this.uri = new Uri(uri);
			this.desiredCapabilities = new DesiredCapabilities(deviceMap);
			this.platform = this.desiredCapabilities.GetCapability("platformName").ToString().ToUpper();
		}

		public RemoteWebDriver CreateDriver()
		{
			switch (platform)
			{
				case "DESKTOP":
					return new RemoteWebDriver(uri, desiredCapabilities);
				default:
					throw new ArgumentException($"Platform not implemented: {platform}");
			}
		}
	}
}
