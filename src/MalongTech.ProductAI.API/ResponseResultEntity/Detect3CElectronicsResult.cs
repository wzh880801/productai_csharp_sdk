using System;
using Newtonsoft.Json;

namespace MalongTech.ProductAI.API.Entity
{
    public class DetectResult
    {
        [JsonProperty("box")]
        public decimal[] BoxLocation { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("score")]
        public decimal Score { get; set; }
    }
}