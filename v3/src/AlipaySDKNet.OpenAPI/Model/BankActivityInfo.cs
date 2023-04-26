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
    /// BankActivityInfo
    /// </summary>
    [DataContract(Name = "BankActivityInfo")]
    public partial class BankActivityInfo : IEquatable<BankActivityInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankActivityInfo" /> class.
        /// </summary>
        /// <param name="bindCard">是否绑定银行卡.</param>
        /// <param name="cardName">银行卡名称.</param>
        /// <param name="discountDesc">优惠描述.</param>
        /// <param name="logo">活动logo.</param>
        public BankActivityInfo(bool bindCard = default(bool), string cardName = default(string), string discountDesc = default(string), string logo = default(string))
        {
            this.BindCard = bindCard;
            this.CardName = cardName;
            this.DiscountDesc = discountDesc;
            this.Logo = logo;
        }

        /// <summary>
        /// 是否绑定银行卡
        /// </summary>
        /// <value>是否绑定银行卡</value>
        [DataMember(Name = "bind_card", EmitDefaultValue = true)]
        public bool BindCard { get; set; }

        /// <summary>
        /// 银行卡名称
        /// </summary>
        /// <value>银行卡名称</value>
        [DataMember(Name = "card_name", EmitDefaultValue = false)]
        public string CardName { get; set; }

        /// <summary>
        /// 优惠描述
        /// </summary>
        /// <value>优惠描述</value>
        [DataMember(Name = "discount_desc", EmitDefaultValue = false)]
        public string DiscountDesc { get; set; }

        /// <summary>
        /// 活动logo
        /// </summary>
        /// <value>活动logo</value>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BankActivityInfo {\n");
            sb.Append("  BindCard: ").Append(BindCard).Append("\n");
            sb.Append("  CardName: ").Append(CardName).Append("\n");
            sb.Append("  DiscountDesc: ").Append(DiscountDesc).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
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
            return this.Equals(input as BankActivityInfo);
        }

        /// <summary>
        /// Returns true if BankActivityInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BankActivityInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankActivityInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BindCard == input.BindCard ||
                    this.BindCard.Equals(input.BindCard)
                ) && 
                (
                    this.CardName == input.CardName ||
                    (this.CardName != null &&
                    this.CardName.Equals(input.CardName))
                ) && 
                (
                    this.DiscountDesc == input.DiscountDesc ||
                    (this.DiscountDesc != null &&
                    this.DiscountDesc.Equals(input.DiscountDesc))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
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
                hashCode = (hashCode * 59) + this.BindCard.GetHashCode();
                if (this.CardName != null)
                {
                    hashCode = (hashCode * 59) + this.CardName.GetHashCode();
                }
                if (this.DiscountDesc != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountDesc.GetHashCode();
                }
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
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
