/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-07-17
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
    /// AlipayOpenOperationOpenbizmockTestpathkeyQueryRequest
    /// </summary>
    [DataContract(Name = "alipay_open_operation_openbizmock_testpathkey_query_request")]
    public partial class AlipayOpenOperationOpenbizmockTestpathkeyQueryRequest : IEquatable<AlipayOpenOperationOpenbizmockTestpathkeyQueryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenOperationOpenbizmockTestpathkeyQueryRequest" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="f">f.</param>
        public AlipayOpenOperationOpenbizmockTestpathkeyQueryRequest(AlipayOpenOperationOpenbizmockTestpathkeyQueryModel data = default(AlipayOpenOperationOpenbizmockTestpathkeyQueryModel), System.IO.Stream f = default(System.IO.Stream))
        {
            this.Data = data;
            this.F = f;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public AlipayOpenOperationOpenbizmockTestpathkeyQueryModel Data { get; set; }

        /// <summary>
        /// Gets or Sets F
        /// </summary>
        [DataMember(Name = "f", EmitDefaultValue = false)]
        public System.IO.Stream F { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenOperationOpenbizmockTestpathkeyQueryRequest {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  F: ").Append(F).Append("\n");
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
            return this.Equals(input as AlipayOpenOperationOpenbizmockTestpathkeyQueryRequest);
        }

        /// <summary>
        /// Returns true if AlipayOpenOperationOpenbizmockTestpathkeyQueryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenOperationOpenbizmockTestpathkeyQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenOperationOpenbizmockTestpathkeyQueryRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.F == input.F ||
                    (this.F != null &&
                    this.F.Equals(input.F))
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.F != null)
                {
                    hashCode = (hashCode * 59) + this.F.GetHashCode();
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
