using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class Detect3CElectronicsByImageFileRequest : ImageFileBaseRequest<DetectResponse>
    {
        public Detect3CElectronicsByImageFileRequest(string loc = "0-0-1-1")
            : base("detect_3c_and_electronics", "_0000027")
        {
            this.Loc = loc;
        }

        public Detect3CElectronicsByImageFileRequest(System.IO.FileInfo imageFile, string loc = "0-0-1-1")
            : this(loc)
        {
            this.ImageFile = imageFile;
        }
    }
}