using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class ImageContentAnalysisByImageFileRequest : CallApiByImageFileBaseRequest<ImageContentAnalysisResponse>
    {
        public ImageContentAnalysisByImageFileRequest(string loc = "0-0-1-1")
            : base("classify_general", "_0000044", loc)
        {

        }

        public ImageContentAnalysisByImageFileRequest(System.IO.FileInfo imageFile, string loc = "0-0-1-1")
            : this(loc)
        {
            this.ImageFile = imageFile;
        }
    }
}