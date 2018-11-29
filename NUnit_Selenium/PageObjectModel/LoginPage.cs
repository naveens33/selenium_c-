using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NUnit_Selenium
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "user_login")]
        internal IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "user_password")]
        internal IWebElement  Password{ get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        internal IWebElement SignIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Forgot your password')]")]
        internal IWebElement ForgetPasswordLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Zero Bank')]")]
        internal IWebElement ZeroBankLink { get; set; }
        
    }
}
