using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial.Exception_Handling
{
    [TestClass]
    public class trycatch
    {
        [TestMethod]
        public void demostrate()
        {
            int a = 5, b = 5, c, d=7,e;

            try
            {
                c = a - b;
                e = d / c;
                Console.WriteLine("answer(-): " + e);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            c = a + b;
            e = d / c;
            Console.WriteLine("answer(+): " + e);
        }
    }
}
