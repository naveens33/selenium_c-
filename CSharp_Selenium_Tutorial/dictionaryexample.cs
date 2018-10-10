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
    public class dictionaryexample
    {
        [TestMethod]
        public void dictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Name", "Naveen");
            dict.Add("Rank", "1");
            dict.Add("Class", "Tenth");

          /*  ICollection key = dict.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(dict[k]);
            }
            */
            
            foreach(KeyValuePair<string,string> ele in dict)
            {
                Console.WriteLine(ele.Key+": "+ele.Value);
            }
            
        }
    }
}
