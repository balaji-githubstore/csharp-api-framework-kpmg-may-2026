using AutomationFramework.Helpers;
using AutomationFramework.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AutomationFramework.Tests
{
    public class PetTest
    {
        //[TestCase(705,HttpStatusCode.OK)]
        //[TestCase(705787878, HttpStatusCode.NotFound)]
        [Test, TestCaseSource(typeof(DataHelper), nameof(DataHelper.GetPetTestSource))]
        public void GetPetTest(long id,HttpStatusCode statusCode)
        {
            var service = new PetService();
            var response= service.GetPetByIdService(id);
            Assert.That(response.StatusCode, Is.EqualTo(statusCode));
        }


        [Test, TestCaseSource(typeof(DataHelper), nameof(DataHelper.AddPetTestSource))]
        public void AddPetTest(string jsonStrBody,HttpStatusCode statusCode)
        {
            var service = new PetService();
            var response = service.AddPetService(jsonStrBody);
            Assert.That(response.StatusCode, Is.EqualTo(statusCode));

            //deserialize jsonStrBody to PetRequest Object
            //deserialize response to PetResponse Object
        }
    }
}
