using System.Collections.Generic;
using AncrRPC.Interfaces;
using Newtonsoft.Json;

namespace AncrRPC.NFT
{
    internal class GetNFTMetadataParams : IParams
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("contractAddress")]
        public string ContractAddress  { get; set; }
        
        [JsonProperty("tokenId")]
        public string TokenId { get; set; }
    }
    
    internal class GetNFTMetadataResult : IResponse, IResult
    {
        [JsonProperty("metadata")]
        public Metadata metadata { get; set; }
        
        [JsonProperty("attributes")]
        public Attributes attributes { get; set; }
    }
    internal class Metadata
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("contractAddress")]
        public string ContractAddress { get; set; }
        
        [JsonProperty("tokenId")]
        public string TokenId { get; set; }
        
        [JsonProperty("contractType")]
        public string ContractType { get; set; }
    }
    internal class Attributes
    {
        [JsonProperty("tokenUrl")]
        public string URL { get; set; }
        
        [JsonProperty("imageUrl")]
        public string Image { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("traits")]
        public List<AssetNFTTrait> Traits { get; set; }
        
        [JsonProperty("attributes")]
        public string ContractType { get; set; }
    }
}