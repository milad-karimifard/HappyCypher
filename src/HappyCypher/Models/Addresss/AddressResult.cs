using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Models.Addresss
{
    public class AddressResult
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("total_received")]
        public int TotalReceived { get; set; }

        [JsonProperty("total_sent")]
        public int TotalSent { get; set; }

        [JsonProperty("balance")]
        public int Balance { get; set; }

        [JsonProperty("unconfirmed_balance")]
        public int UnconfirmedBalance { get; set; }

        [JsonProperty("final_balance")]
        public int FinalBalance { get; set; }

        [JsonProperty("n_tx")]
        public int NTx { get; set; }

        [JsonProperty("unconfirmed_n_tx")]
        public int UnconfirmedNTx { get; set; }

        [JsonProperty("final_n_tx")]
        public int FinalNTx { get; set; }

        [JsonProperty("tx_url")]
        public string TxUrl { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        [JsonProperty("wallet")]
        public Wallet Wallet { get; set; }

        [JsonProperty("hd_wallet")]
        public HDWallet HDWallet { get; set; }

        [JsonProperty("txs")]
        public List<Tx> Txs { get; set; }

        [JsonProperty("txrefs")]
        public List<TXRef> txrefs { get; set; }

        [JsonProperty("unconfirmed_txrefs")]
        public List<TXRef> UnconfirmedTxRefs { get; set; }
    }
}
