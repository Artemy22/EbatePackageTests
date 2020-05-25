using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;

public static class WebDriverFactory
{
       public static IWebDriver CreateWebDriver(WebBrowser name)
    {
        switch (name)
        {
            case WebBrowser.Firefox:
                return new FirefoxDriver();  
            case WebBrowser.Chrome:
            default:                               
                return new ChromeDriver();
        }
    }
}

public enum WebBrowser
{    
    Firefox,
    Chrome
}