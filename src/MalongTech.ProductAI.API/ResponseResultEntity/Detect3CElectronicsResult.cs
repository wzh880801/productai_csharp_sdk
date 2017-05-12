using System;
using Newtonsoft.Json;

namespace MalongTech.ProductAI.API.Entity
{
    public class Detect3CElectronicsResult
    {
        [JsonProperty("box")]
        public decimal[] BoxLocation { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("score")]
        public decimal Score { get; set; }
    }
}