using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Models.Addresss
{
    public class Tx
    {
        [JsonProperty("block_height")]
        public int BlockHeight { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("addresses")]
        public List<string> Addresses { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("fees")]
        public int Fees { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("preference")]
        public string Preference { get; set; }

        [JsonProperty("relayed_by")]
        public string RelayedBy { get; set; }

        [JsonProperty("received")]
        public DateTime Received { get; set; }

        [JsonProperty("ver")]
        public int Ver { get; set; }

        [JsonProperty("lock_time")]
        public int LockTime { get; set; }

        [JsonProperty("double_spend")]
        public bool DoubleSpend { get; set; }

        [JsonProperty("vin_sz")]
        public int VinSz { get; set; }

        [JsonProperty("vout_sz")]
        public int VoutSz { get; set; }

        [JsonProperty("confirmations")]
        public int Confirmations { get; set; }

        [JsonProperty("inputs")]
        public List<TXInput> Inputs { get; set; }

        [JsonProperty("outputs")]
        public List<TXOutput> Outputs { get; set; }

        [JsonProperty("opt_in_rbf")]
        public bool OptInRbf { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("confirmed")]
        public DateTime? Confirmed { get; set; }

        [JsonProperty("receive_count")]
        public int? ReceiveCount { get; set; }

        [JsonProperty("change_address")]
        public string ChangeAddress { get; set; }

        [JsonProperty("block_hash")]
        public string BlockHash { get; set; }

        [JsonProperty("block_index")]
        public int? BlockIndex { get; set; }

        [JsonProperty("double_of")]
        public string DoubleOf { get; set; }

        [JsonProperty("data_protocol")]
        public string DataProtocol { get; set; }

        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("next_inputs")]
        public string NextInputs { get; set; }

        [JsonProperty("next_outputs")]
        public string NextOutputs { get; set; }
    }
}
