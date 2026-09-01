using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemo.Utilities
{
    public class CommonMethods
    {
        
            IWebDriver driver;
            WaitHelper wait;

            public CommonMethods(IWebDriver driver)
            {
                this.driver = driver;
                wait = new WaitHelper(driver);
            }

            public void Click(By locator)
            {
                wait.WaitForClickable(locator);
                driver.FindElement(locator).Click();
            }

            public void EnterText(By locator, string value)
            {
                var element = wait.WaitForElement(locator);

                element.Clear();

                element.SendKeys(value);
            }

            public string GetText(By locator)
            {
                return wait.WaitForElement(locator).Text;
            }

            public bool IsDisplayed(By locator)
            {
                try
                {
                    return driver.FindElement(locator).Displayed;
                }
                catch
                {
                    return false;
                }
            }
        }
    }












