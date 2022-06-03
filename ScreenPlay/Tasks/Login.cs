using OpenQA.Selenium;
using ScreenPlay.Actions;
using ScreenPlay.UI;
using System.Threading;

namespace ScreenPlay.Tasks
{
    public class Login
    {
        public static void As(IWebDriver driver, string user, string passWord)
        {
            Click.On(driver, HomePageUI.MenuLogin);
            Enter.Text(driver, LoginUI.UserInput, user);
            Enter.Text(driver, LoginUI.PassWordInput, passWord);
            Click.On(driver, LoginUI.LoginButton);
        }
    }
}
