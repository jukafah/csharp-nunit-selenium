using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace Csharp.Nunit.Selenium.Controllers
{
    public interface IAction<out T>
    {
        T EnterText(string field, string text);
//        T GetElement(List<IWebElement> elements, string targt);
        T GetElement(string element);
    }
}