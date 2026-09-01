using OpenQA.Selenium;
using SauceDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemo.pages
{
    public class LoginPage
    {
        
            IWebDriver driver;

            CommonMethods common;

            public LoginPage(IWebDriver driver)
            {
                this.driver = driver;
                common = new CommonMethods(driver);
            }

            By username = By.Id("user-name");

            By password = By.Id("password");

            By loginBtn = By.Id("login-button");

            By error = By.CssSelector("h3[data-test='error']");

            public void Login(string user, string pass)
            {
                common.EnterText(username, user);

                common.EnterText(password, pass);

                common.Click(loginBtn);
            }

            public string GetError()
            {
                return common.GetText(error);
            }
        }
    }





