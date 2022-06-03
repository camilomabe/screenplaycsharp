using OpenQA.Selenium;

namespace ScreenPlay.UI
{
    public class PayFormUI
    {
        public static By PayFormHome = By.XPath("//h2[contains(text(),'Formulario de pago')]");

        public static By pais = By.XPath("//select[@id='pais']");
        public static By ciudad = By.XPath("//select[@id='ciudad']");
        public static By firstName = By.XPath("//input[@id='firstName']");
        public static By lastName = By.XPath("//input[@id='lastName']");
        public static By username = By.XPath("//input[@id='username']");
        public static By email = By.XPath("//input[@id='email']");
        public static By address = By.XPath("//input[@id='address']");
        public static By address2 = By.XPath("//input[@id='address2']");
        public static By country = By.XPath("//select[@id='country']");
        public static By state = By.XPath("//select[@id='state']");
        public static By zip = By.XPath("//input[@id='zip']");
        public static By sameAddress = By.XPath("//input[@id='same-address']");
        public static By saveInfo = By.XPath("//input[@id='save-info']");
        public static By credit = By.XPath("//input[@id='credit']");
        public static By debit = By.XPath("//input[@id='debit']");
        public static By paypal = By.XPath("//input[@id='paypal']");
        public static By ccName = By.XPath("//input[@id='cc-name']");
        public static By ccNumber = By.XPath("//input[@id='cc-number']");
        public static By ccExpiration = By.XPath("//input[@id='cc-expiration']");
        public static By ccCvv = By.XPath("//input[@id='cc-cvv']");
        public static By btnContinue = By.XPath("//button[contains(text(),'Continue to checkout')]");

    }
}
