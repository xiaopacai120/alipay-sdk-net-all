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
    /// VoucherPackageInfo
    /// </summary>
    [DataContract(Name = "VoucherPackageInfo")]
    public partial class VoucherPackageInfo : IEquatable<VoucherPackageInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherPackageInfo" /> class.
        /// </summary>
        /// <param name="voucherPackageBaseInfo">voucherPackageBaseInfo.</param>
        /// <param name="voucherPackageSalesLiteInfo">voucherPackageSalesLiteInfo.</param>
        public VoucherPackageInfo(VoucherPackageBaseInfo voucherPackageBaseInfo = default(VoucherPackageBaseInfo), VoucherPackageSalesLiteInfo voucherPackageSalesLiteInfo = default(VoucherPackageSalesLiteInfo))
        {
            this.VoucherPackageBaseInfo = voucherPackageBaseInfo;
            this.VoucherPackageSalesLiteInfo = voucherPackageSalesLiteInfo;
        }

        /// <summary>
        /// Gets or Sets VoucherPackageBaseInfo
        /// </summary>
        [DataMember(Name = "voucher_package_base_info", EmitDefaultValue = false)]
        public VoucherPackageBaseInfo VoucherPackageBaseInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherPackageSalesLiteInfo
        /// </summary>
        [DataMember(Name = "voucher_package_sales_lite_info", EmitDefaultValue = false)]
        public VoucherPackageSalesLiteInfo VoucherPackageSalesLiteInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherPackageInfo {\n");
            sb.Append("  VoucherPackageBaseInfo: ").Append(VoucherPackageBaseInfo).Append("\n");
            sb.Append("  VoucherPackageSalesLiteInfo: ").Append(VoucherPackageSalesLiteInfo).Append("\n");
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
            return this.Equals(input as VoucherPackageInfo);
        }

        /// <summary>
        /// Returns true if VoucherPackageInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherPackageInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherPackageInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VoucherPackageBaseInfo == input.VoucherPackageBaseInfo ||
                    (this.VoucherPackageBaseInfo != null &&
                    this.VoucherPackageBaseInfo.Equals(input.VoucherPackageBaseInfo))
                ) && 
                (
                    this.VoucherPackageSalesLiteInfo == input.VoucherPackageSalesLiteInfo ||
                    (this.VoucherPackageSalesLiteInfo != null &&
                    this.VoucherPackageSalesLiteInfo.Equals(input.VoucherPackageSalesLiteInfo))
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
                if (this.VoucherPackageBaseInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherPackageBaseInfo.GetHashCode();
                }
                if (this.VoucherPackageSalesLiteInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherPackageSalesLiteInfo.GetHashCode();
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
