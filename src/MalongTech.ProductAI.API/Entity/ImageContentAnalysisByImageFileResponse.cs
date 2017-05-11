using System;
using Newtonsoft.Json;

namespace MalongTech.ProductAI.API.Entity
{
    public class ImageContentAnalysisByImageFileResponse : ProductAIBaseResponse
    {
        [JsonProperty("results")]
        public Result[] Results { get; set; }

        public class Result
        {
            [JsonProperty("category")]
            public string Category { get; set; }

            [JsonProperty("score")]
            public decimal Score { get; set; }
        }
    }
}