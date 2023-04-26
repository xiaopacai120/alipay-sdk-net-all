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
    /// AuthorizeDetailDTO
    /// </summary>
    [DataContract(Name = "AuthorizeDetailDTO")]
    public partial class AuthorizeDetailDTO : IEquatable<AuthorizeDetailDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeDetailDTO" /> class.
        /// </summary>
        /// <param name="authorizedPrincipalId">收单主体PID.</param>
        public AuthorizeDetailDTO(string authorizedPrincipalId = default(string))
        {
            this.AuthorizedPrincipalId = authorizedPrincipalId;
        }

        /// <summary>
        /// 收单主体PID
        /// </summary>
        /// <value>收单主体PID</value>
        [DataMember(Name = "authorized_principal_id", EmitDefaultValue = false)]
        public string AuthorizedPrincipalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorizeDetailDTO {\n");
            sb.Append("  AuthorizedPrincipalId: ").Append(AuthorizedPrincipalId).Append("\n");
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
            return this.Equals(input as AuthorizeDetailDTO);
        }

        /// <summary>
        /// Returns true if AuthorizeDetailDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizeDetailDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizeDetailDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthorizedPrincipalId == input.AuthorizedPrincipalId ||
                    (this.AuthorizedPrincipalId != null &&
                    this.AuthorizedPrincipalId.Equals(input.AuthorizedPrincipalId))
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
                if (this.AuthorizedPrincipalId != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorizedPrincipalId.GetHashCode();
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
