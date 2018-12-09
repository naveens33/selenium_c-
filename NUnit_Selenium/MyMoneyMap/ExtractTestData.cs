using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel= Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace NUnit_Selenium.MyMoneyMap
{
    public class ExtractTestData
    {
        public ArrayList desc = new ArrayList();
        public ArrayList valu = new ArrayList();
        public void getData()
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\naveen.s\Documents\Visual Studio 2015\Projects\CSharp_Selenium_Tutorial\NUnit_Selenium\MyMoneyMap\MyMoneyMap_TestData.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            for(int i=2;i< rowCount+1; i++)
            {
                desc.Add(xlRange.Cells[i, 1].Value2.ToString());
                valu.Add(xlRange.Cells[i, 2].Value2.ToString());
            }
            xlWorkbook.Close();
        }
    }
}
