using System;
using System.Collections.Generic;

namespace MalongTech.ProductAI.API.Entity
{
    public class ImageSearchByImageFileRequest : SearchByImageFileBaseRequest<ImageSearchResponse>
    {
        public ImageSearchByImageFileRequest(string serviceId, string loc = "0-0-1-1", List<string> tags = null, int? count = null, double? threshold = null)
            : base("search", serviceId, loc, tags, count, threshold)
        {

        }

        public ImageSearchByImageFileRequest(string serviceId, System.IO.FileInfo imageFile, string loc = "0-0-1-1", List<string> tags = null, int? count = null, double? threshold = null)
            : this(serviceId, loc, tags, count, threshold)
        {
            this.ImageFile = imageFile;
        }
    }
}