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
    /// AlipayCommerceEcBalanceDownloadurlQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcBalanceDownloadurlQueryResponseModel")]
    public partial class AlipayCommerceEcBalanceDownloadurlQueryResponseModel : IEquatable<AlipayCommerceEcBalanceDownloadurlQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcBalanceDownloadurlQueryResponseModel" /> class.
        /// </summary>
        /// <param name="billDownloadUrl">对账单下载地址链接，获取连接后3分钟后未下载，链接地址失效。.</param>
        public AlipayCommerceEcBalanceDownloadurlQueryResponseModel(string billDownloadUrl = default(string))
        {
            this.BillDownloadUrl = billDownloadUrl;
        }

        /// <summary>
        /// 对账单下载地址链接，获取连接后3分钟后未下载，链接地址失效。
        /// </summary>
        /// <value>对账单下载地址链接，获取连接后3分钟后未下载，链接地址失效。</value>
        [DataMember(Name = "bill_download_url", EmitDefaultValue = false)]
        public string BillDownloadUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcBalanceDownloadurlQueryResponseModel {\n");
            sb.Append("  BillDownloadUrl: ").Append(BillDownloadUrl).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcBalanceDownloadurlQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcBalanceDownloadurlQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcBalanceDownloadurlQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcBalanceDownloadurlQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BillDownloadUrl == input.BillDownloadUrl ||
                    (this.BillDownloadUrl != null &&
                    this.BillDownloadUrl.Equals(input.BillDownloadUrl))
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
                if (this.BillDownloadUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BillDownloadUrl.GetHashCode();
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
