using System.Collections.Generic;
using AncrRPC.Interfaces;
using Newtonsoft.Json;

namespace AncrRPC.Token
{
    internal class GetTokenHoldersParams : IParams
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
    internal class GetTokenHoldersResult : IResponse, IResult
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("contractAddress")]
        public string ContractAddress { get; set; }
        
        [JsonProperty("tokenDecimals")]
        public int TokenDecimals { get; set; }
        
        [JsonProperty("holders")]
        public List<Holder> Holders { get; set; }
        
        [JsonProperty("holdersCount")]
        public int HoldersCount { get; set; }
        
        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }
    }
    internal class Holder
    {
        [JsonProperty("holderAddress")]
        public string HolderAddress { get; set; }
        
        [JsonProperty("balance")]
        public string Balance { get; set; }
        
        [JsonProperty("balanceRawInteger")]
        public string BalanceRawInteger { get; set; }
    }
}