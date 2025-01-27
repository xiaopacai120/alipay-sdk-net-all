using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessBindModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseHttpaccessBindModifyModel : AopObject
    {
        /// <summary>
        /// 路由绑定ID
        /// </summary>
        [XmlElement("bind_id")]
        public string BindId { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [XmlElement("domain_name")]
        public string DomainName { get; set; }

        /// <summary>
        /// 函数名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 触发路径
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }
    }
}
