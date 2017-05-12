using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Security.Cryptography;
using SimpleWebRequestHelper;
using SimpleWebRequestHelper.Entity;

namespace MalongTech.ProductAI.API
{
    public class DefaultProductAIClient : DefaultWebClient
    {
        private string _version = "1";
        private string _accessKeyId = "";
        private string _secretKey = "";

        public DefaultProductAIClient(IProfile profile)
            : base("api.productai.cn")
        {
            if (profile == null)
                throw new ArgumentNullException(nameof(profile));

            _version = profile.Version;
            _accessKeyId = profile.AccessKeyId;
            _secretKey = profile.SecretKey;
        }

        protected override void SetHost<T>(SimpleWebRequest<T> request)
        {
            if (request != null)
            {
                var dics = new Dictionary<string, string>();

                dics.Add("x-ca-accesskeyid", _accessKeyId);
                dics.Add("x-ca-version", _version);
                dics.Add("x-ca-timestamp", string.Format("{0}", (long)(DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds)));
                dics.Add("x-ca-signaturenonce", Guid.NewGuid().ToString("N"));
                dics.Add("requestmethod", "POST");

                foreach (var dic in dics)
                    request.SetHeader(dic.Key, dic.Value);

                var properties = request.GetType().GetProperties();
                foreach (var p in properties)
                {
                    var ca = p.GetCustomAttribute(typeof(ParaSignAttribute));
                    if (ca != null)
                    {
                        var _ca = ca as ParaSignAttribute;
                        var value = p.GetValue(request);
                        if (p.PropertyType == typeof(System.String))
                        {
                            if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
                                dics.Add(_ca.Name, string.Format("{0}", value));
                        }
                        else if (p.PropertyType == typeof(int?))
                        {
                            var v = value as int?;
                            if (v != null)
                                dics.Add(_ca.Name, string.Format("{0}", value));
                        }
                        else if (p.PropertyType == typeof(double?))
                        {
                            var v = value as double?;
                            if (v != null)
                                dics.Add(_ca.Name, string.Format("{0}", value));
                        }
                    }
                }

                request.SetHeader("x-ca-signature", Signnature(dics));
            }

            base.SetHost<T>(request);
        }

        protected string Signnature(Dictionary<string,string> paras)
        {
            var excludeKeys = new string[] { "x-ca-signature", "x-ca-file-md5" };
            var res = new List<string>();

            var fields = paras.Where(p => !excludeKeys.Contains(p.Key)).OrderBy(p => p.Key).ToDictionary(p => p.Key, p => p.Value);
            foreach (var f in fields)
                res.Add(string.Format("{0}={1}", f.Key, f.Value));

            var urlPairs = string.Join("&", res);
            var hmac = new HMACSHA1()
            {
                Key = Encoding.UTF8.GetBytes(_secretKey)
            };
            var hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(urlPairs));
            return Convert.ToBase64String(hashBytes);
        }
    }
}