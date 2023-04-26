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
    /// CloudResumeHeadPic
    /// </summary>
    [DataContract(Name = "CloudResumeHeadPic")]
    public partial class CloudResumeHeadPic : IEquatable<CloudResumeHeadPic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudResumeHeadPic" /> class.
        /// </summary>
        /// <param name="picUrl">头像连接url.</param>
        public CloudResumeHeadPic(string picUrl = default(string))
        {
            this.PicUrl = picUrl;
        }

        /// <summary>
        /// 头像连接url
        /// </summary>
        /// <value>头像连接url</value>
        [DataMember(Name = "pic_url", EmitDefaultValue = false)]
        public string PicUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CloudResumeHeadPic {\n");
            sb.Append("  PicUrl: ").Append(PicUrl).Append("\n");
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
            return this.Equals(input as CloudResumeHeadPic);
        }

        /// <summary>
        /// Returns true if CloudResumeHeadPic instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudResumeHeadPic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudResumeHeadPic input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PicUrl == input.PicUrl ||
                    (this.PicUrl != null &&
                    this.PicUrl.Equals(input.PicUrl))
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
                if (this.PicUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PicUrl.GetHashCode();
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
