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
    /// ExtraParams
    /// </summary>
    [DataContract(Name = "ExtraParams")]
    public partial class ExtraParams : IEquatable<ExtraParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtraParams" /> class.
        /// </summary>
        /// <param name="period">轻会员场景下协议结算周期，由协议生效日期到失效日期拼接(yyyyMMddHHmmss-yyyyMMddHHmmss)，精确到秒。.</param>
        /// <param name="periodSummaryInfo">轻会员费用结算原始信息。详细字段说明：total_real_pay_amount轻会员周期内累计支付宝支付金额， total_pay_count轻会员周期内累计支付宝支付次数，total_discount_amount轻会员周期内累计享受的轻会员优惠。（上面金额字段单位为元，精确小数点后两位）.</param>
        /// <param name="quitType">用户主动意愿退出：USER_CANCEL_QUIT; 商户结算退出：SETTLE_APPLY_QUIT; 默认值为SETTLE_APPLY_QUIT；这个字段会影响用户在芝麻信用合约的状态.</param>
        /// <param name="withholdIndex">代扣期数，周期扣场景PERIOD_SETTLE下需要传递.</param>
        public ExtraParams(string period = default(string), string periodSummaryInfo = default(string), string quitType = default(string), string withholdIndex = default(string))
        {
            this.Period = period;
            this.PeriodSummaryInfo = periodSummaryInfo;
            this.QuitType = quitType;
            this.WithholdIndex = withholdIndex;
        }

        /// <summary>
        /// 轻会员场景下协议结算周期，由协议生效日期到失效日期拼接(yyyyMMddHHmmss-yyyyMMddHHmmss)，精确到秒。
        /// </summary>
        /// <value>轻会员场景下协议结算周期，由协议生效日期到失效日期拼接(yyyyMMddHHmmss-yyyyMMddHHmmss)，精确到秒。</value>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public string Period { get; set; }

        /// <summary>
        /// 轻会员费用结算原始信息。详细字段说明：total_real_pay_amount轻会员周期内累计支付宝支付金额， total_pay_count轻会员周期内累计支付宝支付次数，total_discount_amount轻会员周期内累计享受的轻会员优惠。（上面金额字段单位为元，精确小数点后两位）
        /// </summary>
        /// <value>轻会员费用结算原始信息。详细字段说明：total_real_pay_amount轻会员周期内累计支付宝支付金额， total_pay_count轻会员周期内累计支付宝支付次数，total_discount_amount轻会员周期内累计享受的轻会员优惠。（上面金额字段单位为元，精确小数点后两位）</value>
        [DataMember(Name = "period_summary_info", EmitDefaultValue = false)]
        public string PeriodSummaryInfo { get; set; }

        /// <summary>
        /// 用户主动意愿退出：USER_CANCEL_QUIT; 商户结算退出：SETTLE_APPLY_QUIT; 默认值为SETTLE_APPLY_QUIT；这个字段会影响用户在芝麻信用合约的状态
        /// </summary>
        /// <value>用户主动意愿退出：USER_CANCEL_QUIT; 商户结算退出：SETTLE_APPLY_QUIT; 默认值为SETTLE_APPLY_QUIT；这个字段会影响用户在芝麻信用合约的状态</value>
        [DataMember(Name = "quit_type", EmitDefaultValue = false)]
        public string QuitType { get; set; }

        /// <summary>
        /// 代扣期数，周期扣场景PERIOD_SETTLE下需要传递
        /// </summary>
        /// <value>代扣期数，周期扣场景PERIOD_SETTLE下需要传递</value>
        [DataMember(Name = "withhold_index", EmitDefaultValue = false)]
        public string WithholdIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExtraParams {\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  PeriodSummaryInfo: ").Append(PeriodSummaryInfo).Append("\n");
            sb.Append("  QuitType: ").Append(QuitType).Append("\n");
            sb.Append("  WithholdIndex: ").Append(WithholdIndex).Append("\n");
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
            return this.Equals(input as ExtraParams);
        }

        /// <summary>
        /// Returns true if ExtraParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtraParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtraParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.PeriodSummaryInfo == input.PeriodSummaryInfo ||
                    (this.PeriodSummaryInfo != null &&
                    this.PeriodSummaryInfo.Equals(input.PeriodSummaryInfo))
                ) && 
                (
                    this.QuitType == input.QuitType ||
                    (this.QuitType != null &&
                    this.QuitType.Equals(input.QuitType))
                ) && 
                (
                    this.WithholdIndex == input.WithholdIndex ||
                    (this.WithholdIndex != null &&
                    this.WithholdIndex.Equals(input.WithholdIndex))
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
                if (this.Period != null)
                {
                    hashCode = (hashCode * 59) + this.Period.GetHashCode();
                }
                if (this.PeriodSummaryInfo != null)
                {
                    hashCode = (hashCode * 59) + this.PeriodSummaryInfo.GetHashCode();
                }
                if (this.QuitType != null)
                {
                    hashCode = (hashCode * 59) + this.QuitType.GetHashCode();
                }
                if (this.WithholdIndex != null)
                {
                    hashCode = (hashCode * 59) + this.WithholdIndex.GetHashCode();
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
