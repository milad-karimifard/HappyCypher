It is API client. responsible to handle all http request in library.



### Usage:

```c#
// Startup.cs
//Add http client services at ConfigureServices(IServiceCollection services)
services.AddHttpClient<IHappyCypherApiClient, HappyCypherApiClient>();
```



This client has 3 model of Exception

#### Exception

<ul>
  <li>
    <h4>CypherRateLimitException</h2>
    <p>this Exception happend when your rate limit is full</p>
  </li>
  <li>
    <h4>JsonDeserializeException</h2>
    <p>this Exception happend when result can't map to your model</p>
  </li>
     <li>
    <h4>HttpRequestException</h2>
    <p>this Exception happend when response status code is not 200 or 429</p>
  </li>
</ul> 


