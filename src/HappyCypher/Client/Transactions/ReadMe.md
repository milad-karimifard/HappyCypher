# Transaction Methods : 

<ul>
  <li>
    <h4>SetToken()</h2>
    <p>with this method you can set BlockCypher token on Transaction instanse</p>
  </li>
  <li>
    <h4>CreateTransaction(ResourceType resourceType, string fromAddress, string toAddress, int value, bool includeToSignTx = false)</h2>
    <p>To use BlockCypher's two-endpoint transaction creation tool, first you need to provide the input address, output address, and value to transfer (in satoshis).
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

1. Create a instance of Transaction (with DI or manually)

2. Use Like example


```c#
string fromAddress = "mox7Xiw3BX772N3cj45kdwQktk8cwMxfDo";
string toAddress = "mzfYMMjVMLb341X8L3vJ67WX8RioafYmvk";
int value = 10000;

transaction.SetToken("Your TOKEN");

var result = await transaction.CreateTransaction(ResourceType.BitCoinTest, fromAddress, toAddress, value);
```

