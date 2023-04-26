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
    /// ModifyQuotaDetails
    /// </summary>
    [DataContract(Name = "ModifyQuotaDetails")]
    public partial class ModifyQuotaDetails : IEquatable<ModifyQuotaDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyQuotaDetails" /> class.
        /// </summary>
        /// <param name="quotaAmount">具体额度，单位：元。如金额为空，表示删除已有的额度设置，无已有额度设置则忽略。.</param>
        /// <param name="quotaDimension">额度维度 MONTH/DAY/SINGLE 分别代表月、日、单次.</param>
        /// <param name="role">PAYER/PAYEE 额度管控的角色，收or付款方，目前只支持付款方.</param>
        public ModifyQuotaDetails(string quotaAmount = default(string), string quotaDimension = default(string), string role = default(string))
        {
            this.QuotaAmount = quotaAmount;
            this.QuotaDimension = quotaDimension;
            this.Role = role;
        }

        /// <summary>
        /// 具体额度，单位：元。如金额为空，表示删除已有的额度设置，无已有额度设置则忽略。
        /// </summary>
        /// <value>具体额度，单位：元。如金额为空，表示删除已有的额度设置，无已有额度设置则忽略。</value>
        [DataMember(Name = "quota_amount", EmitDefaultValue = false)]
        public string QuotaAmount { get; set; }

        /// <summary>
        /// 额度维度 MONTH/DAY/SINGLE 分别代表月、日、单次
        /// </summary>
        /// <value>额度维度 MONTH/DAY/SINGLE 分别代表月、日、单次</value>
        [DataMember(Name = "quota_dimension", EmitDefaultValue = false)]
        public string QuotaDimension { get; set; }

        /// <summary>
        /// PAYER/PAYEE 额度管控的角色，收or付款方，目前只支持付款方
        /// </summary>
        /// <value>PAYER/PAYEE 额度管控的角色，收or付款方，目前只支持付款方</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public string Role { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModifyQuotaDetails {\n");
            sb.Append("  QuotaAmount: ").Append(QuotaAmount).Append("\n");
            sb.Append("  QuotaDimension: ").Append(QuotaDimension).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as ModifyQuotaDetails);
        }

        /// <summary>
        /// Returns true if ModifyQuotaDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifyQuotaDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyQuotaDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QuotaAmount == input.QuotaAmount ||
                    (this.QuotaAmount != null &&
                    this.QuotaAmount.Equals(input.QuotaAmount))
                ) && 
                (
                    this.QuotaDimension == input.QuotaDimension ||
                    (this.QuotaDimension != null &&
                    this.QuotaDimension.Equals(input.QuotaDimension))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.QuotaAmount != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaAmount.GetHashCode();
                }
                if (this.QuotaDimension != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaDimension.GetHashCode();
                }
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
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
