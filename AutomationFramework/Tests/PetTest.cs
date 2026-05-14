using AutomationFramework.Base;
using AutomationFramework.Helpers;
using AutomationFramework.Model;
using AutomationFramework.Services;
using AventStack.ExtentReports;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AutomationFramework.Tests
{
    public class PetTest : BaseTest
    {
        //[TestCase(705,HttpStatusCode.OK)]
        //[TestCase(705787878, HttpStatusCode.NotFound)]
        [Test, TestCaseSource(typeof(DataHelper), nameof(DataHelper.GetPetTestSource))]
        public void GetPetTest(long id, HttpStatusCode statusCode)
        {
            var service = new PetService();
            var response = service.GetPetByIdService(id);
            Test.Log(Status.Info, $"Get Pet for {id}");
            Assert.That(response.StatusCode, Is.EqualTo(statusCode));
        }


        //[Test, TestCaseSource(typeof(DataHelper), nameof(DataHelper.AddPetTestSourceFromJson))]
        [Test, TestCaseSource(typeof(DataHelper), nameof(DataHelper.AddPetTestSourceFromExcel))]
        public void AddPetTest(string requestBody, HttpStatusCode statusCode)
        {

            var service = new PetService();
            var response = service.AddPetService(requestBody);
            

            //deserialize jsonStrBody to PetRequest Object
            var petRequest= JsonConvert.DeserializeObject<Pet>(requestBody);

            //deserialize response to PetResponse Object
            var petResponse = JsonConvert.DeserializeObject<Pet>(response.Content);


            Assert.That(response.StatusCode, Is.EqualTo(statusCode));
            Assert.That(petResponse.Id, Is.EqualTo(petRequest.Id));
            Assert.That(petResponse.Status, Is.EqualTo(petRequest.Status));
        }

        [Test, TestCaseSource(typeof(DataHelper), nameof(DataHelper.UpdatePetTestSourceFromJson))]
        public void UpdatePetTest(string requestBody, HttpStatusCode statusCode)
        {
            Console.WriteLine(requestBody);
            Console.WriteLine(statusCode);
        }
    }
}
