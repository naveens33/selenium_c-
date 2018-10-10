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
    public class hastablexample
    {
        [TestMethod]
        public void hashtable()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Name", "NaveenS");
            ht.Add("Class", "Tenth");
            ht.Add("Rank", 1);
            //ht.Add("Rank", 5);

            ICollection key = ht.Keys;
            foreach(string k in key)
            {
                Console.WriteLine(ht[k]);
            }
        }
    }
}
