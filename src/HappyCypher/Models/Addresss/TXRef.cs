using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Models.Addresss
{
    public class TXRef
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("block_height")]
        public int BlockHeight { get; set; }

        [JsonProperty("tx_hash")]
        public string TxHash { get; set; }

        [JsonProperty("tx_input_n")]
        public int TxInputN { get; set; }

        [JsonProperty("tx_output_n")]
        public int TxOutputN { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("preference")]
        public string Preference { get; set; }

        [JsonProperty("spent")]
        public bool Spent { get; set; }

        [JsonProperty("double_spend")]
        public bool DoubleSpend { get; set; }

        [JsonProperty("confirmations")]
        public int Confirmations { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }

        [JsonProperty("ref_balance")]
        public int RefBalance { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("confirmed")]
        public DateTime Confirmed { get; set; }

        [JsonProperty("spent_by")]
        public string SpentBy { get; set; }

        [JsonProperty("received")]
        public DateTime Received { get; set; }

        [JsonProperty("receive_count")]
        public int ReceiveCount { get; set; }

        [JsonProperty("double_of")]
        public string DoubleOf { get; set; }
    }
}
