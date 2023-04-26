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
    /// Marketingtest
    /// </summary>
    [DataContract(Name = "Marketingtest")]
    public partial class Marketingtest : IEquatable<Marketingtest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Marketingtest" /> class.
        /// </summary>
        /// <param name="test21">测试描述.</param>
        public Marketingtest(string test21 = default(string))
        {
            this.Test21 = test21;
        }

        /// <summary>
        /// 测试描述
        /// </summary>
        /// <value>测试描述</value>
        [DataMember(Name = "test_21", EmitDefaultValue = false)]
        public string Test21 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Marketingtest {\n");
            sb.Append("  Test21: ").Append(Test21).Append("\n");
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
            return this.Equals(input as Marketingtest);
        }

        /// <summary>
        /// Returns true if Marketingtest instances are equal
        /// </summary>
        /// <param name="input">Instance of Marketingtest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Marketingtest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Test21 == input.Test21 ||
                    (this.Test21 != null &&
                    this.Test21.Equals(input.Test21))
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
                if (this.Test21 != null)
                {
                    hashCode = (hashCode * 59) + this.Test21.GetHashCode();
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
