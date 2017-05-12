using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class DetectPetByImageFileRequest : ImageFileBaseRequest<DetectResponse>
    {
        public DetectPetByImageFileRequest(string loc = "0-0-1-1")
            : base("detect_pet", "_0000031", loc)
        {

        }

        public DetectPetByImageFileRequest(System.IO.FileInfo imageFile, string loc = "0-0-1-1")
            : this(loc)
        {
            this.ImageFile = imageFile;
        }
    }
}