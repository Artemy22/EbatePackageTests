using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace EbatePackageTests
{
    public class AddPackageForSingleCOmpanyOngoingPeriod
    {
        private IWebDriver driver;
        private readonly Credentials creds = new Credentials();
        readonly Random rnd = new Random();

        [SetUp]
        public void Setup()
        {
            driver = WebDriverFactory.CreateWebDriver(WebBrowser.Chrome);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://app.test.e-bate.net/login");
        }

        [Test]
        public void AddPackageForCustomerTradingGroup()
        {

            var loginPage = new LoginTabPageObject(driver);
            var loginTenantnPage = new LoginTenantTabPageObject(driver);
            var mainPageHeaders = new MainMenuPageObject(driver);
            var packagesScreen = new PackagesScreenPageObject(driver);
            var priceManagmentDropDown = new PriceManagmentDropDownPageObject(driver);
            var addPackagePopup = new AddPackagePopupPageObject(driver);
                  
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

        [Test]
        public void AddPackageForCustomerParentAccount()
        {

            var loginPage = new LoginTabPageObject(driver);
            var loginTenantnPage = new LoginTenantTabPageObject(driver);
            var mainPageHeaders = new MainMenuPageObject(driver);
            var packagesScreen = new PackagesScreenPageObject(driver);
            var priceManagmentDropDown = new PriceManagmentDropDownPageObject(driver);
            var addPackagePopup = new AddPackagePopupPageObject(driver);

            // login flow

            loginPage.Login(creds.Email, creds.Password);
            loginTenantnPage.ChooseFirstTenant();
            mainPageHeaders.ClickPricingManagementHeader();
            priceManagmentDropDown.ClickPackages();
            packagesScreen.ClickAddPackageBtn();

            // add package flow

            addPackagePopup.ClickCustomerType();
            addPackagePopup.SetAccountTypeParentAccount();
            Thread.Sleep(100);
            addPackagePopup.SetParentAccountCompany();
            addPackagePopup.SetPeriodOngoing();
            addPackagePopup.SetStartDate();
            addPackagePopup.SetEndDate();
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            string description = "Add Package For Customer Single Company Parent Account Ongoing. Timestamp: " + unixTimestamp;
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
        [Test]
        public void AddPackageForCustomerInvoiceAccount()
        {

            var loginPage = new LoginTabPageObject(driver);
            var loginTenantnPage = new LoginTenantTabPageObject(driver);
            var mainPageHeaders = new MainMenuPageObject(driver);
            var packagesScreen = new PackagesScreenPageObject(driver);
            var priceManagmentDropDown = new PriceManagmentDropDownPageObject(driver);
            var addPackagePopup = new AddPackagePopupPageObject(driver);

            // login flow

            loginPage.Login(creds.Email, creds.Password);
            loginTenantnPage.ChooseFirstTenant();
            mainPageHeaders.ClickPricingManagementHeader();
            priceManagmentDropDown.ClickPackages();
            packagesScreen.ClickAddPackageBtn();

            // add package flow

            addPackagePopup.ClickCustomerType();
            addPackagePopup.SetAccountTypeInvoiceAccount();
            Thread.Sleep(100);
            addPackagePopup.SetInvoiceAccountCompany();
            addPackagePopup.SetPeriodOngoing();
            addPackagePopup.SetStartDate();
            addPackagePopup.SetEndDate();
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            string description = "Add Package For Customer Single Company Invoice Account Ongoing. Timestamp: " + unixTimestamp;
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
        [Test]
        public void AddPackageForCustomerDeliveryAccount()
        {

            var loginPage = new LoginTabPageObject(driver);
            var loginTenantnPage = new LoginTenantTabPageObject(driver);
            var mainPageHeaders = new MainMenuPageObject(driver);
            var packagesScreen = new PackagesScreenPageObject(driver);
            var priceManagmentDropDown = new PriceManagmentDropDownPageObject(driver);
            var addPackagePopup = new AddPackagePopupPageObject(driver);

            // login flow

            loginPage.Login(creds.Email, creds.Password);
            loginTenantnPage.ChooseFirstTenant();
            mainPageHeaders.ClickPricingManagementHeader();
            priceManagmentDropDown.ClickPackages();
            packagesScreen.ClickAddPackageBtn();

            // add package flow

            addPackagePopup.ClickCustomerType();
            addPackagePopup.SetAccountTypeDeliveryAccount();
            Thread.Sleep(100);
            addPackagePopup.SetDeliveryAccountCompany();
            addPackagePopup.SetPeriodOngoing();
            addPackagePopup.SetStartDate();
            addPackagePopup.SetEndDate();
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            string description = "Add Package For Customer Single Company Delivery Account Ongoing. Timestamp: " + unixTimestamp;
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
        [Test]
        public void AddPackageForCustomerDistributor()
        {

            var loginPage = new LoginTabPageObject(driver);
            var loginTenantnPage = new LoginTenantTabPageObject(driver);
            var mainPageHeaders = new MainMenuPageObject(driver);
            var packagesScreen = new PackagesScreenPageObject(driver);
            var priceManagmentDropDown = new PriceManagmentDropDownPageObject(driver);
            var addPackagePopup = new AddPackagePopupPageObject(driver);

            // login flow

            loginPage.Login(creds.Email, creds.Password);
            loginTenantnPage.ChooseFirstTenant();
            mainPageHeaders.ClickPricingManagementHeader();
            priceManagmentDropDown.ClickPackages();
            packagesScreen.ClickAddPackageBtn();

            // add package flow

            addPackagePopup.ClickCustomerType();
            addPackagePopup.SetAccountTypeDistributor();
            Thread.Sleep(100);
            addPackagePopup.SetDistributorCompany();
            addPackagePopup.SetPeriodOngoing();
            addPackagePopup.SetStartDate();
            addPackagePopup.SetEndDate();
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            string description = "Add Package For Customer Single Company Distributor Ongoing. Timestamp: " + unixTimestamp;
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
        [Test]
        public void AddPackageForCustomerLandlord()
        {

            var loginPage = new LoginTabPageObject(driver);
            var loginTenantnPage = new LoginTenantTabPageObject(driver);
            var mainPageHeaders = new MainMenuPageObject(driver);
            var packagesScreen = new PackagesScreenPageObject(driver);
            var priceManagmentDropDown = new PriceManagmentDropDownPageObject(driver);
            var addPackagePopup = new AddPackagePopupPageObject(driver);

            // login flow

            loginPage.Login(creds.Email, creds.Password);
            loginTenantnPage.ChooseFirstTenant();
            mainPageHeaders.ClickPricingManagementHeader();
            priceManagmentDropDown.ClickPackages();
            packagesScreen.ClickAddPackageBtn();

            // add package flow

            addPackagePopup.ClickCustomerType();
            addPackagePopup.SetAccountTypeLandlord();
            Thread.Sleep(100);
            addPackagePopup.SetLandlordCompany();
            addPackagePopup.SetPeriodOngoing();
            addPackagePopup.SetStartDate();
            addPackagePopup.SetEndDate();
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            string description = "Add Package For Customer Single Company Landlord Ongoing. Timestamp: " + unixTimestamp;
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
        [Test]
        public void AddPackageForCustomerMerchantDistribution()
        {

            var loginPage = new LoginTabPageObject(driver);
            var loginTenantnPage = new LoginTenantTabPageObject(driver);
            var mainPageHeaders = new MainMenuPageObject(driver);
            var packagesScreen = new PackagesScreenPageObject(driver);
            var priceManagmentDropDown = new PriceManagmentDropDownPageObject(driver);
            var addPackagePopup = new AddPackagePopupPageObject(driver);

            // login flow

            loginPage.Login(creds.Email, creds.Password);
            loginTenantnPage.ChooseFirstTenant();
            mainPageHeaders.ClickPricingManagementHeader();
            priceManagmentDropDown.ClickPackages();
            packagesScreen.ClickAddPackageBtn();

            // add package flow

            addPackagePopup.ClickCustomerType();
            addPackagePopup.SetAccountTypeMerchantDistribution();
            Thread.Sleep(100);
            addPackagePopup.SetMerchantDistributionCompany();
            addPackagePopup.SetPeriodOngoing();
            addPackagePopup.SetStartDate();
            addPackagePopup.SetEndDate();
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            string description = "Add Package For Customer Single Company Merchant Distribution Ongoing. Timestamp: " + unixTimestamp;
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
        [Test]
        public void AddPackageForCustomerManufacturer()
        {

            var loginPage = new LoginTabPageObject(driver);
            var loginTenantnPage = new LoginTenantTabPageObject(driver);
            var mainPageHeaders = new MainMenuPageObject(driver);
            var packagesScreen = new PackagesScreenPageObject(driver);
            var priceManagmentDropDown = new PriceManagmentDropDownPageObject(driver);
            var addPackagePopup = new AddPackagePopupPageObject(driver);

            // login flow

            loginPage.Login(creds.Email, creds.Password);
            loginTenantnPage.ChooseFirstTenant();
            mainPageHeaders.ClickPricingManagementHeader();
            priceManagmentDropDown.ClickPackages();
            packagesScreen.ClickAddPackageBtn();

            // add package flow

            addPackagePopup.ClickCustomerType();
            addPackagePopup.SetAccountTypeManufacturer();
            Thread.Sleep(100);
            addPackagePopup.SetManufacturerCompany();
            addPackagePopup.SetPeriodOngoing();
            addPackagePopup.SetStartDate();
            addPackagePopup.SetEndDate();
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            string description = "Add Package For Customer Single Company Manufacturer Ongoing. Timestamp: " + unixTimestamp;
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
        [Test]
        public void AddPackageForCustomerContractor()
        {

            var loginPage = new LoginTabPageObject(driver);
            var loginTenantnPage = new LoginTenantTabPageObject(driver);
            var mainPageHeaders = new MainMenuPageObject(driver);
            var packagesScreen = new PackagesScreenPageObject(driver);
            var priceManagmentDropDown = new PriceManagmentDropDownPageObject(driver);
            var addPackagePopup = new AddPackagePopupPageObject(driver);

            // login flow

            loginPage.Login(creds.Email, creds.Password);
            loginTenantnPage.ChooseFirstTenant();
            mainPageHeaders.ClickPricingManagementHeader();
            priceManagmentDropDown.ClickPackages();
            packagesScreen.ClickAddPackageBtn();

            // add package flow

            addPackagePopup.ClickCustomerType();
            addPackagePopup.SetAccountTypeContractor();
            Thread.Sleep(100);
            addPackagePopup.SetContractorCompany();
            addPackagePopup.SetPeriodOngoing();
            addPackagePopup.SetStartDate();
            addPackagePopup.SetEndDate();
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            string description = "Add Package For Customer Single Company Contractor Ongoing. Timestamp: " + unixTimestamp;
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