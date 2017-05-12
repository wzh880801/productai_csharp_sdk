using System;
using Newtonsoft.Json;

namespace MalongTech.ProductAI.API.Entity
{
    public class IntelligentFilterResult
    {
        [JsonProperty("url")]
        public string ImageUrl { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("score")]
        public decimal Score { get; set; }
    }
}