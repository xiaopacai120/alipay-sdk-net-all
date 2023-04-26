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
    /// TradeSettleDetail
    /// </summary>
    [DataContract(Name = "TradeSettleDetail")]
    public partial class TradeSettleDetail : IEquatable<TradeSettleDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeSettleDetail" /> class.
        /// </summary>
        /// <param name="amount">实际操作金额，单位为元，两位小数。该参数的值为分账或补差或结算时传入.</param>
        /// <param name="operationDt">操作日期.</param>
        /// <param name="operationSerialNo">商户操作序列号。商户发起请求的外部请求号。.</param>
        /// <param name="operationType">结算操作类型。有以下几种类型： replenish(补差)、replenish_refund(退补差)、transfer(分账)、transfer_refund(退分账)、settle(结算)、settle_refund(退结算)、on_settle(待结算)。.</param>
        /// <param name="oriTransIn">商户请求的转入账号.</param>
        /// <param name="oriTransOut">商户请求的转出账号.</param>
        /// <param name="transIn">转入账号.</param>
        /// <param name="transOut">转出账号.</param>
        public TradeSettleDetail(string amount = default(string), string operationDt = default(string), string operationSerialNo = default(string), string operationType = default(string), string oriTransIn = default(string), string oriTransOut = default(string), string transIn = default(string), string transOut = default(string))
        {
            this.Amount = amount;
            this.OperationDt = operationDt;
            this.OperationSerialNo = operationSerialNo;
            this.OperationType = operationType;
            this.OriTransIn = oriTransIn;
            this.OriTransOut = oriTransOut;
            this.TransIn = transIn;
            this.TransOut = transOut;
        }

        /// <summary>
        /// 实际操作金额，单位为元，两位小数。该参数的值为分账或补差或结算时传入
        /// </summary>
        /// <value>实际操作金额，单位为元，两位小数。该参数的值为分账或补差或结算时传入</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 操作日期
        /// </summary>
        /// <value>操作日期</value>
        [DataMember(Name = "operation_dt", EmitDefaultValue = false)]
        public string OperationDt { get; set; }

        /// <summary>
        /// 商户操作序列号。商户发起请求的外部请求号。
        /// </summary>
        /// <value>商户操作序列号。商户发起请求的外部请求号。</value>
        [DataMember(Name = "operation_serial_no", EmitDefaultValue = false)]
        public string OperationSerialNo { get; set; }

        /// <summary>
        /// 结算操作类型。有以下几种类型： replenish(补差)、replenish_refund(退补差)、transfer(分账)、transfer_refund(退分账)、settle(结算)、settle_refund(退结算)、on_settle(待结算)。
        /// </summary>
        /// <value>结算操作类型。有以下几种类型： replenish(补差)、replenish_refund(退补差)、transfer(分账)、transfer_refund(退分账)、settle(结算)、settle_refund(退结算)、on_settle(待结算)。</value>
        [DataMember(Name = "operation_type", EmitDefaultValue = false)]
        public string OperationType { get; set; }

        /// <summary>
        /// 商户请求的转入账号
        /// </summary>
        /// <value>商户请求的转入账号</value>
        [DataMember(Name = "ori_trans_in", EmitDefaultValue = false)]
        public string OriTransIn { get; set; }

        /// <summary>
        /// 商户请求的转出账号
        /// </summary>
        /// <value>商户请求的转出账号</value>
        [DataMember(Name = "ori_trans_out", EmitDefaultValue = false)]
        public string OriTransOut { get; set; }

        /// <summary>
        /// 转入账号
        /// </summary>
        /// <value>转入账号</value>
        [DataMember(Name = "trans_in", EmitDefaultValue = false)]
        public string TransIn { get; set; }

        /// <summary>
        /// 转出账号
        /// </summary>
        /// <value>转出账号</value>
        [DataMember(Name = "trans_out", EmitDefaultValue = false)]
        public string TransOut { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TradeSettleDetail {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  OperationDt: ").Append(OperationDt).Append("\n");
            sb.Append("  OperationSerialNo: ").Append(OperationSerialNo).Append("\n");
            sb.Append("  OperationType: ").Append(OperationType).Append("\n");
            sb.Append("  OriTransIn: ").Append(OriTransIn).Append("\n");
            sb.Append("  OriTransOut: ").Append(OriTransOut).Append("\n");
            sb.Append("  TransIn: ").Append(TransIn).Append("\n");
            sb.Append("  TransOut: ").Append(TransOut).Append("\n");
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
            return this.Equals(input as TradeSettleDetail);
        }

        /// <summary>
        /// Returns true if TradeSettleDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of TradeSettleDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeSettleDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.OperationDt == input.OperationDt ||
                    (this.OperationDt != null &&
                    this.OperationDt.Equals(input.OperationDt))
                ) && 
                (
                    this.OperationSerialNo == input.OperationSerialNo ||
                    (this.OperationSerialNo != null &&
                    this.OperationSerialNo.Equals(input.OperationSerialNo))
                ) && 
                (
                    this.OperationType == input.OperationType ||
                    (this.OperationType != null &&
                    this.OperationType.Equals(input.OperationType))
                ) && 
                (
                    this.OriTransIn == input.OriTransIn ||
                    (this.OriTransIn != null &&
                    this.OriTransIn.Equals(input.OriTransIn))
                ) && 
                (
                    this.OriTransOut == input.OriTransOut ||
                    (this.OriTransOut != null &&
                    this.OriTransOut.Equals(input.OriTransOut))
                ) && 
                (
                    this.TransIn == input.TransIn ||
                    (this.TransIn != null &&
                    this.TransIn.Equals(input.TransIn))
                ) && 
                (
                    this.TransOut == input.TransOut ||
                    (this.TransOut != null &&
                    this.TransOut.Equals(input.TransOut))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.OperationDt != null)
                {
                    hashCode = (hashCode * 59) + this.OperationDt.GetHashCode();
                }
                if (this.OperationSerialNo != null)
                {
                    hashCode = (hashCode * 59) + this.OperationSerialNo.GetHashCode();
                }
                if (this.OperationType != null)
                {
                    hashCode = (hashCode * 59) + this.OperationType.GetHashCode();
                }
                if (this.OriTransIn != null)
                {
                    hashCode = (hashCode * 59) + this.OriTransIn.GetHashCode();
                }
                if (this.OriTransOut != null)
                {
                    hashCode = (hashCode * 59) + this.OriTransOut.GetHashCode();
                }
                if (this.TransIn != null)
                {
                    hashCode = (hashCode * 59) + this.TransIn.GetHashCode();
                }
                if (this.TransOut != null)
                {
                    hashCode = (hashCode * 59) + this.TransOut.GetHashCode();
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
