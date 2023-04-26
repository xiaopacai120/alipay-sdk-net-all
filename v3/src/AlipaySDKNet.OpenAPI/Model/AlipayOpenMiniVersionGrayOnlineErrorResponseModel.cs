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
    /// AlipayOpenMiniVersionGrayOnlineErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniVersionGrayOnlineErrorResponseModel")]
    public partial class AlipayOpenMiniVersionGrayOnlineErrorResponseModel : IEquatable<AlipayOpenMiniVersionGrayOnlineErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 1,

            /// <summary>
            /// Enum APPVERSIONISBLANK for value: APP_VERSION_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APP_VERSION_IS_BLANK")]
            APPVERSIONISBLANK = 2,

            /// <summary>
            /// Enum GRAYSTRATEGYISBLANK for value: GRAY_STRATEGY_IS_BLANK
            /// </summary>
            [EnumMember(Value = "GRAY_STRATEGY_IS_BLANK")]
            GRAYSTRATEGYISBLANK = 3,

            /// <summary>
            /// Enum GRAYSTRATEGYISINVALID for value: GRAY_STRATEGY_IS_INVALID
            /// </summary>
            [EnumMember(Value = "GRAY_STRATEGY_IS_INVALID")]
            GRAYSTRATEGYISINVALID = 4,

            /// <summary>
            /// Enum APPLICATIONTYPENOTMINIAPP for value: APPLICATION_TYPE_NOT_MINIAPP
            /// </summary>
            [EnumMember(Value = "APPLICATION_TYPE_NOT_MINIAPP")]
            APPLICATIONTYPENOTMINIAPP = 5,

            /// <summary>
            /// Enum MINIAPPPACKAGEINFONOTEXIST for value: MINI_APP_PACKAGE_INFO_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "MINI_APP_PACKAGE_INFO_NOT_EXIST")]
            MINIAPPPACKAGEINFONOTEXIST = 6,

            /// <summary>
            /// Enum MINIAPPNOTONLINE for value: MINI_APP_NOT_ONLINE
            /// </summary>
            [EnumMember(Value = "MINI_APP_NOT_ONLINE")]
            MINIAPPNOTONLINE = 7,

            /// <summary>
            /// Enum GRAYSTRATEGYNOTALLOWREDUCE for value: GRAY_STRATEGY_NOT_ALLOW_REDUCE
            /// </summary>
            [EnumMember(Value = "GRAY_STRATEGY_NOT_ALLOW_REDUCE")]
            GRAYSTRATEGYNOTALLOWREDUCE = 8,

            /// <summary>
            /// Enum CANNOTGRAYWITHOUTAUDITPASS for value: CAN_NOT_GRAY_WITHOUT_AUDIT_PASS
            /// </summary>
            [EnumMember(Value = "CAN_NOT_GRAY_WITHOUT_AUDIT_PASS")]
            CANNOTGRAYWITHOUTAUDITPASS = 9,

            /// <summary>
            /// Enum BUNDLEIDNOTEXIST for value: BUNDLE_ID_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "BUNDLE_ID_NOT_EXIST")]
            BUNDLEIDNOTEXIST = 10,

            /// <summary>
            /// Enum CANNOTGRAYWITHOUTINNERPASS for value: CAN_NOT_GRAY_WITHOUT_INNER_PASS
            /// </summary>
            [EnumMember(Value = "CAN_NOT_GRAY_WITHOUT_INNER_PASS")]
            CANNOTGRAYWITHOUTINNERPASS = 11,

            /// <summary>
            /// Enum MINIAPPVERSIONNOTEXSIT for value: MINIAPP_VERSION_NOT_EXSIT
            /// </summary>
            [EnumMember(Value = "MINIAPP_VERSION_NOT_EXSIT")]
            MINIAPPVERSIONNOTEXSIT = 12,

            /// <summary>
            /// Enum CANNOTGRAYWITHRISKVERSION for value: CAN_NOT_GRAY_WITH_RISK_VERSION
            /// </summary>
            [EnumMember(Value = "CAN_NOT_GRAY_WITH_RISK_VERSION")]
            CANNOTGRAYWITHRISKVERSION = 13,

            /// <summary>
            /// Enum APPOPERATORQUERYERROR for value: APP_OPERATOR_QUERY_ERROR
            /// </summary>
            [EnumMember(Value = "APP_OPERATOR_QUERY_ERROR")]
            APPOPERATORQUERYERROR = 14,

            /// <summary>
            /// Enum CREATEGRAYRULEERROR for value: CREATE_GRAY_RULE_ERROR
            /// </summary>
            [EnumMember(Value = "CREATE_GRAY_RULE_ERROR")]
            CREATEGRAYRULEERROR = 15,

            /// <summary>
            /// Enum EXECUTEGRAYFAILED for value: EXECUTE_GRAY_FAILED
            /// </summary>
            [EnumMember(Value = "EXECUTE_GRAY_FAILED")]
            EXECUTEGRAYFAILED = 16

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniVersionGrayOnlineErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenMiniVersionGrayOnlineErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniVersionGrayOnlineErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenMiniVersionGrayOnlineErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenMiniVersionGrayOnlineErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenMiniVersionGrayOnlineErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenMiniVersionGrayOnlineErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniVersionGrayOnlineErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniVersionGrayOnlineErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniVersionGrayOnlineErrorResponseModel input)
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
