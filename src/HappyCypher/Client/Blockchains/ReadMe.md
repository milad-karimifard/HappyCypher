# Blockchain Methods : 

<ul>
  <li>
    <h4>SetToken()</h2>
    <p>with this method you can set BlockCypher token on BlockChain instanse</p>
  </li>
  <li>
    <h4>GetChain(ResourceType resourceType)</h2>
    <p>General information about a blockchain is available by GET-ing the base resource. The returned object contains a litany of information about the blockchain, including its height, the time/hash of the latest block, and more.
      </p>
      <p>
          ResourceType for tell program which resource you want to use
          <br>
          Types :
          	 <ul>
                 <li>BitCoinMain</li>
                 <li>BitCoinTest</li>
                 <li>DashMain</li>
                 <li>DogeCoinMain</li>
                 <li>LiteCoinMain</li>
                 <li>BlockCypherTest</li>
     		 </ul>
      </ul>

​	Usage : 

1. Create a instance of Blockchain (with DI or manually)

2. Use Like example

   example : 

```c#
blockchain.SetToken("Your TOKEN");
var result = await blockchain.GetChain(ResourceType.BitCoinMain);
```

 <ul>
  <li>
    <h4>GetBlockHash(ResourceType resourceType, string blockHash)</h2>
      <p>If you want more data on a particular block, you can use the Block Hash endpoint.The returned object contains information about the block, including its height, the total amount of satoshis transacted within it, the number of transactions in it, transaction hashes listed in the canonical order in which they appear in the block, and more</p>
      <br>
     </li>
</ul>

​	Usage : 

1. Create a instance of Blockchain (with DI or manually)

2. Use Like example. for this example we use this data

   blockHash : "0000000000000000189bba3564a63772107b5673c940c16f12662b3e8546b412"



```c#
blockchain.SetToken("Your TOKEN");
var result = await blockchain.GetBlockHash(ResourceType.BitCoinMain,"0000000000000000189bba3564a63772107b5673c940c16f12662b3e8546b412");
```

 <ul>
  <li>
    <h4>GetBlockHeight(ResourceType resourceType, long blockHeight, int txStart = int.MinValue, int limit = int.MinValue)</h2>
      <p>You can query for information on a block using its height, using the same resource but with a different variable type. blockHeight is an integer representing the height of the block you're interested in querying</p>
      <br>
     </li>
</ul>

​	Usage :

1.  Create a instance of Blockchain (with DI or manually)

2. Use Like example. for this example we use this data

   blockHeight : 294322

   ```c#
   blockchain.SetToken("Your TOKEN");
   var result = await blockchain.GetBlockHeight(ResourceType.BitCoinMain, 294322);
   ```

 <ul>
  <li>
    <h4>GetFeature(ResourceType resourceType, string name)</h2>
      <p>If you're curious about the adoption of upgrade features on a blockchain, you can use this endpoint to get some information about its state on the network.</p>
      <br>
     </li>
</ul>

​	Usage : 

1. Create a instance of Blockchain (with DI or manually)

2. Use Like example. for this example we use this data

   name : "bip65"

   ```c#
   blockchain.SetToken("Your TOKEN");
   var result = await blockchain.GetFeature(ResourceType.BitCoinMain, "bip65");
   ```

