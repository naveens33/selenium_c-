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
    public class sortedlistexample
    {
        [TestMethod]
        public void sortedlist()
        {
            SortedList s1 = new SortedList();
            s1.Add("Name", "NaveenS");
            s1.Add("Class", "Tenth");
            s1.Add("x", 1);


            ICollection key = s1.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(s1[k]);
            }
        }
    }
}
