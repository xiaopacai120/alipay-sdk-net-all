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
    /// AlipayEbppInvoiceExpensecontrolQuotaCreateModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceExpensecontrolQuotaCreateModel")]
    public partial class AlipayEbppInvoiceExpensecontrolQuotaCreateModel : IEquatable<AlipayEbppInvoiceExpensecontrolQuotaCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpensecontrolQuotaCreateModel" /> class.
        /// </summary>
        /// <param name="accountId">企业共同账户id，和授权签约协议号共同使用。.</param>
        /// <param name="agreementNo">授权签约协议号，可通过签约消息获取。配合企业共同账户id使用，当填写企业共同账户id时，此字段必填。.</param>
        /// <param name="effectiveEndDate">额度失效时间（格式：yyyy-MM-dd HH:mm:ss），额度类型为点券时必填，额度类型为余额时有默认值，无需填写.</param>
        /// <param name="effectiveStartDate">额度生效时间（格式：yyyy-MM-dd HH:mm:ss），额度类型为点券时必填，额度类型为余额时有默认值，无需填写.</param>
        /// <param name="enterpriseId">企业ID.</param>
        /// <param name="outerSourceId">外部操作幂等ID（接入方接口调用幂等控制ID），创建额度类型为点券时必填.</param>
        /// <param name="ownerId">额度所属者ID（未切换open_id请使用此字段）： owner_type为EMPLOYEE时填写员工支付宝ID； owner_type为ENTERPRISE_PAY_UID时填写员工企业码ID； owner_type为PHONE时填写员工手机号； owner_type为ENTERPRISE时填写企业ID。.</param>
        /// <param name="ownerOpenId">额度所属者ID（切换open_id后请使用此字段）： owner_type为EMPLOYEE时填写open_id； owner_type为ENTERPRISE_PAY_UID时填写员工企业码ID； owner_type为PHONE时填写员工手机号； owner_type为ENTERPRISE时填写企业ID。.</param>
        /// <param name="ownerType">额度所属者类型，可通过设置该字段来指定操作的owner_id类型，如果设置企业额度则设置为ENTERPRISE.</param>
        /// <param name="platform">外部平台编码（通常为接入方大写英文缩写）.</param>
        /// <param name="quotaType">创建额度类型，支持点券和余额，不填写则默认为余额类型.</param>
        /// <param name="quotaValue">额度值，以（分）为单位 约束：个人额度不超过100000元，企业额度不超过100000000元.</param>
        /// <param name="shareMode">0:不可转赠（注：不传模式为0） 1:可以转增（注：只有quota_type&#x3D;COUPON,可设置）.</param>
        /// <param name="targetId">额度维度ID 当 target_type&#x3D;EXPENSE_TYPE 时，值为 MEAL（工作餐） 当target_type&#x3D;RULE_GROUP_AGGREGATION 时，值为费控规则聚合ID 当target_type&#x3D;INSTITUTION 时，值为制度ID.</param>
        /// <param name="targetType">额度维度 枚举值： EXPENSE_TYPE（费用类型维度）， RULE_GROUP_AGGREGATION（规则聚合维度）， INSTITUTION（制度维度）.</param>
        public AlipayEbppInvoiceExpensecontrolQuotaCreateModel(string accountId = default(string), string agreementNo = default(string), string effectiveEndDate = default(string), string effectiveStartDate = default(string), string enterpriseId = default(string), string outerSourceId = default(string), string ownerId = default(string), string ownerOpenId = default(string), string ownerType = default(string), string platform = default(string), string quotaType = default(string), string quotaValue = default(string), string shareMode = default(string), string targetId = default(string), string targetType = default(string))
        {
            this.AccountId = accountId;
            this.AgreementNo = agreementNo;
            this.EffectiveEndDate = effectiveEndDate;
            this.EffectiveStartDate = effectiveStartDate;
            this.EnterpriseId = enterpriseId;
            this.OuterSourceId = outerSourceId;
            this.OwnerId = ownerId;
            this.OwnerOpenId = ownerOpenId;
            this.OwnerType = ownerType;
            this.Platform = platform;
            this.QuotaType = quotaType;
            this.QuotaValue = quotaValue;
            this.ShareMode = shareMode;
            this.TargetId = targetId;
            this.TargetType = targetType;
        }

        /// <summary>
        /// 企业共同账户id，和授权签约协议号共同使用。
        /// </summary>
        /// <value>企业共同账户id，和授权签约协议号共同使用。</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号，可通过签约消息获取。配合企业共同账户id使用，当填写企业共同账户id时，此字段必填。
        /// </summary>
        /// <value>授权签约协议号，可通过签约消息获取。配合企业共同账户id使用，当填写企业共同账户id时，此字段必填。</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 额度失效时间（格式：yyyy-MM-dd HH:mm:ss），额度类型为点券时必填，额度类型为余额时有默认值，无需填写
        /// </summary>
        /// <value>额度失效时间（格式：yyyy-MM-dd HH:mm:ss），额度类型为点券时必填，额度类型为余额时有默认值，无需填写</value>
        [DataMember(Name = "effective_end_date", EmitDefaultValue = false)]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 额度生效时间（格式：yyyy-MM-dd HH:mm:ss），额度类型为点券时必填，额度类型为余额时有默认值，无需填写
        /// </summary>
        /// <value>额度生效时间（格式：yyyy-MM-dd HH:mm:ss），额度类型为点券时必填，额度类型为余额时有默认值，无需填写</value>
        [DataMember(Name = "effective_start_date", EmitDefaultValue = false)]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 外部操作幂等ID（接入方接口调用幂等控制ID），创建额度类型为点券时必填
        /// </summary>
        /// <value>外部操作幂等ID（接入方接口调用幂等控制ID），创建额度类型为点券时必填</value>
        [DataMember(Name = "outer_source_id", EmitDefaultValue = false)]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 额度所属者ID（未切换open_id请使用此字段）： owner_type为EMPLOYEE时填写员工支付宝ID； owner_type为ENTERPRISE_PAY_UID时填写员工企业码ID； owner_type为PHONE时填写员工手机号； owner_type为ENTERPRISE时填写企业ID。
        /// </summary>
        /// <value>额度所属者ID（未切换open_id请使用此字段）： owner_type为EMPLOYEE时填写员工支付宝ID； owner_type为ENTERPRISE_PAY_UID时填写员工企业码ID； owner_type为PHONE时填写员工手机号； owner_type为ENTERPRISE时填写企业ID。</value>
        [DataMember(Name = "owner_id", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// 额度所属者ID（切换open_id后请使用此字段）： owner_type为EMPLOYEE时填写open_id； owner_type为ENTERPRISE_PAY_UID时填写员工企业码ID； owner_type为PHONE时填写员工手机号； owner_type为ENTERPRISE时填写企业ID。
        /// </summary>
        /// <value>额度所属者ID（切换open_id后请使用此字段）： owner_type为EMPLOYEE时填写open_id； owner_type为ENTERPRISE_PAY_UID时填写员工企业码ID； owner_type为PHONE时填写员工手机号； owner_type为ENTERPRISE时填写企业ID。</value>
        [DataMember(Name = "owner_open_id", EmitDefaultValue = false)]
        public string OwnerOpenId { get; set; }

        /// <summary>
        /// 额度所属者类型，可通过设置该字段来指定操作的owner_id类型，如果设置企业额度则设置为ENTERPRISE
        /// </summary>
        /// <value>额度所属者类型，可通过设置该字段来指定操作的owner_id类型，如果设置企业额度则设置为ENTERPRISE</value>
        [DataMember(Name = "owner_type", EmitDefaultValue = false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// 外部平台编码（通常为接入方大写英文缩写）
        /// </summary>
        /// <value>外部平台编码（通常为接入方大写英文缩写）</value>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public string Platform { get; set; }

        /// <summary>
        /// 创建额度类型，支持点券和余额，不填写则默认为余额类型
        /// </summary>
        /// <value>创建额度类型，支持点券和余额，不填写则默认为余额类型</value>
        [DataMember(Name = "quota_type", EmitDefaultValue = false)]
        public string QuotaType { get; set; }

        /// <summary>
        /// 额度值，以（分）为单位 约束：个人额度不超过100000元，企业额度不超过100000000元
        /// </summary>
        /// <value>额度值，以（分）为单位 约束：个人额度不超过100000元，企业额度不超过100000000元</value>
        [DataMember(Name = "quota_value", EmitDefaultValue = false)]
        public string QuotaValue { get; set; }

        /// <summary>
        /// 0:不可转赠（注：不传模式为0） 1:可以转增（注：只有quota_type&#x3D;COUPON,可设置）
        /// </summary>
        /// <value>0:不可转赠（注：不传模式为0） 1:可以转增（注：只有quota_type&#x3D;COUPON,可设置）</value>
        [DataMember(Name = "share_mode", EmitDefaultValue = false)]
        public string ShareMode { get; set; }

        /// <summary>
        /// 额度维度ID 当 target_type&#x3D;EXPENSE_TYPE 时，值为 MEAL（工作餐） 当target_type&#x3D;RULE_GROUP_AGGREGATION 时，值为费控规则聚合ID 当target_type&#x3D;INSTITUTION 时，值为制度ID
        /// </summary>
        /// <value>额度维度ID 当 target_type&#x3D;EXPENSE_TYPE 时，值为 MEAL（工作餐） 当target_type&#x3D;RULE_GROUP_AGGREGATION 时，值为费控规则聚合ID 当target_type&#x3D;INSTITUTION 时，值为制度ID</value>
        [DataMember(Name = "target_id", EmitDefaultValue = false)]
        public string TargetId { get; set; }

        /// <summary>
        /// 额度维度 枚举值： EXPENSE_TYPE（费用类型维度）， RULE_GROUP_AGGREGATION（规则聚合维度）， INSTITUTION（制度维度）
        /// </summary>
        /// <value>额度维度 枚举值： EXPENSE_TYPE（费用类型维度）， RULE_GROUP_AGGREGATION（规则聚合维度）， INSTITUTION（制度维度）</value>
        [DataMember(Name = "target_type", EmitDefaultValue = false)]
        public string TargetType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceExpensecontrolQuotaCreateModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
            sb.Append("  EffectiveStartDate: ").Append(EffectiveStartDate).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  OuterSourceId: ").Append(OuterSourceId).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  OwnerOpenId: ").Append(OwnerOpenId).Append("\n");
            sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  QuotaType: ").Append(QuotaType).Append("\n");
            sb.Append("  QuotaValue: ").Append(QuotaValue).Append("\n");
            sb.Append("  ShareMode: ").Append(ShareMode).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceExpensecontrolQuotaCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceExpensecontrolQuotaCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceExpensecontrolQuotaCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceExpensecontrolQuotaCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.EffectiveEndDate == input.EffectiveEndDate ||
                    (this.EffectiveEndDate != null &&
                    this.EffectiveEndDate.Equals(input.EffectiveEndDate))
                ) && 
                (
                    this.EffectiveStartDate == input.EffectiveStartDate ||
                    (this.EffectiveStartDate != null &&
                    this.EffectiveStartDate.Equals(input.EffectiveStartDate))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.OuterSourceId == input.OuterSourceId ||
                    (this.OuterSourceId != null &&
                    this.OuterSourceId.Equals(input.OuterSourceId))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.OwnerOpenId == input.OwnerOpenId ||
                    (this.OwnerOpenId != null &&
                    this.OwnerOpenId.Equals(input.OwnerOpenId))
                ) && 
                (
                    this.OwnerType == input.OwnerType ||
                    (this.OwnerType != null &&
                    this.OwnerType.Equals(input.OwnerType))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.QuotaType == input.QuotaType ||
                    (this.QuotaType != null &&
                    this.QuotaType.Equals(input.QuotaType))
                ) && 
                (
                    this.QuotaValue == input.QuotaValue ||
                    (this.QuotaValue != null &&
                    this.QuotaValue.Equals(input.QuotaValue))
                ) && 
                (
                    this.ShareMode == input.ShareMode ||
                    (this.ShareMode != null &&
                    this.ShareMode.Equals(input.ShareMode))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.EffectiveEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveEndDate.GetHashCode();
                }
                if (this.EffectiveStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveStartDate.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.OuterSourceId != null)
                {
                    hashCode = (hashCode * 59) + this.OuterSourceId.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.OwnerOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerOpenId.GetHashCode();
                }
                if (this.OwnerType != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerType.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.QuotaType != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaType.GetHashCode();
                }
                if (this.QuotaValue != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaValue.GetHashCode();
                }
                if (this.ShareMode != null)
                {
                    hashCode = (hashCode * 59) + this.ShareMode.GetHashCode();
                }
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                if (this.TargetType != null)
                {
                    hashCode = (hashCode * 59) + this.TargetType.GetHashCode();
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
