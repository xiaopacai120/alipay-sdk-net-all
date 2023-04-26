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
    /// KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel
    /// </summary>
    [DataContract(Name = "KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel")]
    public partial class KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel : IEquatable<KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel" /> class.
        /// </summary>
        /// <param name="pageNo">页码.</param>
        /// <param name="pageSize">每页显示内容数.</param>
        /// <param name="status">活动状态.</param>
        public KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel(int pageNo = default(int), int pageSize = default(int), string status = default(string))
        {
            this.PageNo = pageNo;
            this.PageSize = pageSize;
            this.Status = status;
        }

        /// <summary>
        /// 页码
        /// </summary>
        /// <value>页码</value>
        [DataMember(Name = "page_no", EmitDefaultValue = false)]
        public int PageNo { get; set; }

        /// <summary>
        /// 每页显示内容数
        /// </summary>
        /// <value>每页显示内容数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        /// <value>活动状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel {\n");
            sb.Append("  PageNo: ").Append(PageNo).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel);
        }

        /// <summary>
        /// Returns true if KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PageNo == input.PageNo ||
                    this.PageNo.Equals(input.PageNo)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                hashCode = (hashCode * 59) + this.PageNo.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
