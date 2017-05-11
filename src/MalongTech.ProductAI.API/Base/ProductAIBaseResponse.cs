using System;
using Newtonsoft.Json;
using SimpleWebRequestHelper.Entity;
using SimpleWebRequestHelper.Enum;

namespace MalongTech.ProductAI.API
{
    public abstract class ProductAIBaseResponse : SimpleWebResponse
    {
        public override ResponseType ResponseType
        {
            get
            {
                return ResponseType.JSON;
            }
        }

        /// <summary>
        /// Error Code. Different codes means different errors
        /// <para>0 - Succeed</para>
        /// </summary>
        [JsonProperty("is_err")]
        public int IsError { get; set; }

        /// <summary>
        /// Error Message
        /// </summary>
        [JsonProperty("err_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Time cost
        /// </summary>
        [JsonProperty("time")]
        public decimal Time { get; set; }

        [JsonProperty("time_detail")]
        public decimal[] TimeDetails { get; set; }

        /// <summary>
        /// Unique request id
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("error_code")]
        public int ErrorCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("ver")]
        public string Version { get; set; }
    }
}