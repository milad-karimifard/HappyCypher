using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Models.Addresss
{
    public class HDWallet
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("chains")]
        public List<HDChain> Chains { get; set; }

        [JsonProperty("hd")]
        public bool HD { get; set; }

        [JsonProperty("extended_public_key")]
        public string ExtendedPublicKey { get; set; }

        [JsonProperty("subchain_indexes")]
        public List<int> SubchainIndexes { get; set; }
    }
}
