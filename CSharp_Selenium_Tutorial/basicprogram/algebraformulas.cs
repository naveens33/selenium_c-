using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class algebraformulas
    {
        [TestMethod]
        public void formula()
        {
            //(a+b)^2=a^2+b^2+2ab

            int a = 6;
            int b = 5;
            int c = (a * a) + (b * b) + (2 * a * b);
            Console.WriteLine(c);
        }
    }
}
