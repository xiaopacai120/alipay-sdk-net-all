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
    /// VoucherAvailableGeographyScopeResultInfo
    /// </summary>
    [DataContract(Name = "VoucherAvailableGeographyScopeResultInfo")]
    public partial class VoucherAvailableGeographyScopeResultInfo : IEquatable<VoucherAvailableGeographyScopeResultInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherAvailableGeographyScopeResultInfo" /> class.
        /// </summary>
        /// <param name="availableGeographyShopResultInfo">availableGeographyShopResultInfo.</param>
        public VoucherAvailableGeographyScopeResultInfo(VoucherAvailableGeographyShopResultInfo availableGeographyShopResultInfo = default(VoucherAvailableGeographyShopResultInfo))
        {
            this.AvailableGeographyShopResultInfo = availableGeographyShopResultInfo;
        }

        /// <summary>
        /// Gets or Sets AvailableGeographyShopResultInfo
        /// </summary>
        [DataMember(Name = "available_geography_shop_result_info", EmitDefaultValue = false)]
        public VoucherAvailableGeographyShopResultInfo AvailableGeographyShopResultInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherAvailableGeographyScopeResultInfo {\n");
            sb.Append("  AvailableGeographyShopResultInfo: ").Append(AvailableGeographyShopResultInfo).Append("\n");
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
            return this.Equals(input as VoucherAvailableGeographyScopeResultInfo);
        }

        /// <summary>
        /// Returns true if VoucherAvailableGeographyScopeResultInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherAvailableGeographyScopeResultInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherAvailableGeographyScopeResultInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvailableGeographyShopResultInfo == input.AvailableGeographyShopResultInfo ||
                    (this.AvailableGeographyShopResultInfo != null &&
                    this.AvailableGeographyShopResultInfo.Equals(input.AvailableGeographyShopResultInfo))
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
                if (this.AvailableGeographyShopResultInfo != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableGeographyShopResultInfo.GetHashCode();
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
