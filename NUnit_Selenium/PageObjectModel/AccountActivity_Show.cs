using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Selenium.PageObjectModel
{
    public class AccountActivity_Show
    {
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Find Transactions')]")]
        internal IWebElement FindTransactionsLink { get; set; }
    }
}
