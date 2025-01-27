using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCertificateCertificationRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCertificateCertificationRefundModel : AopObject
    {
        /// <summary>
        /// 撤销核销时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 已核销待冲正的三方码。取值为支付宝调用三方凭证发放spi时商户返回的三方码 当前字段已废弃(指定凭证id做单次核销撤回)
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 凭证归属支付宝用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 购买商品的订单id。通过下单接口获取订单id，新接口不再支持，请勿使用 当前字段已废弃(指定凭证id做单次核销撤回)
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。 幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 核销接口返回的核销操作单号，撤销orderNo对应的核销操作
        /// </summary>
        [XmlArray("use_order_no_list")]
        [XmlArrayItem("string")]
        public List<string> UseOrderNoList { get; set; }

        /// <summary>
        /// 凭证归属支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
