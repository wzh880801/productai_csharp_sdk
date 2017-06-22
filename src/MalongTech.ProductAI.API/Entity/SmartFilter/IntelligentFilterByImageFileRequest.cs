using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class IntelligentFilterByImageFileRequest : CallApiByImageFileBaseRequest<IntelligentFilterResponse>
    {
        public IntelligentFilterByImageFileRequest(string loc = "0-0-1-1")
            : base("classify_art", "_0000015")
        {
            this.Loc = loc;
        }

        public IntelligentFilterByImageFileRequest(System.IO.FileInfo imageFile, string loc = "0-0-1-1")
            : this(loc)
        {
            this.ImageFile = imageFile;
        }
    }
}