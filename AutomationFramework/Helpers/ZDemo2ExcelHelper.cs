//using ClosedXML.Excel;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace AutomationFramework.Helpers
//{
//    public class ZDemo2ExcelHelper
//    {
//        [Test]
//        public void ReadExcel()
//        {
//            XLWorkbook book = new XLWorkbook(@"testdata\petdata.xlsx");
//            var sheet = book.Worksheet("addPet");
//            var range = sheet.RangeUsed();
//            int rowCount = range.RowCount();
//            int cellCount = range.ColumnCount();

//            object[] main = new object[rowCount-1];
//            for (int r = 2; r <= rowCount; r++) 
//            {
//                object[] data = new object[cellCount];
//                for (int c = 1; c <= cellCount; c++)
//                {
//                    data[c-1] = range.Cell(r, c).GetString();
//                }
//                main[r-2] = data;
//            }
//            Console.WriteLine();
//        }
//    }
//}
