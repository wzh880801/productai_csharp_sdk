using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class DetectFoodByImageFileRequest : ImageFileBaseRequest<DetectResponse>
    {
        public DetectFoodByImageFileRequest(string loc = "0-0-1-1")
            : base("detect_food", "detect_food", loc)
        {

        }

        public DetectFoodByImageFileRequest(System.IO.FileInfo imageFile, string loc = "0-0-1-1")
            : this(loc)
        {
            this.ImageFile = imageFile;
        }
    }
}