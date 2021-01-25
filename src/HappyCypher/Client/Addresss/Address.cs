using HappyCypher.Client.Utilities;
using HappyCypher.Client.Utilities.Enums;
using HappyCypher.Domain.Interface;
using HappyCypher.Models.Addresss;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HappyCypher.Client.Addresss
{
    public class Address
    {
        private readonly IHappyCypherApiClient _client;
        public string TOKEN { get; private set; }

        public Address(IHappyCypherApiClient client)
        {
            _client = client;
        }

        public void SetToken(string token) => TOKEN = token;

        public async Task<AddressBalanceResult> GetAddressBalance(ResourceType resourceType,string address)
        {
            string url = EndPoints.GetUrl(resourceType, "v1");

            url += $"/addrs/{address}/balance";
            ApplyToken(url);
            
            return await _client.GetAsync<AddressBalanceResult>(url);
        }

        private void ApplyToken(string url)
        {
            url += $"?token={TOKEN}";
        }
    }
}
