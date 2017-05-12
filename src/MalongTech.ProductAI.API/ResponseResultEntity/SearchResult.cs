using System;
using Newtonsoft.Json;

namespace MalongTech.ProductAI.API.Entity
{
    public class SearchResult
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }
    }
}