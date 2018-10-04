using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Selenium_Tutorial
{
    [TestClass]
    public class whilestatement
    {
        [TestMethod]
        public void whilestatementex()
        {
            /*
             * while(cond){
             * }
             */
            /*
             * int i=1;
            while(i<=10){
            Console.Writeline(i);
            i++;
            }
            */

/*
 * 1. i=1
i<=10 -- true
i++
2. i=2
i<10 --true
i++
.
.
.
i=11 i<=10 -- false*/
/*
 * //infinte loop 
while(true)
{
if(documentname=="SRS discussiopn)"
{
 break;
}
}*/

//infinte loop
int i = 0;
while (true)
{
    Console.WriteLine(i);
    if(i==25)
    {
        break;
    }
    i++;
}

}
}
}
