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
    /// AlipayMarketingCardFormtemplateSetErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCardFormtemplateSetErrorResponseModel")]
    public partial class AlipayMarketingCardFormtemplateSetErrorResponseModel : IEquatable<AlipayMarketingCardFormtemplateSetErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 1,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 2,

            /// <summary>
            /// Enum CARDTEMPLATENOTEXIST for value: CARD_TEMPLATE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "CARD_TEMPLATE_NOT_EXIST")]
            CARDTEMPLATENOTEXIST = 3,

            /// <summary>
            /// Enum DUPLICATEFORMFIELD for value: DUPLICATE_FORM_FIELD
            /// </summary>
            [EnumMember(Value = "DUPLICATE_FORM_FIELD")]
            DUPLICATEFORMFIELD = 4,

            /// <summary>
            /// Enum FORMFIELDINVALID for value: FORM_FIELD_INVALID
            /// </summary>
            [EnumMember(Value = "FORM_FIELD_INVALID")]
            FORMFIELDINVALID = 5,

            /// <summary>
            /// Enum OPENFORMSETFAIL for value: OPEN_FORM_SET_FAIL
            /// </summary>
            [EnumMember(Value = "OPEN_FORM_SET_FAIL")]
            OPENFORMSETFAIL = 6,

            /// <summary>
            /// Enum DUPLICATEBIRTHDAYFIELD for value: DUPLICATE_BIRTHDAY_FIELD
            /// </summary>
            [EnumMember(Value = "DUPLICATE_BIRTHDAY_FIELD")]
            DUPLICATEBIRTHDAYFIELD = 7,

            /// <summary>
            /// Enum DUPLICATECERTNO for value: DUPLICATE_CERT_NO
            /// </summary>
            [EnumMember(Value = "DUPLICATE_CERT_NO")]
            DUPLICATECERTNO = 8,

            /// <summary>
            /// Enum INVALIDCERTTYPEANDNO for value: INVALID_CERT_TYPE_AND_NO
            /// </summary>
            [EnumMember(Value = "INVALID_CERT_TYPE_AND_NO")]
            INVALIDCERTTYPEANDNO = 9,

            /// <summary>
            /// Enum ILLEGALNULLARGUMENT for value: ILLEGAL_NULL_ARGUMENT
            /// </summary>
            [EnumMember(Value = "ILLEGAL_NULL_ARGUMENT")]
            ILLEGALNULLARGUMENT = 10

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardFormtemplateSetErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayMarketingCardFormtemplateSetErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardFormtemplateSetErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayMarketingCardFormtemplateSetErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayMarketingCardFormtemplateSetErrorResponseModel and cannot be null");
            // }
            this.Message = message;
            this.Links = links;
        }

        /// <summary>
        /// 解决方案链接
        /// </summary>
        /// <value>解决方案链接</value>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public string Links { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        /// <value>错误描述</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCardFormtemplateSetErrorResponseModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as AlipayMarketingCardFormtemplateSetErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCardFormtemplateSetErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCardFormtemplateSetErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCardFormtemplateSetErrorResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                hashCode = (hashCode * 59) + this.Code.GetHashCode();
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
