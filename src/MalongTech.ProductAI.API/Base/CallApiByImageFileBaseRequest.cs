using System;
using System.Collections.Generic;
using System.IO;
using SimpleWebRequestHelper.Entity;

namespace MalongTech.ProductAI.API
{
    public abstract class CallApiByImageFileBaseRequest<T> : ProductAIBaseRequest<T>
        where T : ProductAIBaseResponse
    {
        private string _serviceType = "";
        private string _serviceId = "";

        public override string ApiUrl
        {
            get
            {
                return string.Format("https://{0}/{1}/{2}/", this.Host, this._serviceType, this._serviceId);
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

        public CallApiByImageFileBaseRequest(string serviceType, string serviceId)
        : base()
        {
            if (string.IsNullOrWhiteSpace(serviceType))
                throw new ArgumentNullException(nameof(serviceType));
            if (string.IsNullOrWhiteSpace(serviceId))
                throw new ArgumentNullException(nameof(serviceId));

            this._serviceType = serviceType;
            this._serviceId = serviceId;

            this._boundary = Helper.FileHelper.GetBoundary();
        }

        public CallApiByImageFileBaseRequest(string serviceType, string serviceId, string loc = "0-0-1-1")
                : this(serviceType, serviceId)
        {
            this.Loc = loc;
        }

        public CallApiByImageFileBaseRequest(string serviceType, string serviceId, FileInfo imageFile, string loc = "0-0-1-1")
                : this(serviceType, serviceId, loc)
        {
            this.ImageFile = imageFile;
        }
    }
}