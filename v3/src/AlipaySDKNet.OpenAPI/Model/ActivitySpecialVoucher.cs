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
    /// ActivitySpecialVoucher
    /// </summary>
    [DataContract(Name = "ActivitySpecialVoucher")]
    public partial class ActivitySpecialVoucher : IEquatable<ActivitySpecialVoucher>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitySpecialVoucher" /> class.
        /// </summary>
        /// <param name="floorAmount">门槛金额。.</param>
        /// <param name="goodsName">商品名称。说明：该字段可不填，填入 origin_amount 则必填。.</param>
        /// <param name="originAmount">原价。.</param>
        /// <param name="specialAmount">特价，即：原价-特价&#x3D;优惠金额。.</param>
        public ActivitySpecialVoucher(string floorAmount = default(string), string goodsName = default(string), string originAmount = default(string), string specialAmount = default(string))
        {
            this.FloorAmount = floorAmount;
            this.GoodsName = goodsName;
            this.OriginAmount = originAmount;
            this.SpecialAmount = specialAmount;
        }

        /// <summary>
        /// 门槛金额。
        /// </summary>
        /// <value>门槛金额。</value>
        [DataMember(Name = "floor_amount", EmitDefaultValue = false)]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 商品名称。说明：该字段可不填，填入 origin_amount 则必填。
        /// </summary>
        /// <value>商品名称。说明：该字段可不填，填入 origin_amount 则必填。</value>
        [DataMember(Name = "goods_name", EmitDefaultValue = false)]
        public string GoodsName { get; set; }

        /// <summary>
        /// 原价。
        /// </summary>
        /// <value>原价。</value>
        [DataMember(Name = "origin_amount", EmitDefaultValue = false)]
        public string OriginAmount { get; set; }

        /// <summary>
        /// 特价，即：原价-特价&#x3D;优惠金额。
        /// </summary>
        /// <value>特价，即：原价-特价&#x3D;优惠金额。</value>
        [DataMember(Name = "special_amount", EmitDefaultValue = false)]
        public string SpecialAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActivitySpecialVoucher {\n");
            sb.Append("  FloorAmount: ").Append(FloorAmount).Append("\n");
            sb.Append("  GoodsName: ").Append(GoodsName).Append("\n");
            sb.Append("  OriginAmount: ").Append(OriginAmount).Append("\n");
            sb.Append("  SpecialAmount: ").Append(SpecialAmount).Append("\n");
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
            return this.Equals(input as ActivitySpecialVoucher);
        }

        /// <summary>
        /// Returns true if ActivitySpecialVoucher instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivitySpecialVoucher to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivitySpecialVoucher input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FloorAmount == input.FloorAmount ||
                    (this.FloorAmount != null &&
                    this.FloorAmount.Equals(input.FloorAmount))
                ) && 
                (
                    this.GoodsName == input.GoodsName ||
                    (this.GoodsName != null &&
                    this.GoodsName.Equals(input.GoodsName))
                ) && 
                (
                    this.OriginAmount == input.OriginAmount ||
                    (this.OriginAmount != null &&
                    this.OriginAmount.Equals(input.OriginAmount))
                ) && 
                (
                    this.SpecialAmount == input.SpecialAmount ||
                    (this.SpecialAmount != null &&
                    this.SpecialAmount.Equals(input.SpecialAmount))
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
                if (this.FloorAmount != null)
                {
                    hashCode = (hashCode * 59) + this.FloorAmount.GetHashCode();
                }
                if (this.GoodsName != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsName.GetHashCode();
                }
                if (this.OriginAmount != null)
                {
                    hashCode = (hashCode * 59) + this.OriginAmount.GetHashCode();
                }
                if (this.SpecialAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SpecialAmount.GetHashCode();
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
