using AncrRPC.Interfaces;
using Newtonsoft.Json;

namespace AncrRPC.Token
{
    internal class GetTokenPriceParams : IParams
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("contractAddress")]
        public string ContractAddress { get; set; }
    }
    internal class GetTokenPriceResult : IResponse, IResult
    {
        [JsonProperty("usdPrice")]
        public string USDPrice { get; set; }
        
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("contractAddress")]
        public string ContractAddress { get; set; }
    }
}