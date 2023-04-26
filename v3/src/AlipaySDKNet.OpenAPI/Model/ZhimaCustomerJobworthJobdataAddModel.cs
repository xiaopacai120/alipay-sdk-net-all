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
    /// ZhimaCustomerJobworthJobdataAddModel
    /// </summary>
    [DataContract(Name = "ZhimaCustomerJobworthJobdataAddModel")]
    public partial class ZhimaCustomerJobworthJobdataAddModel : IEquatable<ZhimaCustomerJobworthJobdataAddModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCustomerJobworthJobdataAddModel" /> class.
        /// </summary>
        /// <param name="certNo">身份证证件号.</param>
        /// <param name="certType">0:身份证1:护照2:台湾同胞回乡证3:港澳居民往来内地通行证4:台湾居民通行证5:港澳居民通行证.</param>
        /// <param name="connKey">关联key，受理台返回.</param>
        /// <param name="jobDataList">回传信息.</param>
        /// <param name="openId">支付宝uid.</param>
        /// <param name="userId">支付宝uid.</param>
        /// <param name="userName">用户中文名.</param>
        public ZhimaCustomerJobworthJobdataAddModel(string certNo = default(string), string certType = default(string), string connKey = default(string), List<JobWorthJobdata> jobDataList = default(List<JobWorthJobdata>), string openId = default(string), string userId = default(string), string userName = default(string))
        {
            this.CertNo = certNo;
            this.CertType = certType;
            this.ConnKey = connKey;
            this.JobDataList = jobDataList;
            this.OpenId = openId;
            this.UserId = userId;
            this.UserName = userName;
        }

        /// <summary>
        /// 身份证证件号
        /// </summary>
        /// <value>身份证证件号</value>
        [DataMember(Name = "cert_no", EmitDefaultValue = false)]
        public string CertNo { get; set; }

        /// <summary>
        /// 0:身份证1:护照2:台湾同胞回乡证3:港澳居民往来内地通行证4:台湾居民通行证5:港澳居民通行证
        /// </summary>
        /// <value>0:身份证1:护照2:台湾同胞回乡证3:港澳居民往来内地通行证4:台湾居民通行证5:港澳居民通行证</value>
        [DataMember(Name = "cert_type", EmitDefaultValue = false)]
        public string CertType { get; set; }

        /// <summary>
        /// 关联key，受理台返回
        /// </summary>
        /// <value>关联key，受理台返回</value>
        [DataMember(Name = "conn_key", EmitDefaultValue = false)]
        public string ConnKey { get; set; }

        /// <summary>
        /// 回传信息
        /// </summary>
        /// <value>回传信息</value>
        [DataMember(Name = "job_data_list", EmitDefaultValue = false)]
        public List<JobWorthJobdata> JobDataList { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        /// <value>支付宝uid</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        /// <value>支付宝uid</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户中文名
        /// </summary>
        /// <value>用户中文名</value>
        [DataMember(Name = "user_name", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCustomerJobworthJobdataAddModel {\n");
            sb.Append("  CertNo: ").Append(CertNo).Append("\n");
            sb.Append("  CertType: ").Append(CertType).Append("\n");
            sb.Append("  ConnKey: ").Append(ConnKey).Append("\n");
            sb.Append("  JobDataList: ").Append(JobDataList).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(input as ZhimaCustomerJobworthJobdataAddModel);
        }

        /// <summary>
        /// Returns true if ZhimaCustomerJobworthJobdataAddModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCustomerJobworthJobdataAddModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCustomerJobworthJobdataAddModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CertNo == input.CertNo ||
                    (this.CertNo != null &&
                    this.CertNo.Equals(input.CertNo))
                ) && 
                (
                    this.CertType == input.CertType ||
                    (this.CertType != null &&
                    this.CertType.Equals(input.CertType))
                ) && 
                (
                    this.ConnKey == input.ConnKey ||
                    (this.ConnKey != null &&
                    this.ConnKey.Equals(input.ConnKey))
                ) && 
                (
                    this.JobDataList == input.JobDataList ||
                    this.JobDataList != null &&
                    input.JobDataList != null &&
                    this.JobDataList.SequenceEqual(input.JobDataList)
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.CertNo != null)
                {
                    hashCode = (hashCode * 59) + this.CertNo.GetHashCode();
                }
                if (this.CertType != null)
                {
                    hashCode = (hashCode * 59) + this.CertType.GetHashCode();
                }
                if (this.ConnKey != null)
                {
                    hashCode = (hashCode * 59) + this.ConnKey.GetHashCode();
                }
                if (this.JobDataList != null)
                {
                    hashCode = (hashCode * 59) + this.JobDataList.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
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
