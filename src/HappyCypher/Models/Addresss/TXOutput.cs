using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Models.Addresss
{
    public class TXOutput
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }

        [JsonProperty("addresses")]
        public List<string> Addresses { get; set; }

        [JsonProperty("script_type")]
        public string ScriptType { get; set; }

        [JsonProperty("spent_by")]
        public string SpentBy { get; set; }

        [JsonProperty("data_hex")]
        public string DataHex { get; set; }

        [JsonProperty("data_string")]
        public string DataString { get; set; }
    }
}
