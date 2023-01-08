using System.Collections.Generic;
using AncrRPC.Interfaces;
using Newtonsoft.Json;

namespace AncrRPC.Token
{
    public enum OrderBy
    {
        ASC,
        DESC
    }
    public enum TransactionType
    {
        REGULAR_TRANSACTION,
        TRANSFER_TOKEN,
        ERC721,
        ERC1155
    }
    internal class GetTransfersByAddressParams : IParams
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("walletAddress")]
        public string WalletAddress { get; set; }
        
        [JsonProperty("transactionType")]
        public string TransactionType { get; set; }
        
        [JsonProperty("orderAsc")]
        public bool OrderBy { get; set; }
        
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }
        
        [JsonProperty("pageToken")]
        public string NextPageToken { get; set; }
        
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }

    internal class GetTransfersByAddressResult : IResponse, IResult
    {
        [JsonProperty("transactions")]
        public List<Transaction> Transactions { get; set; }
        
        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }
    }
    internal class Transaction
    {
        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }
        
        [JsonProperty("transactionHash")]
        public string TransactionHash { get; set; }
        
        [JsonProperty("TransactionId")]
        public string transactionId { get; set; }
        
        [JsonProperty("blockHeight")]
        public long BlockHeight { get; set; }
        
        [JsonProperty("blockHash")]
        public string BlockHash { get; set; }
        
        [JsonProperty("fromAddress")]
        public string FromAddress { get; set; }
        
        [JsonProperty("ContractAddress")]
        public string contractAddress { get; set; }
        
        [JsonProperty("toAddress")]
        public string ToAddress { get; set; }
        
        [JsonProperty("value")]
        public string Value { get; set; }
        
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
        
        [JsonProperty("success")]
        public bool IsSuccess { get; set; }
        
        [JsonProperty("actionDescription")]
        public string ActionDescription { get; set; }
        
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("transactionIndex")]
        public int TransactionIndex { get; set; }
        
        [JsonProperty("logIndex")]
        public int LogIndex { get; set; }
        
        [JsonProperty("isLog")]
        public bool IsLog { get; set; }
    }
}