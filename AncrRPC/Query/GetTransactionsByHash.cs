using System.Collections.Generic;
using AncrRPC.Interfaces;
using Newtonsoft.Json;

namespace AncrRPC.Query
{
     internal class GetTransactionsByHashParams : IParams
    {
        [JsonProperty("blockchain")]
        public string[] Blockchain { get; set; }
        
        [JsonProperty("decodeLogs")]
        public bool DecodeLogs { get; set; }
        
        [JsonProperty("decodeTxData")]
        public bool DecodeTxData { get; set; }
        
        [JsonProperty("includeLogs")]
        public bool IncludeLogs { get; set; }
        
        [JsonProperty("transactionHash")]
        public string TransactionHash { get; set; }
    }
    internal class GetTransactionsByHashResult : IResponse, IResult
    {
        public List<GetTransactionsByHashTransaction> transactions { get; set; }
    }
    internal class GetTransactionsByHashTransaction
    {
        [JsonProperty("v")]
        public string V { get; set; }
        
        [JsonProperty("r")]
        public string R { get; set; }
        
        [JsonProperty("s")]
        public string S { get; set; }
        
        [JsonProperty("nonce")]
        public string Nonce { get; set; }
        
        [JsonProperty("blockNumber")]
        public string BlockNumber { get; set; }
        
        [JsonProperty("from")]
        public string From { get; set; }
        
        [JsonProperty("to")]
        public string To { get; set; }
        
        [JsonProperty("gas")]
        public string Gas { get; set; }
        
        [JsonProperty("gasPrice")]
        public string GasPrice { get; set; }
        
        [JsonProperty("input")]
        public string Input { get; set; }
        
        [JsonProperty("transactionIndex")]
        public string TransactionIndex { get; set; }
        
        [JsonProperty("blockHash")]
        public string BlockHash { get; set; }
        
        [JsonProperty("value")]
        public string Value { get; set; }
        
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("cumulativeGasUsed")]
        public string CumulativeGasUsed { get; set; }
        
        [JsonProperty("gasUsed")]
        public string GasUsed { get; set; }
        
        [JsonProperty("logs")]
        public List<GetTransactionsByHashLog> Logs { get; set; }
        
        [JsonProperty("hash")]
        public string Hash { get; set; }
        
        [JsonProperty("status")]
        public string Status { get; set; }
        
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
    internal class GetTransactionsByHashLog
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
        
        [JsonProperty("event")]
        public GetTransactionsByHashEvent Event { get; set; }
    }
    internal class GetTransactionsByHashEvent
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("inputs")]
        public List<object> Inputs { get; set; }
        
        [JsonProperty("anonymous")]
        public bool Anonymous { get; set; }
        
        [JsonProperty("string")]
        public string String { get; set; }
        
        [JsonProperty("signature")]
        public string Signature { get; set; }
        
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }
}