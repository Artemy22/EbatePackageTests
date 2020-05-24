using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace EbatePackageTests
{
    public class AddPackageForCustomerSingleCompanyTradingGroupOngoing
    {
        private IWebDriver driver;
        private readonly Credentials creds = new Credentials();
        readonly Random rnd = new Random();

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://app.test.e-bate.net/login");
            
        }

        [Test]
        public void AddPackage()
        {

            var loginPage = new LoginTabPageObject(driver);
            var loginTenantnPage = new LoginTenantTabPageObject(driver);
            var mainPageHeaders = new MainMenuPageObject(driver);
            var packagesScreen = new PackagesScreenPageObject(driver);
            var priceManagmentDropDown = new PriceManagmentDropDownPageObject(driver);
            var addPackagePopup = new AddPackagePopupPageObject(driver);
            var actions = new Actions(driver);
            int int0to9 = rnd.Next(0, 9);
                  
            // login flow
           
            loginPage.Login(creds.Email, creds.Password);           
            loginTenantnPage.ChooseFirstTenant();
            mainPageHeaders.ClickPricingManagementHeader();
            priceManagmentDropDown.ClickPackages();
            packagesScreen.ClickAddPackageBtn();

            // add package flow

            addPackagePopup.ClickCustomerType();
            addPackagePopup.SetAccountTypeTradingGroup();
            Thread.Sleep(100);
            addPackagePopup.SetTradingGroupCompany();
            addPackagePopup.SetPeriodOngoing();
            addPackagePopup.SetStartDate();
            addPackagePopup.SetEndDate();
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            string description = "Add Package For Customer Single Company Trading Group Ongoing. Timestamp: " + unixTimestamp;
            addPackagePopup.SetDescription(description);
            addPackagePopup.SetBudget();
            addPackagePopup.SetTarget();
            addPackagePopup.ClickSaveBtn();     
            Thread.Sleep(100);
            packagesScreen.ClickOrderById();
            Thread.Sleep(100);
            packagesScreen.ClickOrderById();
            Thread.Sleep(1000);

            var actualResult = driver.FindElement(By.XPath("//*[@id=\"gridPackageOverview\"]/div/div[2]/kendo-grid/div/kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[6]")).Text;
            Assert.AreEqual(description, actualResult);
        }
        
            [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}