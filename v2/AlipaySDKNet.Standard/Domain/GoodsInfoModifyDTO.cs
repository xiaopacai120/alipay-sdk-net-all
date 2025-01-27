using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsInfoModifyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsInfoModifyDTO : AopObject
    {
        /// <summary>
        /// 提报商品库的商品，若有外部商品sku_id则必传
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 提报商品库的商品，sku维度的商品该字段必传
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商品租赁信息
        /// </summary>
        [XmlElement("rent_info")]
        public RentInfoDTO RentInfo { get; set; }
    }
}
