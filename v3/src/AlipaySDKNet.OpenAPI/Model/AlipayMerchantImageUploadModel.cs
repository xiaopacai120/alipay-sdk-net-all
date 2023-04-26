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
    /// AlipayMerchantImageUploadModel
    /// </summary>
    [DataContract(Name = "AlipayMerchantImageUploadModel")]
    public partial class AlipayMerchantImageUploadModel : IEquatable<AlipayMerchantImageUploadModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantImageUploadModel" /> class.
        /// </summary>
        /// <param name="imageType">图片格式，支持格式：jpg、jpeg、png.</param>
        public AlipayMerchantImageUploadModel(string imageType = default(string))
        {
            this.ImageType = imageType;
        }

        /// <summary>
        /// 图片格式，支持格式：jpg、jpeg、png
        /// </summary>
        /// <value>图片格式，支持格式：jpg、jpeg、png</value>
        [DataMember(Name = "image_type", EmitDefaultValue = false)]
        public string ImageType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMerchantImageUploadModel {\n");
            sb.Append("  ImageType: ").Append(ImageType).Append("\n");
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
            return this.Equals(input as AlipayMerchantImageUploadModel);
        }

        /// <summary>
        /// Returns true if AlipayMerchantImageUploadModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantImageUploadModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantImageUploadModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ImageType == input.ImageType ||
                    (this.ImageType != null &&
                    this.ImageType.Equals(input.ImageType))
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
                if (this.ImageType != null)
                {
                    hashCode = (hashCode * 59) + this.ImageType.GetHashCode();
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
