using System;
using Newtonsoft.Json;

namespace MalongTech.ProductAI.API.Entity
{
    public class IntelligentFilterResponse : ProductAIBaseResponse
    {
        [JsonProperty("results")]
        public IntelligentFilterResult[] Results { get; set; }

        [JsonProperty("content_img")]
        public string ContentImgUrl { get; set; }

        [JsonProperty("style_img")]
        public string StyleImgPath { get; set; }
    }
}