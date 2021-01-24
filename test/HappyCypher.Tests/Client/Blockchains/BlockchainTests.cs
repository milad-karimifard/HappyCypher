using HappyCypher.Client.Blockchains;
using HappyCypher.Client.Utilities.Enums;
using HappyCypher.Domain.API;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HappyCypher.Tests.Client.Blockchains
{
    public class BlockchainTests
    {
        private readonly Blockchain testCase;
        private readonly string TOKEN = "YOUR TOKEN";

        public BlockchainTests()
        {
            testCase = new Blockchain(new HappyCypherApiClient(new HttpClient()));
        }

        [Fact]
        public async Task GetChain_Should_Be_Fine()
        {
            SetToken();
            var result = await testCase.GetChain(ResourceType.BitCoinMain);
            Assert.NotNull(result);
        }

        private void SetToken()
        {
            testCase.SetToken(TOKEN);
        }
    }
}
