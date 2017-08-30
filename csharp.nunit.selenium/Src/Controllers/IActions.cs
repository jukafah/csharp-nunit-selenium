namespace Csharp.Nunit.Selenium.Controllers
{
    public interface IActions
    {
        IActions Click(string element);
        IActions EnterText(string text, string element);
    }
}