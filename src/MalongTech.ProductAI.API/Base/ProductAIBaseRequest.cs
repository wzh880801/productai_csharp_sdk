using System;
using SimpleWebRequestHelper.Entity;

namespace MalongTech.ProductAI.API
{
    public abstract class ProductAIBaseRequest<T> : SimpleWebRequest<T>
        where T : ProductAIBaseResponse
    {
        public string Host { get; set; }

        public ProductAIBaseRequest() 
            : base()
        {
            this.ContentType = SimpleWebRequestHelper.Enum.ContentTypes.WWW_URL_ENCODEED;
            this.HttpMethod = SimpleWebRequestHelper.Enum.HttpMethods.POST;
            this.KeepAlive = true;
        }
    }
}