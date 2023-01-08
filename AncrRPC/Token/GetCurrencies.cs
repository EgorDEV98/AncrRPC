using System.Collections.Generic;
using AncrRPC.Interfaces;
using Newtonsoft.Json;

namespace AncrRPC.Token
{
    internal class GetCurrenciesParams : IParams
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
    }
    internal class GetCurrenciesResult : IResponse, IResult
    {
        [JsonProperty("currencies")]
        public List<Currency> Currencies { get; set; }
    }
    internal class Currency
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("address")]
        public string Address { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("decimals")]
        public int Decimals { get; set; }
        
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }
}