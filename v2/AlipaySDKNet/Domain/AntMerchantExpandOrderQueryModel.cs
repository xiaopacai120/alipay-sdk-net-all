using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandOrderQueryModel : AopObject
    {
        /// <summary>
        /// 申请单 id。 1.蚂蚁门店管理场景：通过 <a href="https://opendocs.alipay.com/apis/014tmc">ant.merchant.expand.shop.create</a>(蚂蚁店铺创建)接口进件时返回的order_id。 2.直付通二级商户进件场景：通过<a href="https://opendocs.alipay.com/pre-apis/00a8e3">ant.merchant.expand.indirect.zft.create</a>(直付通二级商户创建)接口进件时返回的order_id。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
