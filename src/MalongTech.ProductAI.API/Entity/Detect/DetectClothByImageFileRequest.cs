using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class DetectClothByImageFileRequest : ImageFileBaseRequest<DetectResponse>
    {
        public DetectClothByImageFileRequest(string loc = "0-0-1-1")
            : base("detect_cloth", "_0000025", loc)
        {

        }

        public DetectClothByImageFileRequest(System.IO.FileInfo imageFile, string loc = "0-0-1-1")
            : this(loc)
        {
            this.ImageFile = imageFile;
        }
    }
}