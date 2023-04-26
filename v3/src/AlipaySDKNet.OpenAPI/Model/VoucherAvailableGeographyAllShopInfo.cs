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
    /// VoucherAvailableGeographyAllShopInfo
    /// </summary>
    [DataContract(Name = "VoucherAvailableGeographyAllShopInfo")]
    public partial class VoucherAvailableGeographyAllShopInfo : IEquatable<VoucherAvailableGeographyAllShopInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherAvailableGeographyAllShopInfo" /> class.
        /// </summary>
        /// <param name="excludeShopIds">券不可使用的门店列表。指定商户全部门店可用时可通过该字段排除部分不可用门店。 列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id 接口参数是列表类型。.</param>
        /// <param name="merchantIds">全部门店可用的商户ID.</param>
        public VoucherAvailableGeographyAllShopInfo(List<string> excludeShopIds = default(List<string>), List<string> merchantIds = default(List<string>))
        {
            this.ExcludeShopIds = excludeShopIds;
            this.MerchantIds = merchantIds;
        }

        /// <summary>
        /// 券不可使用的门店列表。指定商户全部门店可用时可通过该字段排除部分不可用门店。 列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id 接口参数是列表类型。
        /// </summary>
        /// <value>券不可使用的门店列表。指定商户全部门店可用时可通过该字段排除部分不可用门店。 列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id 接口参数是列表类型。</value>
        [DataMember(Name = "exclude_shop_ids", EmitDefaultValue = false)]
        public List<string> ExcludeShopIds { get; set; }

        /// <summary>
        /// 全部门店可用的商户ID
        /// </summary>
        /// <value>全部门店可用的商户ID</value>
        [DataMember(Name = "merchant_ids", EmitDefaultValue = false)]
        public List<string> MerchantIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherAvailableGeographyAllShopInfo {\n");
            sb.Append("  ExcludeShopIds: ").Append(ExcludeShopIds).Append("\n");
            sb.Append("  MerchantIds: ").Append(MerchantIds).Append("\n");
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
            return this.Equals(input as VoucherAvailableGeographyAllShopInfo);
        }

        /// <summary>
        /// Returns true if VoucherAvailableGeographyAllShopInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherAvailableGeographyAllShopInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherAvailableGeographyAllShopInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExcludeShopIds == input.ExcludeShopIds ||
                    this.ExcludeShopIds != null &&
                    input.ExcludeShopIds != null &&
                    this.ExcludeShopIds.SequenceEqual(input.ExcludeShopIds)
                ) && 
                (
                    this.MerchantIds == input.MerchantIds ||
                    this.MerchantIds != null &&
                    input.MerchantIds != null &&
                    this.MerchantIds.SequenceEqual(input.MerchantIds)
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
                if (this.ExcludeShopIds != null)
                {
                    hashCode = (hashCode * 59) + this.ExcludeShopIds.GetHashCode();
                }
                if (this.MerchantIds != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantIds.GetHashCode();
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
