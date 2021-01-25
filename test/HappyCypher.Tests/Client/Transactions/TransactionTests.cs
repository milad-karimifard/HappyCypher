using HappyCypher.Client.Blockchains;
using HappyCypher.Client.Transactions;
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
    public class TransactionTests
    {
        private readonly Transaction testCase;
        private readonly string TOKEN = "Your Token";
        private string fromAddress;
        private string toAddress;
        private int value;

        public TransactionTests()
        {
            testCase = new Transaction(new HappyCypherApiClient(new HttpClient()));
            SetUpData();
        }

        private void SetUpData()
        {
            fromAddress = "mox7Xiw3BX772N3cj45kdwQktk8cwMxfDo";
            toAddress = "mzfYMMjVMLb341X8L3vJ67WX8RioafYmvk";
            value = 10000;
        }

        [Fact]
        public async Task CreateTransaction_Should_Be_Fine()
        {
            SetToken();
            var result = await testCase.CreateTransaction(ResourceType.BitCoinTest, fromAddress, toAddress, value);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task CreateTransaction_With_Tx_Signed_Should_Be_Fine()
        {
            SetToken();
            var result = await testCase.CreateTransaction(ResourceType.BitCoinTest, fromAddress, toAddress, value, true);
            Assert.NotNull(result);
        }

        private void SetToken()
        {
            testCase.SetToken(TOKEN);
        }
    }
}
