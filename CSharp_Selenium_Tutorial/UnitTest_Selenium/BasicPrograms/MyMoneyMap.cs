using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial.UnitTest_Selenium.BasicPrograms
{
    [TestClass]
    public class MyMoneyMap
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
        public void Inflow()
        {
            driver.FindElement(By.XPath("//*[@id='money_map_tab']/a")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            /*
             * ImplictWait have an impact in overall testing performance,
             * since the implicit wait will be used in all FindElement calls.
            */
            IWebElement element = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.XPath("//*[@id='gridview-1015-bd-Deposits']/td/table/tbody/tr[2]/td[1]/div"))));
            //Console.WriteLine(element.Text);
            /*
             * Explicit Wait, is a one-timer used for a particular search. 
             * It is more extendible in the means that we can set it up to wait for any condition.
             * Usually, some of the prebuilt ExpectedConditions to wait for elements to become clickable, visible, invisible, etc.,
             */ 
            Assert.AreEqual("Direct Deposits",element.Text);
            Assert.AreEqual("Other Deposits", driver.FindElement(By.XPath("//*[@id='gridview-1015-bd-Deposits']/td/table/tbody/tr[3]/td[1]/div")).Text);
        }

        [TestCleanup]
        public void close()
        {
            driver.Close();
        }
    }
}
