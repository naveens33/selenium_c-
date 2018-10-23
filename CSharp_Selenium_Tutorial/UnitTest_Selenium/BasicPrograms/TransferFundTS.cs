using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class TransferFundTS
    {
        /* 
        [TestClass]
        [TestMethod] -TestCase
        [TestInitialize] -setup
        [TestCleanup]
        [ClassInitialize]
        [ClassCLeanup]
        [Ignore]

        [TestClass]
        [ClassInitialize]-1
        [TestInitialize] -1
        [TestMethod]
        [TestCleanup]-1
        [TestInitialize] 
        [TestMethod]
        [TestCleanup]
        [TestInitialize] 
        [TestMethod]
        [TestCleanup]
        [ClassCLeanup]-1
        */
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
        public void TransferFunTC1()
        {
            driver.FindElement(By.XPath("//*[@id='transfer_funds_tab']/a")).Click();
            Assert.AreEqual("Zero - Transfer Funds", driver.Title);

            IWebElement fromaccount = driver.FindElement(By.XPath("//*[@id='tf_fromAccountId']"));
            SelectElement dropdown1 = new SelectElement(fromaccount);
            dropdown1.SelectByText("Savings(Avail. balance = $ 1548)");

            IWebElement toaccount = driver.FindElement(By.Id("tf_toAccountId"));
            SelectElement dropdown2 = new SelectElement(toaccount);
            dropdown2.SelectByValue("5");

            driver.FindElement(By.Id("tf_amount")).SendKeys("500");
            driver.FindElement(By.XPath("//*[@id='tf_description']")).SendKeys("CreditCard Bill");

            driver.FindElement(By.XPath("//*[@id='btn_submit']")).Click();
                
            //IWebElement fromaccountdis =driver.FindElement(By.XPath("//*[@id='tf_fromAccountId']"));
            Assert.AreEqual(false, fromaccount.Enabled);

            driver.FindElement(By.XPath("//*[@id='btn_submit']")).Click();

            IWebElement browse = driver.FindElement(By.Id("uploadfile"));
            //pass the path of the file to be uploaded using Sendkeys method
            browse.SendKeys("D:\\SoftwareTestingMaterial\\UploadFile.txt");

            Assert.AreEqual("You successfully submitted your transaction.", driver.FindElement(By.XPath("//*[@id='transfer_funds_content']/div/div/div[1]")).Text);
        }

        [TestCleanup]
        public void quit()
        {
            driver.Close();
        }
    }
}
