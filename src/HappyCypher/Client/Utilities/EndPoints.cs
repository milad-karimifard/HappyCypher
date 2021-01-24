using HappyCypher.Client.Utilities.Enums;
using HappyCypher.Extensions.EndPoints;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Client.Utilities
{
    /// <summary>
    /// Blockcypher Endpoint list
    /// you must set api version by SetAPIVersion method
    /// ex: EndPoints.BitCoinMain.SetAPIVersion("v1");
    /// </summary>
    public class EndPoints
    {
        #region Coin Base Url 

        public const string BitCoinMain = "{0}/btc/main";
        public const string BitCoinTest = "{0}/btc/test3";
        public const string DashMain = "{0}/dash/main";
        public const string DogeCoinMain = "{0}/doge/main";
        public const string LiteCoinMain = "{0}/ltc/main";
        public const string BlockCypherTest = "{0}/bcy/test";

        #endregion

        public static string GetUrl(ResourceType resourceType,string apiVersion)
        {
            switch (resourceType)
            {
                case ResourceType.BitCoinMain:
                    return BitCoinMain.SetAPIVersion(apiVersion);
                case ResourceType.BitCoinTest:
                    return BitCoinTest.SetAPIVersion(apiVersion);
                case ResourceType.DashMain:
                    return DashMain.SetAPIVersion(apiVersion);
                case ResourceType.DogeCoinMain:
                    return DogeCoinMain.SetAPIVersion(apiVersion);
                case ResourceType.LiteCoinMain:
                    return LiteCoinMain.SetAPIVersion(apiVersion);
                case ResourceType.BlockCypherTest:
                    return BlockCypherTest.SetAPIVersion(apiVersion);
                default:
                    throw new ArgumentException("invalid resource type");
            }
        }
    }
}
