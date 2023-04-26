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
    /// AlipayFundEnterprisepayUnsignResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundEnterprisepayUnsignResponseModel")]
    public partial class AlipayFundEnterprisepayUnsignResponseModel : IEquatable<AlipayFundEnterprisepayUnsignResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundEnterprisepayUnsignResponseModel" /> class.
        /// </summary>
        /// <param name="unsignToken">解约凭证.</param>
        /// <param name="unsignUrl">解约链接.</param>
        public AlipayFundEnterprisepayUnsignResponseModel(string unsignToken = default(string), string unsignUrl = default(string))
        {
            this.UnsignToken = unsignToken;
            this.UnsignUrl = unsignUrl;
        }

        /// <summary>
        /// 解约凭证
        /// </summary>
        /// <value>解约凭证</value>
        [DataMember(Name = "unsign_token", EmitDefaultValue = false)]
        public string UnsignToken { get; set; }

        /// <summary>
        /// 解约链接
        /// </summary>
        /// <value>解约链接</value>
        [DataMember(Name = "unsign_url", EmitDefaultValue = false)]
        public string UnsignUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundEnterprisepayUnsignResponseModel {\n");
            sb.Append("  UnsignToken: ").Append(UnsignToken).Append("\n");
            sb.Append("  UnsignUrl: ").Append(UnsignUrl).Append("\n");
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
            return this.Equals(input as AlipayFundEnterprisepayUnsignResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundEnterprisepayUnsignResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundEnterprisepayUnsignResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundEnterprisepayUnsignResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UnsignToken == input.UnsignToken ||
                    (this.UnsignToken != null &&
                    this.UnsignToken.Equals(input.UnsignToken))
                ) && 
                (
                    this.UnsignUrl == input.UnsignUrl ||
                    (this.UnsignUrl != null &&
                    this.UnsignUrl.Equals(input.UnsignUrl))
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
                if (this.UnsignToken != null)
                {
                    hashCode = (hashCode * 59) + this.UnsignToken.GetHashCode();
                }
                if (this.UnsignUrl != null)
                {
                    hashCode = (hashCode * 59) + this.UnsignUrl.GetHashCode();
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
