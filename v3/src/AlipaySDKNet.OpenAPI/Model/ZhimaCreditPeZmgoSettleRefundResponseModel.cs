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
    /// ZhimaCreditPeZmgoSettleRefundResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPeZmgoSettleRefundResponseModel")]
    public partial class ZhimaCreditPeZmgoSettleRefundResponseModel : IEquatable<ZhimaCreditPeZmgoSettleRefundResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoSettleRefundResponseModel" /> class.
        /// </summary>
        /// <param name="failReason">退款操作错误原因描述.</param>
        /// <param name="outRequestNo">外部请求号.</param>
        /// <param name="refundAmount">本次请求退款金额.</param>
        /// <param name="refundOptNo">芝麻GO退款生成的内部唯一流水，外部商户可以拿这个参数进行对账.</param>
        /// <param name="retry">此字段含义，商家接入时需咨询对接技术。.</param>
        /// <param name="withholdPlanNo">本次退款的扣款计划单号.</param>
        public ZhimaCreditPeZmgoSettleRefundResponseModel(string failReason = default(string), string outRequestNo = default(string), string refundAmount = default(string), string refundOptNo = default(string), bool retry = default(bool), string withholdPlanNo = default(string))
        {
            this.FailReason = failReason;
            this.OutRequestNo = outRequestNo;
            this.RefundAmount = refundAmount;
            this.RefundOptNo = refundOptNo;
            this.Retry = retry;
            this.WithholdPlanNo = withholdPlanNo;
        }

        /// <summary>
        /// 退款操作错误原因描述
        /// </summary>
        /// <value>退款操作错误原因描述</value>
        [DataMember(Name = "fail_reason", EmitDefaultValue = false)]
        public string FailReason { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        /// <value>外部请求号</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次请求退款金额
        /// </summary>
        /// <value>本次请求退款金额</value>
        [DataMember(Name = "refund_amount", EmitDefaultValue = false)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 芝麻GO退款生成的内部唯一流水，外部商户可以拿这个参数进行对账
        /// </summary>
        /// <value>芝麻GO退款生成的内部唯一流水，外部商户可以拿这个参数进行对账</value>
        [DataMember(Name = "refund_opt_no", EmitDefaultValue = false)]
        public string RefundOptNo { get; set; }

        /// <summary>
        /// 此字段含义，商家接入时需咨询对接技术。
        /// </summary>
        /// <value>此字段含义，商家接入时需咨询对接技术。</value>
        [DataMember(Name = "retry", EmitDefaultValue = true)]
        public bool Retry { get; set; }

        /// <summary>
        /// 本次退款的扣款计划单号
        /// </summary>
        /// <value>本次退款的扣款计划单号</value>
        [DataMember(Name = "withhold_plan_no", EmitDefaultValue = false)]
        public string WithholdPlanNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCreditPeZmgoSettleRefundResponseModel {\n");
            sb.Append("  FailReason: ").Append(FailReason).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
            sb.Append("  RefundOptNo: ").Append(RefundOptNo).Append("\n");
            sb.Append("  Retry: ").Append(Retry).Append("\n");
            sb.Append("  WithholdPlanNo: ").Append(WithholdPlanNo).Append("\n");
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
            return this.Equals(input as ZhimaCreditPeZmgoSettleRefundResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPeZmgoSettleRefundResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPeZmgoSettleRefundResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPeZmgoSettleRefundResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.RefundAmount == input.RefundAmount ||
                    (this.RefundAmount != null &&
                    this.RefundAmount.Equals(input.RefundAmount))
                ) && 
                (
                    this.RefundOptNo == input.RefundOptNo ||
                    (this.RefundOptNo != null &&
                    this.RefundOptNo.Equals(input.RefundOptNo))
                ) && 
                (
                    this.Retry == input.Retry ||
                    this.Retry.Equals(input.Retry)
                ) && 
                (
                    this.WithholdPlanNo == input.WithholdPlanNo ||
                    (this.WithholdPlanNo != null &&
                    this.WithholdPlanNo.Equals(input.WithholdPlanNo))
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
                if (this.FailReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailReason.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.RefundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundAmount.GetHashCode();
                }
                if (this.RefundOptNo != null)
                {
                    hashCode = (hashCode * 59) + this.RefundOptNo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Retry.GetHashCode();
                if (this.WithholdPlanNo != null)
                {
                    hashCode = (hashCode * 59) + this.WithholdPlanNo.GetHashCode();
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
