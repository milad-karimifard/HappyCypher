# Address Methods : 

<ul>
  <li>
    <h4>SetToken()</h2>
    <p>with this method you can set BlockCypher token on Address instanse</p>
  </li>
  <li>
    <h4>GetAddressBalance(ResourceType resourceType, string address)</h2>
    <p>The Address Balance Endpoint is the simplest---and fastest---method to get a subset of information on a public address.
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

1. Create a instance of Address (with DI or manually)

2. Use Like example

   example : 

```c#
address.SetToken("Your TOKEN");
var result = await address.GetAddressBalance(ResourceType.BitCoinMain, "bc1qjr9y78heau4kmwl85pzzw89z50ccsv9w9qwu2p");
```




​	
