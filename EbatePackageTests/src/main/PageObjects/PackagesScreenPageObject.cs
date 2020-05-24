using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbatePackageTests
{
    class PackagesScreenPageObject
    {
        private IWebDriver _webDriver;

        public readonly By _breadcrumbsHomeBtn = By.XPath("/html/body/app-home/div/div/div[2]/app-package/app-package/section[1]/ol/li[1]");
        public readonly By _addPackageBtn = By.XPath("//*[@id=\"addPackage\"]");
        public readonly By _orderById = By.XPath("//*[@id=\"gridPackageOverview\"]/div/div[2]/kendo-grid/div/div/div/table/thead/tr/th[3]/a");
        public readonly By _firstRow = By.XPath("//*[@id=\"gridPackageOverview\"]/div/div[2]/kendo-grid/div/kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[2]/label");
        public readonly By _actionEditButton = By.XPath("//*[@id=\"gridPackageOverview\"]/div/div[2]/div/div[2]");
        public readonly By _actionViewButton = By.XPath("//*[@id=\"gridPackageOverview\"]/div/div[2]/div/div[3]");
        public readonly By _actionCopyButton = By.XPath("//*[@id=\"gridPackageOverview\"]/div/div[2]/div/div[4]");
        public readonly By _actionDeleteButton = By.XPath("//*[@id=\"gridPackageOverview\"]/div/div[2]/div/div[5]");
        public readonly By _searchInput = By.XPath("//*[@id=\"filterText\"]");

        public PackagesScreenPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public PackagesScreenPageObject ClickBreadcrumbsHomeBtn()
        {
            _webDriver.FindElement(_breadcrumbsHomeBtn).Click();
            return new PackagesScreenPageObject(_webDriver);
        }
        public PackagesScreenPageObject ClickAddPackageBtn()
        {
            _webDriver.FindElement(_addPackageBtn).Click();
            return new PackagesScreenPageObject(_webDriver);
        }
        public PackagesScreenPageObject ClickOrderById()
        {
            _webDriver.FindElement(_orderById).Click();
            return new PackagesScreenPageObject(_webDriver);
        }
        public PackagesScreenPageObject SelectFirstRow()
        {
            _webDriver.FindElement(_firstRow).Click();
            return new PackagesScreenPageObject(_webDriver);
        }
        public PackagesScreenPageObject ClickActionEditButton()
        {
            _webDriver.FindElement(_actionEditButton).Click();
            return new PackagesScreenPageObject(_webDriver);
        }
        public PackagesScreenPageObject ClickActionViewButton()
        {
            _webDriver.FindElement(_actionViewButton).Click();
            return new PackagesScreenPageObject(_webDriver);
        }
        public PackagesScreenPageObject ClickActionCopyButton()
        {
            _webDriver.FindElement(_actionCopyButton).Click();
            return new PackagesScreenPageObject(_webDriver);
        }
        public PackagesScreenPageObject ClickActionDeleteButton()
        {
            _webDriver.FindElement(_actionDeleteButton).Click();
            return new PackagesScreenPageObject(_webDriver);
        }
        public PackagesScreenPageObject ClickSearchInput()
        {
            _webDriver.FindElement(_searchInput).Click();
            return new PackagesScreenPageObject(_webDriver);
        }
    }
}
