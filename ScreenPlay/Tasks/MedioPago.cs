using OpenQA.Selenium;
using ScreenPlay.Actions;
using ScreenPlay.UI;
using System;

namespace ScreenPlay.Tasks
{
    public class MedioPago
    {
        public static void OpcionPago(IWebDriver driver, string pago)
        {
            if (pago == "Credito")
            {
                Click.On(driver, PayFormUI.credit);
            }
            if (pago == "Debito")
            {
                Click.On(driver, PayFormUI.debit);
            }
            if (pago == "PayPal")
            {
                Click.On(driver, PayFormUI.paypal);
            }
        }
    }
}
