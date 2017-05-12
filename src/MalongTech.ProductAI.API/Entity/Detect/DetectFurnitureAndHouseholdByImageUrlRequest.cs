using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class DetectFurnitureAndHouseholdByImageUrlRequest : ImageUrlBaseRequest<DetectResponse>
    {
        public DetectFurnitureAndHouseholdByImageUrlRequest(string loc = "0-0-1-1")
            : base("detect_pet", "_0000031", loc)
        {

        }

        public DetectFurnitureAndHouseholdByImageUrlRequest(string url, string loc = "0-0-1-1")
            : this(loc)
        {
            this.Url = url;
        }
    }
}