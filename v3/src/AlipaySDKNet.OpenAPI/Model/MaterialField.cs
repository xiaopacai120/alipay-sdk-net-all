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
    /// MaterialField
    /// </summary>
    [DataContract(Name = "MaterialField")]
    public partial class MaterialField : IEquatable<MaterialField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialField" /> class.
        /// </summary>
        /// <param name="fieldName">素材字段名称，来源于素材规范定义的字段名称。注意一次素材提报中字段名称不能重复。.</param>
        /// <param name="fieldValue">素材字段值，素材字段提报的实际值，支持多值，具体的要求请查看素材规范或对应的产品文档。.</param>
        public MaterialField(string fieldName = default(string), List<string> fieldValue = default(List<string>))
        {
            this.FieldName = fieldName;
            this.FieldValue = fieldValue;
        }

        /// <summary>
        /// 素材字段名称，来源于素材规范定义的字段名称。注意一次素材提报中字段名称不能重复。
        /// </summary>
        /// <value>素材字段名称，来源于素材规范定义的字段名称。注意一次素材提报中字段名称不能重复。</value>
        [DataMember(Name = "field_name", EmitDefaultValue = false)]
        public string FieldName { get; set; }

        /// <summary>
        /// 素材字段值，素材字段提报的实际值，支持多值，具体的要求请查看素材规范或对应的产品文档。
        /// </summary>
        /// <value>素材字段值，素材字段提报的实际值，支持多值，具体的要求请查看素材规范或对应的产品文档。</value>
        [DataMember(Name = "field_value", EmitDefaultValue = false)]
        public List<string> FieldValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MaterialField {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  FieldValue: ").Append(FieldValue).Append("\n");
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
            return this.Equals(input as MaterialField);
        }

        /// <summary>
        /// Returns true if MaterialField instances are equal
        /// </summary>
        /// <param name="input">Instance of MaterialField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaterialField input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.FieldValue == input.FieldValue ||
                    this.FieldValue != null &&
                    input.FieldValue != null &&
                    this.FieldValue.SequenceEqual(input.FieldValue)
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
                if (this.FieldName != null)
                {
                    hashCode = (hashCode * 59) + this.FieldName.GetHashCode();
                }
                if (this.FieldValue != null)
                {
                    hashCode = (hashCode * 59) + this.FieldValue.GetHashCode();
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
