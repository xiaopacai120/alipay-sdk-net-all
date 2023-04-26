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
    /// ZhubUidTelPair
    /// </summary>
    [DataContract(Name = "ZhubUidTelPair")]
    public partial class ZhubUidTelPair : IEquatable<ZhubUidTelPair>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhubUidTelPair" /> class.
        /// </summary>
        /// <param name="openId">支付宝用户open_id.</param>
        /// <param name="phone">手机号.</param>
        /// <param name="userId">支付宝uid.</param>
        public ZhubUidTelPair(string openId = default(string), string phone = default(string), string userId = default(string))
        {
            this.OpenId = openId;
            this.Phone = phone;
            this.UserId = userId;
        }

        /// <summary>
        /// 支付宝用户open_id
        /// </summary>
        /// <value>支付宝用户open_id</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        /// <value>手机号</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        /// <value>支付宝uid</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhubUidTelPair {\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as ZhubUidTelPair);
        }

        /// <summary>
        /// Returns true if ZhubUidTelPair instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhubUidTelPair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhubUidTelPair input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
