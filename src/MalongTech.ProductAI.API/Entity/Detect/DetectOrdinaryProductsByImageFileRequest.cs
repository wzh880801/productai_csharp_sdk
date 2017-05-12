using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class DetectOrdinaryProductsByImageFileRequest : ImageFileBaseRequest<DetectResponse>
    {
        public DetectOrdinaryProductsByImageFileRequest(string loc = "0-0-1-1")
            : base("detect_ordinary_products", "_0000030", loc)
        {

        }

        public DetectOrdinaryProductsByImageFileRequest(System.IO.FileInfo imageFile, string loc = "0-0-1-1")
            : this(loc)
        {
            this.ImageFile = imageFile;
        }
    }
}