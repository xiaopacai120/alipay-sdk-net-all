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
    /// AlipayEbppPdeductSignCancelResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppPdeductSignCancelResponseModel")]
    public partial class AlipayEbppPdeductSignCancelResponseModel : IEquatable<AlipayEbppPdeductSignCancelResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppPdeductSignCancelResponseModel" /> class.
        /// </summary>
        /// <param name="agreementId">支付宝代扣协议ID.</param>
        /// <param name="agreementStatus">支付宝协议状态。解约成功则返回success.</param>
        /// <param name="outAgreementId">商户代扣协议ID.</param>
        public AlipayEbppPdeductSignCancelResponseModel(string agreementId = default(string), string agreementStatus = default(string), string outAgreementId = default(string))
        {
            this.AgreementId = agreementId;
            this.AgreementStatus = agreementStatus;
            this.OutAgreementId = outAgreementId;
        }

        /// <summary>
        /// 支付宝代扣协议ID
        /// </summary>
        /// <value>支付宝代扣协议ID</value>
        [DataMember(Name = "agreement_id", EmitDefaultValue = false)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝协议状态。解约成功则返回success
        /// </summary>
        /// <value>支付宝协议状态。解约成功则返回success</value>
        [DataMember(Name = "agreement_status", EmitDefaultValue = false)]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 商户代扣协议ID
        /// </summary>
        /// <value>商户代扣协议ID</value>
        [DataMember(Name = "out_agreement_id", EmitDefaultValue = false)]
        public string OutAgreementId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppPdeductSignCancelResponseModel {\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  AgreementStatus: ").Append(AgreementStatus).Append("\n");
            sb.Append("  OutAgreementId: ").Append(OutAgreementId).Append("\n");
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
            return this.Equals(input as AlipayEbppPdeductSignCancelResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppPdeductSignCancelResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppPdeductSignCancelResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppPdeductSignCancelResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementId == input.AgreementId ||
                    (this.AgreementId != null &&
                    this.AgreementId.Equals(input.AgreementId))
                ) && 
                (
                    this.AgreementStatus == input.AgreementStatus ||
                    (this.AgreementStatus != null &&
                    this.AgreementStatus.Equals(input.AgreementStatus))
                ) && 
                (
                    this.OutAgreementId == input.OutAgreementId ||
                    (this.OutAgreementId != null &&
                    this.OutAgreementId.Equals(input.OutAgreementId))
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
                if (this.AgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementId.GetHashCode();
                }
                if (this.AgreementStatus != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementStatus.GetHashCode();
                }
                if (this.OutAgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.OutAgreementId.GetHashCode();
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
