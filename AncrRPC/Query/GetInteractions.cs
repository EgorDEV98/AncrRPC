using System.Collections.Generic;
using AncrRPC.Interfaces;
using Newtonsoft.Json;

namespace AncrRPC.Query
{
    internal class GetInteractionsParams : IParams
    {
        [JsonProperty("address")]
        public string Address { get; set; }
    }
    internal class GetInteractionsResult : IResponse, IResult
    {
        [JsonProperty("blockchains")]
        public List<string> Blockchains { get; set; }
    }
}