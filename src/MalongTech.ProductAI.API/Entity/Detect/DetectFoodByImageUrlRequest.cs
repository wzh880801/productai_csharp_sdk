using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class DetectFoodByImageUrlRequest : CallApiByImageUrlBaseRequest<DetectResponse>
    {
        public DetectFoodByImageUrlRequest(string loc = "0-0-1-1")
            : base("detect_food", "_0000028", loc)
        {

        }

        public DetectFoodByImageUrlRequest(string url, string loc = "0-0-1-1")
            : this(loc)
        {
            this.Url = url;
        }
    }
}