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
    /// KoubeiMarketingCampaignIntelligentPromoBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "KoubeiMarketingCampaignIntelligentPromoBatchqueryResponseModel")]
    public partial class KoubeiMarketingCampaignIntelligentPromoBatchqueryResponseModel : IEquatable<KoubeiMarketingCampaignIntelligentPromoBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KoubeiMarketingCampaignIntelligentPromoBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="intelligentPromos">查询返回的营销活动列表信息.</param>
        /// <param name="pageResult">pageResult.</param>
        public KoubeiMarketingCampaignIntelligentPromoBatchqueryResponseModel(List<IntelligentPromo> intelligentPromos = default(List<IntelligentPromo>), PromoPageResult pageResult = default(PromoPageResult))
        {
            this.IntelligentPromos = intelligentPromos;
            this.PageResult = pageResult;
        }

        /// <summary>
        /// 查询返回的营销活动列表信息
        /// </summary>
        /// <value>查询返回的营销活动列表信息</value>
        [DataMember(Name = "intelligent_promos", EmitDefaultValue = false)]
        public List<IntelligentPromo> IntelligentPromos { get; set; }

        /// <summary>
        /// Gets or Sets PageResult
        /// </summary>
        [DataMember(Name = "page_result", EmitDefaultValue = false)]
        public PromoPageResult PageResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KoubeiMarketingCampaignIntelligentPromoBatchqueryResponseModel {\n");
            sb.Append("  IntelligentPromos: ").Append(IntelligentPromos).Append("\n");
            sb.Append("  PageResult: ").Append(PageResult).Append("\n");
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
            return this.Equals(input as KoubeiMarketingCampaignIntelligentPromoBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if KoubeiMarketingCampaignIntelligentPromoBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of KoubeiMarketingCampaignIntelligentPromoBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KoubeiMarketingCampaignIntelligentPromoBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IntelligentPromos == input.IntelligentPromos ||
                    this.IntelligentPromos != null &&
                    input.IntelligentPromos != null &&
                    this.IntelligentPromos.SequenceEqual(input.IntelligentPromos)
                ) && 
                (
                    this.PageResult == input.PageResult ||
                    (this.PageResult != null &&
                    this.PageResult.Equals(input.PageResult))
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
                if (this.IntelligentPromos != null)
                {
                    hashCode = (hashCode * 59) + this.IntelligentPromos.GetHashCode();
                }
                if (this.PageResult != null)
                {
                    hashCode = (hashCode * 59) + this.PageResult.GetHashCode();
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
