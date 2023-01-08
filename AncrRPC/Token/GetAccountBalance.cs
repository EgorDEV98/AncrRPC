using System.Collections.Generic;
using AncrRPC.Interfaces;
using Newtonsoft.Json;

namespace AncrRPC.Token
{
    internal class GetAccountBalanceParams : IParams
    {
        [JsonProperty("blockchain")]
        public string[] Blockchains { get; set; }

        [JsonProperty("onlyWhitelisted")] 
        public bool OnlyWhiteListed { get; set; } = false;

        [JsonProperty("pageSize")] 
        public int PageSize { get; set; } = 10;

        [JsonProperty("pageToken")]
        public string NextPageToken { get; set; } = null!;
        
        [JsonProperty("walletAddress")]
        public string walletAddress { get; set; }
    }
    
    internal class GetAccountBalanceResult : IResponse, IResult
    {
        [JsonProperty("totalBalanceUsd")]
        public string TotalBalanceUSD { get; set; }
        
        [JsonProperty("assets")]
        public List<AssetToken> Assets { get; set; }
    }
    internal class AssetToken
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("tokenName")]
        public string TokenName { get; set; }
        
        [JsonProperty("tokenSymbol")]
        public string TokenSymbol { get; set; }
        
        [JsonProperty("tokenDecimals")]
        public int TokenDecimals { get; set; }
        
        [JsonProperty("tokenType")]
        public string TokenType { get; set; }
        
        [JsonProperty("holderAddress")]
        public string HolderAddress { get; set; }
        
        [JsonProperty("balance")]
        public string Balance { get; set; }
        
        [JsonProperty("balanceRawInteger")]
        public string BalanceRawInteger { get; set; }
        
        [JsonProperty("balanceUsd")]
        public string BalanceUSD { get; set; }
        
        [JsonProperty("tokenPrice")]
        public string TokenPrice { get; set; }
        
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
        
        [JsonProperty("contractAddress")]
        public string ContractAddress { get; set; }
    }
}