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
    /// AlipayOpenAppApiQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAppApiQueryResponseModel")]
    public partial class AlipayOpenAppApiQueryResponseModel : IEquatable<AlipayOpenAppApiQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAppApiQueryResponseModel" /> class.
        /// </summary>
        /// <param name="apis">应用可申请的接口出参敏感字段列表.</param>
        public AlipayOpenAppApiQueryResponseModel(List<AuthApiDTO> apis = default(List<AuthApiDTO>))
        {
            this.Apis = apis;
        }

        /// <summary>
        /// 应用可申请的接口出参敏感字段列表
        /// </summary>
        /// <value>应用可申请的接口出参敏感字段列表</value>
        [DataMember(Name = "apis", EmitDefaultValue = false)]
        public List<AuthApiDTO> Apis { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAppApiQueryResponseModel {\n");
            sb.Append("  Apis: ").Append(Apis).Append("\n");
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
            return this.Equals(input as AlipayOpenAppApiQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAppApiQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAppApiQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAppApiQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Apis == input.Apis ||
                    this.Apis != null &&
                    input.Apis != null &&
                    this.Apis.SequenceEqual(input.Apis)
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
                if (this.Apis != null)
                {
                    hashCode = (hashCode * 59) + this.Apis.GetHashCode();
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
