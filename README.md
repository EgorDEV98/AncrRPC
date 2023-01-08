<strong>Unofficial library for working with Ankr Advanced APIs</strong>

Official documentation: <a href="https://www.ankr.com/docs/advanced-api/overview/" target="_blank"/>

Code Example:

<h3>NFTs API</h3>

<ol>
  <li>
    <h5>MultiChain Get NFTs Balance</5>
    using AnkrRPC;
    
    Ankr ankr = new Ankr();
    
    string walletAddress = "0xf573d99385C05c23B24ed33De616ad16a43a0919";
    var blockchaines = new[]
    {
      Blockchain.ETH,
      Blockchain.BSC
    };
    
    var multiChainRequest = await ankr.GetNFTsByOwnerAsync(blockchaines, walletAddress)
    var oneChainRequest = await ankr.GetNFTsByOwnerAsync(Blockchain.ETH, walletAddress)
  </li>
  
  <li>
    <h5>Get NFT Metadata</5>
    using AnkrRPC;
    
    Ankr ankr = new Ankr();
    
    var blockchain = Blockchain.ETH;
    string contractAddress = "0x8d01c8ee82e581e55c02117a676b5bbd4734fabb";
    string tokenId = "23240";
    
    var result = await ankr.GetNFTMetadataAsync(blockchain, contractAddress, tokenId )
  </li>
  
  <li>
    <h5>Get NFT Holders</5>
    using AnkrRPC;
    
    Ankr ankr = new Ankr();
    
    var blockchain = Blockchain.ETH;
    string contractAddress = "0x8d01c8ee82e581e55c02117a676b5bbd4734fabb";
    int pageSize = 10; `<= Not a requered parameter. The default setting is 50`
    string tokenId = "23240";
    
    var result = await ankr.GetNFTHoldersAsync(blockchain, contractAddress, tokenId )
  </li>
</ol>
