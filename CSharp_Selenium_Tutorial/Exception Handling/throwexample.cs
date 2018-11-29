using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial.Exception_Handling
{
    [TestClass]
    public class throwexample
    {
        [TestMethod]
        public void demostratethrow()
        {
            throw (new DivideByZeroException());
        }


    }
}
