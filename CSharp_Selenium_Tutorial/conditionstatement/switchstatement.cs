using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class switchstatement
    {
        [TestMethod]
        public void switchprogram()
        {
            /*switch(choice){
             * case value:
             * statement;
             * break;
             * .
             * .
             * .
             * case nvalue:
             * statement;
             * break;
             * default:
             * statement;
             *}
             */

            int ch = 10;

            switch (ch)
            {
                case 1:
                    Console.WriteLine("Burger");
                    break;
                case 2:
                    Console.WriteLine("Pizza");
                    break;
                case 3:
                    Console.WriteLine("Donuts");
                    break;
                case 4:
                    Console.WriteLine("Pepsi");
                    break;
                default:
                    Console.WriteLine("Item not avaiable");
                    break;
            }
        }
    }
}
