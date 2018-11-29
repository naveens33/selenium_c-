using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial.Exception_Handling
{
    [TestClass]
    public class rethrowexample
    {
        [TestMethod]
        public void demostraterethrow()
        {
            int a = 5, b = 5, c=0, d = 7, e=0;
            getvaluediff(a, b, c, d,e);
            getvaluesum(a, b, c, d, e);

        }

        private void getvaluediff(int a, int b, int c, int d, int e)
        {
            try
            {
                c = a - b;
                //e = d / c;
                throw (new IndexOutOfRangeException());
                Console.WriteLine("answer(-): " + e);
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void getvaluesum(int a, int b, int c, int d, int e)
        {
                c = a + b;
                e = d / c;
                Console.WriteLine("answer(+): " + e);
        }
    }
}
