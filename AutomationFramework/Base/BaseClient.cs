using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Base
{
    public class BaseClient
    {
        protected readonly RestClient client;

        public BaseClient()
        {
            client = new RestClient(baseUrl: "https://petstore.swagger.io/v2");
        }

        protected RestResponse Execute(RestRequest request)
        {
            return client.Execute(request);
        }
       
    }
}
