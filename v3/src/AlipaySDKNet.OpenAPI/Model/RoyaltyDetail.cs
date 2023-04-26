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
    /// RoyaltyDetail
    /// </summary>
    [DataContract(Name = "RoyaltyDetail")]
    public partial class RoyaltyDetail : IEquatable<RoyaltyDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoyaltyDetail" /> class.
        /// </summary>
        /// <param name="amount">分账金额.</param>
        /// <param name="detailId">支付宝分账明细单号，每笔分账业务执行的明细单号.</param>
        /// <param name="errorCode">分账失败错误码，只在分账失败时返回.</param>
        /// <param name="errorDesc">分账错误描述信息.</param>
        /// <param name="executeDt">分账执行时间.</param>
        /// <param name="operationType">分账操作类型。有以下几种类型： replenish(补差)、replenish_refund(退补差)、transfer(分账)、transfer_refund(退分账).</param>
        /// <param name="state">分账状态，SUCCESS成功，FAIL失败，PROCESSING处理中.</param>
        /// <param name="transIn">分账转入账号，只有在operation_type为replenish_refund(退补差)，transfer(分账)才返回该字段或trans_in_open_id。trans_in_open_id为分账转入方的openId，当trans_in_open_id不为空的时候，请优先使用trans_in_open_id。.</param>
        /// <param name="transInOpenId">分账转入方的OpenId，OpenId为用户在该应用下支付宝的唯一用户标识。.</param>
        /// <param name="transInType">分账转入账号类型，userId表示是支付宝账号对应的支付宝唯一用户号，loginName表示是支付宝登录号，secondMerchantID表示是二级商户id。 只有在operation_type为replenish_refund(退补差)，transfer(分账)才返回该字段.</param>
        /// <param name="transOut">分账转出账号，只有在operation_type为replenish(补差),transfer_refund(退分账)类型才返回该字段或trans_out_open_id字段。trans_out_open_id字段为分账转出方的openId，当trans_out_open_id 字段不为空时，请优先使用trans_out_open_id。.</param>
        /// <param name="transOutOpenId">分账转出方的OpenId，OpenId为用户在该应用下支付宝内的唯一用户标识。.</param>
        /// <param name="transOutType">分账转出账号类型，userId表示是支付宝账号对应的支付宝唯一用户号，loginName表示是支付宝登录号，secondMerchantID表示是二级商户id。 只有在operation_type为replenish(补差)，transfer_refund(退分账)类型才返回该字段.</param>
        public RoyaltyDetail(string amount = default(string), string detailId = default(string), string errorCode = default(string), string errorDesc = default(string), string executeDt = default(string), string operationType = default(string), string state = default(string), string transIn = default(string), string transInOpenId = default(string), string transInType = default(string), string transOut = default(string), string transOutOpenId = default(string), string transOutType = default(string))
        {
            this.Amount = amount;
            this.DetailId = detailId;
            this.ErrorCode = errorCode;
            this.ErrorDesc = errorDesc;
            this.ExecuteDt = executeDt;
            this.OperationType = operationType;
            this.State = state;
            this.TransIn = transIn;
            this.TransInOpenId = transInOpenId;
            this.TransInType = transInType;
            this.TransOut = transOut;
            this.TransOutOpenId = transOutOpenId;
            this.TransOutType = transOutType;
        }

        /// <summary>
        /// 分账金额
        /// </summary>
        /// <value>分账金额</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝分账明细单号，每笔分账业务执行的明细单号
        /// </summary>
        /// <value>支付宝分账明细单号，每笔分账业务执行的明细单号</value>
        [DataMember(Name = "detail_id", EmitDefaultValue = false)]
        public string DetailId { get; set; }

        /// <summary>
        /// 分账失败错误码，只在分账失败时返回
        /// </summary>
        /// <value>分账失败错误码，只在分账失败时返回</value>
        [DataMember(Name = "error_code", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 分账错误描述信息
        /// </summary>
        /// <value>分账错误描述信息</value>
        [DataMember(Name = "error_desc", EmitDefaultValue = false)]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 分账执行时间
        /// </summary>
        /// <value>分账执行时间</value>
        [DataMember(Name = "execute_dt", EmitDefaultValue = false)]
        public string ExecuteDt { get; set; }

        /// <summary>
        /// 分账操作类型。有以下几种类型： replenish(补差)、replenish_refund(退补差)、transfer(分账)、transfer_refund(退分账)
        /// </summary>
        /// <value>分账操作类型。有以下几种类型： replenish(补差)、replenish_refund(退补差)、transfer(分账)、transfer_refund(退分账)</value>
        [DataMember(Name = "operation_type", EmitDefaultValue = false)]
        public string OperationType { get; set; }

        /// <summary>
        /// 分账状态，SUCCESS成功，FAIL失败，PROCESSING处理中
        /// </summary>
        /// <value>分账状态，SUCCESS成功，FAIL失败，PROCESSING处理中</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// 分账转入账号，只有在operation_type为replenish_refund(退补差)，transfer(分账)才返回该字段或trans_in_open_id。trans_in_open_id为分账转入方的openId，当trans_in_open_id不为空的时候，请优先使用trans_in_open_id。
        /// </summary>
        /// <value>分账转入账号，只有在operation_type为replenish_refund(退补差)，transfer(分账)才返回该字段或trans_in_open_id。trans_in_open_id为分账转入方的openId，当trans_in_open_id不为空的时候，请优先使用trans_in_open_id。</value>
        [DataMember(Name = "trans_in", EmitDefaultValue = false)]
        public string TransIn { get; set; }

        /// <summary>
        /// 分账转入方的OpenId，OpenId为用户在该应用下支付宝的唯一用户标识。
        /// </summary>
        /// <value>分账转入方的OpenId，OpenId为用户在该应用下支付宝的唯一用户标识。</value>
        [DataMember(Name = "trans_in_open_id", EmitDefaultValue = false)]
        public string TransInOpenId { get; set; }

        /// <summary>
        /// 分账转入账号类型，userId表示是支付宝账号对应的支付宝唯一用户号，loginName表示是支付宝登录号，secondMerchantID表示是二级商户id。 只有在operation_type为replenish_refund(退补差)，transfer(分账)才返回该字段
        /// </summary>
        /// <value>分账转入账号类型，userId表示是支付宝账号对应的支付宝唯一用户号，loginName表示是支付宝登录号，secondMerchantID表示是二级商户id。 只有在operation_type为replenish_refund(退补差)，transfer(分账)才返回该字段</value>
        [DataMember(Name = "trans_in_type", EmitDefaultValue = false)]
        public string TransInType { get; set; }

        /// <summary>
        /// 分账转出账号，只有在operation_type为replenish(补差),transfer_refund(退分账)类型才返回该字段或trans_out_open_id字段。trans_out_open_id字段为分账转出方的openId，当trans_out_open_id 字段不为空时，请优先使用trans_out_open_id。
        /// </summary>
        /// <value>分账转出账号，只有在operation_type为replenish(补差),transfer_refund(退分账)类型才返回该字段或trans_out_open_id字段。trans_out_open_id字段为分账转出方的openId，当trans_out_open_id 字段不为空时，请优先使用trans_out_open_id。</value>
        [DataMember(Name = "trans_out", EmitDefaultValue = false)]
        public string TransOut { get; set; }

        /// <summary>
        /// 分账转出方的OpenId，OpenId为用户在该应用下支付宝内的唯一用户标识。
        /// </summary>
        /// <value>分账转出方的OpenId，OpenId为用户在该应用下支付宝内的唯一用户标识。</value>
        [DataMember(Name = "trans_out_open_id", EmitDefaultValue = false)]
        public string TransOutOpenId { get; set; }

        /// <summary>
        /// 分账转出账号类型，userId表示是支付宝账号对应的支付宝唯一用户号，loginName表示是支付宝登录号，secondMerchantID表示是二级商户id。 只有在operation_type为replenish(补差)，transfer_refund(退分账)类型才返回该字段
        /// </summary>
        /// <value>分账转出账号类型，userId表示是支付宝账号对应的支付宝唯一用户号，loginName表示是支付宝登录号，secondMerchantID表示是二级商户id。 只有在operation_type为replenish(补差)，transfer_refund(退分账)类型才返回该字段</value>
        [DataMember(Name = "trans_out_type", EmitDefaultValue = false)]
        public string TransOutType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RoyaltyDetail {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  DetailId: ").Append(DetailId).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorDesc: ").Append(ErrorDesc).Append("\n");
            sb.Append("  ExecuteDt: ").Append(ExecuteDt).Append("\n");
            sb.Append("  OperationType: ").Append(OperationType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TransIn: ").Append(TransIn).Append("\n");
            sb.Append("  TransInOpenId: ").Append(TransInOpenId).Append("\n");
            sb.Append("  TransInType: ").Append(TransInType).Append("\n");
            sb.Append("  TransOut: ").Append(TransOut).Append("\n");
            sb.Append("  TransOutOpenId: ").Append(TransOutOpenId).Append("\n");
            sb.Append("  TransOutType: ").Append(TransOutType).Append("\n");
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
            return this.Equals(input as RoyaltyDetail);
        }

        /// <summary>
        /// Returns true if RoyaltyDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of RoyaltyDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoyaltyDetail input)
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
                    this.DetailId == input.DetailId ||
                    (this.DetailId != null &&
                    this.DetailId.Equals(input.DetailId))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorDesc == input.ErrorDesc ||
                    (this.ErrorDesc != null &&
                    this.ErrorDesc.Equals(input.ErrorDesc))
                ) && 
                (
                    this.ExecuteDt == input.ExecuteDt ||
                    (this.ExecuteDt != null &&
                    this.ExecuteDt.Equals(input.ExecuteDt))
                ) && 
                (
                    this.OperationType == input.OperationType ||
                    (this.OperationType != null &&
                    this.OperationType.Equals(input.OperationType))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.TransIn == input.TransIn ||
                    (this.TransIn != null &&
                    this.TransIn.Equals(input.TransIn))
                ) && 
                (
                    this.TransInOpenId == input.TransInOpenId ||
                    (this.TransInOpenId != null &&
                    this.TransInOpenId.Equals(input.TransInOpenId))
                ) && 
                (
                    this.TransInType == input.TransInType ||
                    (this.TransInType != null &&
                    this.TransInType.Equals(input.TransInType))
                ) && 
                (
                    this.TransOut == input.TransOut ||
                    (this.TransOut != null &&
                    this.TransOut.Equals(input.TransOut))
                ) && 
                (
                    this.TransOutOpenId == input.TransOutOpenId ||
                    (this.TransOutOpenId != null &&
                    this.TransOutOpenId.Equals(input.TransOutOpenId))
                ) && 
                (
                    this.TransOutType == input.TransOutType ||
                    (this.TransOutType != null &&
                    this.TransOutType.Equals(input.TransOutType))
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
                if (this.DetailId != null)
                {
                    hashCode = (hashCode * 59) + this.DetailId.GetHashCode();
                }
                if (this.ErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                }
                if (this.ErrorDesc != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorDesc.GetHashCode();
                }
                if (this.ExecuteDt != null)
                {
                    hashCode = (hashCode * 59) + this.ExecuteDt.GetHashCode();
                }
                if (this.OperationType != null)
                {
                    hashCode = (hashCode * 59) + this.OperationType.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.TransIn != null)
                {
                    hashCode = (hashCode * 59) + this.TransIn.GetHashCode();
                }
                if (this.TransInOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.TransInOpenId.GetHashCode();
                }
                if (this.TransInType != null)
                {
                    hashCode = (hashCode * 59) + this.TransInType.GetHashCode();
                }
                if (this.TransOut != null)
                {
                    hashCode = (hashCode * 59) + this.TransOut.GetHashCode();
                }
                if (this.TransOutOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.TransOutOpenId.GetHashCode();
                }
                if (this.TransOutType != null)
                {
                    hashCode = (hashCode * 59) + this.TransOutType.GetHashCode();
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
