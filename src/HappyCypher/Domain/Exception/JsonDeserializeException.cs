using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Domain.Exception
{
    public class JsonDeserializeException : System.Exception
    {
        public JsonDeserializeException() : base("map json to your object failed")
        {

        }
    }
}
