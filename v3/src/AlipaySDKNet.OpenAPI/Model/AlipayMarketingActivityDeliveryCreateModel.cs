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
    /// AlipayMarketingActivityDeliveryCreateModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityDeliveryCreateModel")]
    public partial class AlipayMarketingActivityDeliveryCreateModel : IEquatable<AlipayMarketingActivityDeliveryCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityDeliveryCreateModel" /> class.
        /// </summary>
        /// <param name="belongMerchantInfo">belongMerchantInfo.</param>
        /// <param name="deliveryBaseInfo">deliveryBaseInfo.</param>
        /// <param name="deliveryBoothCode">投放的展位编码。.</param>
        /// <param name="deliveryConfigList">[已废弃] 待创建的投放配置列表。 最大数量限制20个。.</param>
        /// <param name="deliveryPlayConfig">deliveryPlayConfig.</param>
        /// <param name="deliveryTargetRule">deliveryTargetRule.</param>
        /// <param name="merchantAccessMode">商户接入模式  枚举值 SELF_MODE 商户自接入模式 AGENCY_MODE 服务商代接入模式.</param>
        /// <param name="outBizNo">外部业务单号，用作幂等控制。 幂等作用：请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。.</param>
        public AlipayMarketingActivityDeliveryCreateModel(DeliveryAgencyMerchantInfo belongMerchantInfo = default(DeliveryAgencyMerchantInfo), DeliveryBaseInfo deliveryBaseInfo = default(DeliveryBaseInfo), string deliveryBoothCode = default(string), List<DeliveryConfig> deliveryConfigList = default(List<DeliveryConfig>), DeliveryPlayConfig deliveryPlayConfig = default(DeliveryPlayConfig), DeliveryTargetRule deliveryTargetRule = default(DeliveryTargetRule), string merchantAccessMode = default(string), string outBizNo = default(string))
        {
            this.BelongMerchantInfo = belongMerchantInfo;
            this.DeliveryBaseInfo = deliveryBaseInfo;
            this.DeliveryBoothCode = deliveryBoothCode;
            this.DeliveryConfigList = deliveryConfigList;
            this.DeliveryPlayConfig = deliveryPlayConfig;
            this.DeliveryTargetRule = deliveryTargetRule;
            this.MerchantAccessMode = merchantAccessMode;
            this.OutBizNo = outBizNo;
        }

        /// <summary>
        /// Gets or Sets BelongMerchantInfo
        /// </summary>
        [DataMember(Name = "belong_merchant_info", EmitDefaultValue = false)]
        public DeliveryAgencyMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryBaseInfo
        /// </summary>
        [DataMember(Name = "delivery_base_info", EmitDefaultValue = false)]
        public DeliveryBaseInfo DeliveryBaseInfo { get; set; }

        /// <summary>
        /// 投放的展位编码。
        /// </summary>
        /// <value>投放的展位编码。</value>
        [DataMember(Name = "delivery_booth_code", EmitDefaultValue = false)]
        public string DeliveryBoothCode { get; set; }

        /// <summary>
        /// [已废弃] 待创建的投放配置列表。 最大数量限制20个。
        /// </summary>
        /// <value>[已废弃] 待创建的投放配置列表。 最大数量限制20个。</value>
        [DataMember(Name = "delivery_config_list", EmitDefaultValue = false)]
        public List<DeliveryConfig> DeliveryConfigList { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryPlayConfig
        /// </summary>
        [DataMember(Name = "delivery_play_config", EmitDefaultValue = false)]
        public DeliveryPlayConfig DeliveryPlayConfig { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryTargetRule
        /// </summary>
        [DataMember(Name = "delivery_target_rule", EmitDefaultValue = false)]
        public DeliveryTargetRule DeliveryTargetRule { get; set; }

        /// <summary>
        /// 商户接入模式  枚举值 SELF_MODE 商户自接入模式 AGENCY_MODE 服务商代接入模式
        /// </summary>
        /// <value>商户接入模式  枚举值 SELF_MODE 商户自接入模式 AGENCY_MODE 服务商代接入模式</value>
        [DataMember(Name = "merchant_access_mode", EmitDefaultValue = false)]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。 幂等作用：请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。
        /// </summary>
        /// <value>外部业务单号，用作幂等控制。 幂等作用：请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityDeliveryCreateModel {\n");
            sb.Append("  BelongMerchantInfo: ").Append(BelongMerchantInfo).Append("\n");
            sb.Append("  DeliveryBaseInfo: ").Append(DeliveryBaseInfo).Append("\n");
            sb.Append("  DeliveryBoothCode: ").Append(DeliveryBoothCode).Append("\n");
            sb.Append("  DeliveryConfigList: ").Append(DeliveryConfigList).Append("\n");
            sb.Append("  DeliveryPlayConfig: ").Append(DeliveryPlayConfig).Append("\n");
            sb.Append("  DeliveryTargetRule: ").Append(DeliveryTargetRule).Append("\n");
            sb.Append("  MerchantAccessMode: ").Append(MerchantAccessMode).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityDeliveryCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityDeliveryCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityDeliveryCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityDeliveryCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BelongMerchantInfo == input.BelongMerchantInfo ||
                    (this.BelongMerchantInfo != null &&
                    this.BelongMerchantInfo.Equals(input.BelongMerchantInfo))
                ) && 
                (
                    this.DeliveryBaseInfo == input.DeliveryBaseInfo ||
                    (this.DeliveryBaseInfo != null &&
                    this.DeliveryBaseInfo.Equals(input.DeliveryBaseInfo))
                ) && 
                (
                    this.DeliveryBoothCode == input.DeliveryBoothCode ||
                    (this.DeliveryBoothCode != null &&
                    this.DeliveryBoothCode.Equals(input.DeliveryBoothCode))
                ) && 
                (
                    this.DeliveryConfigList == input.DeliveryConfigList ||
                    this.DeliveryConfigList != null &&
                    input.DeliveryConfigList != null &&
                    this.DeliveryConfigList.SequenceEqual(input.DeliveryConfigList)
                ) && 
                (
                    this.DeliveryPlayConfig == input.DeliveryPlayConfig ||
                    (this.DeliveryPlayConfig != null &&
                    this.DeliveryPlayConfig.Equals(input.DeliveryPlayConfig))
                ) && 
                (
                    this.DeliveryTargetRule == input.DeliveryTargetRule ||
                    (this.DeliveryTargetRule != null &&
                    this.DeliveryTargetRule.Equals(input.DeliveryTargetRule))
                ) && 
                (
                    this.MerchantAccessMode == input.MerchantAccessMode ||
                    (this.MerchantAccessMode != null &&
                    this.MerchantAccessMode.Equals(input.MerchantAccessMode))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
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
                if (this.BelongMerchantInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BelongMerchantInfo.GetHashCode();
                }
                if (this.DeliveryBaseInfo != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryBaseInfo.GetHashCode();
                }
                if (this.DeliveryBoothCode != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryBoothCode.GetHashCode();
                }
                if (this.DeliveryConfigList != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryConfigList.GetHashCode();
                }
                if (this.DeliveryPlayConfig != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryPlayConfig.GetHashCode();
                }
                if (this.DeliveryTargetRule != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryTargetRule.GetHashCode();
                }
                if (this.MerchantAccessMode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccessMode.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
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
