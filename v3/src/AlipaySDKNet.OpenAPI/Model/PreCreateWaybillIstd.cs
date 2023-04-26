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
    /// PreCreateWaybillIstd
    /// </summary>
    [DataContract(Name = "PreCreateWaybillIstd")]
    public partial class PreCreateWaybillIstd : IEquatable<PreCreateWaybillIstd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreCreateWaybillIstd" /> class.
        /// </summary>
        /// <param name="couponFee">优惠券费用.</param>
        /// <param name="deliverFee">运费.</param>
        /// <param name="dispatchDuration">预计骑手还剩多久接单（单位：秒）.</param>
        /// <param name="distance">配送距离(单位：米).</param>
        /// <param name="fee">实际运费.</param>
        /// <param name="insuranceFee">保价费用.</param>
        /// <param name="logisticsCode">即时配送公司编码.</param>
        /// <param name="logisticsToken">配送公司可以返回此字段，当商家下单时候带上这个字段，保证在一段时间内运费不变.</param>
        /// <param name="payAmount">支付金额，实际扣减的费用以此字段为准.</param>
        /// <param name="serviceCode">即时配送公司服务代码.</param>
        /// <param name="thirdCode">即时配送公司返回的响应码。10000表示业务处理成功，40004表示业务处理失败。.</param>
        /// <param name="thirdSubCode">即时配送公司返回的错误码.</param>
        /// <param name="thirdSubMsg">即时配送公司返回的错误描述.</param>
        public PreCreateWaybillIstd(string couponFee = default(string), string deliverFee = default(string), int dispatchDuration = default(int), int distance = default(int), string fee = default(string), string insuranceFee = default(string), string logisticsCode = default(string), string logisticsToken = default(string), string payAmount = default(string), string serviceCode = default(string), string thirdCode = default(string), string thirdSubCode = default(string), string thirdSubMsg = default(string))
        {
            this.CouponFee = couponFee;
            this.DeliverFee = deliverFee;
            this.DispatchDuration = dispatchDuration;
            this.Distance = distance;
            this.Fee = fee;
            this.InsuranceFee = insuranceFee;
            this.LogisticsCode = logisticsCode;
            this.LogisticsToken = logisticsToken;
            this.PayAmount = payAmount;
            this.ServiceCode = serviceCode;
            this.ThirdCode = thirdCode;
            this.ThirdSubCode = thirdSubCode;
            this.ThirdSubMsg = thirdSubMsg;
        }

        /// <summary>
        /// 优惠券费用
        /// </summary>
        /// <value>优惠券费用</value>
        [DataMember(Name = "coupon_fee", EmitDefaultValue = false)]
        public string CouponFee { get; set; }

        /// <summary>
        /// 运费
        /// </summary>
        /// <value>运费</value>
        [DataMember(Name = "deliver_fee", EmitDefaultValue = false)]
        public string DeliverFee { get; set; }

        /// <summary>
        /// 预计骑手还剩多久接单（单位：秒）
        /// </summary>
        /// <value>预计骑手还剩多久接单（单位：秒）</value>
        [DataMember(Name = "dispatch_duration", EmitDefaultValue = false)]
        public int DispatchDuration { get; set; }

        /// <summary>
        /// 配送距离(单位：米)
        /// </summary>
        /// <value>配送距离(单位：米)</value>
        [DataMember(Name = "distance", EmitDefaultValue = false)]
        public int Distance { get; set; }

        /// <summary>
        /// 实际运费
        /// </summary>
        /// <value>实际运费</value>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public string Fee { get; set; }

        /// <summary>
        /// 保价费用
        /// </summary>
        /// <value>保价费用</value>
        [DataMember(Name = "insurance_fee", EmitDefaultValue = false)]
        public string InsuranceFee { get; set; }

        /// <summary>
        /// 即时配送公司编码
        /// </summary>
        /// <value>即时配送公司编码</value>
        [DataMember(Name = "logistics_code", EmitDefaultValue = false)]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 配送公司可以返回此字段，当商家下单时候带上这个字段，保证在一段时间内运费不变
        /// </summary>
        /// <value>配送公司可以返回此字段，当商家下单时候带上这个字段，保证在一段时间内运费不变</value>
        [DataMember(Name = "logistics_token", EmitDefaultValue = false)]
        public string LogisticsToken { get; set; }

        /// <summary>
        /// 支付金额，实际扣减的费用以此字段为准
        /// </summary>
        /// <value>支付金额，实际扣减的费用以此字段为准</value>
        [DataMember(Name = "pay_amount", EmitDefaultValue = false)]
        public string PayAmount { get; set; }

        /// <summary>
        /// 即时配送公司服务代码
        /// </summary>
        /// <value>即时配送公司服务代码</value>
        [DataMember(Name = "service_code", EmitDefaultValue = false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 即时配送公司返回的响应码。10000表示业务处理成功，40004表示业务处理失败。
        /// </summary>
        /// <value>即时配送公司返回的响应码。10000表示业务处理成功，40004表示业务处理失败。</value>
        [DataMember(Name = "third_code", EmitDefaultValue = false)]
        public string ThirdCode { get; set; }

        /// <summary>
        /// 即时配送公司返回的错误码
        /// </summary>
        /// <value>即时配送公司返回的错误码</value>
        [DataMember(Name = "third_sub_code", EmitDefaultValue = false)]
        public string ThirdSubCode { get; set; }

        /// <summary>
        /// 即时配送公司返回的错误描述
        /// </summary>
        /// <value>即时配送公司返回的错误描述</value>
        [DataMember(Name = "third_sub_msg", EmitDefaultValue = false)]
        public string ThirdSubMsg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PreCreateWaybillIstd {\n");
            sb.Append("  CouponFee: ").Append(CouponFee).Append("\n");
            sb.Append("  DeliverFee: ").Append(DeliverFee).Append("\n");
            sb.Append("  DispatchDuration: ").Append(DispatchDuration).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  InsuranceFee: ").Append(InsuranceFee).Append("\n");
            sb.Append("  LogisticsCode: ").Append(LogisticsCode).Append("\n");
            sb.Append("  LogisticsToken: ").Append(LogisticsToken).Append("\n");
            sb.Append("  PayAmount: ").Append(PayAmount).Append("\n");
            sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
            sb.Append("  ThirdCode: ").Append(ThirdCode).Append("\n");
            sb.Append("  ThirdSubCode: ").Append(ThirdSubCode).Append("\n");
            sb.Append("  ThirdSubMsg: ").Append(ThirdSubMsg).Append("\n");
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
            return this.Equals(input as PreCreateWaybillIstd);
        }

        /// <summary>
        /// Returns true if PreCreateWaybillIstd instances are equal
        /// </summary>
        /// <param name="input">Instance of PreCreateWaybillIstd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreCreateWaybillIstd input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CouponFee == input.CouponFee ||
                    (this.CouponFee != null &&
                    this.CouponFee.Equals(input.CouponFee))
                ) && 
                (
                    this.DeliverFee == input.DeliverFee ||
                    (this.DeliverFee != null &&
                    this.DeliverFee.Equals(input.DeliverFee))
                ) && 
                (
                    this.DispatchDuration == input.DispatchDuration ||
                    this.DispatchDuration.Equals(input.DispatchDuration)
                ) && 
                (
                    this.Distance == input.Distance ||
                    this.Distance.Equals(input.Distance)
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.InsuranceFee == input.InsuranceFee ||
                    (this.InsuranceFee != null &&
                    this.InsuranceFee.Equals(input.InsuranceFee))
                ) && 
                (
                    this.LogisticsCode == input.LogisticsCode ||
                    (this.LogisticsCode != null &&
                    this.LogisticsCode.Equals(input.LogisticsCode))
                ) && 
                (
                    this.LogisticsToken == input.LogisticsToken ||
                    (this.LogisticsToken != null &&
                    this.LogisticsToken.Equals(input.LogisticsToken))
                ) && 
                (
                    this.PayAmount == input.PayAmount ||
                    (this.PayAmount != null &&
                    this.PayAmount.Equals(input.PayAmount))
                ) && 
                (
                    this.ServiceCode == input.ServiceCode ||
                    (this.ServiceCode != null &&
                    this.ServiceCode.Equals(input.ServiceCode))
                ) && 
                (
                    this.ThirdCode == input.ThirdCode ||
                    (this.ThirdCode != null &&
                    this.ThirdCode.Equals(input.ThirdCode))
                ) && 
                (
                    this.ThirdSubCode == input.ThirdSubCode ||
                    (this.ThirdSubCode != null &&
                    this.ThirdSubCode.Equals(input.ThirdSubCode))
                ) && 
                (
                    this.ThirdSubMsg == input.ThirdSubMsg ||
                    (this.ThirdSubMsg != null &&
                    this.ThirdSubMsg.Equals(input.ThirdSubMsg))
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
                if (this.CouponFee != null)
                {
                    hashCode = (hashCode * 59) + this.CouponFee.GetHashCode();
                }
                if (this.DeliverFee != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverFee.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DispatchDuration.GetHashCode();
                hashCode = (hashCode * 59) + this.Distance.GetHashCode();
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                }
                if (this.InsuranceFee != null)
                {
                    hashCode = (hashCode * 59) + this.InsuranceFee.GetHashCode();
                }
                if (this.LogisticsCode != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticsCode.GetHashCode();
                }
                if (this.LogisticsToken != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticsToken.GetHashCode();
                }
                if (this.PayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PayAmount.GetHashCode();
                }
                if (this.ServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCode.GetHashCode();
                }
                if (this.ThirdCode != null)
                {
                    hashCode = (hashCode * 59) + this.ThirdCode.GetHashCode();
                }
                if (this.ThirdSubCode != null)
                {
                    hashCode = (hashCode * 59) + this.ThirdSubCode.GetHashCode();
                }
                if (this.ThirdSubMsg != null)
                {
                    hashCode = (hashCode * 59) + this.ThirdSubMsg.GetHashCode();
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
