using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using SimpleWebRequestHelper.Entity;

namespace MalongTech.ProductAI.API
{
    public abstract class SearchByImageFileBaseRequest<T> : CallApiByImageFileBaseRequest<T>
        where T : ProductAIBaseResponse
    {
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
            : base(serviceType, serviceId)
        {

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