using System;
using Newtonsoft.Json;

namespace MalongTech.ProductAI.API.Entity
{
    public class DressingAnalysisResponse : ProductAIBaseResponse
    {
        [JsonProperty("results")]
        public DressingAnalysisResult[] Results { get; set; }
    }
}