using System;
using Newtonsoft.Json;

namespace MalongTech.ProductAI.API.Entity
{
    public class Detect3CElectronicsResponse : ProductAIBaseResponse
    {
        [JsonProperty("boxes_detected")]
        public Detect3CElectronicsResult[] DetectedBoxes { get; set; }

        [JsonProperty("detecttime")]
        public double DetectTime { get; set; }
    }
}