using System;
using System.Collections.Generic;
using AncrRPC.Interfaces;
using Newtonsoft.Json;

namespace AncrRPC.Token
{
    internal class GetTokenHolderCountParams : IParams
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("contractAddress")]
        public string ContractAddress { get; set; }
        
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }
        
        [JsonProperty("pageToken")]
        public string NextPageToken { get; set; }
    }
    internal class GetTokenHolderCountResult : IResponse, IResult
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("contractAddress")]
        public string ContractAddress { get; set; }
        
        [JsonProperty("tokenDecimals")]
        public int TokenDecimals { get; set; }
        
        [JsonProperty("holderCountHistory")]
        public List<HolderCountHistory> HolderCountHistory { get; set; }
        
        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }
        
        [JsonProperty("latestHoldersCount")]
        public int LatestHoldersCount { get; set; }
    }
    internal class HolderCountHistory
    {
        [JsonProperty("holderCount")]
        public int HolderCount { get; set; }
        
        [JsonProperty("totalAmount")]
        public string TotalAmount { get; set; }
        
        [JsonProperty("totalAmountRawInteger")]
        public string TotalAmountRawInteger { get; set; }
        
        [JsonProperty("lastUpdatedAt")]
        public DateTime LastUpdatedAt { get; set; }
    }
}