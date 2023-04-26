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
    /// VoucherUseTimeInfo
    /// </summary>
    [DataContract(Name = "VoucherUseTimeInfo")]
    public partial class VoucherUseTimeInfo : IEquatable<VoucherUseTimeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherUseTimeInfo" /> class.
        /// </summary>
        /// <param name="absolutePeriodInfo">absolutePeriodInfo.</param>
        /// <param name="periodType">券有效期。.</param>
        /// <param name="relativePeriodInfo">relativePeriodInfo.</param>
        public VoucherUseTimeInfo(VoucherAbsolutePeriodInfo absolutePeriodInfo = default(VoucherAbsolutePeriodInfo), string periodType = default(string), VoucherRelativePeriodInfo relativePeriodInfo = default(VoucherRelativePeriodInfo))
        {
            this.AbsolutePeriodInfo = absolutePeriodInfo;
            this.PeriodType = periodType;
            this.RelativePeriodInfo = relativePeriodInfo;
        }

        /// <summary>
        /// Gets or Sets AbsolutePeriodInfo
        /// </summary>
        [DataMember(Name = "absolute_period_info", EmitDefaultValue = false)]
        public VoucherAbsolutePeriodInfo AbsolutePeriodInfo { get; set; }

        /// <summary>
        /// 券有效期。
        /// </summary>
        /// <value>券有效期。</value>
        [DataMember(Name = "period_type", EmitDefaultValue = false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// Gets or Sets RelativePeriodInfo
        /// </summary>
        [DataMember(Name = "relative_period_info", EmitDefaultValue = false)]
        public VoucherRelativePeriodInfo RelativePeriodInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherUseTimeInfo {\n");
            sb.Append("  AbsolutePeriodInfo: ").Append(AbsolutePeriodInfo).Append("\n");
            sb.Append("  PeriodType: ").Append(PeriodType).Append("\n");
            sb.Append("  RelativePeriodInfo: ").Append(RelativePeriodInfo).Append("\n");
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
            return this.Equals(input as VoucherUseTimeInfo);
        }

        /// <summary>
        /// Returns true if VoucherUseTimeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherUseTimeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherUseTimeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AbsolutePeriodInfo == input.AbsolutePeriodInfo ||
                    (this.AbsolutePeriodInfo != null &&
                    this.AbsolutePeriodInfo.Equals(input.AbsolutePeriodInfo))
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
                ) && 
                (
                    this.RelativePeriodInfo == input.RelativePeriodInfo ||
                    (this.RelativePeriodInfo != null &&
                    this.RelativePeriodInfo.Equals(input.RelativePeriodInfo))
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
                if (this.AbsolutePeriodInfo != null)
                {
                    hashCode = (hashCode * 59) + this.AbsolutePeriodInfo.GetHashCode();
                }
                if (this.PeriodType != null)
                {
                    hashCode = (hashCode * 59) + this.PeriodType.GetHashCode();
                }
                if (this.RelativePeriodInfo != null)
                {
                    hashCode = (hashCode * 59) + this.RelativePeriodInfo.GetHashCode();
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
