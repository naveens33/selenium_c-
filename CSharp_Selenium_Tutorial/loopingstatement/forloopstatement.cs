using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class forloopstatement
    {
        [TestMethod]
        public void forstatementex()
        {
            /*for(initialze;cond.;increment/decrement){
             * }
             */
            
          for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }

            /*program to find those numbers which are divisible by 7 and multiple of 5, 
             * between 1300 and 1900 (both included).*/
            
        }

        [TestMethod]
        public void example1()
        {

            for (int i = 1300; i <= 1900; i++)
            {
                if (i % 7 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }


        [TestMethod]
        public void startpattern()
        {
            /*
             * 1. i=1
	j=1
	j<=i true 1<=1
	j=2
	2<=1 false
2. i=2
	j=1
	1<=2 true
	j=2
	2<=2 true
	j=3
	3<=2 false
3. i=3
	j=1
	1<=3
	j=2
	2<=3
	j=3
	3<=3
*/

            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int i=4;i>=1;i--)
            {
                for(int j=i;j>=1;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
