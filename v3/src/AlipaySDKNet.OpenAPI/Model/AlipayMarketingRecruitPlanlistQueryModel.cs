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
    /// AlipayMarketingRecruitPlanlistQueryModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingRecruitPlanlistQueryModel")]
    public partial class AlipayMarketingRecruitPlanlistQueryModel : IEquatable<AlipayMarketingRecruitPlanlistQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingRecruitPlanlistQueryModel" /> class.
        /// </summary>
        /// <param name="enrollMerchant">enrollMerchant.</param>
        /// <param name="enrollSceneType">活动报名场景配置。  枚举值： VOUCHER：券报名场景查询； MINI_APP：小程序报名场景查询； VOUCHER,MINI_APP：同时进行券报名场景和小程序报名场景的查询；.</param>
        /// <param name="pageNum">第几页，默认1（需要在1和999之间）.</param>
        /// <param name="pageSize">每页记录条数，默认20，需要在1和100之间.</param>
        public AlipayMarketingRecruitPlanlistQueryModel(RecruitEnrollMerchant enrollMerchant = default(RecruitEnrollMerchant), string enrollSceneType = default(string), int pageNum = default(int), int pageSize = default(int))
        {
            this.EnrollMerchant = enrollMerchant;
            this.EnrollSceneType = enrollSceneType;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Gets or Sets EnrollMerchant
        /// </summary>
        [DataMember(Name = "enroll_merchant", EmitDefaultValue = false)]
        public RecruitEnrollMerchant EnrollMerchant { get; set; }

        /// <summary>
        /// 活动报名场景配置。  枚举值： VOUCHER：券报名场景查询； MINI_APP：小程序报名场景查询； VOUCHER,MINI_APP：同时进行券报名场景和小程序报名场景的查询；
        /// </summary>
        /// <value>活动报名场景配置。  枚举值： VOUCHER：券报名场景查询； MINI_APP：小程序报名场景查询； VOUCHER,MINI_APP：同时进行券报名场景和小程序报名场景的查询；</value>
        [DataMember(Name = "enroll_scene_type", EmitDefaultValue = false)]
        public string EnrollSceneType { get; set; }

        /// <summary>
        /// 第几页，默认1（需要在1和999之间）
        /// </summary>
        /// <value>第几页，默认1（需要在1和999之间）</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，默认20，需要在1和100之间
        /// </summary>
        /// <value>每页记录条数，默认20，需要在1和100之间</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingRecruitPlanlistQueryModel {\n");
            sb.Append("  EnrollMerchant: ").Append(EnrollMerchant).Append("\n");
            sb.Append("  EnrollSceneType: ").Append(EnrollSceneType).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(input as AlipayMarketingRecruitPlanlistQueryModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingRecruitPlanlistQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingRecruitPlanlistQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingRecruitPlanlistQueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EnrollMerchant == input.EnrollMerchant ||
                    (this.EnrollMerchant != null &&
                    this.EnrollMerchant.Equals(input.EnrollMerchant))
                ) && 
                (
                    this.EnrollSceneType == input.EnrollSceneType ||
                    (this.EnrollSceneType != null &&
                    this.EnrollSceneType.Equals(input.EnrollSceneType))
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
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
                if (this.EnrollMerchant != null)
                {
                    hashCode = (hashCode * 59) + this.EnrollMerchant.GetHashCode();
                }
                if (this.EnrollSceneType != null)
                {
                    hashCode = (hashCode * 59) + this.EnrollSceneType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
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
