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
    /// GoodsInfo
    /// </summary>
    [DataContract(Name = "GoodsInfo")]
    public partial class GoodsInfo : IEquatable<GoodsInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoodsInfo" /> class.
        /// </summary>
        /// <param name="goodsCategory">商品类目.</param>
        /// <param name="goodsId">商户自定义商品外部编号.</param>
        /// <param name="goodsName">商户自定义商品名称.</param>
        /// <param name="price">商品单价，单位元,精确到小数点后两位，取值范围[0.01,100000000].</param>
        /// <param name="quantity">商品数量,支持小数，但是小数位不能超过两位.</param>
        public GoodsInfo(string goodsCategory = default(string), string goodsId = default(string), string goodsName = default(string), string price = default(string), string quantity = default(string))
        {
            this.GoodsCategory = goodsCategory;
            this.GoodsId = goodsId;
            this.GoodsName = goodsName;
            this.Price = price;
            this.Quantity = quantity;
        }

        /// <summary>
        /// 商品类目
        /// </summary>
        /// <value>商品类目</value>
        [DataMember(Name = "goods_category", EmitDefaultValue = false)]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 商户自定义商品外部编号
        /// </summary>
        /// <value>商户自定义商品外部编号</value>
        [DataMember(Name = "goods_id", EmitDefaultValue = false)]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商户自定义商品名称
        /// </summary>
        /// <value>商户自定义商品名称</value>
        [DataMember(Name = "goods_name", EmitDefaultValue = false)]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品单价，单位元,精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        /// <value>商品单价，单位元,精确到小数点后两位，取值范围[0.01,100000000]</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量,支持小数，但是小数位不能超过两位
        /// </summary>
        /// <value>商品数量,支持小数，但是小数位不能超过两位</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public string Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoodsInfo {\n");
            sb.Append("  GoodsCategory: ").Append(GoodsCategory).Append("\n");
            sb.Append("  GoodsId: ").Append(GoodsId).Append("\n");
            sb.Append("  GoodsName: ").Append(GoodsName).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as GoodsInfo);
        }

        /// <summary>
        /// Returns true if GoodsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GoodsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoodsInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GoodsCategory == input.GoodsCategory ||
                    (this.GoodsCategory != null &&
                    this.GoodsCategory.Equals(input.GoodsCategory))
                ) && 
                (
                    this.GoodsId == input.GoodsId ||
                    (this.GoodsId != null &&
                    this.GoodsId.Equals(input.GoodsId))
                ) && 
                (
                    this.GoodsName == input.GoodsName ||
                    (this.GoodsName != null &&
                    this.GoodsName.Equals(input.GoodsName))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.GoodsCategory != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsCategory.GetHashCode();
                }
                if (this.GoodsId != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsId.GetHashCode();
                }
                if (this.GoodsName != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsName.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.Quantity != null)
                {
                    hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
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
