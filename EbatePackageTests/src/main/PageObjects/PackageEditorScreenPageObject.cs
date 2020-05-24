using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbatePackageTests
{
    class PackageEditorScreenPageObject
    {
        private IWebDriver _webDriver;

        public readonly By _BreadCrumbsHomeBtn = By.XPath("//*[@id=\"linkHome\"]");
        public readonly By _BreadCrumbPackageBtn = By.XPath("//*[@id=\"linkPackage\"]");
        public readonly By _editPackageBtn = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package-detail/section[2]/div/div/div/div[1]/div/button");
        public readonly By _tabsAgreements = By.XPath("//*[@id=\"k - tabstrip - tab - 0\"]");
        public readonly By _tabsCriteria = By.XPath("//*[@id=\"k - tabstrip - tab - 1\"]");
        public readonly By _tabsDocuments = By.XPath("//*[@id=\"k - tabstrip - tab - 2\"]");
        public readonly By _tabsNotes = By.XPath("//*[@id=\"k - tabstrip - tab - 3\"]");
        public readonly By _tabsAudit = By.XPath("//*[@id=\"k - tabstrip - tab - 4\"]");

        public PackageEditorScreenPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public PackageEditorScreenPageObject ClickBreadCrumbsHomeBtn()
        {         
            _webDriver.FindElement(_BreadCrumbsHomeBtn).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickBreadCrumbPackageBtn()
        {
            _webDriver.FindElement(_BreadCrumbPackageBtn).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickEditPackageBtn()
        {
            _webDriver.FindElement(_editPackageBtn).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsAgreements()
        {
            _webDriver.FindElement(_tabsAgreements).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsCriteria()
        {
            _webDriver.FindElement(_tabsCriteria).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsDocuments()
        {
            _webDriver.FindElement(_tabsDocuments).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsNotes()
        {
            _webDriver.FindElement(_tabsNotes).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
        public PackageEditorScreenPageObject ClickTabsAudit()
        {
            _webDriver.FindElement(_tabsAudit).Click();
            return new PackageEditorScreenPageObject(_webDriver);
        }
    }
}
