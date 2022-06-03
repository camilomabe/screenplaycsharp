using NUnit.Framework;
using ScreenPlay.Tasks;
using System;

namespace ScreenPlay.Test
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        [Test]
        public void SuccessfulLogin()
        {
            try
            {
                Login.As(driver, "admin", "admin123");
                Assert.IsTrue(IsPayFormPresent.Pay(driver));
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en: "+ex);
            }
        }
    }
}
