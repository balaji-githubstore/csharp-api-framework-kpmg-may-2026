using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Helpers
{
    public class ExcelHelper
    {
        /// <summary>
        /// Get Object Array from excel by passing sheetname
        /// </summary>
        /// <param name="path"></param>
        /// <param name="sheetname"></param>
        /// <returns>object[]</returns>
        public static object[] GetObjectArrayFromSheet(string path,string sheetname)
        {
            XLWorkbook book = new XLWorkbook(path);
            var sheet = book.Worksheet(sheetname);
            var range = sheet.RangeUsed();
            int rowCount = range.RowCount();
            int cellCount = range.ColumnCount();

            object[] main = new object[rowCount - 1];
            for (int r = 2; r <= rowCount; r++)
            {
                object[] data = new object[cellCount];
                for (int c = 1; c <= cellCount; c++)
                {
                    data[c - 1] = range.Cell(r, c).GetString();
                }
                main[r - 2] = data;
            }
            return main;
        }
    }
}
