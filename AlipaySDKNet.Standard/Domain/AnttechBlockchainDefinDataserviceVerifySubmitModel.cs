using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceVerifySubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinDataserviceVerifySubmitModel : AopObject
    {
        /// <summary>
        /// base64编码的业务参数
        /// </summary>
        [XmlElement("encoded_biz_param")]
        public string EncodedBizParam { get; set; }

        /// <summary>
        /// 系统参数
        /// </summary>
        [XmlElement("sys_param")]
        public SystemParam SysParam { get; set; }
    }
}