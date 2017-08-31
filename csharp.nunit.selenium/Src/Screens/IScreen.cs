using Csharp.Nunit.Selenium.Screens;
using OpenQA.Selenium.Remote;

namespace Csharp.Nunit.Selenium.Screens
{
    public interface IScreen<out T>
    {
        T Trait();
        T Navigate();
        // implement additional screen requirements
    }
}