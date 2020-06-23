using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowTest.Steps
{
    [Binding]
    public class EBD_190_Add_AgreementSteps
    {
        private IWebDriver driver;
        string description;

        [Given(@"Open chrome")]
        public void GivenOpenChrome()
        {
            driver = WebDriverFactory.CreateWebDriver(WebBrowser.Chrome);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://app.test.e-bate.net/login");
        }
        
        [Given(@"Open Package")]
        public void GivenOpenPackage()
        {
            Basic basic = new Basic();
            Actions action = new Actions(driver);
            MainMenuPageObject mainMenuPageObject = new MainMenuPageObject(driver);
            PackagesScreenPageObject packagesScreenPageObject = new PackagesScreenPageObject(driver);
            PriceManagmentDropDownPageObject priceManagmentDropDownPageObject = new PriceManagmentDropDownPageObject(driver);
            PackageEditorScreenPageObject packageEditorScreenPageObject = new PackageEditorScreenPageObject(driver);

            basic.LoginFlow(driver);
            mainMenuPageObject.ClickPricingManagementHeader();
            priceManagmentDropDownPageObject.ClickPackages();
            packagesScreenPageObject.ClickSearchInput();
            action.SendKeys("owasp test").Perform();
            Thread.Sleep(1500);
            packagesScreenPageObject.ClickOrderById().ClickOrderById().SelectFirstRow();
            packagesScreenPageObject.ClickActionViewButton();
            Thread.Sleep(1500);
            //if (packageEditorScreenPageObject.IfCriteriaPopupAppeared() == true)
            //{
                packageEditorScreenPageObject.ClickNoButtonAddCriteria();
            //}
            Thread.Sleep(1500);
            packageEditorScreenPageObject.ClickTabsAgreements();
            packageEditorScreenPageObject.ClickTabsAgreementsAddNewBtn();            
        }

        [When(@"Add agreement to the package")]
        public void WhenAddAgreementToThePackage()
        {            
            
        }
        
        [Then(@"Save the Agreement")]
        public void ThenSaveTheAgreement()
        {
            
            
            
        }
    }
}
