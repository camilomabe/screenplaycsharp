using OpenQA.Selenium;
using ScreenPlay.Actions;
using ScreenPlay.UI;
using System;

namespace ScreenPlay.Tasks
{
    public class IsPayFormPresent
    {
        public static bool Pay(IWebDriver driver)
        {
            return WaitUntil.ElementIsPresent(driver, PayFormUI.PayFormHome);
        }
    }
}
