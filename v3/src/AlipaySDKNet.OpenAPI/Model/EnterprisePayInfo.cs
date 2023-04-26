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
    /// EnterprisePayInfo
    /// </summary>
    [DataContract(Name = "EnterprisePayInfo")]
    public partial class EnterprisePayInfo : IEquatable<EnterprisePayInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnterprisePayInfo" /> class.
        /// </summary>
        /// <param name="bizInfo">因公付业务信息.</param>
        /// <param name="invoiceAmount">开票金额.</param>
        /// <param name="isUseEnterprisePay">是否包含因公付资产.</param>
        public EnterprisePayInfo(string bizInfo = default(string), string invoiceAmount = default(string), bool isUseEnterprisePay = default(bool))
        {
            this.BizInfo = bizInfo;
            this.InvoiceAmount = invoiceAmount;
            this.IsUseEnterprisePay = isUseEnterprisePay;
        }

        /// <summary>
        /// 因公付业务信息
        /// </summary>
        /// <value>因公付业务信息</value>
        [DataMember(Name = "biz_info", EmitDefaultValue = false)]
        public string BizInfo { get; set; }

        /// <summary>
        /// 开票金额
        /// </summary>
        /// <value>开票金额</value>
        [DataMember(Name = "invoice_amount", EmitDefaultValue = false)]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 是否包含因公付资产
        /// </summary>
        /// <value>是否包含因公付资产</value>
        [DataMember(Name = "is_use_enterprise_pay", EmitDefaultValue = true)]
        public bool IsUseEnterprisePay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EnterprisePayInfo {\n");
            sb.Append("  BizInfo: ").Append(BizInfo).Append("\n");
            sb.Append("  InvoiceAmount: ").Append(InvoiceAmount).Append("\n");
            sb.Append("  IsUseEnterprisePay: ").Append(IsUseEnterprisePay).Append("\n");
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
            return this.Equals(input as EnterprisePayInfo);
        }

        /// <summary>
        /// Returns true if EnterprisePayInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of EnterprisePayInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnterprisePayInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizInfo == input.BizInfo ||
                    (this.BizInfo != null &&
                    this.BizInfo.Equals(input.BizInfo))
                ) && 
                (
                    this.InvoiceAmount == input.InvoiceAmount ||
                    (this.InvoiceAmount != null &&
                    this.InvoiceAmount.Equals(input.InvoiceAmount))
                ) && 
                (
                    this.IsUseEnterprisePay == input.IsUseEnterprisePay ||
                    this.IsUseEnterprisePay.Equals(input.IsUseEnterprisePay)
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
                if (this.BizInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BizInfo.GetHashCode();
                }
                if (this.InvoiceAmount != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsUseEnterprisePay.GetHashCode();
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
