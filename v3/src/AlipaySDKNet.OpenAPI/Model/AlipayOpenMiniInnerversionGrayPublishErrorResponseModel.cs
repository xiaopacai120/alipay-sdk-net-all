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
    /// AlipayOpenMiniInnerversionGrayPublishErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerversionGrayPublishErrorResponseModel")]
    public partial class AlipayOpenMiniInnerversionGrayPublishErrorResponseModel : IEquatable<AlipayOpenMiniInnerversionGrayPublishErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum GRAYONLINEFAILURE for value: GRAY_ONLINE_FAILURE
            /// </summary>
            [EnumMember(Value = "GRAY_ONLINE_FAILURE")]
            GRAYONLINEFAILURE = 1,

            /// <summary>
            /// Enum PARAMSVALIDERROR for value: PARAMS_VALID_ERROR
            /// </summary>
            [EnumMember(Value = "PARAMS_VALID_ERROR")]
            PARAMSVALIDERROR = 2,

            /// <summary>
            /// Enum APPINFONOTEXISTS for value: APP_INFO_NOT_EXISTS
            /// </summary>
            [EnumMember(Value = "APP_INFO_NOT_EXISTS")]
            APPINFONOTEXISTS = 3,

            /// <summary>
            /// Enum APPVERSIONNOTEXIST for value: APP_VERSION_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_VERSION_NOT_EXIST")]
            APPVERSIONNOTEXIST = 4,

            /// <summary>
            /// Enum NOPERMISSION for value: NO_PERMISSION
            /// </summary>
            [EnumMember(Value = "NO_PERMISSION")]
            NOPERMISSION = 5,

            /// <summary>
            /// Enum APPORIGINNOTEXIST for value: APP_ORIGIN_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_ORIGIN_NOT_EXIST")]
            APPORIGINNOTEXIST = 6,

            /// <summary>
            /// Enum BUNDLEIDNOTEXIST for value: BUNDLE_ID_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "BUNDLE_ID_NOT_EXIST")]
            BUNDLEIDNOTEXIST = 7,

            /// <summary>
            /// Enum CANNOTGRAYALIBABAPASS for value: CAN_NOT_GRAY_ALIBABA_PASS
            /// </summary>
            [EnumMember(Value = "CAN_NOT_GRAY_ALIBABA_PASS")]
            CANNOTGRAYALIBABAPASS = 8,

            /// <summary>
            /// Enum CANNOTGRAYWITHOUTAUDITPASS for value: CAN_NOT_GRAY_WITHOUT_AUDIT_PASS
            /// </summary>
            [EnumMember(Value = "CAN_NOT_GRAY_WITHOUT_AUDIT_PASS")]
            CANNOTGRAYWITHOUTAUDITPASS = 9,

            /// <summary>
            /// Enum PLUGINNOTALLOWEDGRAY for value: PLUGIN_NOT_ALLOWED_GRAY
            /// </summary>
            [EnumMember(Value = "PLUGIN_NOT_ALLOWED_GRAY")]
            PLUGINNOTALLOWEDGRAY = 10

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionGrayPublishErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenMiniInnerversionGrayPublishErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionGrayPublishErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenMiniInnerversionGrayPublishErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenMiniInnerversionGrayPublishErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenMiniInnerversionGrayPublishErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenMiniInnerversionGrayPublishErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionGrayPublishErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionGrayPublishErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionGrayPublishErrorResponseModel input)
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
