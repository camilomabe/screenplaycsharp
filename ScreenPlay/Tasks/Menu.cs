using OpenQA.Selenium;
using ScreenPlay.Actions;
using ScreenPlay.UI;

namespace ScreenPlay.Tasks
{
    public class Menu
    {
        public static void As(IWebDriver driver)
        {
            Click.On(driver, HomePageUI.MenuLogin);
        }
    }
}
