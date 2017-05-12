using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class DressingClassifyByImageFileRequest : ImageFileBaseRequest<DressingAnalysisResponse>
    {
        public DressingClassifyByImageFileRequest(string loc = "0-0-1-1")
            : base("classify_dressing", "_0000057", loc)
        {

        }

        public DressingClassifyByImageFileRequest(System.IO.FileInfo imageFile, string loc = "0-0-1-1")
            : this(loc)
        {
            this.ImageFile = imageFile;
        }
    }
}