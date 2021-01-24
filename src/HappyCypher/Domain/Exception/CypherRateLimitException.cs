using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Domain.Exception
{
    public class CypherRateLimitException : System.Exception
    {
        public CypherRateLimitException() : base("Your Rate Limit is full. rate limit reset at 04:00 UTC")
        {

        }
    }
}
