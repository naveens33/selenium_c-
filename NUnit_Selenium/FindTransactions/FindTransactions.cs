using NUnit.Framework;
using NUnit_Selenium.PageObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;

namespace NUnit_Selenium.FindTransactions
{
    [TestFixture]
    public class FindTransactions
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void onetimesetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://zero.webappsecurity.com/index.html";
            driver.FindElement(By.Id("signin_button")).Click();
        }

        [SetUp]
        public void setup()
        {
            var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.UserName.SendKeys("username");
            loginPage.Password.SendKeys("password");
            loginPage.SignIn.Click();

            Assert.AreEqual("Zero - Account Summary", driver.Title);
        }
        
        [Test]
        public void FindByDateAndType()
        {
            
            var accontsummaryPage = new AccountSummaryPage();
            PageFactory.InitElements(driver, accontsummaryPage);
            accontsummaryPage.AccountActivityLink.Click();

            var accountactivityshowPage = new AccountActivity_Show();
            PageFactory.InitElements(driver, accountactivityshowPage);
            accountactivityshowPage.FindTransactionsLink.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            var accountactivityfindPage = new AccountActivity_Find();
            PageFactory.InitElements(driver, accountactivityfindPage);
            accountactivityfindPage.FromDate.SendKeys("2012-01-01");
            accountactivityfindPage.ToDate.SendKeys("2012-12-31");
            accountactivityfindPage.FindButton.Click();
            
        }


        [TearDown]
        public void teardown()
        {
        
        }

        [OneTimeTearDown]
        public void onetimeteardown()
        {
            //driver.Close();
        }
    }
}
