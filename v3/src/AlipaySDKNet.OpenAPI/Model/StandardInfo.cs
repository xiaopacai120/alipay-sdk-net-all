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
    /// StandardInfo
    /// </summary>
    [DataContract(Name = "StandardInfo")]
    public partial class StandardInfo : IEquatable<StandardInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardInfo" /> class.
        /// </summary>
        /// <param name="consumeMode">消费模式，不填为默认模式，枚举值：COUPON_ONLY（仅支持点券） COUPON_AND_CAP（支持点券+余额） DEFAULT（默认模式） 点券：消费时找员工的点券，没有或者用完了不可付； 点券+余额：消费时找员工的点券，没有找员工的余额，没有或者用完了不可付。 默认：有给员工设置员工余额以员工余额为准，用完为止。否则只受规则里的限额和企业账户资金上限管控；.</param>
        /// <param name="expenseTypeSubCategory">费用类型子类，当制度的费用类型为MEAL时，支持到店、外卖；当费用类型为非MEAL时，与费用类型保持一致.</param>
        /// <param name="openRuleId">开票规则id，可通过接口alipay.ebpp.invoice.enterpriseconsume.enterpriseopenrule.create 创建并得到开票规则ID.</param>
        /// <param name="outerSourceId">外部使用规则id，制度内使用规则该字段不允许重复.</param>
        /// <param name="paymentPolicy">支付策略 当笔消费金额大于规则可用余额时，用于控制支付策略，该字段缺省时采取因公账户和个人账户组合支付策略， 枚举值：PERSONAL（全部个人账户支付）, COMBINATION（因公账户和个人账户组合支付）.</param>
        /// <param name="standardConditionInfoList">使用规则条件列表.</param>
        /// <param name="standardDesc">使用规则描述(敏感词校验).</param>
        /// <param name="standardId">制度ID（创建使用规则时非必填）.</param>
        /// <param name="standardName">规则名称.</param>
        public StandardInfo(string consumeMode = default(string), string expenseTypeSubCategory = default(string), string openRuleId = default(string), string outerSourceId = default(string), string paymentPolicy = default(string), List<StandardConditionInfo> standardConditionInfoList = default(List<StandardConditionInfo>), string standardDesc = default(string), string standardId = default(string), string standardName = default(string))
        {
            this.ConsumeMode = consumeMode;
            this.ExpenseTypeSubCategory = expenseTypeSubCategory;
            this.OpenRuleId = openRuleId;
            this.OuterSourceId = outerSourceId;
            this.PaymentPolicy = paymentPolicy;
            this.StandardConditionInfoList = standardConditionInfoList;
            this.StandardDesc = standardDesc;
            this.StandardId = standardId;
            this.StandardName = standardName;
        }

        /// <summary>
        /// 消费模式，不填为默认模式，枚举值：COUPON_ONLY（仅支持点券） COUPON_AND_CAP（支持点券+余额） DEFAULT（默认模式） 点券：消费时找员工的点券，没有或者用完了不可付； 点券+余额：消费时找员工的点券，没有找员工的余额，没有或者用完了不可付。 默认：有给员工设置员工余额以员工余额为准，用完为止。否则只受规则里的限额和企业账户资金上限管控；
        /// </summary>
        /// <value>消费模式，不填为默认模式，枚举值：COUPON_ONLY（仅支持点券） COUPON_AND_CAP（支持点券+余额） DEFAULT（默认模式） 点券：消费时找员工的点券，没有或者用完了不可付； 点券+余额：消费时找员工的点券，没有找员工的余额，没有或者用完了不可付。 默认：有给员工设置员工余额以员工余额为准，用完为止。否则只受规则里的限额和企业账户资金上限管控；</value>
        [DataMember(Name = "consume_mode", EmitDefaultValue = false)]
        public string ConsumeMode { get; set; }

        /// <summary>
        /// 费用类型子类，当制度的费用类型为MEAL时，支持到店、外卖；当费用类型为非MEAL时，与费用类型保持一致
        /// </summary>
        /// <value>费用类型子类，当制度的费用类型为MEAL时，支持到店、外卖；当费用类型为非MEAL时，与费用类型保持一致</value>
        [DataMember(Name = "expense_type_sub_category", EmitDefaultValue = false)]
        public string ExpenseTypeSubCategory { get; set; }

        /// <summary>
        /// 开票规则id，可通过接口alipay.ebpp.invoice.enterpriseconsume.enterpriseopenrule.create 创建并得到开票规则ID
        /// </summary>
        /// <value>开票规则id，可通过接口alipay.ebpp.invoice.enterpriseconsume.enterpriseopenrule.create 创建并得到开票规则ID</value>
        [DataMember(Name = "open_rule_id", EmitDefaultValue = false)]
        public string OpenRuleId { get; set; }

        /// <summary>
        /// 外部使用规则id，制度内使用规则该字段不允许重复
        /// </summary>
        /// <value>外部使用规则id，制度内使用规则该字段不允许重复</value>
        [DataMember(Name = "outer_source_id", EmitDefaultValue = false)]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 支付策略 当笔消费金额大于规则可用余额时，用于控制支付策略，该字段缺省时采取因公账户和个人账户组合支付策略， 枚举值：PERSONAL（全部个人账户支付）, COMBINATION（因公账户和个人账户组合支付）
        /// </summary>
        /// <value>支付策略 当笔消费金额大于规则可用余额时，用于控制支付策略，该字段缺省时采取因公账户和个人账户组合支付策略， 枚举值：PERSONAL（全部个人账户支付）, COMBINATION（因公账户和个人账户组合支付）</value>
        [DataMember(Name = "payment_policy", EmitDefaultValue = false)]
        public string PaymentPolicy { get; set; }

        /// <summary>
        /// 使用规则条件列表
        /// </summary>
        /// <value>使用规则条件列表</value>
        [DataMember(Name = "standard_condition_info_list", EmitDefaultValue = false)]
        public List<StandardConditionInfo> StandardConditionInfoList { get; set; }

        /// <summary>
        /// 使用规则描述(敏感词校验)
        /// </summary>
        /// <value>使用规则描述(敏感词校验)</value>
        [DataMember(Name = "standard_desc", EmitDefaultValue = false)]
        public string StandardDesc { get; set; }

        /// <summary>
        /// 制度ID（创建使用规则时非必填）
        /// </summary>
        /// <value>制度ID（创建使用规则时非必填）</value>
        [DataMember(Name = "standard_id", EmitDefaultValue = false)]
        public string StandardId { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        /// <value>规则名称</value>
        [DataMember(Name = "standard_name", EmitDefaultValue = false)]
        public string StandardName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StandardInfo {\n");
            sb.Append("  ConsumeMode: ").Append(ConsumeMode).Append("\n");
            sb.Append("  ExpenseTypeSubCategory: ").Append(ExpenseTypeSubCategory).Append("\n");
            sb.Append("  OpenRuleId: ").Append(OpenRuleId).Append("\n");
            sb.Append("  OuterSourceId: ").Append(OuterSourceId).Append("\n");
            sb.Append("  PaymentPolicy: ").Append(PaymentPolicy).Append("\n");
            sb.Append("  StandardConditionInfoList: ").Append(StandardConditionInfoList).Append("\n");
            sb.Append("  StandardDesc: ").Append(StandardDesc).Append("\n");
            sb.Append("  StandardId: ").Append(StandardId).Append("\n");
            sb.Append("  StandardName: ").Append(StandardName).Append("\n");
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
            return this.Equals(input as StandardInfo);
        }

        /// <summary>
        /// Returns true if StandardInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of StandardInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StandardInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConsumeMode == input.ConsumeMode ||
                    (this.ConsumeMode != null &&
                    this.ConsumeMode.Equals(input.ConsumeMode))
                ) && 
                (
                    this.ExpenseTypeSubCategory == input.ExpenseTypeSubCategory ||
                    (this.ExpenseTypeSubCategory != null &&
                    this.ExpenseTypeSubCategory.Equals(input.ExpenseTypeSubCategory))
                ) && 
                (
                    this.OpenRuleId == input.OpenRuleId ||
                    (this.OpenRuleId != null &&
                    this.OpenRuleId.Equals(input.OpenRuleId))
                ) && 
                (
                    this.OuterSourceId == input.OuterSourceId ||
                    (this.OuterSourceId != null &&
                    this.OuterSourceId.Equals(input.OuterSourceId))
                ) && 
                (
                    this.PaymentPolicy == input.PaymentPolicy ||
                    (this.PaymentPolicy != null &&
                    this.PaymentPolicy.Equals(input.PaymentPolicy))
                ) && 
                (
                    this.StandardConditionInfoList == input.StandardConditionInfoList ||
                    this.StandardConditionInfoList != null &&
                    input.StandardConditionInfoList != null &&
                    this.StandardConditionInfoList.SequenceEqual(input.StandardConditionInfoList)
                ) && 
                (
                    this.StandardDesc == input.StandardDesc ||
                    (this.StandardDesc != null &&
                    this.StandardDesc.Equals(input.StandardDesc))
                ) && 
                (
                    this.StandardId == input.StandardId ||
                    (this.StandardId != null &&
                    this.StandardId.Equals(input.StandardId))
                ) && 
                (
                    this.StandardName == input.StandardName ||
                    (this.StandardName != null &&
                    this.StandardName.Equals(input.StandardName))
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
                if (this.ConsumeMode != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumeMode.GetHashCode();
                }
                if (this.ExpenseTypeSubCategory != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseTypeSubCategory.GetHashCode();
                }
                if (this.OpenRuleId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenRuleId.GetHashCode();
                }
                if (this.OuterSourceId != null)
                {
                    hashCode = (hashCode * 59) + this.OuterSourceId.GetHashCode();
                }
                if (this.PaymentPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentPolicy.GetHashCode();
                }
                if (this.StandardConditionInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.StandardConditionInfoList.GetHashCode();
                }
                if (this.StandardDesc != null)
                {
                    hashCode = (hashCode * 59) + this.StandardDesc.GetHashCode();
                }
                if (this.StandardId != null)
                {
                    hashCode = (hashCode * 59) + this.StandardId.GetHashCode();
                }
                if (this.StandardName != null)
                {
                    hashCode = (hashCode * 59) + this.StandardName.GetHashCode();
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
