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
    public class arraylistexample
    {
        [TestMethod]
        public void  arratlist()
        {
            /*
            ArrayList li = new ArrayList();
            li.Add("hello");
            li.Add(56.89);
            li.Add(5);
            li.Add(true);

            for(int i=0;i<li.Count;i++)
            {
                Console.WriteLine(li[i]);
            }
            */

            ArrayList li = new ArrayList();
            li.Add("hello");
            li.Add("world");
            li.Add("kids");
            foreach(string s in li)
            {
                Console.WriteLine(s);
            }

        }

    }
}
