using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial.UnitTest_Selenium.ddt
{
    [TestClass]
    public class sampledatadriventest
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"C:\Users\naveen.s\Documents\Visual Studio 2015\Projects\CSharp_Selenium_Tutorial\CSharp_Selenium_Tutorial\UnitTest_Selenium\ddt\PaySavedPayee.csv", "PaySavedPayee#csv",
            DataAccessMethod.Sequential), DeploymentItem(@"C:\Users\naveen.s\Documents\Visual Studio 2015\Projects\CSharp_Selenium_Tutorial\CSharp_Selenium_Tutorial\UnitTest_Selenium\ddt\PaySavedPayee.csv"),
            TestMethod]
        public void sample()
        {
            Console.WriteLine(TestContext.DataRow["Payee"]);
            Console.WriteLine(TestContext.DataRow["Account"]);
            Console.WriteLine(TestContext.DataRow["Amount"]);
            Console.WriteLine(TestContext.DataRow["Date"]);
            Console.WriteLine(TestContext.DataRow["Description"]);

        }
    }
}
