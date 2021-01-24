# Blockchain Method : 

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

   example ; 

```c#
blockchain.SetToken("Your TOKEN");
var result = await blockchain.GetChain(ResourceType.BitCoinMain);
```

 