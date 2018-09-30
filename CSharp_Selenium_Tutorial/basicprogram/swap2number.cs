using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class swap2number
    {
        [TestMethod]
        public void swap()
        {
            int num1 = 56;
            int num2 = 78;
            int temp;

            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);
        }
    }
}
