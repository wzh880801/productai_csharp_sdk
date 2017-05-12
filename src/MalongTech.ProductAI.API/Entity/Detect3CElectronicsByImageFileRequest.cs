using System;
using System.Collections.Generic;
using System.IO;

namespace MalongTech.ProductAI.API.Entity
{
    public class Detect3CElectronicsByImageFileRequest : ProductAIBaseRequest<Detect3CElectronicsResponse>
    {
        public override string ApiUrl
        {
            get
            {
                return string.Format("https://{0}/detect_3c_and_electronics/_0000027/", this.Host);
            }
        }

        public override string QueryString
        {
            get
            {
                return "";
            }
        }

        private string _boundary = "";

        public override byte[] QueryBytes
        {
            get
            {
                var options = new Dictionary<string, string>();
                options.Add("loc", this.Loc);
                return Helper.FileHelper.GetMultipartBytes(this.ImageFile, _boundary, options, "search");
            }
        }

        public override string ContentTypeHeader
        {
            get
            {
                return Helper.FileHelper.GetContentType(_boundary);
            }
        }

        [ParaSign("loc")]
        public string Loc { get; set; }

        public FileInfo ImageFile { get; set; }

        public Detect3CElectronicsByImageFileRequest(string loc = "0-0-1-1")
            : base()
        {
            _boundary = Helper.FileHelper.GetBoundary();
            this.Loc = loc;
        }

        public Detect3CElectronicsByImageFileRequest(FileInfo imageFile, string loc = "0-0-1-1")
            : this(loc)
        {
            this.ImageFile = imageFile;
        }
    }
}