using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class IntelligentFilterByImageUrlRequest : ImageUrlBaseRequest<IntelligentFilterResponse>
    {
        public IntelligentFilterByImageUrlRequest(string loc = "0-0-1-1")
            : base("classify_art", "_0000015")
        {
            this.Loc = loc;
        }

        public IntelligentFilterByImageUrlRequest(string url, string loc = "0-0-1-1")
            : this(loc)
        {
            this.Url = url;
        }
    }
}