using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbatePackageTests
{
    class AddPackagePopupPageObject
    {
        private IWebDriver _webDriver;

        public readonly By _CustomerType = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/div/form/div/div/app-company-selection/form/div[1]/div/div/div/fieldset/label[1]");
        public readonly By _SupplierType = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/div/form/div/div/app-company-selection/form/div[1]/div/div/div/fieldset/label[2]");
        public readonly By _DistributorType = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/div/form/div/div/app-company-selection/form/div[1]/div/div/div/fieldset/label[3]");
        public readonly By _ChannelType = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/div/form/div/div/app-company-selection/form/div[1]/div/div/div/fieldset/label[4]");
        public readonly By _SingleCompany = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/div/form/div/div/app-company-selection/form/div[2]/div/div/fieldset/div[1]/label[1]");
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

        public MainMenuPageObject ClickCustomerType()
        {
            _webDriver.FindElement(_CustomerType).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickSupplierType()
        {
            _webDriver.FindElement(_SupplierType).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickDistributorType()
        {
            _webDriver.FindElement(_DistributorType).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickChannelType()
        {
            _webDriver.FindElement(_ChannelType).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickSingleCompany()
        {
            _webDriver.FindElement(_SingleCompany).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickSingleCompanyAccountTypeDropDown()
        {
            _webDriver.FindElement(_SingleCompanyAccountTypeDropDown).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickAllCompanies()
        {
            _webDriver.FindElement(_AllCompanies).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickPeriodInput()
        {
            _webDriver.FindElement(_periodInput).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickStartDate()
        {
            _webDriver.FindElement(_startDate).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickEndDate()
        {
            _webDriver.FindElement(_endDate).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickDescription()
        {
            _webDriver.FindElement(_description).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickBudget()
        {
            _webDriver.FindElement(_budget).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickTarget()
        {
            _webDriver.FindElement(_target).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickComments()
        {
            _webDriver.FindElement(_comments).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickSaveBtn()
        {
            _webDriver.FindElement(_saveBtn).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickCancelBtn()
        {
            _webDriver.FindElement(_cancelBtn).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickAccountTypeDropDown()
        {
            _webDriver.FindElement(_accountTypeDropDown).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickCompanyNameDropDown()
        {
            _webDriver.FindElement(_companyNameDropDown).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject SetChosenCompany()
        {
            _webDriver.FindElement(_setChosenCompany).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject getActualResult()
        {
            _webDriver.FindElement(_actualResult);
            return new MainMenuPageObject(_webDriver);
        }
    }
}
