<strong>Unofficial library for working with Ankr Advanced APIs</strong>

This is just a brief description of the methods. For a more detailed description, visit the official website:<br>
<strong>https://www.ankr.com/docs/advanced-api/overview/</strong>

<h2>Code Example:</h2>

<h3>NFTs API</h3>

<ol>
  <li>
    <h5>
      MultiChain Get NFTs Balance<br>Description: Retrieves a list of NFTs (ERC721/ERC1155/ENS/POAP) that belong to the particular account specified.
      <h5/>
    
    using AnkrRPC;
      
    Ankr ankr = new Ankr();
    
    string walletAddress = "0xf573d99385C05c23B24ed33De616ad16a43a0919";
    var blockchaines = new[]
    {
      Blockchain.ETH,
      Blockchain.BSC
    };
    string nextPageToken;  // Not a requered parameter.
    
    var multiChainRequest = await ankr.GetNFTsByOwnerAsync(blockchaines, walletAddress);
    var oneChainRequest = await ankr.GetNFTsByOwnerAsync(Blockchain.ETH, walletAddress);
  </li>
  
  <li>
    <h5>
      Get NFT Metadata<br>Description: Retrieves the metadata that belongs to a particular NFT (ERC721/ERC1155/ENS/POAP).
    </h5>

    
    using AnkrRPC;
    
    Ankr ankr = new Ankr();
    
    var blockchain = Blockchain.ETH;
    string contractAddress = "0x8d01c8ee82e581e55c02117a676b5bbd4734fabb";
    string tokenId = "23240";
    
    var result = await ankr.GetNFTMetadataAsync(blockchain, contractAddress, tokenId );
  </li>
  
  <li>
    <h5>Get NFT Holders<br>
      Description: Retrieves a list of holders (wallet addresses) of the NFT specified by request body parameters.
    </h5>

    using AnkrRPC;
    
    Ankr ankr = new Ankr();
    
    var blockchain = Blockchain.ETH;
    string contractAddress = "0x8d01c8ee82e581e55c02117a676b5bbd4734fabb";
    int pageSize = 10; // Not a requered parameter. The default setting is 50
    string nextPageToken = null; // Not a requered parameter.
    
    var result = await ankr.GetNFTHoldersAsync(blockchain, contractAddress, tokenId );
  </li>
</ol>

<h3>Query API</h3>

<ol>
  <li>
    <h5>Get Blocks<br>
      Retrieves complete information for the block specified.
    </h5>
    
    using AnkrRPC;
    
    Ankr ankr = new Ankr();
    
    var blockchain = Blockchain.ETH;
    long fromBlock = 14500000;
    long toBlock = 14500000;
    bool decodeLogs = true; // Not a requered parameter. The default: true
    bool decodeTxData = true; // Not a requered parameter. The default: true
    var orderBy = OrderBy.DESC; // Not a requered parameter. The default: OrderBy.DESC
    bool includeLogs = true; // Not a requered parameter. The default: true
    bool includeTxs = true; // Not a requered parameter. The default: true
    
    var result = await ankr.GetBlocksAsync(blockchain, fromBlock, toBlock);
  </li>
  
  <li>
    <h5>Get Logs<br>
      Retrieves history data for the blocks specified.
    </h5>
    
    using AnkrRPC;
    
    Ankr ankr = new Ankr();
    
    var blockchaines = new[] 
    {
      Blockchain.ETH,
      Blockchain.BSC
    };
    var addresses = new List<List<int>> { { 0 } };
    long fromBlock = 14500000;
    long toBlock = 14500000;
    int pageSize = 15; // Not a requered parameter. The default: 50;
    var orderBy = OrderBy.DESC; // Not a requered parameter. The default: OrderBy.DESC
    long fromTimeStamp = 0; //Not a requered parameter. The default: 0
    long toTimeStamp = 0; //Not a requered parameter. The default: 0
    var topics = new List<List<List<int>>> { { { 0 } } }; //Not a requered parameter. The default: null
    string nextPageToken = null; //Not a requered parameter. The default: null
    
    var multiChain = await ankr.GetLogsAsyncGetLogsAsync(
            blockchains, address, fromBlock, toBlock, pageSize, decodeLogs, 
            orderBy, fromTimeStamp, toTimeStamp, topics, nextPageToken);
    
    var onlyOneChain = await ankr.GetLogsAsyncGetLogsAsync(
            Blockchain.ETH, address, fromBlock, toBlock, pageSize, decodeLogs, 
            orderBy, fromTimeStamp, toTimeStamp, topics, nextPageToken);
  </li>
    
  <li>
    <h5>Get Transaction By Hash<br>
      Retrieves the details for a transaction specified by hash.
    </h5>
    
    using AnkrRPC;
    
    Ankr ankr = new Ankr();
    
    var blockchaines = new[] 
    {
      Blockchain.ETH,
      Blockchain.BSC
    };
    string transactionHash = "0x82c13aaac6f0b6471afb94a3a64ae89d45baa3608ad397621dbb0d847f51196f";
    bool decodeLogs = true; //Not a requered parameter. The default: true
    bool includeLogs = true; //Not a requered parameter. The default: true
    bool decodeTxData = true; //Not a requered parameter. The default: true
    
    var result = await ankr.GetTransactionByHashAsync(blockchaines, transactionHash, decodeLogs, includeLogs, decodeTxData);
  </li>
  
  <li>
    <h5>Get Transaction By Hash<br>
      Retrieves a list of blockchains on which the address interaction was registered and manifested by the info available for the address (tokens, NFTs, transactions).
    </h5>
    
    using AnkrRPC;
    
    Ankr ankr = new Ankr();
    
    string address = "0xF977814e90dA44bFA03b6295A0616a897441aceC";
   
    var result = await ankr.GetInteractionsAsync(address);
  </li>
</ol>

<h3>Tokens API</h3>

<ol>
  <li>
    <h5>Get Currencies<br>
      Retrieves the balance of the account specified.
    </h5>
    
    using AnkrRPC;
    
    Ankr ankr = new Ankr();
    var blockchaines = new[] 
    {
      Blockchain.ETH,
      Blockchain.BSC
    };
    string walletAddress = "0xF977814e90dA44bFA03b6295A0616a897441aceC";
    int pageSize = 25; //Not a requered parameter. The default: 50
    bool onlyWhiteList = true  //Not a requered parameter. The default: true
    string? nextPageToken = null;   //Not a requered parameter. The default: null
   
    var multiChainResult = await ankr.GetAccountBalanceAsync(blockchaines, walletAddress, pageSize, onlyWhiteList, nextPageToken);
    var onlyOneChainResult = await ankr.GetAccountBalanceAsync(Blockchain.ETH, walletAddress, pageSize, onlyWhiteList, nextPageToken);
  </li>
  
  <li>
    <h5>Get Transaction By Hash<br>
      Retrieves a list of all the currencies used in transactions on a blockchain specified.
    </h5>
    
    using AnkrRPC;
    
    Ankr ankr = new Ankr();
    var result = await ankr.GetCurrenciesAsync(Blockchain.ETH);
  </li>
  
  <li>
    <h5>Get Token Prices<br>
      Retrieves a USD price of the token specified.
    </h5>
    
    using AnkrRPC;
    
    Ankr ankr = new Ankr();
    string contractAddress = "0x8290333cef9e6d528dd5618fb97a76f268f3edd4";
    
    var result = await ankr.GetCurrenciesAsync(Blockchain.ETH, contractAddress);
  </li>
  
  <li>
    <h5>Get Token Holders<br>
      Retrieves holders and the associated metadata of the tokens specified.
    </h5>
    
    using AnkrRPC;
    
    Ankr ankr = new Ankr();
    string contractAddress = "0x8290333cef9e6d528dd5618fb97a76f268f3edd4";
    int pageSize = 6000; //Not a requered parameter. The default: 500 MAX: 10000
    string nextPageToken; //Not a requered parameter. The default: null
    
    var result = await ankr.GetCurrenciesAsync(Blockchain.ETH, contractAddress, pageSize, nextPageToken);
  </li>
  
  <li>
    <h5>Get Token Holders Count<br>
      Retrieves the number of holders for the tokens specified.
    </h5>
    
    using AnkrRPC;
    
    Ankr ankr = new Ankr();
    string contractAddress = "0x8290333cef9e6d528dd5618fb97a76f268f3edd4";
    int pageSize = 50; //Not a requered parameter. The default: 100
    string nextPageToken; //Not a requered parameter. The default: null
    
    var result = await ankr.GetTokenHoldersCountAsync(Blockchain.ETH, contractAddress, pageSize, nextPageToken);
  </li>
  
  <li>
    <h5>Get Transfers By Address<br>
      Retrieves the transfers info for the wallet address specified.
    </h5>
    
    using AnkrRPC;
    
    Ankr ankr = new Ankr();
    string walletAddress = "0x186ea56f0a40c5593a697b3e804968b8c5920ff3";
    int pageSize = 50; //Not a requered parameter. The default: 50
    var transactionType = TransactionType.REGULAR_TRANSACTION; //Not a requered parameter. The default: TransactionType.REGULAR_TRANSACTION
    var orderBy = OrderBy.ASC; //Not a requered parameter. The default: OrderBy.DESC
    long timeStamp = 0; //Not a requered parameter. The default: 0
    string nextPageToken; //Not a requered parameter. The default: null
    
    var result = await ankr.GetTransfersByAddress(Blockchain.ETH, walletAddress, pageSize, transactionType, orderBy, timeStamp, nextPageToken);
  </li>
</ol>
