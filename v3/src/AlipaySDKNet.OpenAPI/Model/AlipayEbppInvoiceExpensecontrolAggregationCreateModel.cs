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
    /// AlipayEbppInvoiceExpensecontrolAggregationCreateModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceExpensecontrolAggregationCreateModel")]
    public partial class AlipayEbppInvoiceExpensecontrolAggregationCreateModel : IEquatable<AlipayEbppInvoiceExpensecontrolAggregationCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpensecontrolAggregationCreateModel" /> class.
        /// </summary>
        /// <param name="accountId">企业ID.</param>
        /// <param name="aggregationName">聚合关系名称 特殊说明：敏感词校验.</param>
        /// <param name="agreementNo">授权签约协议号.</param>
        /// <param name="standardIdList">费控规则ID列表.</param>
        public AlipayEbppInvoiceExpensecontrolAggregationCreateModel(string accountId = default(string), string aggregationName = default(string), string agreementNo = default(string), List<string> standardIdList = default(List<string>))
        {
            this.AccountId = accountId;
            this.AggregationName = aggregationName;
            this.AgreementNo = agreementNo;
            this.StandardIdList = standardIdList;
        }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 聚合关系名称 特殊说明：敏感词校验
        /// </summary>
        /// <value>聚合关系名称 特殊说明：敏感词校验</value>
        [DataMember(Name = "aggregation_name", EmitDefaultValue = false)]
        public string AggregationName { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        /// <value>授权签约协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 费控规则ID列表
        /// </summary>
        /// <value>费控规则ID列表</value>
        [DataMember(Name = "standard_id_list", EmitDefaultValue = false)]
        public List<string> StandardIdList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceExpensecontrolAggregationCreateModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AggregationName: ").Append(AggregationName).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  StandardIdList: ").Append(StandardIdList).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceExpensecontrolAggregationCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceExpensecontrolAggregationCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceExpensecontrolAggregationCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceExpensecontrolAggregationCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AggregationName == input.AggregationName ||
                    (this.AggregationName != null &&
                    this.AggregationName.Equals(input.AggregationName))
                ) && 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.StandardIdList == input.StandardIdList ||
                    this.StandardIdList != null &&
                    input.StandardIdList != null &&
                    this.StandardIdList.SequenceEqual(input.StandardIdList)
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.AggregationName != null)
                {
                    hashCode = (hashCode * 59) + this.AggregationName.GetHashCode();
                }
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.StandardIdList != null)
                {
                    hashCode = (hashCode * 59) + this.StandardIdList.GetHashCode();
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
