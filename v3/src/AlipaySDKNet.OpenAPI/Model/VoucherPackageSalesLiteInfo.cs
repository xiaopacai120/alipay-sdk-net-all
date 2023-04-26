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
    /// VoucherPackageSalesLiteInfo
    /// </summary>
    [DataContract(Name = "VoucherPackageSalesLiteInfo")]
    public partial class VoucherPackageSalesLiteInfo : IEquatable<VoucherPackageSalesLiteInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherPackageSalesLiteInfo" /> class.
        /// </summary>
        /// <param name="budget">券包预算，单位是份数.</param>
        /// <param name="salePrice">券包售卖价格，单位是元.</param>
        public VoucherPackageSalesLiteInfo(int budget = default(int), string salePrice = default(string))
        {
            this.Budget = budget;
            this.SalePrice = salePrice;
        }

        /// <summary>
        /// 券包预算，单位是份数
        /// </summary>
        /// <value>券包预算，单位是份数</value>
        [DataMember(Name = "budget", EmitDefaultValue = false)]
        public int Budget { get; set; }

        /// <summary>
        /// 券包售卖价格，单位是元
        /// </summary>
        /// <value>券包售卖价格，单位是元</value>
        [DataMember(Name = "sale_price", EmitDefaultValue = false)]
        public string SalePrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherPackageSalesLiteInfo {\n");
            sb.Append("  Budget: ").Append(Budget).Append("\n");
            sb.Append("  SalePrice: ").Append(SalePrice).Append("\n");
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
            return this.Equals(input as VoucherPackageSalesLiteInfo);
        }

        /// <summary>
        /// Returns true if VoucherPackageSalesLiteInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherPackageSalesLiteInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherPackageSalesLiteInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Budget == input.Budget ||
                    this.Budget.Equals(input.Budget)
                ) && 
                (
                    this.SalePrice == input.SalePrice ||
                    (this.SalePrice != null &&
                    this.SalePrice.Equals(input.SalePrice))
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
                hashCode = (hashCode * 59) + this.Budget.GetHashCode();
                if (this.SalePrice != null)
                {
                    hashCode = (hashCode * 59) + this.SalePrice.GetHashCode();
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
