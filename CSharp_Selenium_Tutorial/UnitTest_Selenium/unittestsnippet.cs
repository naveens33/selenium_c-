using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{ 
    [TestClass]
    public class unittestsnippet
    {
    [ClassInitialize]
    static public void Class_Ini(TestContext v)
    {
        Console.WriteLine("ClassInitialize");
    }
    
    [TestInitialize]
    public void Test_Ini()
    {
        Console.WriteLine("TestInitialize");
    }
    [TestMethod]
    public void tm1()
    {
        Console.WriteLine("TestMethod-1");
    }
    [TestMethod]
    [ExpectedException(typeof(ElementNotVisibleException),AllowDerivedTypes =true)]
    public void tm2()
    {
            throw new ElementNotVisibleException();
        Console.WriteLine("TestMethod-2");
    }

        [TestMethod]
        [Ignore]
        public void tm3()
        {
            Console.WriteLine("TestMethod-3");
        }
    [TestCleanup]
    public void Test_clean()
    {
        Console.WriteLine("TestCleanup");
    }

    [ClassCleanup()]
    static public void Class_Clean()
    {
        Console.WriteLine("ClassCleanup");
    }
}
}
