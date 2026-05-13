using AutomationFramework.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AutomationFramework.Tests
{
    public class PetTest
    {

        public static object[] GetPetTestSource()
        {
            //(705,HttpStatusCode.OK)
            //(705787878, HttpStatusCode.NotFound)
            object[] data1 = new object[2];
            data1[0] = 705;
            data1[1] = HttpStatusCode.OK;

            object[] data2 = new object[2];
            data2[0] = 705787878;
            data2[1] = HttpStatusCode.NotFound;

            object[] main = new object[2];
            main[0] = data1;
            main[1] = data2;

            return main;
        }

        //[TestCase(705,HttpStatusCode.OK)]
        //[TestCase(705787878, HttpStatusCode.NotFound)]
        [Test,TestCaseSource(nameof(GetPetTestSource))]
        public void GetValidPetTest(int id,HttpStatusCode statusCode)
        {
            var service = new PetService();
            var response= service.GetPetById(id);
            Assert.That(response.StatusCode, Is.EqualTo(statusCode));
        }
    }
}
