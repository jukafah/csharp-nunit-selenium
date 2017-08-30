using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json.Linq;


namespace Csharp.Nunit.Selenium.Test.Config
{
    public class Configuration
    {
        public readonly string uri;
        public readonly Dictionary<string, object> deviceMap;

        public Configuration()
        {
            this.uri = Environment.GetEnvironmentVariable("uri") ?? "http://127.0.0.1:4444/wd/hub";
            this.deviceMap = GetDevice();
        }

        Dictionary<string, object> GetDevice()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream deviceStream = assembly.GetManifestResourceStream("Csharp.Nunit.Selenium.Test.Resources.devices.json");
            if (deviceStream == null)
                throw new FileNotFoundException("Could not find devices.json resource");
            
            StreamReader reader = new StreamReader(deviceStream);
            JObject obj = JObject.Parse(reader.ReadToEnd());

            string deviceName = Environment.GetEnvironmentVariable("DEVICE") ?? "Chrome";

            var node = obj[deviceName];
            Dictionary<string, object> map = new Dictionary<string, object>();
            map = node.ToObject<Dictionary<string, object>>();

            return map;
        }
    }
}