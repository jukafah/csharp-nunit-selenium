using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

using Csharp.Nunit.Selenium.Data;

namespace Csharp.Nunit.Selenium.Data
{
	public class TestData
	{
		public readonly User User;

		public TestData()
		{
			this.User = LoadTestData();
		}
		
		User LoadTestData()
		{
			Assembly assembly = Assembly.GetExecutingAssembly();
			Stream userStream = assembly.GetManifestResourceStream("Csharp.Nunit.Selenium.Test.Resources.Users.smomcilovic.json");
			
			if (userStream == null)
				throw new FileNotFoundException("Could not find user.json resource");
			
			StreamReader streamReader = new StreamReader(userStream);
			JObject obj = JObject.Parse(streamReader.ReadToEnd());

			// set default if not provided
			string user = Environment.GetEnvironmentVariable("user") ?? "smomcilovic";

			var node = obj[user];

			return node.ToObject<User>();
		}
	}
}