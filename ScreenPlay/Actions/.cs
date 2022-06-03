using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ScreenPlay.Actions
{
    public class Select
    {
        public static void Text(IWebDriver driver, By locator, string text)
        {
            new SelectElement(driver.FindElement(locator)).SelectByText(text);
        }
    }
}


