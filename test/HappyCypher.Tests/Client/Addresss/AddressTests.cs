using HappyCypher.Client.Addresss;
using HappyCypher.Client.Utilities.Enums;
using HappyCypher.Domain.API;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HappyCypher.Tests.Client.Addresss
{
    public class AddressTests
    {
        private readonly Address testCase;
        private readonly string TOKEN = "YOUR TOKEN";

        public AddressTests()
        {
            testCase = new Address(new HappyCypherApiClient(new HttpClient()));
        }

        [Fact]
        public async Task GetChain_Should_Be_Fine()
        {
            SetToken();
            var result = await testCase.GetAddressBalance(ResourceType.BitCoinMain, "bc1qjr9y78heau4kmwl85pzzw89z50ccsv9w9qwu2p");
            Assert.NotNull(result);
        }

        private void SetToken()
        {
            testCase.SetToken(TOKEN);
        }
    }
}
