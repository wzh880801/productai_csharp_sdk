using System;
using System.Collections.Generic;

namespace MalongTech.ProductAI.API.Entity
{
    public class DataSetSingleAddByImageUrlRequest : DataSetSingleModifyByUrlBaseRequest<DataSetModifyResponse>
    {
        public DataSetSingleAddByImageUrlRequest(string imageSetId, List<string> tags = null, string metaId = null)
            : base(imageSetId, tags, metaId)
        {

        }

        public DataSetSingleAddByImageUrlRequest(string imageSetId, string imageUrl, List<string> tags = null, string metaId = null)
            : this(imageSetId, tags, metaId)
        {
            this.ImageUrl = imageUrl;
        }
    }
}