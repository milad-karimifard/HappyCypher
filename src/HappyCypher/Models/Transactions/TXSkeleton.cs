using HappyCypher.Models.Addresss;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Models.Transactions
{
    public class TXSkeleton
    {
        [JsonProperty("tx")]
        public Tx Tx { get; set; }

        [JsonProperty("tosign")]
        public List<string> Tosign { get; set; }

        [JsonProperty("tosign_tx")]
        public List<string> TosignTx { get; set; }

        [JsonProperty("errors")]
        public List<Error> Errors { get; set; }

        [JsonProperty("signatures")]
        public List<string> Signatures { get; set; }

        [JsonProperty("pubkeys")]
        public List<string> Pubkeys { get; set; }
    }

    public class Error
    {
        [JsonProperty("error")]
        public string ErrorMessage { get; set; }
    }
}
