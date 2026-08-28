using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SauceDemo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            Assert.Pass();
        }
    }
}
