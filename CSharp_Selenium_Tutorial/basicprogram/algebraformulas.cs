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
            //simple formula (a+b)^2=a^2+b^2+2ab

            int Min = 0;
            int Max = 20;
            Random randNum = new Random();
            int[] test2 = Enumerable
                .Repeat(0, 5)
                .Select(i => randNum.Next(1, 10))
                .ToArray();
          for(int i=0;i<5;i++)
            {
                Console.WriteLine(test2[i]);
            }

            //int a = 6;
            //int b = 5;
            //int c = (a * a) + (b * b) + (2 * a * b);
            //Console.WriteLine(c);
        }
    }
}
