using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransEntrustPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransEntrustPayModel : AopObject
    {
        /// <summary>
        /// 授权对象
        /// </summary>
        [XmlElement("auth_info")]
        public AuthInfo AuthInfo { get; set; }

        /// <summary>
        /// 业务场景，比如诚e赊还款、淘宝心选等
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// JSON格式，传递业务扩展参数，使用前请与支付宝工程师联系！
        /// </summary>
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 默认都是ASYNC；填SYNC是准实时委托扣款，并不会实时返回支付结果
        /// </summary>
        [XmlElement("entrust_payment_mode")]
        public string EntrustPaymentMode { get; set; }

        /// <summary>
        /// 订单的标题，用于在消费记录展示
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户端的唯一订单号，对于同一笔委托支付请求，商户需保证该订单号唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。
        /// </summary>
        [XmlElement("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [XmlElement("payee_info")]
        public Participant PayeeInfo { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [XmlElement("payer_info")]
        public Participant PayerInfo { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }
    }
}
