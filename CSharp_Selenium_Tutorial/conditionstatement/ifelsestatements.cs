using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class ifelsestatements
    {
        [TestMethod]
        public void ifelseprogram()
        {
            /*
             * if(cond){
             * statement;
             * }
             * else{
             * }
             */
            int a = 3;
            int b = 6;
            if(a>b)
            {
                Console.WriteLine("A is greater");
            } 
            else
            {
                Console.WriteLine("B is greater");
            }
        }
    }
}
