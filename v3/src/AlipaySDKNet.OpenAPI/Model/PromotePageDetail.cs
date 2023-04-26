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
    /// PromotePageDetail
    /// </summary>
    [DataContract(Name = "PromotePageDetail")]
    public partial class PromotePageDetail : IEquatable<PromotePageDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromotePageDetail" /> class.
        /// </summary>
        /// <param name="gmtCreate">推广页创建时间，格式：yyyy-mm-dd hh:mm:ss.</param>
        /// <param name="id">推广页id.</param>
        /// <param name="name">推广页名称.</param>
        /// <param name="propertyList">推广留资schema.</param>
        /// <param name="type">推广页类型：COLLECT_INFO -  普通留资；TRADE - 交易留资.</param>
        public PromotePageDetail(string gmtCreate = default(string), int id = default(int), string name = default(string), List<PromotePageProperty> propertyList = default(List<PromotePageProperty>), string type = default(string))
        {
            this.GmtCreate = gmtCreate;
            this.Id = id;
            this.Name = name;
            this.PropertyList = propertyList;
            this.Type = type;
        }

        /// <summary>
        /// 推广页创建时间，格式：yyyy-mm-dd hh:mm:ss
        /// </summary>
        /// <value>推广页创建时间，格式：yyyy-mm-dd hh:mm:ss</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 推广页id
        /// </summary>
        /// <value>推广页id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// 推广页名称
        /// </summary>
        /// <value>推广页名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 推广留资schema
        /// </summary>
        /// <value>推广留资schema</value>
        [DataMember(Name = "property_list", EmitDefaultValue = false)]
        public List<PromotePageProperty> PropertyList { get; set; }

        /// <summary>
        /// 推广页类型：COLLECT_INFO -  普通留资；TRADE - 交易留资
        /// </summary>
        /// <value>推广页类型：COLLECT_INFO -  普通留资；TRADE - 交易留资</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PromotePageDetail {\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PropertyList: ").Append(PropertyList).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as PromotePageDetail);
        }

        /// <summary>
        /// Returns true if PromotePageDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of PromotePageDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromotePageDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PropertyList == input.PropertyList ||
                    this.PropertyList != null &&
                    input.PropertyList != null &&
                    this.PropertyList.SequenceEqual(input.PropertyList)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PropertyList != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyList.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
