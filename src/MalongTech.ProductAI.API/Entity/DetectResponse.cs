using System;
using Newtonsoft.Json;

namespace MalongTech.ProductAI.API.Entity
{
    public class DetectResponse : ProductAIBaseResponse
    {
        [JsonProperty("boxes_detected")]
        public DetectResult[] DetectedBoxes { get; set; }

        [JsonProperty("detecttime")]
        public double DetectTime { get; set; }
    }
}