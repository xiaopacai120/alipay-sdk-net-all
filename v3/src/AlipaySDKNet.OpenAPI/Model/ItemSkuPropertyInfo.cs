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
    /// ItemSkuPropertyInfo
    /// </summary>
    [DataContract(Name = "ItemSkuPropertyInfo")]
    public partial class ItemSkuPropertyInfo : IEquatable<ItemSkuPropertyInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSkuPropertyInfo" /> class.
        /// </summary>
        /// <param name="propertyKey">属性.</param>
        /// <param name="propertyValue">属性值.</param>
        public ItemSkuPropertyInfo(string propertyKey = default(string), string propertyValue = default(string))
        {
            this.PropertyKey = propertyKey;
            this.PropertyValue = propertyValue;
        }

        /// <summary>
        /// 属性
        /// </summary>
        /// <value>属性</value>
        [DataMember(Name = "property_key", EmitDefaultValue = false)]
        public string PropertyKey { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        /// <value>属性值</value>
        [DataMember(Name = "property_value", EmitDefaultValue = false)]
        public string PropertyValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemSkuPropertyInfo {\n");
            sb.Append("  PropertyKey: ").Append(PropertyKey).Append("\n");
            sb.Append("  PropertyValue: ").Append(PropertyValue).Append("\n");
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
            return this.Equals(input as ItemSkuPropertyInfo);
        }

        /// <summary>
        /// Returns true if ItemSkuPropertyInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemSkuPropertyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemSkuPropertyInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PropertyKey == input.PropertyKey ||
                    (this.PropertyKey != null &&
                    this.PropertyKey.Equals(input.PropertyKey))
                ) && 
                (
                    this.PropertyValue == input.PropertyValue ||
                    (this.PropertyValue != null &&
                    this.PropertyValue.Equals(input.PropertyValue))
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
                if (this.PropertyKey != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyKey.GetHashCode();
                }
                if (this.PropertyValue != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyValue.GetHashCode();
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
