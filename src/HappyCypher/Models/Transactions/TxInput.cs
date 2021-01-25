﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Models.Transactions
{
    public class TxInput
    {
        [JsonProperty("addresses")]
        public IList<string> Addresses { get; set; }
    }
}
