using HappyCypher.Client.Utilities;
using HappyCypher.Client.Utilities.Enums;
using HappyCypher.Domain.Interface;
using HappyCypher.Models.Addresss;
using HappyCypher.Models.Transactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HappyCypher.Client.Transactions
{
    public class Transaction
    {
        private readonly IHappyCypherApiClient _client;
        public string TOKEN { get; private set; }

        public Transaction(IHappyCypherApiClient client)
        {
            _client = client;
        }

        public void SetToken(string token) => TOKEN = token;

        public async Task<TXSkeleton> CreateTransaction(ResourceType resourceType, string fromAddress, string toAddress, int value, bool includeToSignTx = false)
        {
            var transaction = new BasicTransaction
            {
                Inputs = new[] {
                    new TxInput {
                        Addresses = new[] {
                            fromAddress
                        }
                    }
                },
                Outputs = new[] {
                    new TxOutput {
                        Addresses = new[] {
                            toAddress
                        },
                        Value = value
                    }
                }
            };

            string url = EndPoints.GetUrl(resourceType, "v1");
            url += "/txs/new";
            ApplyToken(ref url);

            if (includeToSignTx) url += "&includeToSignTx=true";

            return await _client.PostAsync<BasicTransaction, TXSkeleton>(url, transaction);
        }

        private void ApplyToken(ref string url)
        {
            url += $"?token={TOKEN}";
        }
    }
}
