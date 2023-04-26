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
    /// DatadigitalFincloudGeneralsaasFaceCertifyQueryResponseModel
    /// </summary>
    [DataContract(Name = "DatadigitalFincloudGeneralsaasFaceCertifyQueryResponseModel")]
    public partial class DatadigitalFincloudGeneralsaasFaceCertifyQueryResponseModel : IEquatable<DatadigitalFincloudGeneralsaasFaceCertifyQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatadigitalFincloudGeneralsaasFaceCertifyQueryResponseModel" /> class.
        /// </summary>
        /// <param name="failReason">认证错误原因，扩展字段，默认不返回.</param>
        /// <param name="identityInfo">刷脸用户的身份信息，目前返回为空.</param>
        /// <param name="materialInfo">认证主体附件信息，主要为图片类材料，一般的认证场景都是返回空.</param>
        /// <param name="passed">是否通过，通过为T，不通过为F.</param>
        public DatadigitalFincloudGeneralsaasFaceCertifyQueryResponseModel(string failReason = default(string), string identityInfo = default(string), string materialInfo = default(string), string passed = default(string))
        {
            this.FailReason = failReason;
            this.IdentityInfo = identityInfo;
            this.MaterialInfo = materialInfo;
            this.Passed = passed;
        }

        /// <summary>
        /// 认证错误原因，扩展字段，默认不返回
        /// </summary>
        /// <value>认证错误原因，扩展字段，默认不返回</value>
        [DataMember(Name = "fail_reason", EmitDefaultValue = false)]
        public string FailReason { get; set; }

        /// <summary>
        /// 刷脸用户的身份信息，目前返回为空
        /// </summary>
        /// <value>刷脸用户的身份信息，目前返回为空</value>
        [DataMember(Name = "identity_info", EmitDefaultValue = false)]
        public string IdentityInfo { get; set; }

        /// <summary>
        /// 认证主体附件信息，主要为图片类材料，一般的认证场景都是返回空
        /// </summary>
        /// <value>认证主体附件信息，主要为图片类材料，一般的认证场景都是返回空</value>
        [DataMember(Name = "material_info", EmitDefaultValue = false)]
        public string MaterialInfo { get; set; }

        /// <summary>
        /// 是否通过，通过为T，不通过为F
        /// </summary>
        /// <value>是否通过，通过为T，不通过为F</value>
        [DataMember(Name = "passed", EmitDefaultValue = false)]
        public string Passed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatadigitalFincloudGeneralsaasFaceCertifyQueryResponseModel {\n");
            sb.Append("  FailReason: ").Append(FailReason).Append("\n");
            sb.Append("  IdentityInfo: ").Append(IdentityInfo).Append("\n");
            sb.Append("  MaterialInfo: ").Append(MaterialInfo).Append("\n");
            sb.Append("  Passed: ").Append(Passed).Append("\n");
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
            return this.Equals(input as DatadigitalFincloudGeneralsaasFaceCertifyQueryResponseModel);
        }

        /// <summary>
        /// Returns true if DatadigitalFincloudGeneralsaasFaceCertifyQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DatadigitalFincloudGeneralsaasFaceCertifyQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatadigitalFincloudGeneralsaasFaceCertifyQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
                ) && 
                (
                    this.IdentityInfo == input.IdentityInfo ||
                    (this.IdentityInfo != null &&
                    this.IdentityInfo.Equals(input.IdentityInfo))
                ) && 
                (
                    this.MaterialInfo == input.MaterialInfo ||
                    (this.MaterialInfo != null &&
                    this.MaterialInfo.Equals(input.MaterialInfo))
                ) && 
                (
                    this.Passed == input.Passed ||
                    (this.Passed != null &&
                    this.Passed.Equals(input.Passed))
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
                if (this.FailReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailReason.GetHashCode();
                }
                if (this.IdentityInfo != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityInfo.GetHashCode();
                }
                if (this.MaterialInfo != null)
                {
                    hashCode = (hashCode * 59) + this.MaterialInfo.GetHashCode();
                }
                if (this.Passed != null)
                {
                    hashCode = (hashCode * 59) + this.Passed.GetHashCode();
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
