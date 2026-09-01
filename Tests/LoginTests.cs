using SauceDemo.Base;
using SauceDemo.pages;
using SauceDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemo.Tests
{
    public class LoginTests : BaseTest
    {
            [Test]
            [Category("Smoke")]
            public void VerifyPositiveLogin()
            {
            string filePath = "TestData/LoginData.json";
            var data = JsonReader.ReadLoginData(filePath);

                foreach (var login in data)
                {
                    if (login.Expected == "Success")
                    {
                        driver.Navigate().GoToUrl("https://www.saucedemo.com/");

                        LoginPage page = new(driver);

                        page.Login(login.Username!, login.Password!);

                        InventoryPage inventory = new(driver);

                        Assert.That(
                            inventory.IsInventoryDisplayed(),
                            Is.True,
                            $"Login failed for user: {login.Username}"
                        );
                    }
                }
            }

            [Test]
            [Category("Regression")]
            public void VerifyNegativeLogin()
            {
            string filePath = "TestData/LoginData.json";
            var data = JsonReader.ReadLoginData(filePath);

            foreach (var login in data)
                {
                    if (login.Expected == "Failure")
                    {
                        driver.Navigate().GoToUrl("https://www.saucedemo.com/");

                        LoginPage page = new(driver);

                        page.Login(login.Username!, login.Password!);

                        Assert.That(
                            page.GetError(),
                            Is.Not.Empty,
                            $"Expected login failure for user: {login.Username}"
                        );
                    }
                }
            }
        }
    }




