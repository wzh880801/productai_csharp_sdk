using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class DetectFurnitureAndHouseholdByImageFileRequest : ImageFileBaseRequest<DetectResponse>
    {
        public DetectFurnitureAndHouseholdByImageFileRequest(string loc = "0-0-1-1")
            : base("detect_furniture_and_household", "_0000029", loc)
        {

        }

        public DetectFurnitureAndHouseholdByImageFileRequest(System.IO.FileInfo imageFile, string loc = "0-0-1-1")
            : this(loc)
        {
            this.ImageFile = imageFile;
        }
    }
}