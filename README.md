<strong>Unofficial library for working with Ankr Advanced APIs</strong>

Official documentation: <a href="https://www.ankr.com/docs/advanced-api/overview/" target="_blank"/>

Code Example:

using AnkrRPC;

NFTs API

<ol>
  <li>
    <h5>MultiChain Get NFTs Balance</5>
    
    Ankr ankr = new Ankr();
    var result = await ankr.GetNFTsByOwnerAsync(IEnumerable<Blockchain> blockchains,string walletAddress, string nextPageToken = null)
  </li>
</ol>
