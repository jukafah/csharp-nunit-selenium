using Csharp.Nunit.Selenium.Screens;

namespace Csharp.Nunit.Selenium.Controllers
{
    public interface IScreen
    {
//        IScreen NavigateTo();
        GoogleScreen GoogleScreen();
        AppiumScreen AppiumScreen();
        JetBrainsScreen JetBrainsScreen();
        SeleniumScreen SeleniumScreen();
//        ScreenObject Url(string destination);
        // implement additional screens
    }
}