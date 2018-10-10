using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class stringexample
    {
        [TestMethod]
        public void stringexample1()
        {
            string a = "Build to test continuously after code change";
            Console.WriteLine(a);

            if (a.Contains("Code"))
            {
                Console.WriteLine("Code is there");
            }
            else
                {
                Console.WriteLine("Code is not there");
            }

            if(a.Equals("Build to test continuously after code change."))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            Console.WriteLine(a.Length);

            string b= "September 15, 1977 in Hammersmith,  London,  England";

            string[] arr=b.Split(',');
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("arr("+i+"): "+arr[i]);
            }

            Console.WriteLine(arr[2]);

            string c = b.Replace("1977", "1999");
            Console.WriteLine(c);

            int index = b.IndexOf("Hammersmith");
            Console.WriteLine(index);
            
            string[] arr1 = b.Split(' ');
            int year = Int32.Parse(arr1[2]);
            int ans = 2018 - year;
            Console.WriteLine(ans);

            string money= "56.23";
          double s= Convert.ToDouble(money);

        }
    }
}
