using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class DressingClassifyByImageUrlRequest : CallApiByImageUrlBaseRequest<DressingAnalysisResponse>
    {
        public DressingClassifyByImageUrlRequest(string loc = "0-0-1-1")
            : base("classify_dressing", "_0000057", loc)
        {

        }

        public DressingClassifyByImageUrlRequest(string url, string loc = "0-0-1-1")
            : this(loc)
        {
            this.Url = url;
        }
    }
}