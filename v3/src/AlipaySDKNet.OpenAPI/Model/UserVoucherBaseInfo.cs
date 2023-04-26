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
    /// UserVoucherBaseInfo
    /// </summary>
    [DataContract(Name = "UserVoucherBaseInfo")]
    public partial class UserVoucherBaseInfo : IEquatable<UserVoucherBaseInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVoucherBaseInfo" /> class.
        /// </summary>
        /// <param name="associateTradeNo">若商家券操作过关联商户订单信息，则该字段返回商家券已关联的商户订单号。.</param>
        /// <param name="createTime">领券时间.</param>
        /// <param name="validBeginTime">券可使用的开始时间。 格式为：yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="validEndTime">券可使用的结束时间。 格式为yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="voucherId">支付宝券id.</param>
        /// <param name="voucherMaxUseTimes">券最大核销次数.</param>
        /// <param name="voucherName">券名称.</param>
        /// <param name="voucherStatus">券状态。SENDED:可用 USED:已核销(即完全使用), EXPIRED:已过期(只能查询6个月内数据).</param>
        /// <param name="voucherUsedTimes">券已核销次数.</param>
        public UserVoucherBaseInfo(string associateTradeNo = default(string), string createTime = default(string), string validBeginTime = default(string), string validEndTime = default(string), string voucherId = default(string), int voucherMaxUseTimes = default(int), string voucherName = default(string), string voucherStatus = default(string), int voucherUsedTimes = default(int))
        {
            this.AssociateTradeNo = associateTradeNo;
            this.CreateTime = createTime;
            this.ValidBeginTime = validBeginTime;
            this.ValidEndTime = validEndTime;
            this.VoucherId = voucherId;
            this.VoucherMaxUseTimes = voucherMaxUseTimes;
            this.VoucherName = voucherName;
            this.VoucherStatus = voucherStatus;
            this.VoucherUsedTimes = voucherUsedTimes;
        }

        /// <summary>
        /// 若商家券操作过关联商户订单信息，则该字段返回商家券已关联的商户订单号。
        /// </summary>
        /// <value>若商家券操作过关联商户订单信息，则该字段返回商家券已关联的商户订单号。</value>
        [DataMember(Name = "associate_trade_no", EmitDefaultValue = false)]
        public string AssociateTradeNo { get; set; }

        /// <summary>
        /// 领券时间
        /// </summary>
        /// <value>领券时间</value>
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 券可使用的开始时间。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>券可使用的开始时间。 格式为：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "valid_begin_time", EmitDefaultValue = false)]
        public string ValidBeginTime { get; set; }

        /// <summary>
        /// 券可使用的结束时间。 格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>券可使用的结束时间。 格式为yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "valid_end_time", EmitDefaultValue = false)]
        public string ValidEndTime { get; set; }

        /// <summary>
        /// 支付宝券id
        /// </summary>
        /// <value>支付宝券id</value>
        [DataMember(Name = "voucher_id", EmitDefaultValue = false)]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券最大核销次数
        /// </summary>
        /// <value>券最大核销次数</value>
        [DataMember(Name = "voucher_max_use_times", EmitDefaultValue = false)]
        public int VoucherMaxUseTimes { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        /// <value>券名称</value>
        [DataMember(Name = "voucher_name", EmitDefaultValue = false)]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券状态。SENDED:可用 USED:已核销(即完全使用), EXPIRED:已过期(只能查询6个月内数据)
        /// </summary>
        /// <value>券状态。SENDED:可用 USED:已核销(即完全使用), EXPIRED:已过期(只能查询6个月内数据)</value>
        [DataMember(Name = "voucher_status", EmitDefaultValue = false)]
        public string VoucherStatus { get; set; }

        /// <summary>
        /// 券已核销次数
        /// </summary>
        /// <value>券已核销次数</value>
        [DataMember(Name = "voucher_used_times", EmitDefaultValue = false)]
        public int VoucherUsedTimes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserVoucherBaseInfo {\n");
            sb.Append("  AssociateTradeNo: ").Append(AssociateTradeNo).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  ValidBeginTime: ").Append(ValidBeginTime).Append("\n");
            sb.Append("  ValidEndTime: ").Append(ValidEndTime).Append("\n");
            sb.Append("  VoucherId: ").Append(VoucherId).Append("\n");
            sb.Append("  VoucherMaxUseTimes: ").Append(VoucherMaxUseTimes).Append("\n");
            sb.Append("  VoucherName: ").Append(VoucherName).Append("\n");
            sb.Append("  VoucherStatus: ").Append(VoucherStatus).Append("\n");
            sb.Append("  VoucherUsedTimes: ").Append(VoucherUsedTimes).Append("\n");
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
            return this.Equals(input as UserVoucherBaseInfo);
        }

        /// <summary>
        /// Returns true if UserVoucherBaseInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of UserVoucherBaseInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserVoucherBaseInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssociateTradeNo == input.AssociateTradeNo ||
                    (this.AssociateTradeNo != null &&
                    this.AssociateTradeNo.Equals(input.AssociateTradeNo))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.ValidBeginTime == input.ValidBeginTime ||
                    (this.ValidBeginTime != null &&
                    this.ValidBeginTime.Equals(input.ValidBeginTime))
                ) && 
                (
                    this.ValidEndTime == input.ValidEndTime ||
                    (this.ValidEndTime != null &&
                    this.ValidEndTime.Equals(input.ValidEndTime))
                ) && 
                (
                    this.VoucherId == input.VoucherId ||
                    (this.VoucherId != null &&
                    this.VoucherId.Equals(input.VoucherId))
                ) && 
                (
                    this.VoucherMaxUseTimes == input.VoucherMaxUseTimes ||
                    this.VoucherMaxUseTimes.Equals(input.VoucherMaxUseTimes)
                ) && 
                (
                    this.VoucherName == input.VoucherName ||
                    (this.VoucherName != null &&
                    this.VoucherName.Equals(input.VoucherName))
                ) && 
                (
                    this.VoucherStatus == input.VoucherStatus ||
                    (this.VoucherStatus != null &&
                    this.VoucherStatus.Equals(input.VoucherStatus))
                ) && 
                (
                    this.VoucherUsedTimes == input.VoucherUsedTimes ||
                    this.VoucherUsedTimes.Equals(input.VoucherUsedTimes)
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
                if (this.AssociateTradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.AssociateTradeNo.GetHashCode();
                }
                if (this.CreateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreateTime.GetHashCode();
                }
                if (this.ValidBeginTime != null)
                {
                    hashCode = (hashCode * 59) + this.ValidBeginTime.GetHashCode();
                }
                if (this.ValidEndTime != null)
                {
                    hashCode = (hashCode * 59) + this.ValidEndTime.GetHashCode();
                }
                if (this.VoucherId != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VoucherMaxUseTimes.GetHashCode();
                if (this.VoucherName != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherName.GetHashCode();
                }
                if (this.VoucherStatus != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherStatus.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VoucherUsedTimes.GetHashCode();
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
