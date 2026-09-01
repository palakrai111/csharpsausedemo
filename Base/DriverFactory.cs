using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemo.Base
{
    public class DriverFactory
    {
        public static IWebDriver GetDriver()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArgument("--start-maximized");

            IWebDriver driver = new ChromeDriver(options);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            return driver;
        }
    }
}
