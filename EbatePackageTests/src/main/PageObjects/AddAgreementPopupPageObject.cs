using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbatePackageTests
{
    class AddAgreementPopupPageObject
    {
        private IWebDriver _webDriver;
        
        public readonly By _startDate = By.XPath("//*[@id=\"periodStart\"]");
        public readonly By _endDate = By.XPath("//*[@id=\"periodEnd\"]");
        public readonly By _budget = By.XPath("//*[@id=\"k - tabstrip - tabpanel - 0\"]/app-package-agreement/app-package-detail-agreement-dialog/kendo-dialog/div[2]/div/form/div/div/div[6]/div[1]/div/kendo-numerictextbox");
        public readonly By _target = By.XPath("//*[@id=\"k - tabstrip - tabpanel - 0\"]/app-package-agreement/app-package-detail-agreement-dialog/kendo-dialog/div[2]/div/form/div/div/div[6]/div[2]/div/kendo-numerictextbox");
        public readonly By _description = By.XPath("//*[@id=\"description\"]");
        public readonly By _saveButton = By.XPath("//*[@id=\"save\"]");
        public readonly By _cancelButton = By.XPath("//*[@id=\"cancel\"]");
        public readonly By _comments = By.XPath("//*[@id=\"comments\"]");

        public AddAgreementPopupPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public LoginTenantTabPageObject SetBudget()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_budget).Click();
            actions.SendKeys("1" + Keys.Enter).Perform();
            return new LoginTenantTabPageObject(_webDriver);
        }
        public LoginTenantTabPageObject SetTarget()
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_target).Click();
            actions.SendKeys("1" + Keys.Enter).Perform();
            return new LoginTenantTabPageObject(_webDriver);
        }
        public LoginTenantTabPageObject ClickSaveButton()
        {
            _webDriver.FindElement(_saveButton).Click();
            return new LoginTenantTabPageObject(_webDriver);
        }
        public LoginTenantTabPageObject ClickCancelButton()
        {
            _webDriver.FindElement(_cancelButton).Click();
            return new LoginTenantTabPageObject(_webDriver);
        }


    }
}




