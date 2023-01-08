using System.Collections.Generic;
using AncrRPC.Interfaces;
using Newtonsoft.Json;

namespace AncrRPC.NFT
{
    internal class GetNFTsByOwnerParams : IParams
    {
        [JsonProperty("walletAddress")] 
        public string Address { get; set; }

        [JsonProperty("blockchain")] 
        public string[] Blockchains { get; set; }

        [JsonProperty("pageSize")] 
        public int PageSize { get; set; } = 10;
        
        [JsonProperty("pageToken")]
        public string NextPageToken { get; set; }
        
        [JsonProperty("filter")]
        public Dictionary<string, List<string>> Filter { get; set; }
    }
    
    internal class GetNFTsByOwnerResult : IResponse, IResult
    {
        [JsonProperty("owner")]
        public string Owner { get; set; }
        
        [JsonProperty("assets")]
        public List<AssetNFT> Assets { get; set; }
        
        [JsonProperty("nextPageToken")]
        public string nextPageToken { get; set; }
    }
    internal class AssetNFT
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("tokenId")]
        public string TokenId { get; set; }
        
        [JsonProperty("imageUrl")]
        public string Image { get; set; }
        
        [JsonProperty("collectionName")]
        public string CollectionName { get; set; }
        
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        
        [JsonProperty("contractType")]
        public string ContractType { get; set; }
        
        [JsonProperty("contractAddress")]
        public string ContractAddress { get; set; }
        
        [JsonProperty("traits")]
        public List<AssetNFTTrait> Traits { get; set; }
    }
    internal class AssetNFTTrait
    {
        [JsonProperty("trait_type")]
        public string TraitType { get; set; }
        
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}