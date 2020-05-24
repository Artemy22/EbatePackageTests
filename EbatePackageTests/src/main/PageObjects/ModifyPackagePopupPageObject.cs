using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbatePackageTests
{
    class ModifyPackagePopupPageObject
    {
        private IWebDriver _webDriver;
        readonly Random rnd = new Random();

        public readonly By _periodDropDown = By.XPath("//*[@id=\"period\"]");
        public readonly By _startDate = By.XPath("//*[@id=\"periodStart\"]");
        public readonly By _endDate = By.XPath("//*[@id=\"periodEnd\"]");
        public readonly By _descriptionInput = By.XPath("//*[@id=\"description\"]");
        public readonly By _budgetInput = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/div/form/div/div/div[4]/div[1]/div/kendo-numerictextbox");
        public readonly By _targetInput = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/div/form/div/div/div[4]/div[2]/div/kendo-numerictextbox");
        public readonly By _commentsInput = By.XPath("//*[@id=\"comments\"]");
        public readonly By _saveBtn = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/kendo-dialog-actions/button[1]");
        public readonly By _cancelBtn = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/app-package-dialog/kendo-dialog/div[2]/kendo-dialog-actions/button[2]");

        public ModifyPackagePopupPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
           
        public ModifyPackagePopupPageObject SetNewStartDate(string newStartDate)
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_startDate).Click();
            actions.SendKeys(Keys.Home).Perform();
            actions.SendKeys(newStartDate).Perform();
            return new ModifyPackagePopupPageObject(_webDriver);
        }
        public ModifyPackagePopupPageObject SetNewEndDate(string newEndDate)
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_endDate).Click();
            actions.SendKeys(Keys.Home).Perform();
            actions.SendKeys(newEndDate).Perform();
            return new ModifyPackagePopupPageObject(_webDriver);
        }
        public ModifyPackagePopupPageObject SetDescription(string description)
        {
            Actions actions = new Actions(_webDriver);
            _webDriver.FindElement(_descriptionInput).Click();
            actions.SendKeys(description).Perform();
            return new ModifyPackagePopupPageObject(_webDriver);
        }        
    }
}
