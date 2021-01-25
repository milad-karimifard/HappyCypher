using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Models.Addresss
{
    public class HDAddress
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("public")]
        public string Public { get; set; }
    }
}
