using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class DetectVehicleByImageFileRequest : ImageFileBaseRequest<DetectResponse>
    {
        public DetectVehicleByImageFileRequest(string loc = "0-0-1-1")
            : base("detect_vehicle", "_0000033", loc)
        {

        }

        public DetectVehicleByImageFileRequest(System.IO.FileInfo imageFile, string loc = "0-0-1-1")
            : this(loc)
        {
            this.ImageFile = imageFile;
        }
    }
}