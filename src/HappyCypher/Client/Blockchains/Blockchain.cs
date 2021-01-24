using HappyCypher.Client.Utilities;
using HappyCypher.Client.Utilities.Enums;
using HappyCypher.Domain.API;
using HappyCypher.Domain.Interface;
using HappyCypher.Models.Blockchain;
using System;
using System.Collections.Generic;
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


        public async Task<Blockchain> GetChain(ResourceType resourceType)
        {
            string url = EndPoints.GetUrl(resourceType, "v1");

            return await _client.GetAsync<Blockchain>(url);
        }
    
    }
}
