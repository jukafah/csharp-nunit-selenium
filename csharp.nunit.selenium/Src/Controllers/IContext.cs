using Csharp.Nunit.Selenium.Screens;

namespace Csharp.Nunit.Selenium.Controllers
{
    public interface IContext
    {
        GoogleScreen GoogleScreen();
        AppiumScreen AppiumScreen();
        JetBrainsScreen JetBrainsScreen();
        SeleniumScreen SeleniumScreen();
        
        // additional screens here
    }
}