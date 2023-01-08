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
    
    var result = await ankr.GetNFTsByOwnerAsync(blockchaines, walletAddress)
  </li>
  
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
    
    var result = await ankr.GetNFTsByOwnerAsync(blockchaines, walletAddress)
  </li>
</ol>
