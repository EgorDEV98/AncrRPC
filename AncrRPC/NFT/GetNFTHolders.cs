using System.Collections.Generic;
using AncrRPC.Interfaces;
using Newtonsoft.Json;

namespace AncrRPC.NFT
{
    internal class GetNFTHoldersParams : IParams
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("contractAddress")]
        public string ContractAddress  { get; set; }
        
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }
        
        [JsonProperty("pageToken")]
        public string NextPageToken { get; set; }
    }
    
    internal class GetNFTHoldersResult : IResponse, IResult
    {
        [JsonProperty("holders")]
        public List<string> Holders { get; set; }
        
        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }
    }
}