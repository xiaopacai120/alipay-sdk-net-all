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
    /// AlipayOpenViolationViolationdetailQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenViolationViolationdetailQueryResponseModel")]
    public partial class AlipayOpenViolationViolationdetailQueryResponseModel : IEquatable<AlipayOpenViolationViolationdetailQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenViolationViolationdetailQueryResponseModel" /> class.
        /// </summary>
        /// <param name="appealDeadLine">申诉截止日期。 即商户可进行申诉的截止日期，若超过该时间未申诉或申诉不通过，平台不提供申诉机会，维持原处罚结果；若该时间内完成申诉且申诉通过，平台将撤销对商户的处罚.</param>
        /// <param name="appealReplyRecords">商家申诉记录.</param>
        /// <param name="canAppeal">商家是否可以申诉.</param>
        /// <param name="canRectify">商家是否可以整改.</param>
        /// <param name="punishAction">处罚动作及有效期.</param>
        /// <param name="rectifyDeadLine">截止整改时间。即商户可进行整改的截止日期，若超过该时间未整改或整改不通过，平台将对商户进行处罚，若该时间内完成整改且整改通过，平台对商户不处罚.</param>
        /// <param name="rectifyReplyRecords">商家整改记录.</param>
        /// <param name="status">违规工单状态枚举： PUNISH_DONE：处罚生效中 PUNISH_APPEAL_REVOKED：处罚已撤销 PUNISH_INVALID_REVOKED：处罚已到期 WAITING_RECTIFY：待整改  RECTIFY_AUDITOR_PROCESSING：整改审核中 RECTIFY_REJECTED：整改不通过 RECTIFY_PASSED：整改通过 RECTIFY_TIMEOUT ：整改已超时.</param>
        /// <param name="surplusAppealCnt">剩余申诉次数。 即在申诉截止日期内，平台允许商家申诉的次数，当商户提交申诉但申诉未通过时，剩余申诉次数减1，当整改次数为0，不管是否在整改截止日期内，平台将对商户进行处罚.</param>
        /// <param name="surplusRectifyCnt">剩余整改次数。即在整改截止日期内，平台允许商家整改的次数，当商户提交整改但整改未通过时，剩余整改次数减1，当整改次数为0，不管是否在整改截止日期内，平台将对商户进行处罚.</param>
        /// <param name="targetId">违规对象ID.</param>
        /// <param name="targetName">违规对象名称.</param>
        /// <param name="targetType">违规对象类型 小程序ID:APPID 生活号ID:PUBLICID.</param>
        /// <param name="violationEvidence">平台判定商家违规凭证.</param>
        /// <param name="violationReason">违规原因.</param>
        /// <param name="violationRecordId">支付宝侧生成的违规记录唯一标识.</param>
        /// <param name="violationTime">违规时间.</param>
        /// <param name="violationType">即平台依据平台规范/规则，判定商户的违规类型.</param>
        public AlipayOpenViolationViolationdetailQueryResponseModel(string appealDeadLine = default(string), List<ReplyRecord> appealReplyRecords = default(List<ReplyRecord>), bool canAppeal = default(bool), bool canRectify = default(bool), List<string> punishAction = default(List<string>), string rectifyDeadLine = default(string), List<ReplyRecord> rectifyReplyRecords = default(List<ReplyRecord>), string status = default(string), string surplusAppealCnt = default(string), string surplusRectifyCnt = default(string), string targetId = default(string), string targetName = default(string), string targetType = default(string), List<AuditEvidenceInfo> violationEvidence = default(List<AuditEvidenceInfo>), string violationReason = default(string), string violationRecordId = default(string), string violationTime = default(string), string violationType = default(string))
        {
            this.AppealDeadLine = appealDeadLine;
            this.AppealReplyRecords = appealReplyRecords;
            this.CanAppeal = canAppeal;
            this.CanRectify = canRectify;
            this.PunishAction = punishAction;
            this.RectifyDeadLine = rectifyDeadLine;
            this.RectifyReplyRecords = rectifyReplyRecords;
            this.Status = status;
            this.SurplusAppealCnt = surplusAppealCnt;
            this.SurplusRectifyCnt = surplusRectifyCnt;
            this.TargetId = targetId;
            this.TargetName = targetName;
            this.TargetType = targetType;
            this.ViolationEvidence = violationEvidence;
            this.ViolationReason = violationReason;
            this.ViolationRecordId = violationRecordId;
            this.ViolationTime = violationTime;
            this.ViolationType = violationType;
        }

        /// <summary>
        /// 申诉截止日期。 即商户可进行申诉的截止日期，若超过该时间未申诉或申诉不通过，平台不提供申诉机会，维持原处罚结果；若该时间内完成申诉且申诉通过，平台将撤销对商户的处罚
        /// </summary>
        /// <value>申诉截止日期。 即商户可进行申诉的截止日期，若超过该时间未申诉或申诉不通过，平台不提供申诉机会，维持原处罚结果；若该时间内完成申诉且申诉通过，平台将撤销对商户的处罚</value>
        [DataMember(Name = "appeal_dead_line", EmitDefaultValue = false)]
        public string AppealDeadLine { get; set; }

        /// <summary>
        /// 商家申诉记录
        /// </summary>
        /// <value>商家申诉记录</value>
        [DataMember(Name = "appeal_reply_records", EmitDefaultValue = false)]
        public List<ReplyRecord> AppealReplyRecords { get; set; }

        /// <summary>
        /// 商家是否可以申诉
        /// </summary>
        /// <value>商家是否可以申诉</value>
        [DataMember(Name = "can_appeal", EmitDefaultValue = true)]
        public bool CanAppeal { get; set; }

        /// <summary>
        /// 商家是否可以整改
        /// </summary>
        /// <value>商家是否可以整改</value>
        [DataMember(Name = "can_rectify", EmitDefaultValue = true)]
        public bool CanRectify { get; set; }

        /// <summary>
        /// 处罚动作及有效期
        /// </summary>
        /// <value>处罚动作及有效期</value>
        [DataMember(Name = "punish_action", EmitDefaultValue = false)]
        public List<string> PunishAction { get; set; }

        /// <summary>
        /// 截止整改时间。即商户可进行整改的截止日期，若超过该时间未整改或整改不通过，平台将对商户进行处罚，若该时间内完成整改且整改通过，平台对商户不处罚
        /// </summary>
        /// <value>截止整改时间。即商户可进行整改的截止日期，若超过该时间未整改或整改不通过，平台将对商户进行处罚，若该时间内完成整改且整改通过，平台对商户不处罚</value>
        [DataMember(Name = "rectify_dead_line", EmitDefaultValue = false)]
        public string RectifyDeadLine { get; set; }

        /// <summary>
        /// 商家整改记录
        /// </summary>
        /// <value>商家整改记录</value>
        [DataMember(Name = "rectify_reply_records", EmitDefaultValue = false)]
        public List<ReplyRecord> RectifyReplyRecords { get; set; }

        /// <summary>
        /// 违规工单状态枚举： PUNISH_DONE：处罚生效中 PUNISH_APPEAL_REVOKED：处罚已撤销 PUNISH_INVALID_REVOKED：处罚已到期 WAITING_RECTIFY：待整改  RECTIFY_AUDITOR_PROCESSING：整改审核中 RECTIFY_REJECTED：整改不通过 RECTIFY_PASSED：整改通过 RECTIFY_TIMEOUT ：整改已超时
        /// </summary>
        /// <value>违规工单状态枚举： PUNISH_DONE：处罚生效中 PUNISH_APPEAL_REVOKED：处罚已撤销 PUNISH_INVALID_REVOKED：处罚已到期 WAITING_RECTIFY：待整改  RECTIFY_AUDITOR_PROCESSING：整改审核中 RECTIFY_REJECTED：整改不通过 RECTIFY_PASSED：整改通过 RECTIFY_TIMEOUT ：整改已超时</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 剩余申诉次数。 即在申诉截止日期内，平台允许商家申诉的次数，当商户提交申诉但申诉未通过时，剩余申诉次数减1，当整改次数为0，不管是否在整改截止日期内，平台将对商户进行处罚
        /// </summary>
        /// <value>剩余申诉次数。 即在申诉截止日期内，平台允许商家申诉的次数，当商户提交申诉但申诉未通过时，剩余申诉次数减1，当整改次数为0，不管是否在整改截止日期内，平台将对商户进行处罚</value>
        [DataMember(Name = "surplus_appeal_cnt", EmitDefaultValue = false)]
        public string SurplusAppealCnt { get; set; }

        /// <summary>
        /// 剩余整改次数。即在整改截止日期内，平台允许商家整改的次数，当商户提交整改但整改未通过时，剩余整改次数减1，当整改次数为0，不管是否在整改截止日期内，平台将对商户进行处罚
        /// </summary>
        /// <value>剩余整改次数。即在整改截止日期内，平台允许商家整改的次数，当商户提交整改但整改未通过时，剩余整改次数减1，当整改次数为0，不管是否在整改截止日期内，平台将对商户进行处罚</value>
        [DataMember(Name = "surplus_rectify_cnt", EmitDefaultValue = false)]
        public string SurplusRectifyCnt { get; set; }

        /// <summary>
        /// 违规对象ID
        /// </summary>
        /// <value>违规对象ID</value>
        [DataMember(Name = "target_id", EmitDefaultValue = false)]
        public string TargetId { get; set; }

        /// <summary>
        /// 违规对象名称
        /// </summary>
        /// <value>违规对象名称</value>
        [DataMember(Name = "target_name", EmitDefaultValue = false)]
        public string TargetName { get; set; }

        /// <summary>
        /// 违规对象类型 小程序ID:APPID 生活号ID:PUBLICID
        /// </summary>
        /// <value>违规对象类型 小程序ID:APPID 生活号ID:PUBLICID</value>
        [DataMember(Name = "target_type", EmitDefaultValue = false)]
        public string TargetType { get; set; }

        /// <summary>
        /// 平台判定商家违规凭证
        /// </summary>
        /// <value>平台判定商家违规凭证</value>
        [DataMember(Name = "violation_evidence", EmitDefaultValue = false)]
        public List<AuditEvidenceInfo> ViolationEvidence { get; set; }

        /// <summary>
        /// 违规原因
        /// </summary>
        /// <value>违规原因</value>
        [DataMember(Name = "violation_reason", EmitDefaultValue = false)]
        public string ViolationReason { get; set; }

        /// <summary>
        /// 支付宝侧生成的违规记录唯一标识
        /// </summary>
        /// <value>支付宝侧生成的违规记录唯一标识</value>
        [DataMember(Name = "violation_record_id", EmitDefaultValue = false)]
        public string ViolationRecordId { get; set; }

        /// <summary>
        /// 违规时间
        /// </summary>
        /// <value>违规时间</value>
        [DataMember(Name = "violation_time", EmitDefaultValue = false)]
        public string ViolationTime { get; set; }

        /// <summary>
        /// 即平台依据平台规范/规则，判定商户的违规类型
        /// </summary>
        /// <value>即平台依据平台规范/规则，判定商户的违规类型</value>
        [DataMember(Name = "violation_type", EmitDefaultValue = false)]
        public string ViolationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenViolationViolationdetailQueryResponseModel {\n");
            sb.Append("  AppealDeadLine: ").Append(AppealDeadLine).Append("\n");
            sb.Append("  AppealReplyRecords: ").Append(AppealReplyRecords).Append("\n");
            sb.Append("  CanAppeal: ").Append(CanAppeal).Append("\n");
            sb.Append("  CanRectify: ").Append(CanRectify).Append("\n");
            sb.Append("  PunishAction: ").Append(PunishAction).Append("\n");
            sb.Append("  RectifyDeadLine: ").Append(RectifyDeadLine).Append("\n");
            sb.Append("  RectifyReplyRecords: ").Append(RectifyReplyRecords).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SurplusAppealCnt: ").Append(SurplusAppealCnt).Append("\n");
            sb.Append("  SurplusRectifyCnt: ").Append(SurplusRectifyCnt).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  TargetName: ").Append(TargetName).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
            sb.Append("  ViolationEvidence: ").Append(ViolationEvidence).Append("\n");
            sb.Append("  ViolationReason: ").Append(ViolationReason).Append("\n");
            sb.Append("  ViolationRecordId: ").Append(ViolationRecordId).Append("\n");
            sb.Append("  ViolationTime: ").Append(ViolationTime).Append("\n");
            sb.Append("  ViolationType: ").Append(ViolationType).Append("\n");
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
            return this.Equals(input as AlipayOpenViolationViolationdetailQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenViolationViolationdetailQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenViolationViolationdetailQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenViolationViolationdetailQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppealDeadLine == input.AppealDeadLine ||
                    (this.AppealDeadLine != null &&
                    this.AppealDeadLine.Equals(input.AppealDeadLine))
                ) && 
                (
                    this.AppealReplyRecords == input.AppealReplyRecords ||
                    this.AppealReplyRecords != null &&
                    input.AppealReplyRecords != null &&
                    this.AppealReplyRecords.SequenceEqual(input.AppealReplyRecords)
                ) && 
                (
                    this.CanAppeal == input.CanAppeal ||
                    this.CanAppeal.Equals(input.CanAppeal)
                ) && 
                (
                    this.CanRectify == input.CanRectify ||
                    this.CanRectify.Equals(input.CanRectify)
                ) && 
                (
                    this.PunishAction == input.PunishAction ||
                    this.PunishAction != null &&
                    input.PunishAction != null &&
                    this.PunishAction.SequenceEqual(input.PunishAction)
                ) && 
                (
                    this.RectifyDeadLine == input.RectifyDeadLine ||
                    (this.RectifyDeadLine != null &&
                    this.RectifyDeadLine.Equals(input.RectifyDeadLine))
                ) && 
                (
                    this.RectifyReplyRecords == input.RectifyReplyRecords ||
                    this.RectifyReplyRecords != null &&
                    input.RectifyReplyRecords != null &&
                    this.RectifyReplyRecords.SequenceEqual(input.RectifyReplyRecords)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SurplusAppealCnt == input.SurplusAppealCnt ||
                    (this.SurplusAppealCnt != null &&
                    this.SurplusAppealCnt.Equals(input.SurplusAppealCnt))
                ) && 
                (
                    this.SurplusRectifyCnt == input.SurplusRectifyCnt ||
                    (this.SurplusRectifyCnt != null &&
                    this.SurplusRectifyCnt.Equals(input.SurplusRectifyCnt))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) && 
                (
                    this.TargetName == input.TargetName ||
                    (this.TargetName != null &&
                    this.TargetName.Equals(input.TargetName))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
                ) && 
                (
                    this.ViolationEvidence == input.ViolationEvidence ||
                    this.ViolationEvidence != null &&
                    input.ViolationEvidence != null &&
                    this.ViolationEvidence.SequenceEqual(input.ViolationEvidence)
                ) && 
                (
                    this.ViolationReason == input.ViolationReason ||
                    (this.ViolationReason != null &&
                    this.ViolationReason.Equals(input.ViolationReason))
                ) && 
                (
                    this.ViolationRecordId == input.ViolationRecordId ||
                    (this.ViolationRecordId != null &&
                    this.ViolationRecordId.Equals(input.ViolationRecordId))
                ) && 
                (
                    this.ViolationTime == input.ViolationTime ||
                    (this.ViolationTime != null &&
                    this.ViolationTime.Equals(input.ViolationTime))
                ) && 
                (
                    this.ViolationType == input.ViolationType ||
                    (this.ViolationType != null &&
                    this.ViolationType.Equals(input.ViolationType))
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
                if (this.AppealDeadLine != null)
                {
                    hashCode = (hashCode * 59) + this.AppealDeadLine.GetHashCode();
                }
                if (this.AppealReplyRecords != null)
                {
                    hashCode = (hashCode * 59) + this.AppealReplyRecords.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CanAppeal.GetHashCode();
                hashCode = (hashCode * 59) + this.CanRectify.GetHashCode();
                if (this.PunishAction != null)
                {
                    hashCode = (hashCode * 59) + this.PunishAction.GetHashCode();
                }
                if (this.RectifyDeadLine != null)
                {
                    hashCode = (hashCode * 59) + this.RectifyDeadLine.GetHashCode();
                }
                if (this.RectifyReplyRecords != null)
                {
                    hashCode = (hashCode * 59) + this.RectifyReplyRecords.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.SurplusAppealCnt != null)
                {
                    hashCode = (hashCode * 59) + this.SurplusAppealCnt.GetHashCode();
                }
                if (this.SurplusRectifyCnt != null)
                {
                    hashCode = (hashCode * 59) + this.SurplusRectifyCnt.GetHashCode();
                }
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                if (this.TargetName != null)
                {
                    hashCode = (hashCode * 59) + this.TargetName.GetHashCode();
                }
                if (this.TargetType != null)
                {
                    hashCode = (hashCode * 59) + this.TargetType.GetHashCode();
                }
                if (this.ViolationEvidence != null)
                {
                    hashCode = (hashCode * 59) + this.ViolationEvidence.GetHashCode();
                }
                if (this.ViolationReason != null)
                {
                    hashCode = (hashCode * 59) + this.ViolationReason.GetHashCode();
                }
                if (this.ViolationRecordId != null)
                {
                    hashCode = (hashCode * 59) + this.ViolationRecordId.GetHashCode();
                }
                if (this.ViolationTime != null)
                {
                    hashCode = (hashCode * 59) + this.ViolationTime.GetHashCode();
                }
                if (this.ViolationType != null)
                {
                    hashCode = (hashCode * 59) + this.ViolationType.GetHashCode();
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
