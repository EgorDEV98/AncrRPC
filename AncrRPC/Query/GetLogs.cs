using System.Collections.Generic;
using AncrRPC.Interfaces;
using Newtonsoft.Json;

namespace AncrRPC.Query
{
        internal class GetLogsParams : IParams
    {
        [JsonProperty("address")]
        public List<List<int>> Address { get; set; }
        
        [JsonProperty("blockchain")]
        public string[] Blockchain { get; set; }
        
        [JsonProperty("decodeLogs")]
        public bool DecodeLogs { get; set; }
        
        [JsonProperty("descOrder")]
        public bool DescOrder { get; set; }
        
        [JsonProperty("fromBlock")]
        public long FromBlock { get; set; }
        
        [JsonProperty("fromTimestamp")]
        public long FromTimestamp { get; set; }
        
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }
        
        [JsonProperty("pageToken")]
        public string PageToken { get; set; }
        
        [JsonProperty("toBlock")]
        public long ToBlock { get; set; }
        
        [JsonProperty("toTimestamp")]
        public long ToTimestamp { get; set; }
        
        [JsonProperty("topics")]
        public List<List<List<int>>> Topics { get; set; }
    }
    internal class GetLogsResult : IResponse, IResult
    {
        [JsonProperty("logs")]
        public List<GetLogsLog> Logs { get; set; }
    }
    internal class GetLogsLog
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("address")]
        public string Address { get; set; }
        
        [JsonProperty("topics")]
        public List<string> Topics { get; set; }
        
        [JsonProperty("data")]
        public string Data { get; set; }
        
        [JsonProperty("blockNumber")]
        public string BlockNumber { get; set; }
        
        [JsonProperty("transactionHash")]
        public string TransactionHash { get; set; }
        
        [JsonProperty("transactionIndex")]
        public string TransactionIndex { get; set; }
        
        [JsonProperty("blockHash")]
        public string BlockHash { get; set; }
        
        [JsonProperty("logIndex")]
        public string LogIndex { get; set; }
        
        [JsonProperty("removed")]
        public bool Removed { get; set; }
    }
}