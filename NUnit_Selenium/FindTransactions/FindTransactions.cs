using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

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
