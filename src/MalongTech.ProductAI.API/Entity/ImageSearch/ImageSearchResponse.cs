using System;
using Newtonsoft.Json;

namespace MalongTech.ProductAI.API.Entity
{
    public class ImageSearchResponse : ProductAIBaseResponse
    {
        [JsonProperty("results")]
        public SearchResult[] Results { get; set; }

        [JsonProperty("ds")]
        public string DataSetIndexVersion { get; set; }

        [JsonProperty("searchtime")]
        public double SearchTime { get; set; }

        [JsonProperty("loc")]
        public int[] Location { get; set; }

        [JsonProperty("download_time")]
        public double DownloadTime { get; set; }
    }
}