using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Helpers
{
    public class DataHelper
    {
        public static object[] DemoData()
        {
            object[] data1 = new object[2];
            data1[0] = "saul";
            data1[1] = 787887;
            object[] data2 = new object[2];
            data2[0] = "peter";
            data2[1] = 45455;

            object[] main = new object[2];
            main[0] = data1;
            main[1] = data2;
            return main;
        }
        [Test,TestCaseSource(nameof(DemoData))]
        public void DemoTest(string name,int password)
        {
            Console.WriteLine(name+password);
        }

    }
}
