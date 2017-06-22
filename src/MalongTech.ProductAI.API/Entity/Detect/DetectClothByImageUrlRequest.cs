using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class DetectClothByImageUrlRequest : CallApiByImageUrlBaseRequest<DetectResponse>
    {
        public DetectClothByImageUrlRequest(string loc = "0-0-1-1")
            : base("detect_cloth", "_0000025", loc)
        {
            
        }

        public DetectClothByImageUrlRequest(string url, string loc = "0-0-1-1")
            : this(loc)
        {
            this.Url = url;
        }
    }
}