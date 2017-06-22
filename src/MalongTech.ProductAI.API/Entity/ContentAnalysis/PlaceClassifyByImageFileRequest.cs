using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class PlaceClassifyByImageFileRequest : CallApiByImageFileBaseRequest<ImageContentAnalysisResponse>
    {
        public PlaceClassifyByImageFileRequest(string loc = "0-0-1-1")
            : base("classify_place_cls", "_0000039", loc)
        {
            
        }

        public PlaceClassifyByImageFileRequest(System.IO.FileInfo imageFile, string loc = "0-0-1-1")
            : this(loc)
        {
            this.ImageFile = imageFile;
        }
    }
}