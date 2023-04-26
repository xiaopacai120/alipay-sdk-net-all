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
    /// AlipayCommerceOperationActivityMerchantModifyModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceOperationActivityMerchantModifyModel")]
    public partial class AlipayCommerceOperationActivityMerchantModifyModel : IEquatable<AlipayCommerceOperationActivityMerchantModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceOperationActivityMerchantModifyModel" /> class.
        /// </summary>
        /// <param name="consumptionThreshold">消费门槛，单位分.</param>
        /// <param name="discountAmount">优惠金额，单位分.</param>
        /// <param name="type">NORMAL 常规类型，不限制, RESTRICTED 限制报名条件.</param>
        public AlipayCommerceOperationActivityMerchantModifyModel(int consumptionThreshold = default(int), int discountAmount = default(int), string type = default(string))
        {
            this.ConsumptionThreshold = consumptionThreshold;
            this.DiscountAmount = discountAmount;
            this.Type = type;
        }

        /// <summary>
        /// 消费门槛，单位分
        /// </summary>
        /// <value>消费门槛，单位分</value>
        [DataMember(Name = "consumption_threshold", EmitDefaultValue = false)]
        public int ConsumptionThreshold { get; set; }

        /// <summary>
        /// 优惠金额，单位分
        /// </summary>
        /// <value>优惠金额，单位分</value>
        [DataMember(Name = "discount_amount", EmitDefaultValue = false)]
        public int DiscountAmount { get; set; }

        /// <summary>
        /// NORMAL 常规类型，不限制, RESTRICTED 限制报名条件
        /// </summary>
        /// <value>NORMAL 常规类型，不限制, RESTRICTED 限制报名条件</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceOperationActivityMerchantModifyModel {\n");
            sb.Append("  ConsumptionThreshold: ").Append(ConsumptionThreshold).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as AlipayCommerceOperationActivityMerchantModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceOperationActivityMerchantModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceOperationActivityMerchantModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceOperationActivityMerchantModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConsumptionThreshold == input.ConsumptionThreshold ||
                    this.ConsumptionThreshold.Equals(input.ConsumptionThreshold)
                ) && 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    this.DiscountAmount.Equals(input.DiscountAmount)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                hashCode = (hashCode * 59) + this.ConsumptionThreshold.GetHashCode();
                hashCode = (hashCode * 59) + this.DiscountAmount.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
