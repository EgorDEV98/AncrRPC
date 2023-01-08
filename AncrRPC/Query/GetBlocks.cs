using System.Collections.Generic;
using AncrRPC.Interfaces;
using Newtonsoft.Json;

namespace AncrRPC.Query
{
        
    internal class GetBlocksParams : IParams
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("decodeLogs")]
        public bool DecodeLogs { get; set; }
        
        [JsonProperty("decodeTxData")]
        public bool DecodeTxData { get; set; }
        
        [JsonProperty("descOrder")]
        public bool DescOrder { get; set; }
        
        [JsonProperty("fromBlock")]
        public long FromBlock { get; set; }
        
        [JsonProperty("includeLogs")]
        public bool IncludeLogs { get; set; }
        
        [JsonProperty("includeTxs")]
        public bool IncludeTxs { get; set; }
        
        [JsonProperty("toBlock")]
        public long ToBlock { get; set; }
    }
    internal class GetBlocksResult : IResponse, IResult
    {
        [JsonProperty("blocks")]
        public List<Block> Blocks { get; set; }
    }
    internal class Block
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("number")]
        public string Number { get; set; }
        
        [JsonProperty("hash")]
        public string Hash { get; set; }
        
        [JsonProperty("parentHash")]
        public string ParentHash { get; set; }
        
        [JsonProperty("nonce")]
        public string Nonce { get; set; }
        
        [JsonProperty("mixHash")]
        public string MixHash { get; set; }
        
        [JsonProperty("sha3Uncles")]
        public string Sha3Uncles { get; set; }
        
        [JsonProperty("logsBloom")]
        public string LogsBloom { get; set; }
        
        [JsonProperty("stateRoot")]
        public string StateRoot { get; set; }
        
        [JsonProperty("miner")]
        public string Miner { get; set; }
        
        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }
        
        [JsonProperty("extraData")]
        public string ExtraData { get; set; }
        
        [JsonProperty("size")]
        public string Size { get; set; }
        
        [JsonProperty("gasLimit")]
        public string GasLimit { get; set; }
        
        [JsonProperty("gasUsed")]
        public string GasUsed { get; set; }
        
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
        
        [JsonProperty("transactionsRoot")]
        public string TransactionsRoot { get; set; }
        
        [JsonProperty("receiptsRoot")]
        public string ReceiptsRoot { get; set; }
        
        [JsonProperty("totalDifficulty")]
        public string TotalDifficulty { get; set; }
        
        [JsonProperty("transactions")]
        public List<BlockTransaction> Transactions { get; set; }
        
        [JsonProperty("tncles")]
        public List<object> Uncles { get; set; }
    }
    internal class BlockTransaction
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
        public List<Log> Logs { get; set; }
        
        [JsonProperty("hash")]
        public string Hash { get; set; }
        
        [JsonProperty("status")]
        public string Status { get; set; }
        
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
        
        [JsonProperty("method")]
        public Method Method { get; set; }
    }
    internal class Method
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("name")]
        public List<Input> Inputs { get; set; }
        
        [JsonProperty("string")]
        public string String { get; set; }
        
        [JsonProperty("name")]
        public string Signature { get; set; }
        
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }
    internal class Log
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
    internal class Input
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("size")]
        public int Size { get; set; }
        
        [JsonProperty("valueDecoded")]
        public string ValueDecoded { get; set; }
    }
}