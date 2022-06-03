using OpenQA.Selenium;
using ScreenPlay.Actions;
using System;

namespace ScreenPlay.Tasks
{
    public class AcceptAlert
    {
        public static bool Success(IWebDriver driver)
        {
            return Accept.Alert(driver);
        }
    }
}
