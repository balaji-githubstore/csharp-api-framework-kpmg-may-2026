using AutomationFramework.Base;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Services
{
    /// <summary>
    /// All the resource for Pet will be available here
    /// </summary>
    public class PetService : BaseClient
    {
        public RestResponse GetPetByIdService(long id)
        {
            var request = new RestRequest("pet/{petId}", Method.Get);
            request.AddUrlSegment("petId", id);
            return base.Execute(request);
        }

        public RestResponse AddPetService(string jsonStrBody)
        {
            var request = new RestRequest("pet", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddStringBody(jsonStrBody, DataFormat.Json);

            return base.Execute(request);
        }

        //AddPetToStore(json)
        //UpdatePet(json)
        //DeletePet(id)
    }
}
