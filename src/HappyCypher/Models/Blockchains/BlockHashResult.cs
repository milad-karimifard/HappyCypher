using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Models.Blockchains
{
    public class BlockHashResult
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("depth")]
        public int Depth { get; set; }

        [JsonProperty("chain")]
        public string Chain { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("fees")]
        public int Fees { get; set; }

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("ver")]
        public int Ver { get; set; }

        [JsonProperty("time")]
        public DateTime Time { get; set; }

        [JsonProperty("received_time")]
        public DateTime ReceivedTime { get; set; }

        [JsonProperty("relayed_by")]
        public string RelayedBy { get; set; }

        [JsonProperty("bits")]
        public int Bits { get; set; }

        [JsonProperty("nonce")]
        public int Nonce { get; set; }

        [JsonProperty("n_tx")]
        public int NTx { get; set; }

        [JsonProperty("prev_block")]
        public string PrevBlock { get; set; }

        [JsonProperty("prev_block_url")]
        public string PrevBlockUrl { get; set; }

        [JsonProperty("tx_url")]
        public string TxUrl { get; set; }

        [JsonProperty("mrkl_root")]
        public string MrklRoot { get; set; }

        [JsonProperty("txids")]
        public List<string> TxIds { get; set; }

        [JsonProperty("next_txids")]
        public string NextTxIds { get; set; }
    }
}
