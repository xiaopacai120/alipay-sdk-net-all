using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Config Data Structure.
    /// </summary>
    [Serializable]
    public class Config : AopObject
    {
        /// <summary>
        /// 最大并发数
        /// </summary>
        [XmlElement("max_concurrency")]
        public long MaxConcurrency { get; set; }

        /// <summary>
        /// 空闲等待时间
        /// </summary>
        [XmlElement("max_idle_timeout")]
        public long MaxIdleTimeout { get; set; }

        /// <summary>
        /// 请求超时时间
        /// </summary>
        [XmlElement("max_req_timeout")]
        public long MaxReqTimeout { get; set; }

        /// <summary>
        /// 最大重试次数
        /// </summary>
        [XmlElement("max_retry_time")]
        public long MaxRetryTime { get; set; }
    }
}
