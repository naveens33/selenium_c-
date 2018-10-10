using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class listexample
    {
        [TestMethod]
        public void list()
        {
            List<string> li = new List<string>();
            li.Add("First");
            li.Add("Second");
            li.Add("Fifth");
            
            foreach(string s in li)
            {
                Console.WriteLine(s);
            }
        }
    }
}
