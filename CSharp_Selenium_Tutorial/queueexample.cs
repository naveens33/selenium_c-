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
    public class queueexample
    {
        [TestMethod]
        public void queue()
        {
            Queue q = new Queue();
            q.Enqueue("Naveen.S");
            q.Enqueue("Anish");
            q.Enqueue("Somesh");
            q.Dequeue();

            foreach(string s in q)
            {
                Console.WriteLine(s);
            }
        }
    }
}
