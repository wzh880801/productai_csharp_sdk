using System;
using System.Collections.Generic;

namespace MalongTech.ProductAI.API.Entity
{
    public class ImageSearchByImageUrlRequest : SearchByImageUrlBaseRequest<ImageSearchResponse>
    {
        public ImageSearchByImageUrlRequest(string serviceId, string loc = "0-0-1-1", List<string> tags = null, int? count = null, double? threshold = null)
            : base("search", serviceId, loc, tags, count, threshold)
        {
            
        }

        public ImageSearchByImageUrlRequest(string serviceId, string url, string loc = "0-0-1-1", List<string> tags = null, int? count = null, double? threshold = null)
            : this(serviceId, loc, tags, count, threshold)
        {
            this.Url = url;
        }
    }
}