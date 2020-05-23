using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbatePackageTests
{
    class MainMenuPageObject
    {
        private IWebDriver _webDriver;

        public readonly By _emailInput = By.XPath("//*[@id=\"email\"]");
        public readonly By _passwordInput = By.XPath("//*[@id=\"password\"]");
        public readonly By _forgotPasswordInput = By.XPath("/html/body/app-e-bate-login/div/div/div[2]/form/div[2]/a");
        public readonly By _saveButton = By.XPath("//*[@id=\"save\"]");

        public MainMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainMenuPageObject Login()
        {
            _webDriver.FindElement(_saveButton).Click();

            return new MainMenuPageObject(_webDriver);

        }

    }
}
