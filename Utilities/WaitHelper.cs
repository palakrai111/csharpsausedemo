using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using System.Collections.Generic;
using System.Text;

namespace SauceDemo.Utilities
{
    public class WaitHelper
    {
        IWebDriver driver;

        public WaitHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement WaitForElement(By locator, int seconds = 10)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(seconds));

            return wait.Until(driver =>
            {
                IWebElement element = driver.FindElement(locator);
                return element.Displayed ? element : null;
            });
        }

        public bool WaitForTitle(string title, int seconds = 10)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(seconds));

            return wait.Until(driver =>
                driver.Title.Contains(title));
        }

        public bool WaitForUrl(string url, int seconds = 10)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(seconds));

            return wait.Until(driver =>
                driver.Url.Contains(url));
        }
        public void WaitForClickable(By locator, int seconds = 10)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(seconds));

            wait.Until(driver =>
            {
                IWebElement element = driver.FindElement(locator);
                return element.Displayed && element.Enabled;
            });
        }




    }
}
