using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowTest
{
    class LoginTenantTabPageObject
    {
        private IWebDriver _webDriver;

        
        public readonly By _tenantDropDown = By.XPath("//*[@id=\"ddlTenant\"]");
        public readonly By _saveButton = By.XPath("//*[@id=\"save\"]");

        public LoginTenantTabPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public LoginTenantTabPageObject ChooseFirstTenant()
        {
            _webDriver.FindElement(_tenantDropDown).Click();
            _webDriver.FindElement(_saveButton).Click();

            return new LoginTenantTabPageObject(_webDriver);

        }

    }
}




