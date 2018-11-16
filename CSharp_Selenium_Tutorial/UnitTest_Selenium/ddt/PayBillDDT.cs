using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial.UnitTest_Selenium.ddt
{
    [TestClass]
    public class PayBillDDT
    {
        IWebDriver driver = null;

        [TestInitialize]
        public void initialize()
        {
            driver = new ChromeDriver(@"D:\Naveen\Selenium\chromedriver_win32\");
            driver.Manage().Window.Maximize();
            driver.Url = "http://zero.webappsecurity.com/index.html";

            IWebElement signin1 = driver.FindElement(By.Id("signin_button"));
            signin1.Click();

            driver.FindElement(By.Id("user_login")).SendKeys("username");
            driver.FindElement(By.Id("user_password")).SendKeys("password");

            driver.FindElement(By.Name("submit")).Click();

            Assert.AreEqual("Zero - Account Summary", driver.Title);
        }
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"C:\Users\naveen.s\Documents\Visual Studio 2015\Projects\CSharp_Selenium_Tutorial\CSharp_Selenium_Tutorial\UnitTest_Selenium\ddt\PaySavedPayee.csv", "PaySavedPayee#csv",
            DataAccessMethod.Sequential), DeploymentItem(@"C:\Users\naveen.s\Documents\Visual Studio 2015\Projects\CSharp_Selenium_Tutorial\CSharp_Selenium_Tutorial\UnitTest_Selenium\ddt\PaySavedPayee.csv"),
            TestMethod]
        public void MakePayment()
        {

            driver.FindElement(By.XPath("//a[text()='Pay Bills']")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("sp_payee")));

            SelectElement payeeelement = new SelectElement(driver.FindElement(By.Id("sp_payee")));
            payeeelement.SelectByText(TestContext.DataRow["Payee"].ToString());

            SelectElement accountelement = new SelectElement(driver.FindElement(By.Id("sp_account")));
            accountelement.SelectByText(TestContext.DataRow["Account"].ToString());

            driver.FindElement(By.Id("sp_amount")).SendKeys(TestContext.DataRow["Amount"].ToString());

            string actualdate = this.TestContext.DataRow["Date"].ToString();
            string[] date = actualdate.Split('-');
            Console.WriteLine(date[0] + " " + date[1] + " " + date[2]);
            //03-10-2018000000

            driver.FindElement(By.Id("sp_date")).SendKeys(date[2].Substring(0, 4) + "-" + date[1] + "-" + date[0]);

            driver.FindElement(By.Id("sp_description")).SendKeys(TestContext.DataRow["Description"].ToString());
        }


        [TestCleanup]
        public void quit()
        {
            driver.Close();
        }
    }
    }
