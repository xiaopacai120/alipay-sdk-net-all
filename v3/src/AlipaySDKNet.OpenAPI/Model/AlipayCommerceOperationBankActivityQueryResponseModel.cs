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
    /// AlipayCommerceOperationBankActivityQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceOperationBankActivityQueryResponseModel")]
    public partial class AlipayCommerceOperationBankActivityQueryResponseModel : IEquatable<AlipayCommerceOperationBankActivityQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceOperationBankActivityQueryResponseModel" /> class.
        /// </summary>
        /// <param name="activityInfoList">活动信息列表.</param>
        /// <param name="merchantTag">商户标签.</param>
        public AlipayCommerceOperationBankActivityQueryResponseModel(List<BankActivityInfo> activityInfoList = default(List<BankActivityInfo>), string merchantTag = default(string))
        {
            this.ActivityInfoList = activityInfoList;
            this.MerchantTag = merchantTag;
        }

        /// <summary>
        /// 活动信息列表
        /// </summary>
        /// <value>活动信息列表</value>
        [DataMember(Name = "activity_info_list", EmitDefaultValue = false)]
        public List<BankActivityInfo> ActivityInfoList { get; set; }

        /// <summary>
        /// 商户标签
        /// </summary>
        /// <value>商户标签</value>
        [DataMember(Name = "merchant_tag", EmitDefaultValue = false)]
        public string MerchantTag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceOperationBankActivityQueryResponseModel {\n");
            sb.Append("  ActivityInfoList: ").Append(ActivityInfoList).Append("\n");
            sb.Append("  MerchantTag: ").Append(MerchantTag).Append("\n");
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
            return this.Equals(input as AlipayCommerceOperationBankActivityQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceOperationBankActivityQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceOperationBankActivityQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceOperationBankActivityQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityInfoList == input.ActivityInfoList ||
                    this.ActivityInfoList != null &&
                    input.ActivityInfoList != null &&
                    this.ActivityInfoList.SequenceEqual(input.ActivityInfoList)
                ) && 
                (
                    this.MerchantTag == input.MerchantTag ||
                    (this.MerchantTag != null &&
                    this.MerchantTag.Equals(input.MerchantTag))
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
                if (this.ActivityInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityInfoList.GetHashCode();
                }
                if (this.MerchantTag != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantTag.GetHashCode();
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
