using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class multidimensionalarrayexample
    {
        [TestMethod]
        public void multidimensionalarrayexample_()
        {
            /*
             * datatype[,] array_name=new dayatype[3,3];
             * 
             * int[,] a=new int[2,2]; 
             */

            int[,] a = new int[2, 2] { { 4,7}, { 8,3} };

            //Console.WriteLine(a[1,1]);
            
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    a[i, j] = i;
                    //Console.Write(a[i, j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
