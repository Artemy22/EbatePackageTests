using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbatePackageTests
{
    class MainMenuPageObject
    {
        private IWebDriver _webDriver;

        public readonly By _mainLogo = By.XPath("//*[@id=\"menuLogo\"]");
        public readonly By _meinentanceHeader = By.XPath("//*[@id=\"maintenance\"]");
        public readonly By _pricingManagementHeader = By.XPath("//*[@id=\"pricingManagement\"]");
        public readonly By _financeHeader = By.XPath("//*[@id=\"finance\"]");
        public readonly By _reportingHeader = By.XPath("//*[@id=\"reporting\"]");
        public readonly By _version = By.XPath("//*[@id=\"version\"]");
        public readonly By _notifications = By.XPath("//*[@id=\"notifications\"]");
        public readonly By _help = By.XPath("//*[@id=\"help\"]");
        public readonly By _userMenu = By.XPath("//*[@id=\"userMenu\"]");
        public readonly By _signOutButton = By.XPath("//*[@id=\"userDropdown\"]/li[3]/div[1]");


        public MainMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainMenuPageObject ClickMainLogo()
        {
            _webDriver.FindElement(_mainLogo).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickMeinentanceHeader()
        {
            _webDriver.FindElement(_meinentanceHeader).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickPricingManagementHeader()
        {
            _webDriver.FindElement(_pricingManagementHeader).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickFinanceHeader()
        {
            _webDriver.FindElement(_financeHeader).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickReportingHeader()
        {
            _webDriver.FindElement(_reportingHeader).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickVersion()
        {
            _webDriver.FindElement(_version).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickNotifications()
        {
            _webDriver.FindElement(_notifications).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickHelp()
        {
            _webDriver.FindElement(_help).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickUserDropDownMenu()
        {
            _webDriver.FindElement(_userMenu).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public MainMenuPageObject ClickSignOutButton()
        {
            _webDriver.FindElement(_signOutButton).Click();
            return new MainMenuPageObject(_webDriver);
        }
    }
}
