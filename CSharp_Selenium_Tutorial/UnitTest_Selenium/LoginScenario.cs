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
    public class LoginScenario
    {
        [TestMethod]
        public void loginTC1()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://zero.webappsecurity.com/index.html";

            IWebElement signin1 = driver.FindElement(By.Id("signin_button"));
            signin1.Click();

            driver.FindElement(By.Id("user_login")).SendKeys("username");
            driver.FindElement(By.Id("user_password")).SendKeys("password");

            driver.FindElement(By.Name("submit")).Click();

            Assert.AreEqual("Zero - Account Summary",driver.Title);
        }

        [TestMethod]
        public void loginTC2()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://zero.webappsecurity.com/index.html";

            IWebElement signin1 = driver.FindElement(By.Id("signin_button"));
            signin1.Click();

            driver.FindElement(By.Id("user_login")).SendKeys("username");
            driver.FindElement(By.Id("user_password")).SendKeys("1234");

            driver.FindElement(By.Name("submit")).Click();
            //Assert.AreNotEqual("Zero - Account Summary1", driver.Title);
            Assert.AreEqual("Zero - Log in", driver.Title);

            Assert.AreEqual("Login and/or password are wrong.", driver.FindElement(By.CssSelector("#login_form > div.alert.alert-error")).Text);
        }
    }
}
