using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskGuardrailsAskDetectResponse.
    /// </summary>
    public class AlipaySecurityRiskGuardrailsAskDetectResponse : AopResponse
    {
        /// <summary>
        /// 风险识别标签内容
        /// </summary>
        [XmlArray("detect_check_labels")]
        [XmlArrayItem("string")]
        public List<string> DetectCheckLabels { get; set; }

        /// <summary>
        /// 检测数据ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 代答内容
        /// </summary>
        [XmlArray("rewrite_content")]
        [XmlArrayItem("guardrails_biz")]
        public List<GuardrailsBiz> RewriteContent { get; set; }

        /// <summary>
        /// 处置建议：pass、review、block
        /// </summary>
        [XmlElement("suggestion")]
        public string Suggestion { get; set; }
    }
}
