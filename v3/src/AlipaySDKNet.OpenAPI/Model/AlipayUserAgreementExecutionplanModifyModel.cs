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
    /// AlipayUserAgreementExecutionplanModifyModel
    /// </summary>
    [DataContract(Name = "AlipayUserAgreementExecutionplanModifyModel")]
    public partial class AlipayUserAgreementExecutionplanModifyModel : IEquatable<AlipayUserAgreementExecutionplanModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserAgreementExecutionplanModifyModel" /> class.
        /// </summary>
        /// <param name="agreementNo">周期性扣款产品，授权免密支付协议号.</param>
        /// <param name="deductTime">商户下一次扣款时间.</param>
        /// <param name="memo">具体修改原因.</param>
        public AlipayUserAgreementExecutionplanModifyModel(string agreementNo = default(string), string deductTime = default(string), string memo = default(string))
        {
            this.AgreementNo = agreementNo;
            this.DeductTime = deductTime;
            this.Memo = memo;
        }

        /// <summary>
        /// 周期性扣款产品，授权免密支付协议号
        /// </summary>
        /// <value>周期性扣款产品，授权免密支付协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 商户下一次扣款时间
        /// </summary>
        /// <value>商户下一次扣款时间</value>
        [DataMember(Name = "deduct_time", EmitDefaultValue = false)]
        public string DeductTime { get; set; }

        /// <summary>
        /// 具体修改原因
        /// </summary>
        /// <value>具体修改原因</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayUserAgreementExecutionplanModifyModel {\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  DeductTime: ").Append(DeductTime).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
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
            return this.Equals(input as AlipayUserAgreementExecutionplanModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayUserAgreementExecutionplanModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserAgreementExecutionplanModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserAgreementExecutionplanModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.DeductTime == input.DeductTime ||
                    (this.DeductTime != null &&
                    this.DeductTime.Equals(input.DeductTime))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
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
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.DeductTime != null)
                {
                    hashCode = (hashCode * 59) + this.DeductTime.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
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
