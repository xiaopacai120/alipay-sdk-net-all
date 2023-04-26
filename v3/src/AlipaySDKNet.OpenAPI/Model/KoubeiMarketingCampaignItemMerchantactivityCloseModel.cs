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
    /// KoubeiMarketingCampaignItemMerchantactivityCloseModel
    /// </summary>
    [DataContract(Name = "KoubeiMarketingCampaignItemMerchantactivityCloseModel")]
    public partial class KoubeiMarketingCampaignItemMerchantactivityCloseModel : IEquatable<KoubeiMarketingCampaignItemMerchantactivityCloseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KoubeiMarketingCampaignItemMerchantactivityCloseModel" /> class.
        /// </summary>
        /// <param name="activityId">活动id。通过 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-apis/api_pre/koubei.marketing.campaign.item.merchantactivity.create\&quot;&gt;koubei.marketing.campaign.item.merchantactivity.create&lt;/a&gt;(商户创建商品代金券)获取。.</param>
        public KoubeiMarketingCampaignItemMerchantactivityCloseModel(string activityId = default(string))
        {
            this.ActivityId = activityId;
        }

        /// <summary>
        /// 活动id。通过 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-apis/api_pre/koubei.marketing.campaign.item.merchantactivity.create\&quot;&gt;koubei.marketing.campaign.item.merchantactivity.create&lt;/a&gt;(商户创建商品代金券)获取。
        /// </summary>
        /// <value>活动id。通过 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-apis/api_pre/koubei.marketing.campaign.item.merchantactivity.create\&quot;&gt;koubei.marketing.campaign.item.merchantactivity.create&lt;/a&gt;(商户创建商品代金券)获取。</value>
        [DataMember(Name = "activity_id", EmitDefaultValue = false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KoubeiMarketingCampaignItemMerchantactivityCloseModel {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
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
            return this.Equals(input as KoubeiMarketingCampaignItemMerchantactivityCloseModel);
        }

        /// <summary>
        /// Returns true if KoubeiMarketingCampaignItemMerchantactivityCloseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of KoubeiMarketingCampaignItemMerchantactivityCloseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KoubeiMarketingCampaignItemMerchantactivityCloseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
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
                if (this.ActivityId != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityId.GetHashCode();
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
