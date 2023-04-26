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
    /// QueryComplexLabelRule
    /// </summary>
    [DataContract(Name = "QueryComplexLabelRule")]
    public partial class QueryComplexLabelRule : IEquatable<QueryComplexLabelRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryComplexLabelRule" /> class.
        /// </summary>
        /// <param name="labelId">标签id.</param>
        /// <param name="labelName">标签名.</param>
        /// <param name="labelValue">当有多个取值时用英文\&quot;,\&quot;分隔，不允许传入下划线\&quot;_\&quot;、竖线\&quot;|\&quot;或者空格\&quot; \&quot;.</param>
        /// <param name="_operator">运算符.</param>
        public QueryComplexLabelRule(string labelId = default(string), string labelName = default(string), string labelValue = default(string), string _operator = default(string))
        {
            this.LabelId = labelId;
            this.LabelName = labelName;
            this.LabelValue = labelValue;
            this.Operator = _operator;
        }

        /// <summary>
        /// 标签id
        /// </summary>
        /// <value>标签id</value>
        [DataMember(Name = "label_id", EmitDefaultValue = false)]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        /// <value>标签名</value>
        [DataMember(Name = "label_name", EmitDefaultValue = false)]
        public string LabelName { get; set; }

        /// <summary>
        /// 当有多个取值时用英文\&quot;,\&quot;分隔，不允许传入下划线\&quot;_\&quot;、竖线\&quot;|\&quot;或者空格\&quot; \&quot;
        /// </summary>
        /// <value>当有多个取值时用英文\&quot;,\&quot;分隔，不允许传入下划线\&quot;_\&quot;、竖线\&quot;|\&quot;或者空格\&quot; \&quot;</value>
        [DataMember(Name = "label_value", EmitDefaultValue = false)]
        public string LabelValue { get; set; }

        /// <summary>
        /// 运算符
        /// </summary>
        /// <value>运算符</value>
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public string Operator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QueryComplexLabelRule {\n");
            sb.Append("  LabelId: ").Append(LabelId).Append("\n");
            sb.Append("  LabelName: ").Append(LabelName).Append("\n");
            sb.Append("  LabelValue: ").Append(LabelValue).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
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
            return this.Equals(input as QueryComplexLabelRule);
        }

        /// <summary>
        /// Returns true if QueryComplexLabelRule instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryComplexLabelRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryComplexLabelRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LabelId == input.LabelId ||
                    (this.LabelId != null &&
                    this.LabelId.Equals(input.LabelId))
                ) && 
                (
                    this.LabelName == input.LabelName ||
                    (this.LabelName != null &&
                    this.LabelName.Equals(input.LabelName))
                ) && 
                (
                    this.LabelValue == input.LabelValue ||
                    (this.LabelValue != null &&
                    this.LabelValue.Equals(input.LabelValue))
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
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
                if (this.LabelId != null)
                {
                    hashCode = (hashCode * 59) + this.LabelId.GetHashCode();
                }
                if (this.LabelName != null)
                {
                    hashCode = (hashCode * 59) + this.LabelName.GetHashCode();
                }
                if (this.LabelValue != null)
                {
                    hashCode = (hashCode * 59) + this.LabelValue.GetHashCode();
                }
                if (this.Operator != null)
                {
                    hashCode = (hashCode * 59) + this.Operator.GetHashCode();
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
