using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using SimpleWebRequestHelper.Entity;

namespace MalongTech.ProductAI.API
{
    public abstract class SearchByImageFileBaseRequest<T> : ProductAIBaseRequest<T>
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
                                options.Add(_ca.Name, value.ToString());
                            }
                        }
                        else if (p.PropertyType == typeof(int?))
                        {
                            var v = value as int?;
                            if (v != null)
                                options.Add(_ca.Name, string.Format("{0}", v));
                        }
                        else if (p.PropertyType == typeof(double?))
                        {
                            var v = value as double?;
                            if (v != null)
                                options.Add(_ca.Name, string.Format("{0}", v));
                        }
                    }
                }
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

        [ParaSign("count")]
        public int? Count { get; set; }

        [ParaSign("threshold")]
        public double? Threshold { get; set; }

        public SearchByImageFileBaseRequest(string serviceType, string serviceId)
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

        public SearchByImageFileBaseRequest(string serviceType, string serviceId, string loc = "0-0-1-1", List<string> tags = null, int? count = null, double? threshold = null)
            : this(serviceType, serviceId)
        {
            this.Loc = loc;
            this.SearchTags = tags;
            this.Count = count;
            this.Threshold = threshold;
        }

        public SearchByImageFileBaseRequest(string serviceType, string serviceId, FileInfo imageFile, string loc = "0-0-1-1", List<string> tags = null, int? count = null, double? threshold = null)
            : this(serviceType, serviceId, loc, tags, count, threshold)
        {
            this.ImageFile = imageFile;
        }
    }
}