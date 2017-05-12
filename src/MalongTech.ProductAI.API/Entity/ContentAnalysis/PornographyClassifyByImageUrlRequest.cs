using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class PornographyClassifyByImageUrlRequest : ImageUrlBaseRequest<ImageContentAnalysisResponse>
    {
        public PornographyClassifyByImageUrlRequest(string loc = "0-0-1-1")
            : base("classify_porn", "_0000024", loc)
        {

        }

        public PornographyClassifyByImageUrlRequest(string url, string loc = "0-0-1-1")
            : this(loc)
        {
            this.Url = url;
        }
    }
}