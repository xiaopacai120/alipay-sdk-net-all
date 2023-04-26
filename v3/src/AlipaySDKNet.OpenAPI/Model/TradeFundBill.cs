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
    /// TradeFundBill
    /// </summary>
    [DataContract(Name = "TradeFundBill")]
    public partial class TradeFundBill : IEquatable<TradeFundBill>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeFundBill" /> class.
        /// </summary>
        /// <param name="amount">该支付工具类型所使用的金额.</param>
        /// <param name="bankCode">银行卡支付时的银行代码.</param>
        /// <param name="fundChannel">交易使用的资金渠道，详见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/common/103259\&quot;&gt;支付渠道列表&lt;/a&gt;.</param>
        /// <param name="fundType">渠道所使用的资金类型,目前只在资金渠道(fund_channel)是银行卡渠道(BANKCARD)的情况下才返回该信息(DEBIT_CARD:借记卡,CREDIT_CARD:信用卡,MIXED_CARD:借贷合一卡).</param>
        /// <param name="realAmount">渠道实际付款金额.</param>
        public TradeFundBill(string amount = default(string), string bankCode = default(string), string fundChannel = default(string), string fundType = default(string), string realAmount = default(string))
        {
            this.Amount = amount;
            this.BankCode = bankCode;
            this.FundChannel = fundChannel;
            this.FundType = fundType;
            this.RealAmount = realAmount;
        }

        /// <summary>
        /// 该支付工具类型所使用的金额
        /// </summary>
        /// <value>该支付工具类型所使用的金额</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 银行卡支付时的银行代码
        /// </summary>
        /// <value>银行卡支付时的银行代码</value>
        [DataMember(Name = "bank_code", EmitDefaultValue = false)]
        public string BankCode { get; set; }

        /// <summary>
        /// 交易使用的资金渠道，详见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/common/103259\&quot;&gt;支付渠道列表&lt;/a&gt;
        /// </summary>
        /// <value>交易使用的资金渠道，详见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/common/103259\&quot;&gt;支付渠道列表&lt;/a&gt;</value>
        [DataMember(Name = "fund_channel", EmitDefaultValue = false)]
        public string FundChannel { get; set; }

        /// <summary>
        /// 渠道所使用的资金类型,目前只在资金渠道(fund_channel)是银行卡渠道(BANKCARD)的情况下才返回该信息(DEBIT_CARD:借记卡,CREDIT_CARD:信用卡,MIXED_CARD:借贷合一卡)
        /// </summary>
        /// <value>渠道所使用的资金类型,目前只在资金渠道(fund_channel)是银行卡渠道(BANKCARD)的情况下才返回该信息(DEBIT_CARD:借记卡,CREDIT_CARD:信用卡,MIXED_CARD:借贷合一卡)</value>
        [DataMember(Name = "fund_type", EmitDefaultValue = false)]
        public string FundType { get; set; }

        /// <summary>
        /// 渠道实际付款金额
        /// </summary>
        /// <value>渠道实际付款金额</value>
        [DataMember(Name = "real_amount", EmitDefaultValue = false)]
        public string RealAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TradeFundBill {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  FundChannel: ").Append(FundChannel).Append("\n");
            sb.Append("  FundType: ").Append(FundType).Append("\n");
            sb.Append("  RealAmount: ").Append(RealAmount).Append("\n");
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
            return this.Equals(input as TradeFundBill);
        }

        /// <summary>
        /// Returns true if TradeFundBill instances are equal
        /// </summary>
        /// <param name="input">Instance of TradeFundBill to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeFundBill input)
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
                    this.BankCode == input.BankCode ||
                    (this.BankCode != null &&
                    this.BankCode.Equals(input.BankCode))
                ) && 
                (
                    this.FundChannel == input.FundChannel ||
                    (this.FundChannel != null &&
                    this.FundChannel.Equals(input.FundChannel))
                ) && 
                (
                    this.FundType == input.FundType ||
                    (this.FundType != null &&
                    this.FundType.Equals(input.FundType))
                ) && 
                (
                    this.RealAmount == input.RealAmount ||
                    (this.RealAmount != null &&
                    this.RealAmount.Equals(input.RealAmount))
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
                if (this.BankCode != null)
                {
                    hashCode = (hashCode * 59) + this.BankCode.GetHashCode();
                }
                if (this.FundChannel != null)
                {
                    hashCode = (hashCode * 59) + this.FundChannel.GetHashCode();
                }
                if (this.FundType != null)
                {
                    hashCode = (hashCode * 59) + this.FundType.GetHashCode();
                }
                if (this.RealAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RealAmount.GetHashCode();
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
