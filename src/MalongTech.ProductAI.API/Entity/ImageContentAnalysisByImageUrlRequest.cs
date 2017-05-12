using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class ImageContentAnalysisByImageUrlRequest : ImageUrlBaseRequest<ImageContentAnalysisResponse>
    {
        public ImageContentAnalysisByImageUrlRequest(string loc = "0-0-1-1")
            : base("classify_general", "_0000044")
        {
            this.Loc = loc;
        }

        public ImageContentAnalysisByImageUrlRequest(string url, string loc = "0-0-1-1")
            : this(loc)
        {
            this.Url = url;
        }
    }
}