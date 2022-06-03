using OpenQA.Selenium;
using System.Threading;

namespace ScreenPlay.Tasks
{
    public class ScrollDown
    {
        internal static void Scrolldown(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(6, document.body.scrollHeight)");
            Thread.Sleep(2000);
        }
    }
}
