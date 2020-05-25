using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Threading;

namespace EbatePackageTests
{
    public class LoginTest
    {
        private IWebDriver driver;
        private readonly Credentials creds = new Credentials();

        [SetUp]
        public void Setup()
        {
            driver = WebDriverFactory.CreateWebDriver(WebBrowser.Firefox);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://app.test.e-bate.net/login");
        }

        [Test]
        public void Test1()
        {
            var loginPage = new LoginTabPageObject(driver);
            var loginTenantnPage = new LoginTenantTabPageObject(driver);

            loginPage.Login(creds.Email, creds.Password);
            Thread.Sleep(1000);
            loginTenantnPage.ChooseFirstTenant();
            string expectedResult = "Artem Ivanov";

            var actualResult = driver.FindElement(By.XPath("//*[@id=\"userMenu\"]/span")).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}