using Csharp.Nunit.Selenium.Screens;

namespace Csharp.Nunit.Selenium.Controllers
{
    public interface IScreen
    {
        GoogleScreen GoogleScreen();
        AppiumScreen AppiumScreen();
        JetBrainsScreen JetBrainsScreen();
        SeleniumScreen SeleniumScreen();
    }
}