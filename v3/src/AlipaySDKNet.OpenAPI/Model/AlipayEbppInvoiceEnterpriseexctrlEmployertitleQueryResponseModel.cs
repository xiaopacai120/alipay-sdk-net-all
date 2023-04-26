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
    /// AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel")]
    public partial class AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel : IEquatable<AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel" /> class.
        /// </summary>
        /// <param name="code">返回码 10000-成功 其他都是失败.</param>
        /// <param name="msg">返回消息.</param>
        /// <param name="titleInfo">titleInfo.</param>
        public AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel(string code = default(string), string msg = default(string), EnterpriseTitleInfo titleInfo = default(EnterpriseTitleInfo))
        {
            this.Code = code;
            this.Msg = msg;
            this.TitleInfo = titleInfo;
        }

        /// <summary>
        /// 返回码 10000-成功 其他都是失败
        /// </summary>
        /// <value>返回码 10000-成功 其他都是失败</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        /// <value>返回消息</value>
        [DataMember(Name = "msg", EmitDefaultValue = false)]
        public string Msg { get; set; }

        /// <summary>
        /// Gets or Sets TitleInfo
        /// </summary>
        [DataMember(Name = "title_info", EmitDefaultValue = false)]
        public EnterpriseTitleInfo TitleInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
            sb.Append("  TitleInfo: ").Append(TitleInfo).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Msg == input.Msg ||
                    (this.Msg != null &&
                    this.Msg.Equals(input.Msg))
                ) && 
                (
                    this.TitleInfo == input.TitleInfo ||
                    (this.TitleInfo != null &&
                    this.TitleInfo.Equals(input.TitleInfo))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Msg != null)
                {
                    hashCode = (hashCode * 59) + this.Msg.GetHashCode();
                }
                if (this.TitleInfo != null)
                {
                    hashCode = (hashCode * 59) + this.TitleInfo.GetHashCode();
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
