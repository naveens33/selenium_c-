using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Selenium.PageObjectModel
{
    public class AccountActivity_Find
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='aa_fromDate']")]
        internal IWebElement FromDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='aa_toDate']")]
        internal IWebElement ToDate { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Find')]")]
        internal IWebElement FindButton { get; set; }
    
    }
}
