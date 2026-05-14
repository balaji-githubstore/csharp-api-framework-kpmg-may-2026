using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AutomationFramework.Helpers
{
    public class DataHelper
    {
        public static object[] GetPetTestSource()
        {
            object[] data1 = new object[2];
            data1[0] = 705;
            data1[1] = HttpStatusCode.OK;

            object[] data2 = new object[2];
            data2[0] = 888;
            data2[1] = HttpStatusCode.NotFound;

            object[] data3 = new object[2];
            data3[0] = 999;
            data3[1] = HttpStatusCode.NotFound;

            //number of testcases
            object[] main = new object[3];
            main[0] = data1;
            main[1] = data2;
            main[2] = data3;

            return main;
        }
        //string jsonStrBody = @"{
        //      ""id"": 705,
        //      ""name"": ""string"",
        //      ""category"": {
        //        ""id"": 0,
        //        ""name"": ""string""
        //      },
        //      ""tags"": [
        //        {
        //          ""id"": 0,
        //          ""name"": ""string""
        //        }
        //      ],
        //      ""status"": ""available""
        //    }";

        public static object[] AddPetTestSource()
        {
            object[] data1 = new object[2];
            data1[0] = @"{
              ""id"": 856,
              ""name"": ""string"",
              ""category"": {
                ""id"": 0,
                ""name"": ""string""
              },
              ""tags"": [
                {
                  ""id"": 0,
                  ""name"": ""string""
                }
              ],
              ""status"": ""available""
            }";

            data1[1] = HttpStatusCode.OK;

            object[] data2 = new object[2];
            data2[0] = @"{
              ""id"": 855,
              ""name"": ""string"",
              ""status"": ""available""
            }";
            data2[1] = HttpStatusCode.OK;

            object[] main = new object[2];
            main[0] = data1;
            main[1] = data2;

            return main;
        }


        public static object[] AddPetTestSourceFromJson()
        {
            object[] main = JsonHelper.GetObjectArrayFromJson(@"testdata\petdata.json", "addPet");
            return main;
        }

        public static object[] UpdatePetTestSourceFromJson()
        {
            object[] main = JsonHelper.GetObjectArrayFromJson(@"testdata\petdata.json", "updatePet");
            return main;
        }
    }
}
