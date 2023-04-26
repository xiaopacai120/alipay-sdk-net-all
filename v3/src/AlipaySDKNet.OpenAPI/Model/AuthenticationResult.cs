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
    /// AuthenticationResult
    /// </summary>
    [DataContract(Name = "AuthenticationResult")]
    public partial class AuthenticationResult : IEquatable<AuthenticationResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationResult" /> class.
        /// </summary>
        /// <param name="authenticationData">已加密的鉴权数据.</param>
        /// <param name="authenticationMechanism">鉴权类型，如：支付密码、数字签名.</param>
        public AuthenticationResult(string authenticationData = default(string), string authenticationMechanism = default(string))
        {
            this.AuthenticationData = authenticationData;
            this.AuthenticationMechanism = authenticationMechanism;
        }

        /// <summary>
        /// 已加密的鉴权数据
        /// </summary>
        /// <value>已加密的鉴权数据</value>
        [DataMember(Name = "authentication_data", EmitDefaultValue = false)]
        public string AuthenticationData { get; set; }

        /// <summary>
        /// 鉴权类型，如：支付密码、数字签名
        /// </summary>
        /// <value>鉴权类型，如：支付密码、数字签名</value>
        [DataMember(Name = "authentication_mechanism", EmitDefaultValue = false)]
        public string AuthenticationMechanism { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthenticationResult {\n");
            sb.Append("  AuthenticationData: ").Append(AuthenticationData).Append("\n");
            sb.Append("  AuthenticationMechanism: ").Append(AuthenticationMechanism).Append("\n");
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
            return this.Equals(input as AuthenticationResult);
        }

        /// <summary>
        /// Returns true if AuthenticationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthenticationData == input.AuthenticationData ||
                    (this.AuthenticationData != null &&
                    this.AuthenticationData.Equals(input.AuthenticationData))
                ) && 
                (
                    this.AuthenticationMechanism == input.AuthenticationMechanism ||
                    (this.AuthenticationMechanism != null &&
                    this.AuthenticationMechanism.Equals(input.AuthenticationMechanism))
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
                if (this.AuthenticationData != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationData.GetHashCode();
                }
                if (this.AuthenticationMechanism != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationMechanism.GetHashCode();
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
