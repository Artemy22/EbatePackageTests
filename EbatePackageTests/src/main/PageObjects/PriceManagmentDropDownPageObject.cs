using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbatePackageTests
{
    class PriceManagmentDropDownPageObject
    {
        private IWebDriver _webDriver;

        public readonly By _packages = By.XPath("//*[@id=\"packages\"]");
        public readonly By _agreements = By.XPath("//*[@id=\"agreements\"]");
        public readonly By _approvals = By.XPath("//*[@id=\"approvals\"]");
        public readonly By _calcEngineStatus = By.XPath("//*[@id=\"testHarnessLink\"]");


        public PriceManagmentDropDownPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainMenuPageObject ClickPackages()
        {
            _webDriver.FindElement(_packages).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickAgreements()
        {
            _webDriver.FindElement(_agreements).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickApprovals()
        {
            _webDriver.FindElement(_approvals).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickCalcEngineStatus()
        {
            _webDriver.FindElement(_calcEngineStatus).Click();
            return new MainMenuPageObject(_webDriver);
        }
    }
}
