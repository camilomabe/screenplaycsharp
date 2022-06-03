using NUnit.Framework;
using ScreenPlay.Tasks;
using System;
using System.Threading;

namespace ScreenPlay.Test
{
    [TestFixture]
    public class EmployeeTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Login.As(driver, "admin", "admin123");
        }

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
                Console.WriteLine("Error en: " + ex);
            }
        }


        [Test]
        public void TestCredito()
        {
            try
            {
                AddPayForm.WithTheData(driver, "Mexico", "Ciudad de México", "Camilo", "Mamian Becerra", "email@gmail.com", "opcional@gmail.com", "Direccion", "Direccion Opc", "Argentina", "Buenos Aires", "111158001", "Credito", "Camilo Mamian Becerra", "258-256-249-5", "12-2026", "258");
                Assert.IsTrue(AcceptAlert.Success(driver));
                Thread.Sleep(4000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en: " + ex);
            }
        }

        [Test]
        public void TestDebito()
        {
            try
            {
                AddPayForm.WithTheData(driver, "Mexico", "Ciudad de México", "Camilo", "Mamian Becerra", "email@gmail.com", "opcional@gmail.com", "Direccion", "Direccion Opc", "Argentina", "Buenos Aires", "111158001", "Debito", "Camilo Mamian Becerra", "258-256-249-5", "12-2026", "258");
                Assert.IsTrue(AcceptAlert.Success(driver));
                Thread.Sleep(4000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en: " + ex);
            }
        }

        [Test]
        public void TestPayPal()
        {
            try
            {
                AddPayForm.WithTheData(driver, "Mexico", "Ciudad de México", "Camilo", "Mamian Becerra", "email@gmail.com", "opcional@gmail.com", "Direccion", "Direccion Opc", "Argentina", "Buenos Aires", "111158001", "PayPal", "Camilo Mamian Becerra", "258-256-249-5", "12-2026", "258");
                Assert.IsTrue(AcceptAlert.Success(driver));
                Thread.Sleep(4000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en: " + ex);
            }
        }
    }
}
