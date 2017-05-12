using System;

namespace MalongTech.ProductAI.API.Entity
{
    public class Detect3CElectronicsByImageUrlRequest : ProductAIBaseRequest<Detect3CElectronicsResponse>
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
                return string.Format("url={0}&loc={1}", System.Web.HttpUtility.UrlEncode(this.Url), this.Loc);
            }
        }

        [ParaSign("url")]
        public string Url { get; set; }

        [ParaSign("loc")]
        public string Loc { get; set; }

        public Detect3CElectronicsByImageUrlRequest(string loc = "0-0-1-1")
            : base()
        {
            this.Loc = loc;
        }

        public Detect3CElectronicsByImageUrlRequest(string url, string loc = "0-0-1-1")
            : this(loc)
        {
            this.Url = url;
        }
    }
}