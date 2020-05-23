using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace EbatePackageTests
{
    public class AddPackageTest
    {
        private IWebDriver driver;
        private readonly Credentials creds = new Credentials();
      
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://app.test.e-bate.net/login");
            
        }

        [Test]
        public void AddPackageForCustomerAllCompaniesOngoingTest()
        {
            var loginPage = new LoginTabPageObject(driver);
            var loginTenantnPage = new LoginTenantTabPageObject(driver);
            var mainPageHeaders = new MainMenuPageObject(driver);

            loginPage.Login(creds.Email, creds.Password);           
            loginTenantnPage.ChooseFirstTenant();
            mainPageHeaders.ClickMeinentanceHeader();


            Assert.Pass();
        }
    }
}