using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AncrRPC.Enums;
using AncrRPC.Errors;
using AncrRPC.Exception;
using AncrRPC.Extensions;
using AncrRPC.Interfaces;
using AncrRPC.NFT;
using AncrRPC.Query;
using AncrRPC.Token;
using Newtonsoft.Json;

namespace AncrRPC
{
    public class Ankr
    {
        private const string URL = "https://rpc.ankr.com/multichain";
        private static readonly HttpClient client = new();
        
        #region NFT_Methods
        
        public async Task<IResponse> GetNFTsByOwnerAsync(IEnumerable<Blockchain> blockchains,string walletAddress, string nextPageToken = null)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getNFTsByOwner",
                    Params = new GetNFTsByOwnerParams()
                    {
                        Blockchains = blockchains.ListToString(),
                        Address = walletAddress,
                        NextPageToken = nextPageToken
                    }
                };
                return await SendAsync<GetNFTsByOwnerResult>(parameters);
            }
            catch
            {
                throw;
            }
        }
        
        public async Task<IResponse> GetNFTsByOwnerAsync(Blockchain blockchain, string walletAddress, string nextPageToken = null)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getNFTsByOwner",
                    Params = new GetNFTsByOwnerParams()
                    {
                        Blockchains = blockchain.EnumToString(),
                        Address = walletAddress,
                        NextPageToken = nextPageToken
                    }
                };
                return await SendAsync<GetNFTsByOwnerResult>(parameters);
            }
            catch
            {
                throw;
            }
        }

        public async Task<IResponse> GetNFTMetadataAsync(Blockchain blockchain, string contractAddress, string tokenId)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getNFTMetadata",
                    Params = new GetNFTMetadataParams()
                    {
                        Blockchain = blockchain.ToString(),
                        ContractAddress = contractAddress,
                        TokenId = tokenId
                    }
                };
                return await SendAsync<GetNFTMetadataResult>(parameters);
            }
            catch
            {
                throw;
            }
        }
        
        public async Task<IResponse> GetNFTHoldersAsync(Blockchain blockchain, string contractAddress, int pageSize = 50, string nextPageToken = null)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getNFTHolders",
                    Params = new GetNFTHoldersParams()
                    {
                        Blockchain = blockchain.ToString(),
                        ContractAddress = contractAddress,
                        PageSize = pageSize > 1000
                            ? 1000
                            : pageSize,
                        NextPageToken = nextPageToken
                    }
                };
                return await SendAsync<GetNFTHoldersResult>(parameters);
            }
            catch
            {
                throw;
            }
        }
        
        #endregion

        #region Token_Methods

        public async Task<IResponse> GetAccountBalanceAsync(IEnumerable<Blockchain> blockchains, string walletAddress, int pageSize = 10, bool onlyWhiteList = true, string nextPageToken = null)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getAccountBalance",
                    Params = new GetAccountBalanceParams()
                    {
                        Blockchains = blockchains.ListToString(),
                        walletAddress = walletAddress,
                        PageSize = pageSize,
                        OnlyWhiteListed = onlyWhiteList,
                        NextPageToken = nextPageToken
                    }
                };
                return await SendAsync<GetAccountBalanceResult>(parameters);
            }
            catch
            {
                throw;
            }
        }
        
        public async Task<IResponse> GetAccountBalanceAsync(Blockchain blockchain, string walletAddress, int pageSize = 10, bool onlyWhiteList = true, string nextPageToken = null)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getAccountBalance",
                    Params = new GetAccountBalanceParams()
                    {
                        Blockchains = blockchain.EnumToString(),
                        walletAddress = walletAddress,
                        PageSize = pageSize,
                        OnlyWhiteListed = onlyWhiteList,
                        NextPageToken = nextPageToken
                    }
                };
                return await SendAsync<GetAccountBalanceResult>(parameters);
            }
            catch
            {
                throw;
            }
        }
        
        public async Task<IResponse> GetCurrenciesAsync(Blockchain blockchain)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getCurrencies",
                    Params = new GetCurrenciesParams()
                    {
                        Blockchain = blockchain.ToString()
                    }
                };
                return await SendAsync<GetCurrenciesResult>(parameters);
            }
            catch
            {
                throw;
            }
        }
        
        public async Task<IResponse> GetTokenPriceAsync(Blockchain blockchain, string contractAddress)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getTokenPrice",
                    Params = new GetTokenPriceParams()
                    {
                        Blockchain = blockchain.ToString(),
                        ContractAddress = contractAddress
                    }
                };
                return await SendAsync<GetTokenPriceResult>(parameters);
            }
            catch
            {
                throw;
            }
        }

        public async Task<IResponse> GetTokenHoldersAsync(Blockchain blockchain,string contractAddress, int pageSize, string nextPageToken = null)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getTokenHolders",
                    Params = new GetTokenHoldersParams()
                    {
                        Blockchain = blockchain.ToString(),
                        ContractAddress = contractAddress,
                        PageSize = pageSize > 10000 ? 10000 : pageSize,
                        NextPageToken = nextPageToken
                    }
                };
                return await SendAsync<GetTokenHoldersResult>(parameters);
            }
            catch
            {
                throw;
            }
        }
        
        public async Task<IResponse> GetTokenHoldersCountAsync(Blockchain blockchain, string contractAddress, int pageSize = 100,
            string nextPageToken = null)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getTokenHoldersCount",
                    Params = new GetTokenHolderCountParams()
                    {
                        Blockchain = blockchain.ToString(),
                        ContractAddress = contractAddress,
                        PageSize = pageSize,
                        NextPageToken = nextPageToken
                    }
                };
                return await SendAsync<GetTokenHolderCountResult>(parameters);
            }
            catch
            {
                throw;
            }
        }

        public async Task<IResponse> GetTransfersByAddress(Blockchain blockchain, string walletAddress, int pageSize = 10, 
            TransactionType transactionType = TransactionType.REGULAR_TRANSACTION,
            OrderBy orderBy = OrderBy.DESC, long timestamp = 0, string nextPageToken = null)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getTransfersByAddress",
                    Params = new GetTransfersByAddressParams()
                    {
                        Blockchain = blockchain.ToString(),
                        WalletAddress = walletAddress,
                        PageSize = pageSize,
                        TransactionType = transactionType.ToString(),
                        OrderBy = orderBy.ToBool(),
                        Timestamp = timestamp,
                        NextPageToken = nextPageToken
                    }
                };
                return await SendAsync<GetTransfersByAddressResult>(parameters);
            }
            catch
            {
                throw;
            }
        }
        
        #endregion

        #region Query_Methods

        public async Task<IResponse> GetBlocksAsync(Blockchain blockchain, long fromBlock, long toBlock, bool decodeLogs = true, bool decodeTxData = true,
            OrderBy orderBy = OrderBy.DESC, bool includeLogs = true, bool includeTxs = true)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getBlocks",
                    Params = new GetBlocksParams()
                    {
                        Blockchain = blockchain.ToString(),
                        DecodeLogs = decodeLogs,
                        DescOrder = orderBy.ToBool(),
                        FromBlock = fromBlock,
                        IncludeLogs = includeLogs,
                        IncludeTxs = includeTxs,
                        ToBlock = toBlock,
                        DecodeTxData = decodeTxData
                    }
                };
                return await SendAsync<GetBlocksResult>(parameters);
            }
            catch
            {
                throw;
            }
        }

        public async Task<IResponse> GetLogsAsync(IEnumerable<Blockchain> blockchains, List<List<int>> address,long fromBlock, long toBlock, int pageSize = 50, bool decodeLogs = true, 
            OrderBy orderBy = OrderBy.DESC, long fromTimeStamp = 0, long toTimeStamp = 0, List<List<List<int>>> topics = null, string nextPageToken = null)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getLogs",
                    Params = new GetLogsParams()
                    {
                        Blockchain = blockchains.ListToString(),
                        Address = address,
                        DecodeLogs = decodeLogs,
                        DescOrder = orderBy.ToBool(),
                        FromBlock = fromBlock,
                        ToBlock = toBlock,
                        PageSize = pageSize,
                        FromTimestamp = fromTimeStamp,
                        ToTimestamp = toTimeStamp,
                        Topics = topics,
                        PageToken = nextPageToken
                    }
                };
                return await SendAsync<GetLogsResult>(parameters);
            }
            catch
            {
                throw;
            }
        }

        public async Task<IResponse> GetLogsAsync(Blockchain blockchain, List<List<int>> address,long fromBlock, long toBlock, int pageSize = 50, bool decodeLogs = true, 
            OrderBy orderBy = OrderBy.DESC, long fromTimeStamp = 0, long toTimeStamp = 0, List<List<List<int>>> topics = null, string nextPageToken = null)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getLogs",
                    Params = new GetLogsParams()
                    {
                        Blockchain = blockchain.EnumToString(),
                        Address = address,
                        DecodeLogs = decodeLogs,
                        DescOrder = orderBy.ToBool(),
                        FromBlock = fromBlock,
                        ToBlock = toBlock,
                        PageSize = pageSize,
                        FromTimestamp = fromTimeStamp,
                        ToTimestamp = toTimeStamp,
                        Topics = topics,
                        PageToken = nextPageToken
                    }
                };
                return await SendAsync<GetLogsResult>(parameters);
            }
            catch
            {
                throw;
            }
        }

        public async Task<IResponse> GetTransactionByHashAsync(IEnumerable<Blockchain> blockchains, string transactionHash, bool decodeLogs = true, bool includeLogs = true, bool decodeTxData = true)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getTransactionsByHash",
                    Params = new GetTransactionsByHashParams()
                    {
                        Blockchain = blockchains.ListToString(),
                        DecodeLogs = decodeLogs,
                        IncludeLogs = includeLogs,
                        TransactionHash = transactionHash,
                        DecodeTxData = decodeTxData
                    }
                };
                return await SendAsync<GetTransactionsByHashResult>(parameters);
            }
            catch
            {
                throw;
            }
        }
        
        public async Task<IResponse> GetInteractionsAsync(string address)
        {
            try
            {
                var parameters = new Request()
                {
                    Method = "ankr_getInteractions",
                    Params = new GetInteractionsParams()
                    {
                        Address = address
                    }
                };
                return await SendAsync<GetInteractionsResult>(parameters);
            }
            catch
            {
                throw;
            }
        }


        #endregion
        
        private async Task<IResponse> SendAsync<T>(Request parameters)
        {
            var stringContent = JsonConvert.SerializeObject(parameters);
            var requestContent = new StringContent(stringContent, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(URL, requestContent);
            var responseContent = await response.Content.ReadAsStringAsync();
                
            var responseResult = JsonConvert.DeserializeObject<Response<T>>(responseContent);
            if (responseResult.Result == null)
            {
                var error = JsonConvert.DeserializeObject<ErrorBase>(responseContent);
                throw new AncrException(error.error.Message, error.error.Code);
            }
            return responseResult;
        }
    }
    

    internal class Request
    {
        [JsonProperty("id")]
        public long Id { get; set; } = 1;

        [JsonProperty("jsonrpc")] 
        public string JsonRPC { get; set; } = "2.0";
        
        [JsonProperty("method")] 
        public string Method { get; set; }
        
        [JsonProperty("params")] 
        public IParams Params { get; set; }
    }
    internal class Response<T> : IResponse
    {
        [JsonProperty("jsonrpc")]
        public string JsonRPC { get; set; }
        
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("result")]
        public T Result { get; set; }
    }

}