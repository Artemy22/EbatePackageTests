using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace EbatePackageTests
{
    public class AddPackageForCustomerSingleCompanyInvoiceAccountOngoing
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
            addPackagePopup.ClickSingleCompanyAccountTypeDropDown();            
            //actions.SendKeys(Keys.ArrowDown).Perform();            
            actions.SendKeys(Keys.Enter).Perform();
            addPackagePopup.ClickCompanyNameDropDown();            
            actions.SendKeys(Keys.Space).Perform();
            actions.SendKeys(Keys.Space).Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.ArrowDown).Perform();
            actions.SendKeys(Keys.ArrowDown).Perform();
            actions.SendKeys(Keys.Enter).Perform(); // QA trade company is chosen
            addPackagePopup.SetChosenCompany();
            addPackagePopup.ClickPeriodInput();
            for (int i = 0; i < 6; i++)
            {
                actions.SendKeys(Keys.ArrowDown).Perform();  // Period date ONGOING
            }

            addPackagePopup.ClickDescription();
            string description = "Selenium Add Package For Customer Single Company Trade Group Ongoing - " + int0to9*int0to9;
            actions.SendKeys(description).Perform();

            addPackagePopup.ClickBudget();
            actions.SendKeys("1").Perform();
            addPackagePopup.ClickTarget();
            actions.SendKeys("1").Perform();

            addPackagePopup.ClickStartDate();
            actions.SendKeys(Keys.Home).Perform();
            string startDate = "1001200" + int0to9;
            actions.SendKeys(startDate).Perform();

            addPackagePopup.ClickEndDate();
            actions.SendKeys(Keys.Home).Perform();
            string endDate = "3012202" + int0to9;
            actions.SendKeys(endDate).Perform();


            addPackagePopup.ClickSaveBtn();
            Thread.Sleep(500);
            packagesScreen.ClickOrderById();
            Thread.Sleep(500);
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