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
    /// InteligentDelayInfo
    /// </summary>
    [DataContract(Name = "InteligentDelayInfo")]
    public partial class InteligentDelayInfo : IEquatable<InteligentDelayInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteligentDelayInfo" /> class.
        /// </summary>
        /// <param name="type">延迟类型，目前支持以下类型  ABSOLUTELY：按绝对值延迟  BYDAY：按天延迟.</param>
        /// <param name="value">延迟值，单位分钟  按绝对值延迟延迟24*60 (1天)表示，当日08:00:00领到的券要到隔日的08:00:00才能使用  按天延迟延迟24*60(1天)表示，当日08:00:00领到的券，隔日00:00:00点就可以用.</param>
        public InteligentDelayInfo(string type = default(string), string value = default(string))
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// 延迟类型，目前支持以下类型  ABSOLUTELY：按绝对值延迟  BYDAY：按天延迟
        /// </summary>
        /// <value>延迟类型，目前支持以下类型  ABSOLUTELY：按绝对值延迟  BYDAY：按天延迟</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// 延迟值，单位分钟  按绝对值延迟延迟24*60 (1天)表示，当日08:00:00领到的券要到隔日的08:00:00才能使用  按天延迟延迟24*60(1天)表示，当日08:00:00领到的券，隔日00:00:00点就可以用
        /// </summary>
        /// <value>延迟值，单位分钟  按绝对值延迟延迟24*60 (1天)表示，当日08:00:00领到的券要到隔日的08:00:00才能使用  按天延迟延迟24*60(1天)表示，当日08:00:00领到的券，隔日00:00:00点就可以用</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InteligentDelayInfo {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as InteligentDelayInfo);
        }

        /// <summary>
        /// Returns true if InteligentDelayInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of InteligentDelayInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteligentDelayInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
