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
    /// GoodsOrder
    /// </summary>
    [DataContract(Name = "GoodsOrder")]
    public partial class GoodsOrder : IEquatable<GoodsOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoodsOrder" /> class.
        /// </summary>
        /// <param name="goodsName">商品名称.</param>
        /// <param name="goodsPictureId">商品图片素材Id；商品文件上传接口返回material_id。不传则暂时默认约定图片，具体可以咨询支付宝行业小二.</param>
        public GoodsOrder(string goodsName = default(string), string goodsPictureId = default(string))
        {
            this.GoodsName = goodsName;
            this.GoodsPictureId = goodsPictureId;
        }

        /// <summary>
        /// 商品名称
        /// </summary>
        /// <value>商品名称</value>
        [DataMember(Name = "goods_name", EmitDefaultValue = false)]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品图片素材Id；商品文件上传接口返回material_id。不传则暂时默认约定图片，具体可以咨询支付宝行业小二
        /// </summary>
        /// <value>商品图片素材Id；商品文件上传接口返回material_id。不传则暂时默认约定图片，具体可以咨询支付宝行业小二</value>
        [DataMember(Name = "goods_picture_id", EmitDefaultValue = false)]
        public string GoodsPictureId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoodsOrder {\n");
            sb.Append("  GoodsName: ").Append(GoodsName).Append("\n");
            sb.Append("  GoodsPictureId: ").Append(GoodsPictureId).Append("\n");
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
            return this.Equals(input as GoodsOrder);
        }

        /// <summary>
        /// Returns true if GoodsOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of GoodsOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoodsOrder input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GoodsName == input.GoodsName ||
                    (this.GoodsName != null &&
                    this.GoodsName.Equals(input.GoodsName))
                ) && 
                (
                    this.GoodsPictureId == input.GoodsPictureId ||
                    (this.GoodsPictureId != null &&
                    this.GoodsPictureId.Equals(input.GoodsPictureId))
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
                if (this.GoodsName != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsName.GetHashCode();
                }
                if (this.GoodsPictureId != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsPictureId.GetHashCode();
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
