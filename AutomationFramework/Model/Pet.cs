using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Model
{
    public class PetResponse
    {
        public class Category
        {
            public long Id { get; set; }
            public string Name { get; set; }
        }
        public class Tag
        {
            public long Id { get; set; }
            public string Name { get; set; }
        }

        /// <summary>
        /// Required. Always - must exist and not be null 
        /// Required.AllowNull - must exist, null allowed
        /// Required.DisallowNull - optional, but cannot be null 
        /// Required.Default - normal behaviour
        /// </summary>

        //[JsonObject(ItemRequired =Required.Always)]
        public class Pet
        {
            [JsonProperty(Required = Required.Always)]
            public long Id { get; set; }

            public Category Category { get; set; }

            public string Name { get; set; }
            public List<string> PhotoUrls { get; set; }
            public List<Tag> Tags { get; set; }

            //[JsonProperty(Required = Required.Always)]
            public string Status { get; set; }
        }
    }
}
