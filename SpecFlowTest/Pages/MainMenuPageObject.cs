using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowTest
{
    class MainMenuPageObject
    {
        public IWebDriver WebDriver { get; }

        public MainMenuPageObject(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        
        public IWebElement _mainLogo => WebDriver.FindElement(By.Id("menuLogo"));
        public IWebElement _meinentanceHeader => WebDriver.FindElement(By.XPath("//*[@id=\"maintenance\"]"));
        public IWebElement _pricingManagementHeader => WebDriver.FindElement(By.XPath("//*[@id=\"pricingManagement\"]"));
        public IWebElement _financeHeader => WebDriver.FindElement(By.XPath("//*[@id=\"finance\"]"));
        public IWebElement _reportingHeader => WebDriver.FindElement(By.XPath("//*[@id=\"reporting\"]"));
        public IWebElement _version => WebDriver.FindElement(By.XPath("//*[@id=\"version\"]"));
        public IWebElement _notifications => WebDriver.FindElement(By.XPath("//*[@id=\"notifications\"]"));
        public IWebElement _help => WebDriver.FindElement(By.XPath("//*[@id=\"help\"]"));
        public IWebElement _userMenu => WebDriver.FindElement(By.XPath("//*[@id=\"userMenu\"]"));
        public IWebElement _signOutButton => WebDriver.FindElement(By.XPath("//*[@id=\"userDropdown\"]/li[3]/div[1]"));

        public void ClickMainLogo() => _mainLogo.Click();
        public void ClickMeinentanceHeader() => _meinentanceHeader.Click();
        public void ClickPricingManagementHeader() => _pricingManagementHeader.Click();
        public void ClickFinanceHeader() => _financeHeader.Click();
        public void ClickReportingHeader() => _reportingHeader.Click();
        public void ClickVersion() => _version.Click();
        public void ClickNotifications() => _notifications.Click();
        public void ClickHelp() => _help.Click();
        public void ClickUserMenu() => _userMenu.Click();
        public void ClickSignOutButton() => _signOutButton.Click();

    }
}
