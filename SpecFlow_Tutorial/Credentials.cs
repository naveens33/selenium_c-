using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow_Tutorial
{

    public class Credentials
    {
        public Dictionary<string,string> getData(Table table)
        {
            Dictionary<string, string> credential = new Dictionary<string, string>();
            TableRow trow1 =table.Rows[0];
            credential.Add(trow1.Keys.ElementAt(0), trow1[0]);
            credential.Add(trow1.Keys.ElementAt(1), trow1[1]);
            return credential;
        }
    }
}
