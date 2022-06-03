using OpenQA.Selenium;
using ScreenPlay.Actions;
using ScreenPlay.UI;
using System;

namespace ScreenPlay.Tasks
{
    public class IsEmployeePresent
    {
        public static bool Form(IWebDriver driver)
        {
            return WaitUntil.ElementIsPresent(driver, PayFormUI.PayFormHome);
        }
    }
}
