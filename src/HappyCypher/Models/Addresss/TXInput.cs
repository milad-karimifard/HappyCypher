using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Models.Addresss
{
    public class TXInput
    {
        [JsonProperty("prev_hash")]
        public string PrevHash { get; set; }

        [JsonProperty("output_index")]
        public int OutputIndex { get; set; }

        [JsonProperty("output_value")]
        public int OutputValue { get; set; }

        [JsonProperty("script_type")]
        public string ScriptType { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }

        [JsonProperty("addresses")]
        public List<string> Addresses { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("wallet_name")]
        public string WalletName { get; set; }

        [JsonProperty("wallet_token")]
        public string WalletToken { get; set; }
    }
}
