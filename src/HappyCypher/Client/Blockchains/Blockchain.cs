using HappyCypher.Client.Utilities;
using HappyCypher.Client.Utilities.Enums;
using HappyCypher.Domain.API;
using HappyCypher.Domain.Interface;
using HappyCypher.Models.Blockchain;
using HappyCypher.Models.Blockchains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCypher.Client.Blockchains
{
    public class Blockchain
    {
        private readonly IHappyCypherApiClient _client;
        public string TOKEN { get; private set; }

        public Blockchain(IHappyCypherApiClient client)
        {
            _client = client;
        }

        public void SetToken(string token) => TOKEN = token;


        public async Task<BlockchainResult> GetChain(ResourceType resourceType)
        {
            string url = EndPoints.GetUrl(resourceType, "v1");
            ApplyToken(url);
            return await _client.GetAsync<BlockchainResult>(url);
        }

        public async Task<BlockHashResult> GetBlockHash(ResourceType resourceType, string blockHash)
        {
            string url = EndPoints.GetUrl(resourceType, "v1");

            url += $"/blocks/{blockHash}";
            ApplyToken(url);

            return await _client.GetAsync<BlockHashResult>(url);
        }

        public async Task<BlockHashResult> GetBlockHeight(ResourceType resourceType, long blockHeight, int txStart = int.MinValue, int limit = int.MinValue)
        {
            string url = EndPoints.GetUrl(resourceType, "v1");

            url += $"/blocks/{blockHeight}";

            if (txStart != int.MinValue)
            {
                url += $"?txstart={txStart}";
            }

            if (limit != int.MinValue)
            {
                bool hasFilter = url.Contains("?txstart=");

                url += hasFilter ? $"&limit={limit}" : $"?limit={limit}";
            }

            return await _client.GetAsync<BlockHashResult>(url);
        }

        private void ApplyToken(string url)
        {
            url += $"?token={TOKEN}";
        }
    }
}
