using System;

namespace MalongTech.ProductAI.API
{
    public interface IProfile
    {
        string Version { get; set; }

        string AccessKeyId { get; set; }

        string SecretKey { get; set; }
    }
}