using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class PlaceClassifyByImageUrlRequest : CallApiByImageUrlBaseRequest<ImageContentAnalysisResponse>
    {
        public PlaceClassifyByImageUrlRequest(string loc = "0-0-1-1")
            : base("classify_place_cls", "_0000039", loc)
        {

        }

        public PlaceClassifyByImageUrlRequest(string url, string loc = "0-0-1-1")
            : this(loc)
        {
            this.Url = url;
        }
    }
}