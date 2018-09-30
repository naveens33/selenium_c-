using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class elseifstatement
    {
        [TestMethod]
        public void elseifprogram()
        {
            /*
             * if(cond.){
             * statement;
             * }
             * else if(cond.){
             * statement;
             * }
             * else{
             * }
             */

            int year = 2017;

            if(year%4==0)
            {
                Console.WriteLine(year + "is Leap Year");
            }
            else if(year%400==0)
            {
                Console.WriteLine(year + "is Leap Year");
            }
            else
            {
                Console.WriteLine(year + "is not Leap Year");
            }
        }
    }
}
