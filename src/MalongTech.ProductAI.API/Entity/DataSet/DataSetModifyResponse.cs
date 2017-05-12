using System;
using Newtonsoft.Json;

namespace MalongTech.ProductAI.API.Entity
{
    public class DataSetModifyResponse : ProductAIBaseResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("n_downloaded")]
        public int DownloaedCount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("modified_at")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("created_at")]
        public string CreatedTime { get; set; }

        [JsonProperty("creator_id")]
        public long CreatorId { get; set; }

        [JsonProperty("n_items")]
        public int ItemsSearchedCount { get; set; }

        [JsonProperty("id")]
        public string DataSetId { get; set; }

        [JsonProperty("name")]
        public string DataSetName { get; set; }
    }
}