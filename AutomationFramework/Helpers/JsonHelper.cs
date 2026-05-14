using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Helpers
{
    public class JsonHelper
    {
        /// <summary>
        /// Pass json path and key to get object[]
        /// </summary>
        /// <param name="path">file path</param>
        /// <param name="key">key to read</param>
        /// <returns>object[]</returns>
        public static object[] GetObjectArrayFromJson(string path,string key)
        {
            StreamReader reader = new StreamReader(path);
            string jsonStr = reader.ReadToEnd();

            dynamic json = JsonConvert.DeserializeObject(jsonStr);

            //main[] size depends on number of testcase
            object[] main = new object[json[key].Count];

            for (int i = 0; i < json[key].Count; i++)
            {
                object[] data = new object[json[key][i].Count];
                for (int j = 0; j < json[key][i].Count; j++)
                {
                    data[j] = Convert.ToString(json[key][i][j]);
                    Console.WriteLine(Convert.ToString(json[key][i][j]));
                }
                main[i] = data;
            }
            return main;
        }
    }
}
