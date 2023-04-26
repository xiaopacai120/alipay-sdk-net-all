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
    /// AlipayOpenPublicMessageContentModifyResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicMessageContentModifyResponseModel")]
    public partial class AlipayOpenPublicMessageContentModifyResponseModel : IEquatable<AlipayOpenPublicMessageContentModifyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMessageContentModifyResponseModel" /> class.
        /// </summary>
        /// <param name="contentId">内容id.</param>
        /// <param name="contentUrl">内容详情内链url.</param>
        public AlipayOpenPublicMessageContentModifyResponseModel(string contentId = default(string), string contentUrl = default(string))
        {
            this.ContentId = contentId;
            this.ContentUrl = contentUrl;
        }

        /// <summary>
        /// 内容id
        /// </summary>
        /// <value>内容id</value>
        [DataMember(Name = "content_id", EmitDefaultValue = false)]
        public string ContentId { get; set; }

        /// <summary>
        /// 内容详情内链url
        /// </summary>
        /// <value>内容详情内链url</value>
        [DataMember(Name = "content_url", EmitDefaultValue = false)]
        public string ContentUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicMessageContentModifyResponseModel {\n");
            sb.Append("  ContentId: ").Append(ContentId).Append("\n");
            sb.Append("  ContentUrl: ").Append(ContentUrl).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicMessageContentModifyResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicMessageContentModifyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicMessageContentModifyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicMessageContentModifyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContentId == input.ContentId ||
                    (this.ContentId != null &&
                    this.ContentId.Equals(input.ContentId))
                ) && 
                (
                    this.ContentUrl == input.ContentUrl ||
                    (this.ContentUrl != null &&
                    this.ContentUrl.Equals(input.ContentUrl))
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
                if (this.ContentId != null)
                {
                    hashCode = (hashCode * 59) + this.ContentId.GetHashCode();
                }
                if (this.ContentUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ContentUrl.GetHashCode();
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
