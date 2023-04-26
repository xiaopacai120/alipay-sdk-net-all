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
    /// AlipayMarketingMaterialImageUploadResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingMaterialImageUploadResponseModel")]
    public partial class AlipayMarketingMaterialImageUploadResponseModel : IEquatable<AlipayMarketingMaterialImageUploadResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingMaterialImageUploadResponseModel" /> class.
        /// </summary>
        /// <param name="resourceEnhance">图片是否优化过。系统会根据要求，若上传的图片不符合要求的尺寸，会对上传的图片做尺寸的优化。.</param>
        /// <param name="resourceId">图片唯一资源ID.</param>
        /// <param name="resourceUrl">上传后图片的url地址.</param>
        public AlipayMarketingMaterialImageUploadResponseModel(bool resourceEnhance = default(bool), string resourceId = default(string), string resourceUrl = default(string))
        {
            this.ResourceEnhance = resourceEnhance;
            this.ResourceId = resourceId;
            this.ResourceUrl = resourceUrl;
        }

        /// <summary>
        /// 图片是否优化过。系统会根据要求，若上传的图片不符合要求的尺寸，会对上传的图片做尺寸的优化。
        /// </summary>
        /// <value>图片是否优化过。系统会根据要求，若上传的图片不符合要求的尺寸，会对上传的图片做尺寸的优化。</value>
        [DataMember(Name = "resource_enhance", EmitDefaultValue = true)]
        public bool ResourceEnhance { get; set; }

        /// <summary>
        /// 图片唯一资源ID
        /// </summary>
        /// <value>图片唯一资源ID</value>
        [DataMember(Name = "resource_id", EmitDefaultValue = false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 上传后图片的url地址
        /// </summary>
        /// <value>上传后图片的url地址</value>
        [DataMember(Name = "resource_url", EmitDefaultValue = false)]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingMaterialImageUploadResponseModel {\n");
            sb.Append("  ResourceEnhance: ").Append(ResourceEnhance).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  ResourceUrl: ").Append(ResourceUrl).Append("\n");
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
            return this.Equals(input as AlipayMarketingMaterialImageUploadResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingMaterialImageUploadResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingMaterialImageUploadResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingMaterialImageUploadResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ResourceEnhance == input.ResourceEnhance ||
                    this.ResourceEnhance.Equals(input.ResourceEnhance)
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.ResourceUrl == input.ResourceUrl ||
                    (this.ResourceUrl != null &&
                    this.ResourceUrl.Equals(input.ResourceUrl))
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
                hashCode = (hashCode * 59) + this.ResourceEnhance.GetHashCode();
                if (this.ResourceId != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceId.GetHashCode();
                }
                if (this.ResourceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceUrl.GetHashCode();
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
