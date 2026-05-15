using AutomationFramework.Helpers;
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
            var options = new RestClientOptions(ConfigurationHelper.GetBaseUrl())
            {
                Timeout = TimeSpan.FromSeconds(ConfigurationHelper.GetTimeout())
            };
            client = new RestClient(options);
            //client = new RestClient(baseUrl: "https://petstore.swagger.io/v2");
        }

        protected RestResponse Execute(RestRequest request)
        {
            return client.Execute(request);
        }
    }
}
