/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-07-17
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
    /// SearchBoxAreaKeyWordModule
    /// </summary>
    [DataContract(Name = "SearchBoxAreaKeyWordModule")]
    public partial class SearchBoxAreaKeyWordModule : IEquatable<SearchBoxAreaKeyWordModule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchBoxAreaKeyWordModule" /> class.
        /// </summary>
        /// <param name="latestAuditAreaKeywordInfo">latestAuditAreaKeywordInfo.</param>
        /// <param name="moduleId">模块id.</param>
        /// <param name="moduleType">搜索直达模块类型，BOX_EXCLUSIVE_BASE-基础信息/BOX_EXCLUSIVE_KEYWORD-关键词/BOX_EXCLUSIVE_FUNCTIONS-功能服务/BOX_EXCLUSIVE_ACCOUNTS-关联账号/BOX_ATMOSPHERE_IMAGE-氛围图.</param>
        /// <param name="validAreaKeywordInfo">validAreaKeywordInfo.</param>
        public SearchBoxAreaKeyWordModule(SearchBoxKeywordInfo latestAuditAreaKeywordInfo = default(SearchBoxKeywordInfo), string moduleId = default(string), string moduleType = default(string), SearchBoxKeywordInfo validAreaKeywordInfo = default(SearchBoxKeywordInfo))
        {
            this.LatestAuditAreaKeywordInfo = latestAuditAreaKeywordInfo;
            this.ModuleId = moduleId;
            this.ModuleType = moduleType;
            this.ValidAreaKeywordInfo = validAreaKeywordInfo;
        }

        /// <summary>
        /// Gets or Sets LatestAuditAreaKeywordInfo
        /// </summary>
        [DataMember(Name = "latest_audit_area_keyword_info", EmitDefaultValue = false)]
        public SearchBoxKeywordInfo LatestAuditAreaKeywordInfo { get; set; }

        /// <summary>
        /// 模块id
        /// </summary>
        /// <value>模块id</value>
        [DataMember(Name = "module_id", EmitDefaultValue = false)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 搜索直达模块类型，BOX_EXCLUSIVE_BASE-基础信息/BOX_EXCLUSIVE_KEYWORD-关键词/BOX_EXCLUSIVE_FUNCTIONS-功能服务/BOX_EXCLUSIVE_ACCOUNTS-关联账号/BOX_ATMOSPHERE_IMAGE-氛围图
        /// </summary>
        /// <value>搜索直达模块类型，BOX_EXCLUSIVE_BASE-基础信息/BOX_EXCLUSIVE_KEYWORD-关键词/BOX_EXCLUSIVE_FUNCTIONS-功能服务/BOX_EXCLUSIVE_ACCOUNTS-关联账号/BOX_ATMOSPHERE_IMAGE-氛围图</value>
        [DataMember(Name = "module_type", EmitDefaultValue = false)]
        public string ModuleType { get; set; }

        /// <summary>
        /// Gets or Sets ValidAreaKeywordInfo
        /// </summary>
        [DataMember(Name = "valid_area_keyword_info", EmitDefaultValue = false)]
        public SearchBoxKeywordInfo ValidAreaKeywordInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchBoxAreaKeyWordModule {\n");
            sb.Append("  LatestAuditAreaKeywordInfo: ").Append(LatestAuditAreaKeywordInfo).Append("\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
            sb.Append("  ModuleType: ").Append(ModuleType).Append("\n");
            sb.Append("  ValidAreaKeywordInfo: ").Append(ValidAreaKeywordInfo).Append("\n");
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
            return this.Equals(input as SearchBoxAreaKeyWordModule);
        }

        /// <summary>
        /// Returns true if SearchBoxAreaKeyWordModule instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchBoxAreaKeyWordModule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchBoxAreaKeyWordModule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LatestAuditAreaKeywordInfo == input.LatestAuditAreaKeywordInfo ||
                    (this.LatestAuditAreaKeywordInfo != null &&
                    this.LatestAuditAreaKeywordInfo.Equals(input.LatestAuditAreaKeywordInfo))
                ) && 
                (
                    this.ModuleId == input.ModuleId ||
                    (this.ModuleId != null &&
                    this.ModuleId.Equals(input.ModuleId))
                ) && 
                (
                    this.ModuleType == input.ModuleType ||
                    (this.ModuleType != null &&
                    this.ModuleType.Equals(input.ModuleType))
                ) && 
                (
                    this.ValidAreaKeywordInfo == input.ValidAreaKeywordInfo ||
                    (this.ValidAreaKeywordInfo != null &&
                    this.ValidAreaKeywordInfo.Equals(input.ValidAreaKeywordInfo))
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
                if (this.LatestAuditAreaKeywordInfo != null)
                {
                    hashCode = (hashCode * 59) + this.LatestAuditAreaKeywordInfo.GetHashCode();
                }
                if (this.ModuleId != null)
                {
                    hashCode = (hashCode * 59) + this.ModuleId.GetHashCode();
                }
                if (this.ModuleType != null)
                {
                    hashCode = (hashCode * 59) + this.ModuleType.GetHashCode();
                }
                if (this.ValidAreaKeywordInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ValidAreaKeywordInfo.GetHashCode();
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
