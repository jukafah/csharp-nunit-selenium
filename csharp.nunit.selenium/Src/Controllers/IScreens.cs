using Csharp.Nunit.Selenium.Screens;

namespace Csharp.Nunit.Selenium.Controllers
{
    public interface IScreens
    {
        GoogleScreen GoogleScreen();
        AppiumScreen AppiumScreen();
        JetBrainsScreen JetBrainsScreen();
        SeleniumScreen SeleniumScreen();
        Screen Url(string destination);

        // additional screens here
    }
}