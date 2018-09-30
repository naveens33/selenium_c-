using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class nestedifstatement
    {
        [TestMethod]
        public void nestedifprogram()
        {
            /*
             * if(cond){
             * }
             * else{
             * if(cond){
             *  statement;
             *  }
             *  else{
             *  }
             * }
             */

            int num1 = 5;
            int num2 = 23;
            int num3 = 36;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (num2 > num3)
            {
                Console.Write("The 2nd Number is the greatest among three \n\n");
            }
            else
            {
                Console.Write("The 3rd Number is the greatest among three \n\n");
            }
        }
    }
}
