using System;
using Newtonsoft.Json;

namespace MalongTech.ProductAI.API.Entity
{
    public class ImageContentAnalysisResponse : ProductAIBaseResponse
    {
        [JsonProperty("results")]
        public ImageContentAnalysisResult[] Results { get; set; }   
    }
}