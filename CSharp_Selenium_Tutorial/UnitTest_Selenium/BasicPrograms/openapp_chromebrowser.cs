using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class openapp_chromebrowser
    {
        IWebDriver driver;
      [TestMethod]
        public void OpenApplication()
        {
            driver = new ChromeDriver();
            driver.Url = "http://zero.webappsecurity.com/index.html";

            
        }
    }
}
