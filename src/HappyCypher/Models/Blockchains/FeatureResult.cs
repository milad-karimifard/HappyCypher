using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCypher.Models.Blockchains
{
    public class FeatureResult
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("last_transition_height")]
        public int LastTransitionHeight { get; set; }

        [JsonProperty("last_transition_hash")]
        public string LastTransitionHash { get; set; }
    }
}
