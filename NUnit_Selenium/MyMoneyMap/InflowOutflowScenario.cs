using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Selenium.MyMoneyMap
{
    [TestFixture]
    public class InflowOutflowScenario
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void onetimesetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://zero.webappsecurity.com/index.html";
            driver.FindElement(By.Id("signin_button")).Click();
            driver.FindElement(By.Id("user_login")).SendKeys("username");
            driver.FindElement(By.Id("user_password")).SendKeys("password");

            driver.FindElement(By.Name("submit")).Click();

            Assert.AreEqual("Zero - Account Summary", driver.Title);
        }

        [Test]
        public void Inflow()
        {
            ExtractTestData obj = new ExtractTestData();
            obj.getData();
            ArrayList desc = obj.desc;
            ArrayList valu = obj.valu;

            driver.FindElement(By.XPath("//a[contains(text(),'My Money Map')]")).Click();
            IWebElement element = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.XPath("//div[contains(text(),'Deposits') and contains(@class,'title')]"))));

            for(int i=0;i<desc.Count;i++)
            {
                Assert.AreEqual(desc[i], driver.FindElement(By.XPath("//tr[contains(@id,'Deposits')]//tr[" + (i + 2) + "]/td[1]/div[contains(@class,'inner')]")).Text);
                Assert.AreEqual(valu[i], driver.FindElement(By.XPath("//tr[contains(@id,'Deposits')]//tr[" + (i + 2) + "]/td[2]/div[contains(@class,'inner')]")).Text);

                Console.WriteLine(driver.FindElement(By.XPath("//tr[contains(@id,'Deposits')]//tr["+(i+2)+"]/td[1]/div[contains(@class,'inner')]")).Text);
                Console.WriteLine(driver.FindElement(By.XPath("//tr[contains(@id,'Deposits')]//tr[" + (i + 2) + "]/td[2]/div[contains(@class,'inner')]")).Text);

            }
        }
    }
}
