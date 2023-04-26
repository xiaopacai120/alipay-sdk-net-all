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
    /// AlipayFundJointaccountQuotaQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundJointaccountQuotaQueryResponseModel")]
    public partial class AlipayFundJointaccountQuotaQueryResponseModel : IEquatable<AlipayFundJointaccountQuotaQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountQuotaQueryResponseModel" /> class.
        /// </summary>
        /// <param name="accountId">共同账户ID.</param>
        /// <param name="accountQuota">共同账户额度模型.</param>
        /// <param name="bizScene">场景码.</param>
        /// <param name="memberId">成员ID（如果查询员工才返回）.</param>
        /// <param name="memberOpenId">员工openId.</param>
        /// <param name="productCode">产品码.</param>
        public AlipayFundJointaccountQuotaQueryResponseModel(string accountId = default(string), List<JointAccountQuotaRespDTO> accountQuota = default(List<JointAccountQuotaRespDTO>), string bizScene = default(string), string memberId = default(string), string memberOpenId = default(string), string productCode = default(string))
        {
            this.AccountId = accountId;
            this.AccountQuota = accountQuota;
            this.BizScene = bizScene;
            this.MemberId = memberId;
            this.MemberOpenId = memberOpenId;
            this.ProductCode = productCode;
        }

        /// <summary>
        /// 共同账户ID
        /// </summary>
        /// <value>共同账户ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 共同账户额度模型
        /// </summary>
        /// <value>共同账户额度模型</value>
        [DataMember(Name = "account_quota", EmitDefaultValue = false)]
        public List<JointAccountQuotaRespDTO> AccountQuota { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        /// <value>场景码</value>
        [DataMember(Name = "biz_scene", EmitDefaultValue = false)]
        public string BizScene { get; set; }

        /// <summary>
        /// 成员ID（如果查询员工才返回）
        /// </summary>
        /// <value>成员ID（如果查询员工才返回）</value>
        [DataMember(Name = "member_id", EmitDefaultValue = false)]
        public string MemberId { get; set; }

        /// <summary>
        /// 员工openId
        /// </summary>
        /// <value>员工openId</value>
        [DataMember(Name = "member_open_id", EmitDefaultValue = false)]
        public string MemberOpenId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        /// <value>产品码</value>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundJointaccountQuotaQueryResponseModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountQuota: ").Append(AccountQuota).Append("\n");
            sb.Append("  BizScene: ").Append(BizScene).Append("\n");
            sb.Append("  MemberId: ").Append(MemberId).Append("\n");
            sb.Append("  MemberOpenId: ").Append(MemberOpenId).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
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
            return this.Equals(input as AlipayFundJointaccountQuotaQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundJointaccountQuotaQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundJointaccountQuotaQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundJointaccountQuotaQueryResponseModel input)
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
                    this.AccountQuota == input.AccountQuota ||
                    this.AccountQuota != null &&
                    input.AccountQuota != null &&
                    this.AccountQuota.SequenceEqual(input.AccountQuota)
                ) && 
                (
                    this.BizScene == input.BizScene ||
                    (this.BizScene != null &&
                    this.BizScene.Equals(input.BizScene))
                ) && 
                (
                    this.MemberId == input.MemberId ||
                    (this.MemberId != null &&
                    this.MemberId.Equals(input.MemberId))
                ) && 
                (
                    this.MemberOpenId == input.MemberOpenId ||
                    (this.MemberOpenId != null &&
                    this.MemberOpenId.Equals(input.MemberOpenId))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
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
                if (this.AccountQuota != null)
                {
                    hashCode = (hashCode * 59) + this.AccountQuota.GetHashCode();
                }
                if (this.BizScene != null)
                {
                    hashCode = (hashCode * 59) + this.BizScene.GetHashCode();
                }
                if (this.MemberId != null)
                {
                    hashCode = (hashCode * 59) + this.MemberId.GetHashCode();
                }
                if (this.MemberOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.MemberOpenId.GetHashCode();
                }
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
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
