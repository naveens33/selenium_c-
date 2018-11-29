using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
namespace NUnit_Selenium
{
    [TestFixture]
    public class FeedbackFeature
    {


        IWebDriver driver;
        [OneTimeSetUp]
        public void onetimesetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://zero.webappsecurity.com/index.html";
        }
 
        [SetUp]
        public void setup()
        {
            driver.FindElement(By.XPath("//li[@id='feedback']")).Click();
            Assert.AreEqual("Zero - Contact Us", driver.Title);
        }

        [Test]
        public void SubmitFeedback()
        {
            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys("Sankar");
            driver.FindElement(By.XPath("//*[@id='email']")).SendKeys("sankar2.0@gmail.com");
            driver.FindElement(By.XPath("//*[@id='subject']")).SendKeys("LoginIssue");
            driver.FindElement(By.XPath("//*[@id='comment']")).SendKeys("Not able to login");
            driver.FindElement(By.Name("submit")).Click();
            Assert.AreEqual(true, driver.FindElement(By.XPath("//div[@class='offset3 span6']")).Text.Contains("Sankar"));
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("D:\\screenshot.jpeg", ScreenshotImageFormat.Jpeg);
        }

        [Test]
        public void FAQ()
        {
            driver.FindElement(By.XPath("//*[@id='faq-link']")).Click();
            Assert.AreEqual("Zero - FAQ - Frequently Asked Questions", driver.Title);

        }

        [TearDown]
        public void teardown()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Zero Bank')]")).Click();
        }

        [OneTimeTearDown]
        public void onetimeteardown()
        {
            //driver.Close();
        }
    }
}
