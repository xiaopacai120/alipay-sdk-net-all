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
    /// JointAccountMemberDTO
    /// </summary>
    [DataContract(Name = "JointAccountMemberDTO")]
    public partial class JointAccountMemberDTO : IEquatable<JointAccountMemberDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JointAccountMemberDTO" /> class.
        /// </summary>
        /// <param name="accountQuota">accountQuota.</param>
        /// <param name="memberExtInfo">memberExtInfo.</param>
        /// <param name="name">姓名，脱敏输出.</param>
        /// <param name="openId">用户openId.</param>
        /// <param name="status">成员状态.</param>
        /// <param name="userId">用户会员号.</param>
        public JointAccountMemberDTO(JointAccountQuotaDTO accountQuota = default(JointAccountQuotaDTO), MemberExtInfo memberExtInfo = default(MemberExtInfo), string name = default(string), string openId = default(string), string status = default(string), string userId = default(string))
        {
            this.AccountQuota = accountQuota;
            this.MemberExtInfo = memberExtInfo;
            this.Name = name;
            this.OpenId = openId;
            this.Status = status;
            this.UserId = userId;
        }

        /// <summary>
        /// Gets or Sets AccountQuota
        /// </summary>
        [DataMember(Name = "account_quota", EmitDefaultValue = false)]
        public JointAccountQuotaDTO AccountQuota { get; set; }

        /// <summary>
        /// Gets or Sets MemberExtInfo
        /// </summary>
        [DataMember(Name = "member_ext_info", EmitDefaultValue = false)]
        public MemberExtInfo MemberExtInfo { get; set; }

        /// <summary>
        /// 姓名，脱敏输出
        /// </summary>
        /// <value>姓名，脱敏输出</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 用户openId
        /// </summary>
        /// <value>用户openId</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 成员状态
        /// </summary>
        /// <value>成员状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 用户会员号
        /// </summary>
        /// <value>用户会员号</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JointAccountMemberDTO {\n");
            sb.Append("  AccountQuota: ").Append(AccountQuota).Append("\n");
            sb.Append("  MemberExtInfo: ").Append(MemberExtInfo).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as JointAccountMemberDTO);
        }

        /// <summary>
        /// Returns true if JointAccountMemberDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of JointAccountMemberDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JointAccountMemberDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountQuota == input.AccountQuota ||
                    (this.AccountQuota != null &&
                    this.AccountQuota.Equals(input.AccountQuota))
                ) && 
                (
                    this.MemberExtInfo == input.MemberExtInfo ||
                    (this.MemberExtInfo != null &&
                    this.MemberExtInfo.Equals(input.MemberExtInfo))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.AccountQuota != null)
                {
                    hashCode = (hashCode * 59) + this.AccountQuota.GetHashCode();
                }
                if (this.MemberExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.MemberExtInfo.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
