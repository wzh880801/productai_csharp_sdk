using System;

namespace MalongTech.ProductAI.API
{
    public class DefaultProfile : IProfile
    {
        public string AccessKeyId { get; set; }

        public string SecretKey { get; set; }

        public string Version { get; set; }

        public DefaultProfile()
        {

        }

        public DefaultProfile(string accessKeyId, string secretKey, string version = "1")
        {
            this.AccessKeyId = accessKeyId;
            this.SecretKey = secretKey;
            this.Version = version;
        }
    }
}