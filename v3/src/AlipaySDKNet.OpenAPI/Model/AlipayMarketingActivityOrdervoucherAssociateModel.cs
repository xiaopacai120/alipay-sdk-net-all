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
    /// AlipayMarketingActivityOrdervoucherAssociateModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityOrdervoucherAssociateModel")]
    public partial class AlipayMarketingActivityOrdervoucherAssociateModel : IEquatable<AlipayMarketingActivityOrdervoucherAssociateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityOrdervoucherAssociateModel" /> class.
        /// </summary>
        /// <param name="activityId">活动id.</param>
        /// <param name="merchantAccessMode">商户接入模式  枚举值 SELF_MODE 商户自接入模式 AGENCY_MODE 服务商代接入模式.</param>
        /// <param name="outBizNo">外部业务单号，用作幂等控制。 幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。.</param>
        /// <param name="tradeNo">支付宝支付下单时的商户订单号，欲与该商家券关联的支付宝支付.</param>
        /// <param name="voucherCode">商家券券码。 限制: 券码必须已发放给用户。.</param>
        public AlipayMarketingActivityOrdervoucherAssociateModel(string activityId = default(string), string merchantAccessMode = default(string), string outBizNo = default(string), string tradeNo = default(string), string voucherCode = default(string))
        {
            this.ActivityId = activityId;
            this.MerchantAccessMode = merchantAccessMode;
            this.OutBizNo = outBizNo;
            this.TradeNo = tradeNo;
            this.VoucherCode = voucherCode;
        }

        /// <summary>
        /// 活动id
        /// </summary>
        /// <value>活动id</value>
        [DataMember(Name = "activity_id", EmitDefaultValue = false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// 商户接入模式  枚举值 SELF_MODE 商户自接入模式 AGENCY_MODE 服务商代接入模式
        /// </summary>
        /// <value>商户接入模式  枚举值 SELF_MODE 商户自接入模式 AGENCY_MODE 服务商代接入模式</value>
        [DataMember(Name = "merchant_access_mode", EmitDefaultValue = false)]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。 幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。
        /// </summary>
        /// <value>外部业务单号，用作幂等控制。 幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝支付下单时的商户订单号，欲与该商家券关联的支付宝支付
        /// </summary>
        /// <value>支付宝支付下单时的商户订单号，欲与该商家券关联的支付宝支付</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// 商家券券码。 限制: 券码必须已发放给用户。
        /// </summary>
        /// <value>商家券券码。 限制: 券码必须已发放给用户。</value>
        [DataMember(Name = "voucher_code", EmitDefaultValue = false)]
        public string VoucherCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityOrdervoucherAssociateModel {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  MerchantAccessMode: ").Append(MerchantAccessMode).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  TradeNo: ").Append(TradeNo).Append("\n");
            sb.Append("  VoucherCode: ").Append(VoucherCode).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityOrdervoucherAssociateModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityOrdervoucherAssociateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityOrdervoucherAssociateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityOrdervoucherAssociateModel input)
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
                ) && 
                (
                    this.TradeNo == input.TradeNo ||
                    (this.TradeNo != null &&
                    this.TradeNo.Equals(input.TradeNo))
                ) && 
                (
                    this.VoucherCode == input.VoucherCode ||
                    (this.VoucherCode != null &&
                    this.VoucherCode.Equals(input.VoucherCode))
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
                if (this.MerchantAccessMode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccessMode.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.TradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.TradeNo.GetHashCode();
                }
                if (this.VoucherCode != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherCode.GetHashCode();
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
