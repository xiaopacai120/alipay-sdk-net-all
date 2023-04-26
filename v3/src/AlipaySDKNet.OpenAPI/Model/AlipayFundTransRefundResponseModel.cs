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
    /// AlipayFundTransRefundResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundTransRefundResponseModel")]
    public partial class AlipayFundTransRefundResponseModel : IEquatable<AlipayFundTransRefundResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransRefundResponseModel" /> class.
        /// </summary>
        /// <param name="orderId">发红包时支付宝返回的支付宝订单号order_id。.</param>
        /// <param name="outRequestNo">标识一次资金退回请求，一笔资金退回失败后重新提交，要采用原来的资金退回单号。总退款金额不能超过用户实际支付金额。.</param>
        /// <param name="refundAmount">本次退款的金额，单位为元，支持两位小数.</param>
        /// <param name="refundDate">退款资金退回.</param>
        /// <param name="refundOrderId">退款的支付宝系统内部单据id.</param>
        /// <param name="status">SUCCESS：退款成功.</param>
        public AlipayFundTransRefundResponseModel(string orderId = default(string), string outRequestNo = default(string), string refundAmount = default(string), string refundDate = default(string), string refundOrderId = default(string), string status = default(string))
        {
            this.OrderId = orderId;
            this.OutRequestNo = outRequestNo;
            this.RefundAmount = refundAmount;
            this.RefundDate = refundDate;
            this.RefundOrderId = refundOrderId;
            this.Status = status;
        }

        /// <summary>
        /// 发红包时支付宝返回的支付宝订单号order_id。
        /// </summary>
        /// <value>发红包时支付宝返回的支付宝订单号order_id。</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 标识一次资金退回请求，一笔资金退回失败后重新提交，要采用原来的资金退回单号。总退款金额不能超过用户实际支付金额。
        /// </summary>
        /// <value>标识一次资金退回请求，一笔资金退回失败后重新提交，要采用原来的资金退回单号。总退款金额不能超过用户实际支付金额。</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次退款的金额，单位为元，支持两位小数
        /// </summary>
        /// <value>本次退款的金额，单位为元，支持两位小数</value>
        [DataMember(Name = "refund_amount", EmitDefaultValue = false)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款资金退回
        /// </summary>
        /// <value>退款资金退回</value>
        [DataMember(Name = "refund_date", EmitDefaultValue = false)]
        public string RefundDate { get; set; }

        /// <summary>
        /// 退款的支付宝系统内部单据id
        /// </summary>
        /// <value>退款的支付宝系统内部单据id</value>
        [DataMember(Name = "refund_order_id", EmitDefaultValue = false)]
        public string RefundOrderId { get; set; }

        /// <summary>
        /// SUCCESS：退款成功
        /// </summary>
        /// <value>SUCCESS：退款成功</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundTransRefundResponseModel {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
            sb.Append("  RefundDate: ").Append(RefundDate).Append("\n");
            sb.Append("  RefundOrderId: ").Append(RefundOrderId).Append("\n");
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
            return this.Equals(input as AlipayFundTransRefundResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundTransRefundResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundTransRefundResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundTransRefundResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
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
                    this.RefundDate == input.RefundDate ||
                    (this.RefundDate != null &&
                    this.RefundDate.Equals(input.RefundDate))
                ) && 
                (
                    this.RefundOrderId == input.RefundOrderId ||
                    (this.RefundOrderId != null &&
                    this.RefundOrderId.Equals(input.RefundOrderId))
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
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.RefundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundAmount.GetHashCode();
                }
                if (this.RefundDate != null)
                {
                    hashCode = (hashCode * 59) + this.RefundDate.GetHashCode();
                }
                if (this.RefundOrderId != null)
                {
                    hashCode = (hashCode * 59) + this.RefundOrderId.GetHashCode();
                }
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
