//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace AutomationFramework.Helpers
//{
//    public class JsonHelper
//    {
//        [Test]
//        public void GetObjectArrayFromJson()
//        {
//            StreamReader reader = new StreamReader(@"TestData\petdata.json");
//            string jsonStr = reader.ReadToEnd();

//            dynamic json = JsonConvert.DeserializeObject(jsonStr);

//            //Console.WriteLine(json);
//            Console.WriteLine(json["addPet"]);
//            Console.WriteLine(json["addPet"].Count);
//            Console.WriteLine(json.addPet[0]);

//            //main[] size depends on number of testcase
//            object[] main = new object[json["addPet"].Count];

//            for (int i = 0; i < json["addPet"].Count; i++)
//            {
//                object[] data = new object[json["addPet"][i].Count];
//                for(int j = 0; j < json["addPet"][i].Count; j++)
//                {
//                    data[j] = json["addPet"][i][j];
//                    Console.WriteLine(json["addPet"][i][j]);
//                }

//                main[i] = data;
//            }

//            Console.WriteLine();
//        }
//    }
//}
