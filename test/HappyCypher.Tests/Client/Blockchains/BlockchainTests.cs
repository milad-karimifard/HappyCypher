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

        [Fact]
        public async Task GetBlockHash_Should_Be_Fine()
        {
            SetToken();
            var result = await testCase.GetBlockHash(ResourceType.BitCoinMain, "0000000000000000189bba3564a63772107b5673c940c16f12662b3e8546b412");
            Assert.NotNull(result);
        }

        private void SetToken()
        {
            testCase.SetToken(TOKEN);
        }
    }
}
