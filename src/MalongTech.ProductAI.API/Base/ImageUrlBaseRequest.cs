using System;
using SimpleWebRequestHelper.Entity;

namespace MalongTech.ProductAI.API
{
    public abstract class ImageUrlBaseRequest<T> : ProductAIBaseRequest<T>
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
                return string.Format("url={0}&loc={1}", System.Web.HttpUtility.UrlEncode(this.Url), this.Loc);
            }
        }

        public ImageUrlBaseRequest(string serviceType, string serviceId)
            : base()
        {
            if (string.IsNullOrWhiteSpace(serviceType))
                throw new ArgumentNullException(nameof(serviceType));
            if(string.IsNullOrWhiteSpace(serviceId))
                throw new ArgumentNullException(nameof(serviceId));

            this._serviceType = serviceType;
            this._serviceId = serviceId;
        }

        [ParaSign("url")]
        public string Url { get; set; }

        [ParaSign("loc")]
        public string Loc { get; set; }

        public ImageUrlBaseRequest(string serviceType, string serviceId, string loc = "0-0-1-1")
            : this(serviceType, serviceId)
        {
            this.Loc = loc;
        }

        public ImageUrlBaseRequest(string serviceType, string serviceId, string url, string loc = "0-0-1-1")
            : this(serviceType, serviceId, loc)
        {
            this.Url = url;
        }
    }
}