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
    /// AlipayOpenMiniExperienceQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniExperienceQueryResponseModel")]
    public partial class AlipayOpenMiniExperienceQueryResponseModel : IEquatable<AlipayOpenMiniExperienceQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniExperienceQueryResponseModel" /> class.
        /// </summary>
        /// <param name="expQrCodeUrl">小程序体验版二维码地址.</param>
        /// <param name="expSchemaUrl">体验版schema.</param>
        /// <param name="status">体验版打包状态。状态枚举如下： expVersionPackged：体验版打包成功； expVersionPackaging：体验版打包中； notExpVersion：非体验版。.</param>
        public AlipayOpenMiniExperienceQueryResponseModel(string expQrCodeUrl = default(string), string expSchemaUrl = default(string), string status = default(string))
        {
            this.ExpQrCodeUrl = expQrCodeUrl;
            this.ExpSchemaUrl = expSchemaUrl;
            this.Status = status;
        }

        /// <summary>
        /// 小程序体验版二维码地址
        /// </summary>
        /// <value>小程序体验版二维码地址</value>
        [DataMember(Name = "exp_qr_code_url", EmitDefaultValue = false)]
        public string ExpQrCodeUrl { get; set; }

        /// <summary>
        /// 体验版schema
        /// </summary>
        /// <value>体验版schema</value>
        [DataMember(Name = "exp_schema_url", EmitDefaultValue = false)]
        public string ExpSchemaUrl { get; set; }

        /// <summary>
        /// 体验版打包状态。状态枚举如下： expVersionPackged：体验版打包成功； expVersionPackaging：体验版打包中； notExpVersion：非体验版。
        /// </summary>
        /// <value>体验版打包状态。状态枚举如下： expVersionPackged：体验版打包成功； expVersionPackaging：体验版打包中； notExpVersion：非体验版。</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniExperienceQueryResponseModel {\n");
            sb.Append("  ExpQrCodeUrl: ").Append(ExpQrCodeUrl).Append("\n");
            sb.Append("  ExpSchemaUrl: ").Append(ExpSchemaUrl).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniExperienceQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniExperienceQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniExperienceQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniExperienceQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExpQrCodeUrl == input.ExpQrCodeUrl ||
                    (this.ExpQrCodeUrl != null &&
                    this.ExpQrCodeUrl.Equals(input.ExpQrCodeUrl))
                ) && 
                (
                    this.ExpSchemaUrl == input.ExpSchemaUrl ||
                    (this.ExpSchemaUrl != null &&
                    this.ExpSchemaUrl.Equals(input.ExpSchemaUrl))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ExpQrCodeUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ExpQrCodeUrl.GetHashCode();
                }
                if (this.ExpSchemaUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ExpSchemaUrl.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
