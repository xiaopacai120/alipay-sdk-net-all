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
    /// AlipayMarketingActivityOrdervoucherRefundResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityOrdervoucherRefundResponseModel")]
    public partial class AlipayMarketingActivityOrdervoucherRefundResponseModel : IEquatable<AlipayMarketingActivityOrdervoucherRefundResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityOrdervoucherRefundResponseModel" /> class.
        /// </summary>
        /// <param name="activityId">优惠券活动id.</param>
        /// <param name="voucherUseDetailResultInfo">voucherUseDetailResultInfo.</param>
        public AlipayMarketingActivityOrdervoucherRefundResponseModel(string activityId = default(string), VoucherUseDetailResultInfo voucherUseDetailResultInfo = default(VoucherUseDetailResultInfo))
        {
            this.ActivityId = activityId;
            this.VoucherUseDetailResultInfo = voucherUseDetailResultInfo;
        }

        /// <summary>
        /// 优惠券活动id
        /// </summary>
        /// <value>优惠券活动id</value>
        [DataMember(Name = "activity_id", EmitDefaultValue = false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Gets or Sets VoucherUseDetailResultInfo
        /// </summary>
        [DataMember(Name = "voucher_use_detail_result_info", EmitDefaultValue = false)]
        public VoucherUseDetailResultInfo VoucherUseDetailResultInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityOrdervoucherRefundResponseModel {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  VoucherUseDetailResultInfo: ").Append(VoucherUseDetailResultInfo).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityOrdervoucherRefundResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityOrdervoucherRefundResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityOrdervoucherRefundResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityOrdervoucherRefundResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.VoucherUseDetailResultInfo == input.VoucherUseDetailResultInfo ||
                    (this.VoucherUseDetailResultInfo != null &&
                    this.VoucherUseDetailResultInfo.Equals(input.VoucherUseDetailResultInfo))
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
                if (this.ActivityId != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityId.GetHashCode();
                }
                if (this.VoucherUseDetailResultInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherUseDetailResultInfo.GetHashCode();
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
