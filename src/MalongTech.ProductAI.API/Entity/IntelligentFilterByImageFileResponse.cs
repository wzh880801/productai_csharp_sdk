using System;
using Newtonsoft.Json;

namespace MalongTech.ProductAI.API.Entity
{
    public class IntelligentFilterByImageFileResponse : ProductAIBaseResponse
    {
        [JsonProperty("results")]
        public Result[] Results { get; set; }

        public class Result
        {
            [JsonProperty("url")]
            public string ImageUrl { get; set; }

            [JsonProperty("tag")]
            public string Tag { get; set; }

            [JsonProperty("score")]
            public decimal Score { get; set; }
        }

        [JsonProperty("content_img")]
        public string ContentImgUrl { get; set; }

        [JsonProperty("style_img")]
        public string StyleImgPath { get; set; }
    }
}