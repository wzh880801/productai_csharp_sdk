using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class PornographyClassifyByImageFileRequest : CallApiByImageFileBaseRequest<ImageContentAnalysisResponse>
    {
        public PornographyClassifyByImageFileRequest(string loc = "0-0-1-1")
            : base("classify_porn", "_0000024", loc)
        {

        }

        public PornographyClassifyByImageFileRequest(System.IO.FileInfo imageFile, string loc = "0-0-1-1")
            : this(loc)
        {
            this.ImageFile = imageFile;
        }
    }
}