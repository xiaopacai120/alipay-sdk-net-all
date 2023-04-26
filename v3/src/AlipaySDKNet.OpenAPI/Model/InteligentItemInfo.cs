/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-04-19
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AlipaySDKNet.OpenAPI.Client.OpenAPIDateConverter;

namespace AlipaySDKNet.OpenAPI.Model
{
    /// <summary>
    /// InteligentItemInfo
    /// </summary>
    [DataContract(Name = "InteligentItemInfo")]
    public partial class InteligentItemInfo : IEquatable<InteligentItemInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteligentItemInfo" /> class.
        /// </summary>
        /// <param name="itemIds">券适用的单品码列表  最少配置1个单品码  最多配置500个单品码.</param>
        /// <param name="itemImgs">单品图片列表  单品图片不能超过3张.</param>
        /// <param name="itemLink">单品券详细介绍跳转链接.</param>
        /// <param name="itemName">单品名称.</param>
        /// <param name="itemText">单品券说明.</param>
        /// <param name="maxDiscountNum">单品券适用的商品列表中，每一个商品最高可享受优惠的件数；    如：券适用于A,B两种商品，该字段设置为1，则用券A,B两种商品每种最多只有一件可享受优惠；.</param>
        /// <param name="minConsumeNum">单品券适用商品列表中，每种商品享受优惠最低购买件数的门槛；  如：券适用于A,B两种商品，该字段设置为3，则A,B两种商品每种最少需要购买3件才可享受优惠；.</param>
        /// <param name="originalPrice">单品的原价，单位元  必须为合法金额类型字符串，如9.99.</param>
        /// <param name="skuMinConsume">券适用SKU的最低消费金额门槛  如券适用A,B两个SKU，该字段设置的值为100，则订单中购买A,B两个SKU的合计金额需大于100元才可用券.</param>
        /// <param name="totalMaxDiscountNum">如果一个单品券适用A，B，C三个单品，若设置了该字段为2，则在一笔交易中，A，B，C三个单品加起来最多只有俩件能够享受优惠.</param>
        public InteligentItemInfo(List<string> itemIds = default(List<string>), List<string> itemImgs = default(List<string>), string itemLink = default(string), string itemName = default(string), string itemText = default(string), string maxDiscountNum = default(string), string minConsumeNum = default(string), string originalPrice = default(string), string skuMinConsume = default(string), string totalMaxDiscountNum = default(string))
        {
            this.ItemIds = itemIds;
            this.ItemImgs = itemImgs;
            this.ItemLink = itemLink;
            this.ItemName = itemName;
            this.ItemText = itemText;
            this.MaxDiscountNum = maxDiscountNum;
            this.MinConsumeNum = minConsumeNum;
            this.OriginalPrice = originalPrice;
            this.SkuMinConsume = skuMinConsume;
            this.TotalMaxDiscountNum = totalMaxDiscountNum;
        }

        /// <summary>
        /// 券适用的单品码列表  最少配置1个单品码  最多配置500个单品码
        /// </summary>
        /// <value>券适用的单品码列表  最少配置1个单品码  最多配置500个单品码</value>
        [DataMember(Name = "item_ids", EmitDefaultValue = false)]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 单品图片列表  单品图片不能超过3张
        /// </summary>
        /// <value>单品图片列表  单品图片不能超过3张</value>
        [DataMember(Name = "item_imgs", EmitDefaultValue = false)]
        public List<string> ItemImgs { get; set; }

        /// <summary>
        /// 单品券详细介绍跳转链接
        /// </summary>
        /// <value>单品券详细介绍跳转链接</value>
        [DataMember(Name = "item_link", EmitDefaultValue = false)]
        public string ItemLink { get; set; }

        /// <summary>
        /// 单品名称
        /// </summary>
        /// <value>单品名称</value>
        [DataMember(Name = "item_name", EmitDefaultValue = false)]
        public string ItemName { get; set; }

        /// <summary>
        /// 单品券说明
        /// </summary>
        /// <value>单品券说明</value>
        [DataMember(Name = "item_text", EmitDefaultValue = false)]
        public string ItemText { get; set; }

        /// <summary>
        /// 单品券适用的商品列表中，每一个商品最高可享受优惠的件数；    如：券适用于A,B两种商品，该字段设置为1，则用券A,B两种商品每种最多只有一件可享受优惠；
        /// </summary>
        /// <value>单品券适用的商品列表中，每一个商品最高可享受优惠的件数；    如：券适用于A,B两种商品，该字段设置为1，则用券A,B两种商品每种最多只有一件可享受优惠；</value>
        [DataMember(Name = "max_discount_num", EmitDefaultValue = false)]
        public string MaxDiscountNum { get; set; }

        /// <summary>
        /// 单品券适用商品列表中，每种商品享受优惠最低购买件数的门槛；  如：券适用于A,B两种商品，该字段设置为3，则A,B两种商品每种最少需要购买3件才可享受优惠；
        /// </summary>
        /// <value>单品券适用商品列表中，每种商品享受优惠最低购买件数的门槛；  如：券适用于A,B两种商品，该字段设置为3，则A,B两种商品每种最少需要购买3件才可享受优惠；</value>
        [DataMember(Name = "min_consume_num", EmitDefaultValue = false)]
        public string MinConsumeNum { get; set; }

        /// <summary>
        /// 单品的原价，单位元  必须为合法金额类型字符串，如9.99
        /// </summary>
        /// <value>单品的原价，单位元  必须为合法金额类型字符串，如9.99</value>
        [DataMember(Name = "original_price", EmitDefaultValue = false)]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 券适用SKU的最低消费金额门槛  如券适用A,B两个SKU，该字段设置的值为100，则订单中购买A,B两个SKU的合计金额需大于100元才可用券
        /// </summary>
        /// <value>券适用SKU的最低消费金额门槛  如券适用A,B两个SKU，该字段设置的值为100，则订单中购买A,B两个SKU的合计金额需大于100元才可用券</value>
        [DataMember(Name = "sku_min_consume", EmitDefaultValue = false)]
        public string SkuMinConsume { get; set; }

        /// <summary>
        /// 如果一个单品券适用A，B，C三个单品，若设置了该字段为2，则在一笔交易中，A，B，C三个单品加起来最多只有俩件能够享受优惠
        /// </summary>
        /// <value>如果一个单品券适用A，B，C三个单品，若设置了该字段为2，则在一笔交易中，A，B，C三个单品加起来最多只有俩件能够享受优惠</value>
        [DataMember(Name = "total_max_discount_num", EmitDefaultValue = false)]
        public string TotalMaxDiscountNum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InteligentItemInfo {\n");
            sb.Append("  ItemIds: ").Append(ItemIds).Append("\n");
            sb.Append("  ItemImgs: ").Append(ItemImgs).Append("\n");
            sb.Append("  ItemLink: ").Append(ItemLink).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  ItemText: ").Append(ItemText).Append("\n");
            sb.Append("  MaxDiscountNum: ").Append(MaxDiscountNum).Append("\n");
            sb.Append("  MinConsumeNum: ").Append(MinConsumeNum).Append("\n");
            sb.Append("  OriginalPrice: ").Append(OriginalPrice).Append("\n");
            sb.Append("  SkuMinConsume: ").Append(SkuMinConsume).Append("\n");
            sb.Append("  TotalMaxDiscountNum: ").Append(TotalMaxDiscountNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InteligentItemInfo);
        }

        /// <summary>
        /// Returns true if InteligentItemInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of InteligentItemInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteligentItemInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemIds == input.ItemIds ||
                    this.ItemIds != null &&
                    input.ItemIds != null &&
                    this.ItemIds.SequenceEqual(input.ItemIds)
                ) && 
                (
                    this.ItemImgs == input.ItemImgs ||
                    this.ItemImgs != null &&
                    input.ItemImgs != null &&
                    this.ItemImgs.SequenceEqual(input.ItemImgs)
                ) && 
                (
                    this.ItemLink == input.ItemLink ||
                    (this.ItemLink != null &&
                    this.ItemLink.Equals(input.ItemLink))
                ) && 
                (
                    this.ItemName == input.ItemName ||
                    (this.ItemName != null &&
                    this.ItemName.Equals(input.ItemName))
                ) && 
                (
                    this.ItemText == input.ItemText ||
                    (this.ItemText != null &&
                    this.ItemText.Equals(input.ItemText))
                ) && 
                (
                    this.MaxDiscountNum == input.MaxDiscountNum ||
                    (this.MaxDiscountNum != null &&
                    this.MaxDiscountNum.Equals(input.MaxDiscountNum))
                ) && 
                (
                    this.MinConsumeNum == input.MinConsumeNum ||
                    (this.MinConsumeNum != null &&
                    this.MinConsumeNum.Equals(input.MinConsumeNum))
                ) && 
                (
                    this.OriginalPrice == input.OriginalPrice ||
                    (this.OriginalPrice != null &&
                    this.OriginalPrice.Equals(input.OriginalPrice))
                ) && 
                (
                    this.SkuMinConsume == input.SkuMinConsume ||
                    (this.SkuMinConsume != null &&
                    this.SkuMinConsume.Equals(input.SkuMinConsume))
                ) && 
                (
                    this.TotalMaxDiscountNum == input.TotalMaxDiscountNum ||
                    (this.TotalMaxDiscountNum != null &&
                    this.TotalMaxDiscountNum.Equals(input.TotalMaxDiscountNum))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ItemIds != null)
                {
                    hashCode = (hashCode * 59) + this.ItemIds.GetHashCode();
                }
                if (this.ItemImgs != null)
                {
                    hashCode = (hashCode * 59) + this.ItemImgs.GetHashCode();
                }
                if (this.ItemLink != null)
                {
                    hashCode = (hashCode * 59) + this.ItemLink.GetHashCode();
                }
                if (this.ItemName != null)
                {
                    hashCode = (hashCode * 59) + this.ItemName.GetHashCode();
                }
                if (this.ItemText != null)
                {
                    hashCode = (hashCode * 59) + this.ItemText.GetHashCode();
                }
                if (this.MaxDiscountNum != null)
                {
                    hashCode = (hashCode * 59) + this.MaxDiscountNum.GetHashCode();
                }
                if (this.MinConsumeNum != null)
                {
                    hashCode = (hashCode * 59) + this.MinConsumeNum.GetHashCode();
                }
                if (this.OriginalPrice != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalPrice.GetHashCode();
                }
                if (this.SkuMinConsume != null)
                {
                    hashCode = (hashCode * 59) + this.SkuMinConsume.GetHashCode();
                }
                if (this.TotalMaxDiscountNum != null)
                {
                    hashCode = (hashCode * 59) + this.TotalMaxDiscountNum.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
