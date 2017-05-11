using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class ImageContentAnalysisByImageUrlRequest : ProductAIBaseRequest<ImageContentAnalysisByImageUrlResponse>
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
                return string.Format("url={0}&loc={1}", System.Web.HttpUtility.UrlEncode(this.Url), this.Loc);
            }
        }

        [ParaSign("url")]
        public string Url { get; set; }

        [ParaSign("loc")]
        public string Loc { get; set; }

        public ImageContentAnalysisByImageUrlRequest(string loc = "0-0-1-1")
            : base()
        {
            this.Loc = loc;
        }

        public ImageContentAnalysisByImageUrlRequest(string url, string loc = "0-0-1-1")
            : this(loc)
        {
            this.Url = url;
        }
    }
}