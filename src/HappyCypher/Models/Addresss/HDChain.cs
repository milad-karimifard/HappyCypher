using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Models.Addresss
{
    public class HDChain
    {
        [JsonProperty("chain_addresses")]
        public List<HDAddress> ChainAddresses { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }
}
