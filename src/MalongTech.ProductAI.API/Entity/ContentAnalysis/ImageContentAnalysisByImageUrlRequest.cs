using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class ImageContentAnalysisByImageUrlRequest : CallApiByImageUrlBaseRequest<ImageContentAnalysisResponse>
    {
        public ImageContentAnalysisByImageUrlRequest(string loc = "0-0-1-1")
            : base("classify_general", "_0000044", loc)
        {

        }

        public ImageContentAnalysisByImageUrlRequest(string url, string loc = "0-0-1-1")
            : this(loc)
        {
            this.Url = url;
        }
    }
}