using System;
using System.Collections.Generic;
using System.IO;

namespace MalongTech.ProductAI.API.Entity
{
    public class ImageContentAnalysisByImageFileRequest : ProductAIBaseRequest<ImageContentAnalysisByImageFileResponse>
    {
        public override string ApiUrl
        {
            get
            {
                return string.Format("https://{0}/classify_general/_0000044/", this.Host);
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

        public ImageContentAnalysisByImageFileRequest(string loc = "0-0-1-1")
            : base()
        {
            _boundary = Helper.FileHelper.GetBoundary();
            this.Loc = loc;
        }

        public ImageContentAnalysisByImageFileRequest(FileInfo imageFile, string loc = "0-0-1-1")
            : this(loc)
        {
            this.ImageFile = imageFile;
        }
    }
}