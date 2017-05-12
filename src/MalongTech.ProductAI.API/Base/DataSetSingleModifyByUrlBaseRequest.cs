using System;
using System.Collections.Generic;
using System.Reflection;
using SimpleWebRequestHelper.Entity;

namespace MalongTech.ProductAI.API
{
    public abstract class DataSetSingleModifyByUrlBaseRequest<T> : ProductAIBaseRequest<T>
        where T : ProductAIBaseResponse
    {
        private string _imageSetId = "";

        public override string ApiUrl
        {
            get
            {
                return string.Format("https://{0}/image_sets/_0000014/{1}", this.Host, this._imageSetId);
            }
        }

        public override string QueryString
        {
            get
            {
                var list = new List<string>();
                var ps = this.GetType().GetProperties();
                foreach (var p in ps)
                {
                    var ca = p.GetCustomAttribute(typeof(ParaSignAttribute));
                    if (ca != null)
                    {
                        var _ca = ca as ParaSignAttribute;
                        var value = p.GetValue(this);
                        if (p.PropertyType == typeof(System.String))
                        {
                            if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
                            {
                                list.Add(string.Format("{0}={1}", _ca.Name, _ca.IsNeedUrlEncode ? System.Web.HttpUtility.UrlEncode(value.ToString()) : value));
                            }
                        }
                    }
                }
                return string.Join("&", list);
            }
        }

        [ParaSign("image_url", true)]
        public string ImageUrl { get; set; }

        public List<string> SearchTags { get; set; }

        [ParaSign("tags", true)]
        public string Tags
        {
            get
            {
                if (this.SearchTags == null || this.SearchTags.Count == 0)
                    return null;

                return string.Join("|", this.SearchTags);
            }
        }

        [ParaSign("meta")]
        public string MetaId { get; set; }

        public DataSetSingleModifyByUrlBaseRequest(string imageSetId, List<string> tags = null, string metaId = null)
        : base()
        {
            if (string.IsNullOrWhiteSpace(imageSetId))
                throw new ArgumentNullException(nameof(imageSetId));

            this._imageSetId = imageSetId;
            this.SearchTags = tags;
            this.MetaId = metaId;
        }

        public DataSetSingleModifyByUrlBaseRequest(string imageSetId, string imageUrl, List<string> tags = null, string metaId = null)
                : this(imageSetId, tags, metaId)
        {
            this.ImageUrl = imageUrl;
        }
    }
}