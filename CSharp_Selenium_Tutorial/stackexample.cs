using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class stackexample
    {
        [TestMethod]
        public void stack()
        {
            Stack st = new Stack();
            st.Push("NaveenS");
            st.Push("Anish");
            st.Push("Somi");
            st.Push("hello");

            st.Pop();
            st.Pop();

            foreach (string s in st)
            {
                Console.WriteLine(s);
            }
        }
    }
}
