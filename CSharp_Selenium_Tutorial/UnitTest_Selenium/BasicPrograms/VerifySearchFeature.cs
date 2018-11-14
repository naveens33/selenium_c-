using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial.UnitTest_Selenium.BasicPrograms
{
    [TestClass]
    public class VerifySearchFeature
    {
        IWebDriver driver;
        [TestInitialize]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://zero.webappsecurity.com/index.html";

            IWebElement signin1 = driver.FindElement(By.Id("signin_button"));
            signin1.Click();

            driver.FindElement(By.Id("user_login")).SendKeys("username");
            driver.FindElement(By.Id("user_password")).SendKeys("password");

            driver.FindElement(By.Name("submit")).Click();

            Assert.AreEqual("Zero - Account Summary", driver.Title);
        }
        [TestMethod]
        public void VerifySearchFeature_()
        {
            driver.FindElement(By.Id("searchTerm")).SendKeys("Account");
            driver.FindElement(By.Id("searchTerm")).SendKeys(Keys.Enter);
            Assert.AreEqual("Zero - Search Tips", driver.Title);

            IReadOnlyCollection<IWebElement> list = driver.FindElements(By.XPath("//div[@class='top_offset']/ul/li"));
            Assert.AreEqual(2, list.Count);
        }
    }
}
