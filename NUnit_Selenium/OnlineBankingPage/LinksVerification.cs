using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Selenium.OnlineBankingPage
{
    [TestFixture]
    class LinksVerification
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void onetimesetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://zero.webappsecurity.com/index.html";
            driver.FindElement(By.XPath("//strong[contains(text(),'Online Banking')]")).Click();
        }

        [SetUp]
        public void setup()
        {

        }

        static string[] linkname = { "Account Summary", "Account Activity", "Transfer Funds", "Pay Bills" };

        [TestCaseSource("linkname")]
        public void VerifyLinksBeforeSignin(string str)
        {
            driver.FindElement(By.XPath("//span[contains(text(),'"+str+"')]")).Click();
            Assert.AreEqual("Zero - Log in", driver.Title);
        }
        
        [TearDown]
        public void teardown()
        {
            driver.Navigate().Back();
        }

        [OneTimeTearDown]
        public void onetimeteardown()
        {
            driver.Close();
        }
    }
}
