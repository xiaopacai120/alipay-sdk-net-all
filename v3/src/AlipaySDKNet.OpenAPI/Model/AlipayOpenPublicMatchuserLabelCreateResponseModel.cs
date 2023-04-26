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
    /// AlipayOpenPublicMatchuserLabelCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicMatchuserLabelCreateResponseModel")]
    public partial class AlipayOpenPublicMatchuserLabelCreateResponseModel : IEquatable<AlipayOpenPublicMatchuserLabelCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMatchuserLabelCreateResponseModel" /> class.
        /// </summary>
        /// <param name="errorCount">用户打标失败数量.</param>
        /// <param name="errorMatchers">出错的匹配器列表.</param>
        public AlipayOpenPublicMatchuserLabelCreateResponseModel(int errorCount = default(int), List<ErrorMatcher> errorMatchers = default(List<ErrorMatcher>))
        {
            this.ErrorCount = errorCount;
            this.ErrorMatchers = errorMatchers;
        }

        /// <summary>
        /// 用户打标失败数量
        /// </summary>
        /// <value>用户打标失败数量</value>
        [DataMember(Name = "error_count", EmitDefaultValue = false)]
        public int ErrorCount { get; set; }

        /// <summary>
        /// 出错的匹配器列表
        /// </summary>
        /// <value>出错的匹配器列表</value>
        [DataMember(Name = "error_matchers", EmitDefaultValue = false)]
        public List<ErrorMatcher> ErrorMatchers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicMatchuserLabelCreateResponseModel {\n");
            sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
            sb.Append("  ErrorMatchers: ").Append(ErrorMatchers).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicMatchuserLabelCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicMatchuserLabelCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicMatchuserLabelCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicMatchuserLabelCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ErrorCount == input.ErrorCount ||
                    this.ErrorCount.Equals(input.ErrorCount)
                ) && 
                (
                    this.ErrorMatchers == input.ErrorMatchers ||
                    this.ErrorMatchers != null &&
                    input.ErrorMatchers != null &&
                    this.ErrorMatchers.SequenceEqual(input.ErrorMatchers)
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
                hashCode = (hashCode * 59) + this.ErrorCount.GetHashCode();
                if (this.ErrorMatchers != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorMatchers.GetHashCode();
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
