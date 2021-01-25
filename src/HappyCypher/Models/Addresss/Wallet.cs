using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Models.Addresss
{
    public class Wallet
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public List<string> Addresses { get; set; }
    }
}
