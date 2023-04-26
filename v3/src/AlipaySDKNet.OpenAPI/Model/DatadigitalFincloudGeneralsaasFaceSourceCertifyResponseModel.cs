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
    /// DatadigitalFincloudGeneralsaasFaceSourceCertifyResponseModel
    /// </summary>
    [DataContract(Name = "DatadigitalFincloudGeneralsaasFaceSourceCertifyResponseModel")]
    public partial class DatadigitalFincloudGeneralsaasFaceSourceCertifyResponseModel : IEquatable<DatadigitalFincloudGeneralsaasFaceSourceCertifyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatadigitalFincloudGeneralsaasFaceSourceCertifyResponseModel" /> class.
        /// </summary>
        /// <param name="certifyNo">人脸认证单据号，调用后续OpenAPI（datadigital.fincloud.generalsaas.face.source.query ）时传入，用来查询结果.</param>
        /// <param name="mismatchReason">认证不通过原因.</param>
        /// <param name="passed">T：通过；F：不通过.</param>
        /// <param name="quality">double值，人脸图片质量分.</param>
        /// <param name="score">double值，活体检测结果分数.</param>
        public DatadigitalFincloudGeneralsaasFaceSourceCertifyResponseModel(string certifyNo = default(string), string mismatchReason = default(string), string passed = default(string), string quality = default(string), string score = default(string))
        {
            this.CertifyNo = certifyNo;
            this.MismatchReason = mismatchReason;
            this.Passed = passed;
            this.Quality = quality;
            this.Score = score;
        }

        /// <summary>
        /// 人脸认证单据号，调用后续OpenAPI（datadigital.fincloud.generalsaas.face.source.query ）时传入，用来查询结果
        /// </summary>
        /// <value>人脸认证单据号，调用后续OpenAPI（datadigital.fincloud.generalsaas.face.source.query ）时传入，用来查询结果</value>
        [DataMember(Name = "certify_no", EmitDefaultValue = false)]
        public string CertifyNo { get; set; }

        /// <summary>
        /// 认证不通过原因
        /// </summary>
        /// <value>认证不通过原因</value>
        [DataMember(Name = "mismatch_reason", EmitDefaultValue = false)]
        public string MismatchReason { get; set; }

        /// <summary>
        /// T：通过；F：不通过
        /// </summary>
        /// <value>T：通过；F：不通过</value>
        [DataMember(Name = "passed", EmitDefaultValue = false)]
        public string Passed { get; set; }

        /// <summary>
        /// double值，人脸图片质量分
        /// </summary>
        /// <value>double值，人脸图片质量分</value>
        [DataMember(Name = "quality", EmitDefaultValue = false)]
        public string Quality { get; set; }

        /// <summary>
        /// double值，活体检测结果分数
        /// </summary>
        /// <value>double值，活体检测结果分数</value>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public string Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatadigitalFincloudGeneralsaasFaceSourceCertifyResponseModel {\n");
            sb.Append("  CertifyNo: ").Append(CertifyNo).Append("\n");
            sb.Append("  MismatchReason: ").Append(MismatchReason).Append("\n");
            sb.Append("  Passed: ").Append(Passed).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return this.Equals(input as DatadigitalFincloudGeneralsaasFaceSourceCertifyResponseModel);
        }

        /// <summary>
        /// Returns true if DatadigitalFincloudGeneralsaasFaceSourceCertifyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DatadigitalFincloudGeneralsaasFaceSourceCertifyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatadigitalFincloudGeneralsaasFaceSourceCertifyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CertifyNo == input.CertifyNo ||
                    (this.CertifyNo != null &&
                    this.CertifyNo.Equals(input.CertifyNo))
                ) && 
                (
                    this.MismatchReason == input.MismatchReason ||
                    (this.MismatchReason != null &&
                    this.MismatchReason.Equals(input.MismatchReason))
                ) && 
                (
                    this.Passed == input.Passed ||
                    (this.Passed != null &&
                    this.Passed.Equals(input.Passed))
                ) && 
                (
                    this.Quality == input.Quality ||
                    (this.Quality != null &&
                    this.Quality.Equals(input.Quality))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
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
                if (this.CertifyNo != null)
                {
                    hashCode = (hashCode * 59) + this.CertifyNo.GetHashCode();
                }
                if (this.MismatchReason != null)
                {
                    hashCode = (hashCode * 59) + this.MismatchReason.GetHashCode();
                }
                if (this.Passed != null)
                {
                    hashCode = (hashCode * 59) + this.Passed.GetHashCode();
                }
                if (this.Quality != null)
                {
                    hashCode = (hashCode * 59) + this.Quality.GetHashCode();
                }
                if (this.Score != null)
                {
                    hashCode = (hashCode * 59) + this.Score.GetHashCode();
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
