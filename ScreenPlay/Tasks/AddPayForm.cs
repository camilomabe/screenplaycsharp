using OpenQA.Selenium;
using ScreenPlay.Actions;
using ScreenPlay.Test;
using ScreenPlay.UI;
using System;
using System.Threading;

namespace ScreenPlay.Tasks
{
    public class AddPayForm
    {
        public static void WithTheData(IWebDriver driver, 
            string pais, string ciudad, string firstName, string lastName, string userName, 
            string email, string address, string address2, string country, string state,
            string zip, string pago, string ccName,string ccNumber,string ccExpiration, string ccCvv)
        {
            Thread.Sleep(3000);
            Select.Text(driver, PayFormUI.pais, pais);
            Select.Text(driver, PayFormUI.ciudad, ciudad);
            Enter.Text(driver, PayFormUI.firstName, firstName);
            Enter.Text(driver, PayFormUI.lastName, lastName);
            Enter.Text(driver, PayFormUI.email, email);
            Enter.Text(driver, PayFormUI.username, userName);
            Enter.Text(driver, PayFormUI.address, address);
            Enter.Text(driver, PayFormUI.address2, address2);
            Select.Text(driver, PayFormUI.country, country);
            Select.Text(driver, PayFormUI.state, state);
            Enter.Text(driver, PayFormUI.zip, zip);
            Click.On(driver, PayFormUI.sameAddress);
            Click.On(driver, PayFormUI.saveInfo);
            MedioPago.OpcionPago(driver, pago);
            Enter.Text(driver, PayFormUI.ccName, ccName);
            Enter.Text(driver, PayFormUI.ccNumber, ccNumber);
            Enter.Text(driver, PayFormUI.ccExpiration, ccExpiration);
            Enter.Text(driver, PayFormUI.ccCvv, ccCvv);
            ScrollDown.Scrolldown(driver);
            Click.On(driver, PayFormUI.btnContinue);
        }
    }
}
