using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemo.pages
{
    public class InventoryPage
    {
        
            IWebDriver driver;

            public InventoryPage(IWebDriver driver)
            {
                this.driver = driver;
            }

            public bool IsInventoryDisplayed()
            {
                return driver.Url.Contains("inventory");
            }
        }
    }
