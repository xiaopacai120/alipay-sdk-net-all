using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectIotcoverBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectIotcoverBindModel : AopObject
    {
        /// <summary>
        /// 声网入网申请单编号编号是由服务商和支付宝BD录入IoT设备接入协议后生成的，用于后续政策返佣、播报跟踪等重要场景。需要联系支付宝的业务经理获取。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 不同物联网平台接入渠道不同值，支付宝物联网平台传设备SN号，阿里云物联网平台传设备deviceName
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 间连商户在支付宝体系内的唯一id,一般以2088开头。
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 不同物联网平台接入渠道不同值，支付宝物联网平台传设备sourceId号，阿里云物联网平台传设备productKey。
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
