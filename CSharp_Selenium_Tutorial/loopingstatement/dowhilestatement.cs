using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class dowhilestatement
    {
        [TestMethod]
        public void dowhilestatementex()
        {
            /*do{
             * }while(cond.);
             */

/*
 * int i=1;
while(i<=10){
Console.Writeline(i);
i++;
}

while is called as Entry Check loop

int i=1;
do{
Console.Writeline(i);
i++;
}while(i<=10);

do while is as Exit check loop

i=1;
while(i<1){
Console.Writeline(i)
i++;
}

i=1
do
{
Console.Writeline(i)
i++;
}while(i<1);

here it is atleast print once
*/
int i = 1;
do
{
    Console.WriteLine(i);
    i++;
} while (i <= 10);
}
}
}
