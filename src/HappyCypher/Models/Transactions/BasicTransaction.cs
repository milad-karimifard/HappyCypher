using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Models.Transactions
{
    public class BasicTransaction
    {
        [JsonProperty("inputs")]
        public IList<TxInput> Inputs { get; set; }

        [JsonProperty("outputs")]
        public IList<TxOutput> Outputs { get; set; }
    }
}
