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
    /// SearchBaseItems
    /// </summary>
    [DataContract(Name = "SearchBaseItems")]
    public partial class SearchBaseItems : IEquatable<SearchBaseItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchBaseItems" /> class.
        /// </summary>
        /// <param name="canSearch">搜索可见性.</param>
        /// <param name="keyWords">提报关键词列表.</param>
        public SearchBaseItems(bool canSearch = default(bool), List<string> keyWords = default(List<string>))
        {
            this.CanSearch = canSearch;
            this.KeyWords = keyWords;
        }

        /// <summary>
        /// 搜索可见性
        /// </summary>
        /// <value>搜索可见性</value>
        [DataMember(Name = "can_search", EmitDefaultValue = true)]
        public bool CanSearch { get; set; }

        /// <summary>
        /// 提报关键词列表
        /// </summary>
        /// <value>提报关键词列表</value>
        [DataMember(Name = "key_words", EmitDefaultValue = false)]
        public List<string> KeyWords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchBaseItems {\n");
            sb.Append("  CanSearch: ").Append(CanSearch).Append("\n");
            sb.Append("  KeyWords: ").Append(KeyWords).Append("\n");
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
            return this.Equals(input as SearchBaseItems);
        }

        /// <summary>
        /// Returns true if SearchBaseItems instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchBaseItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchBaseItems input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CanSearch == input.CanSearch ||
                    this.CanSearch.Equals(input.CanSearch)
                ) && 
                (
                    this.KeyWords == input.KeyWords ||
                    this.KeyWords != null &&
                    input.KeyWords != null &&
                    this.KeyWords.SequenceEqual(input.KeyWords)
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
                hashCode = (hashCode * 59) + this.CanSearch.GetHashCode();
                if (this.KeyWords != null)
                {
                    hashCode = (hashCode * 59) + this.KeyWords.GetHashCode();
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
