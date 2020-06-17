using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EbatePackageTests
{
    class AddPackagePopupPageObject
    {
        
        private IWebDriver _webDriver;
        readonly Random rnd = new Random();

        public readonly By _CustomerType = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/div/form/div/div/app-company-selection/form/div[1]/div/div/div/fieldset/label[1]");
        public readonly By _SupplierType = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/div/form/div/div/app-company-selection/form/div[1]/div/div/div/fieldset/label[2]");
        public readonly By _DistributorType = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/div/form/div/div/app-company-selection/form/div[1]/div/div/div/fieldset/label[3]");
        public readonly By _ChannelType = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/div/form/div/div/app-company-selection/form/div[1]/div/div/div/fieldset/label[4]");
        public readonly By _SingleCompany = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/div/form/div/div/app-company-selection/form/div[2]/div/div/fieldset/div[1]/label[1]]");
        public readonly By _SingleCompanyAccountTypeDropDown = By.XPath("//*[@id=\"companySelectionAccountType\"]");
        public readonly By _AllCompanies = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/div/form/div/div/app-company-selection/form/div[2]/div/div/fieldset/div[1]/label[2]");
        public readonly By _periodInput = By.XPath("//*[@id=\"period\"]");
        public readonly By _startDate = By.XPath("//*[@id=\"periodStart\"]/span");
        public readonly By _endDate = By.XPath("//*[@id=\"periodEnd\"]/span");
        public readonly By _description = By.XPath("//*[@id=\"description\"]");
        public readonly By _budget = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/div/form/div/div/div[4]/div[1]/div/kendo-numerictextbox/span");
        public readonly By _target = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/div/form/div/div/div[4]/div[2]/div/kendo-numerictextbox/span");
        public readonly By _comments = By.XPath("//*[@id=\"comments\"]");
        public readonly By _saveBtn = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/kendo-dialog-actions/button[1]");
        public readonly By _cancelBtn = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/kendo-dialog-actions/button[2]");
        public readonly By _accountTypeDropDown = By.XPath("//*[@id=\"companySelectionAccountType\"]");
        public readonly By _companyNameDropDown = By.XPath("//*[@id=\"companiesSearch\"]/span/kendo-searchbar");
        public readonly By _setChosenCompany = By.XPath("//*[@id=\"csButtons\"]/button[1]");
        public readonly By _actualResult = By.XPath("//*[@id=\"gridPackageOverview\"]/div/div[2]/kendo-grid/div/kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[6]");


        public AddPackagePopupPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public AddPackagePopupPageObject ClickCustomerType()
        {
            _webDriver.FindElement(_CustomerType).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject ClickSupplierType()
        {
            _webDriver.FindElement(_SupplierType).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject ClickDistributorType()
        {
            _webDriver.FindElement(_DistributorType).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject ClickChannelType()
        {
            _webDriver.FindElement(_ChannelType).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject ClickCompanySelection()
        {
            _webDriver.FindElement(_SingleCompany).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject ClickSingleCompanyAccountTypeDropDown()
        {
            _webDriver.FindElement(_SingleCompanyAccountTypeDropDown).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject ClickAllCompanies()
        {
            _webDriver.FindElement(_AllCompanies).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetPeriodOngoing()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_periodInput).Click();
            actions.SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown).Perform();
            return new AddPackagePopupPageObject(_webDriver);
        }

        public string StartDateGenerator()
        {
            int int0to9 = rnd.Next(0, 9);
            string startDate = "0101200" + int0to9;
            return startDate;
        }

        public string EndDateGenerator()
        {
            int intFirst = rnd.Next(1, 9);
            int intSecond = rnd.Next(0, 9);
            string endDate = "010120" + intFirst + intSecond;
            return endDate;
        }

        public AddPackagePopupPageObject SetStartDate()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_startDate).Click();
            actions.SendKeys(Keys.Home).Perform();
            actions.SendKeys(StartDateGenerator()).Perform();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetEndDate()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_endDate).Click();
            actions.SendKeys(Keys.Home).Perform();
            actions.SendKeys(EndDateGenerator()).Perform();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetDescription(string description)
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_description).Click();
            actions.SendKeys(description).Perform();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetBudget()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_budget).Click();
            actions.SendKeys("1").Perform();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetTarget()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_target).Click();
            actions.SendKeys("1").Perform();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject ClickComments()
        {
            _webDriver.FindElement(_comments).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject ClickSaveBtn()
        {
            _webDriver.FindElement(_saveBtn).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject ClickCancelBtn()
        {
            _webDriver.FindElement(_cancelBtn).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }

        public AddPackagePopupPageObject SetAccountTypeTradingGroup()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_accountTypeDropDown).Click();
            actions.SendKeys(Keys.Enter).Perform(); 
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetAccountTypeParentAccount()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_accountTypeDropDown).Click();
            actions.SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter).Perform();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetAccountTypeInvoiceAccount()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_accountTypeDropDown).Click();
            actions.SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.Enter).Perform();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetAccountTypeDeliveryAccount()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_accountTypeDropDown).Click();
            actions.SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.Enter).Perform();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetAccountTypeDistributor()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_accountTypeDropDown).Click();
            actions.SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.Enter).Perform();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetAccountTypeLandlord()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_accountTypeDropDown).Click();
            actions.SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.Enter).Perform();
            return new AddPackagePopupPageObject(_webDriver);
        }
        
        public AddPackagePopupPageObject SetAccountTypeMerchantDistribution()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_accountTypeDropDown).Click();
            actions.SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.Enter).Perform();
            return new AddPackagePopupPageObject(_webDriver);
        }
        
        public AddPackagePopupPageObject SetAccountTypeManufacturer()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_accountTypeDropDown).Click();
            actions.SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.Enter).Perform();
            return new AddPackagePopupPageObject(_webDriver);
        }
        
        public AddPackagePopupPageObject SetAccountTypeContractor()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_accountTypeDropDown).Click();
            actions.SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.Enter).Perform();
            return new AddPackagePopupPageObject(_webDriver);
        }

        public AddPackagePopupPageObject SetTradingGroupCompany()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_companyNameDropDown).Click();
            actions.SendKeys("qa").Perform();
            Thread.Sleep(500);
            actions.SendKeys(Keys.ArrowDown + Keys.Enter).Perform();
            _webDriver.FindElement(_setChosenCompany).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }

        public AddPackagePopupPageObject SetParentAccountCompany()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_companyNameDropDown).Click();
            actions.SendKeys("pa").Perform();
            Thread.Sleep(500);
            actions.SendKeys(Keys.ArrowDown + Keys.Enter).Perform();
            _webDriver.FindElement(_setChosenCompany).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetInvoiceAccountCompany()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_companyNameDropDown).Click();
            actions.SendKeys("art").Perform();
            Thread.Sleep(500);
            actions.SendKeys(Keys.ArrowDown + Keys.Enter).Perform();
            _webDriver.FindElement(_setChosenCompany).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetDeliveryAccountCompany()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_companyNameDropDown).Click();
            actions.SendKeys("del").Perform();
            Thread.Sleep(500);
            actions.SendKeys(Keys.ArrowDown + Keys.Enter).Perform();
            _webDriver.FindElement(_setChosenCompany).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetDistributorCompany()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_companyNameDropDown).Click();
            actions.SendKeys("dis").Perform();
            Thread.Sleep(500);
            actions.SendKeys(Keys.ArrowDown + Keys.Enter).Perform();
            _webDriver.FindElement(_setChosenCompany).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetLandlordCompany()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_companyNameDropDown).Click();
            actions.SendKeys("land").Perform();
            Thread.Sleep(500);
            actions.SendKeys(Keys.ArrowDown + Keys.Enter).Perform();
            _webDriver.FindElement(_setChosenCompany).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetMerchantDistributionCompany()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_companyNameDropDown).Click();
            actions.SendKeys("merch").Perform();
            Thread.Sleep(500);
            actions.SendKeys(Keys.ArrowDown + Keys.Enter).Perform();
            _webDriver.FindElement(_setChosenCompany).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetManufacturerCompany()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_companyNameDropDown).Click();
            actions.SendKeys("man").Perform();
            Thread.Sleep(500);
            actions.SendKeys(Keys.ArrowDown + Keys.Enter).Perform();
            _webDriver.FindElement(_setChosenCompany).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }
        public AddPackagePopupPageObject SetContractorCompany()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_companyNameDropDown).Click();
            actions.SendKeys("cont").Perform();
            Thread.Sleep(500);
            actions.SendKeys(Keys.ArrowDown + Keys.Enter).Perform();
            _webDriver.FindElement(_setChosenCompany).Click();
            return new AddPackagePopupPageObject(_webDriver);
        }

        public AddPackagePopupPageObject getActualResult()
        {
            _webDriver.FindElement(_actualResult);
            return new AddPackagePopupPageObject(_webDriver);
        }
    }
}
