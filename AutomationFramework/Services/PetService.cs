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
        public RestResponse GetPetById(int id)
        {
            var request = new RestRequest("pet/{petId}", Method.Get);
            request.AddUrlSegment("petId", id);
            return base.Execute(request);
        }

    }
}
