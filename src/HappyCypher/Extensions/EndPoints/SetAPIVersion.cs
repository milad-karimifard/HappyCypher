using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Extensions.EndPoints
{
    public static class EndPointExtension
    {
        public static string SetAPIVersion(this string endpoint, string version) => string.Format(endpoint, version);
    }
}
