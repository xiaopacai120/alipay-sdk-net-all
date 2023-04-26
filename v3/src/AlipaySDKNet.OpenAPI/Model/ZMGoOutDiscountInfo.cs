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
    /// ZMGoOutDiscountInfo
    /// </summary>
    [DataContract(Name = "ZMGoOutDiscountInfo")]
    public partial class ZMGoOutDiscountInfo : IEquatable<ZMGoOutDiscountInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZMGoOutDiscountInfo" /> class.
        /// </summary>
        /// <param name="discountAmount">商户回传的优惠金额，如用户享受的红包金额，单位元.</param>
        /// <param name="discountName">商户数据回传的优惠信息的名称.</param>
        /// <param name="discountType">优惠信息的类型。为枚举值，商户可任意选择一个值作为入参传入。可取值： (\&quot;exclusiveBenefit\&quot;,\&quot;专享优惠\&quot;), (\&quot;exclusiveDiscount\&quot;,\&quot;专享折扣\&quot;), (\&quot;appreciationBenefit\&quot;, \&quot;增值权益\&quot;), (\&quot;memberPoint\&quot;, \&quot;会员积分\&quot;).</param>
        public ZMGoOutDiscountInfo(string discountAmount = default(string), string discountName = default(string), string discountType = default(string))
        {
            this.DiscountAmount = discountAmount;
            this.DiscountName = discountName;
            this.DiscountType = discountType;
        }

        /// <summary>
        /// 商户回传的优惠金额，如用户享受的红包金额，单位元
        /// </summary>
        /// <value>商户回传的优惠金额，如用户享受的红包金额，单位元</value>
        [DataMember(Name = "discount_amount", EmitDefaultValue = false)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 商户数据回传的优惠信息的名称
        /// </summary>
        /// <value>商户数据回传的优惠信息的名称</value>
        [DataMember(Name = "discount_name", EmitDefaultValue = false)]
        public string DiscountName { get; set; }

        /// <summary>
        /// 优惠信息的类型。为枚举值，商户可任意选择一个值作为入参传入。可取值： (\&quot;exclusiveBenefit\&quot;,\&quot;专享优惠\&quot;), (\&quot;exclusiveDiscount\&quot;,\&quot;专享折扣\&quot;), (\&quot;appreciationBenefit\&quot;, \&quot;增值权益\&quot;), (\&quot;memberPoint\&quot;, \&quot;会员积分\&quot;)
        /// </summary>
        /// <value>优惠信息的类型。为枚举值，商户可任意选择一个值作为入参传入。可取值： (\&quot;exclusiveBenefit\&quot;,\&quot;专享优惠\&quot;), (\&quot;exclusiveDiscount\&quot;,\&quot;专享折扣\&quot;), (\&quot;appreciationBenefit\&quot;, \&quot;增值权益\&quot;), (\&quot;memberPoint\&quot;, \&quot;会员积分\&quot;)</value>
        [DataMember(Name = "discount_type", EmitDefaultValue = false)]
        public string DiscountType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZMGoOutDiscountInfo {\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DiscountName: ").Append(DiscountName).Append("\n");
            sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
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
            return this.Equals(input as ZMGoOutDiscountInfo);
        }

        /// <summary>
        /// Returns true if ZMGoOutDiscountInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ZMGoOutDiscountInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZMGoOutDiscountInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    (this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(input.DiscountAmount))
                ) && 
                (
                    this.DiscountName == input.DiscountName ||
                    (this.DiscountName != null &&
                    this.DiscountName.Equals(input.DiscountName))
                ) && 
                (
                    this.DiscountType == input.DiscountType ||
                    (this.DiscountType != null &&
                    this.DiscountType.Equals(input.DiscountType))
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
                if (this.DiscountAmount != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountAmount.GetHashCode();
                }
                if (this.DiscountName != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountName.GetHashCode();
                }
                if (this.DiscountType != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountType.GetHashCode();
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
