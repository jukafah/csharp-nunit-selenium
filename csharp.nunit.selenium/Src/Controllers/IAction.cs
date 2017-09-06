namespace Csharp.Nunit.Selenium.Controllers
{
    public interface IAction<out T>
    {
        T Navigate();
        T Navigate(string destination);
        
        // additional navigation
    }
}