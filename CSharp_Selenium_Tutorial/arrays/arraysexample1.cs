using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class arraysexample1
    {
        [TestMethod]
        public void arraysexmaple1_()
        {
            /*Arrays - group smilar elements
where size fixed 

a=10
b=10
c=10

ans=a+b+c+d+e.....

datatype[] array_name;
array_name=new datatype[10];

            ONE DIMENTIONAL ARRAY
int[] a;
a=new int[10];

int a=new int[10];
int[] a = new int[10]{3,4,2,7,1,5,6,9,0,1};
string[] name=new string[3]{"prem,"kumar, "somesh"};
*/

            ////int[] a = new int[10]{3,4,2,7,1,5,6,9,0,1};

            ////for(int i=0;i<10;i++)
            ////{
            ////    Console.WriteLine(a[i]);
            ////}

            ////a[7] = 56;
            ////Console.WriteLine("*******");
            ////for (int i = 0; i < 10; i++)
            ////{
            ////    Console.WriteLine(a[i]);
            ////}

            //string[] days = new string[7];
            //days[0] = "Monday";
            //days[1] = "Tuesday";

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}


            string[] name = new string[3];
            name[0] = "prem";
            name[1] = "kumar";
            name[2] = "satessh";
            //Test method CSharp_Selenium_Tutorial.arraysexample1.arraysexmaple1_ threw exception:
            //System.IndexOutOfRangeException: Index was outside the bounds of the array.
            
            //name[3] = "somi";

            for(int i=0;i<4;i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
