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
    /// AlipayPcreditHuabeiAuthSettleApplyErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayPcreditHuabeiAuthSettleApplyErrorResponseModel")]
    public partial class AlipayPcreditHuabeiAuthSettleApplyErrorResponseModel : IEquatable<AlipayPcreditHuabeiAuthSettleApplyErrorResponseModel>, IValidatableObject
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
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 2,

            /// <summary>
            /// Enum AGREEMENTNOTEXIST for value: AGREEMENT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "AGREEMENT_NOT_EXIST")]
            AGREEMENTNOTEXIST = 3,

            /// <summary>
            /// Enum AGREEMENTEXPIRED for value: AGREEMENT_EXPIRED
            /// </summary>
            [EnumMember(Value = "AGREEMENT_EXPIRED")]
            AGREEMENTEXPIRED = 4,

            /// <summary>
            /// Enum PAYAMOUNTCHECKERROR for value: PAY_AMOUNT_CHECK_ERROR
            /// </summary>
            [EnumMember(Value = "PAY_AMOUNT_CHECK_ERROR")]
            PAYAMOUNTCHECKERROR = 5,

            /// <summary>
            /// Enum AUTHSCENENOTSUPPORTEDERROR for value: AUTH_SCENE_NOT_SUPPORTED_ERROR
            /// </summary>
            [EnumMember(Value = "AUTH_SCENE_NOT_SUPPORTED_ERROR")]
            AUTHSCENENOTSUPPORTEDERROR = 6,

            /// <summary>
            /// Enum ORDERIDEMPOTENTERROR for value: ORDER_IDEMPOTENT_ERROR
            /// </summary>
            [EnumMember(Value = "ORDER_IDEMPOTENT_ERROR")]
            ORDERIDEMPOTENTERROR = 7,

            /// <summary>
            /// Enum ORDERALREADYDEAL for value: ORDER_ALREADY_DEAL
            /// </summary>
            [EnumMember(Value = "ORDER_ALREADY_DEAL")]
            ORDERALREADYDEAL = 8,

            /// <summary>
            /// Enum ORDERNOTEXIST for value: ORDER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ORDER_NOT_EXIST")]
            ORDERNOTEXIST = 9,

            /// <summary>
            /// Enum PAYAMOUNTIDEMPOTENTERROR for value: PAY_AMOUNT_IDEMPOTENT_ERROR
            /// </summary>
            [EnumMember(Value = "PAY_AMOUNT_IDEMPOTENT_ERROR")]
            PAYAMOUNTIDEMPOTENTERROR = 10,

            /// <summary>
            /// Enum BEYONDPAYRESTRICTION for value: BEYOND_PAY_RESTRICTION
            /// </summary>
            [EnumMember(Value = "BEYOND_PAY_RESTRICTION")]
            BEYONDPAYRESTRICTION = 11,

            /// <summary>
            /// Enum ACCESSFORBIDDEN for value: ACCESS_FORBIDDEN
            /// </summary>
            [EnumMember(Value = "ACCESS_FORBIDDEN")]
            ACCESSFORBIDDEN = 12,

            /// <summary>
            /// Enum BUYERENABLESTATUSFORBID for value: BUYER_ENABLE_STATUS_FORBID
            /// </summary>
            [EnumMember(Value = "BUYER_ENABLE_STATUS_FORBID")]
            BUYERENABLESTATUSFORBID = 13,

            /// <summary>
            /// Enum TOTALFEEEXCEED for value: TOTAL_FEE_EXCEED
            /// </summary>
            [EnumMember(Value = "TOTAL_FEE_EXCEED")]
            TOTALFEEEXCEED = 14,

            /// <summary>
            /// Enum INVALIDRECEIVEACCOUNT for value: INVALID_RECEIVE_ACCOUNT
            /// </summary>
            [EnumMember(Value = "INVALID_RECEIVE_ACCOUNT")]
            INVALIDRECEIVEACCOUNT = 15,

            /// <summary>
            /// Enum BUYERPAYMENTAMOUNTDAYLIMIT for value: BUYER_PAYMENT_AMOUNT_DAY_LIMIT
            /// </summary>
            [EnumMember(Value = "BUYER_PAYMENT_AMOUNT_DAY_LIMIT")]
            BUYERPAYMENTAMOUNTDAYLIMIT = 16,

            /// <summary>
            /// Enum CONTEXTINCONSISTENT for value: CONTEXT_INCONSISTENT
            /// </summary>
            [EnumMember(Value = "CONTEXT_INCONSISTENT")]
            CONTEXTINCONSISTENT = 17,

            /// <summary>
            /// Enum BUYERPAYMENTAMOUNTMONTHLIMIT for value: BUYER_PAYMENT_AMOUNT_MONTH_LIMIT
            /// </summary>
            [EnumMember(Value = "BUYER_PAYMENT_AMOUNT_MONTH_LIMIT")]
            BUYERPAYMENTAMOUNTMONTHLIMIT = 18,

            /// <summary>
            /// Enum PAYMENTREQUESTHASRISK for value: PAYMENT_REQUEST_HAS_RISK
            /// </summary>
            [EnumMember(Value = "PAYMENT_REQUEST_HAS_RISK")]
            PAYMENTREQUESTHASRISK = 19,

            /// <summary>
            /// Enum AGREEMENTINVALID for value: AGREEMENT_INVALID
            /// </summary>
            [EnumMember(Value = "AGREEMENT_INVALID")]
            AGREEMENTINVALID = 20,

            /// <summary>
            /// Enum AGREEMENTERROR for value: AGREEMENT_ERROR
            /// </summary>
            [EnumMember(Value = "AGREEMENT_ERROR")]
            AGREEMENTERROR = 21,

            /// <summary>
            /// Enum BUSINESSERROR for value: BUSINESS_ERROR
            /// </summary>
            [EnumMember(Value = "BUSINESS_ERROR")]
            BUSINESSERROR = 22,

            /// <summary>
            /// Enum PRODUCTAMOUNTLIMITERROR for value: PRODUCT_AMOUNT_LIMIT_ERROR
            /// </summary>
            [EnumMember(Value = "PRODUCT_AMOUNT_LIMIT_ERROR")]
            PRODUCTAMOUNTLIMITERROR = 23,

            /// <summary>
            /// Enum CALLLIMITED for value: CALL_LIMITED
            /// </summary>
            [EnumMember(Value = "CALL_LIMITED")]
            CALLLIMITED = 24,

            /// <summary>
            /// Enum CONCURRENTOPERATIONERROR for value: CONCURRENT_OPERATION_ERROR
            /// </summary>
            [EnumMember(Value = "CONCURRENT_OPERATION_ERROR")]
            CONCURRENTOPERATIONERROR = 25,

            /// <summary>
            /// Enum INVALIDSETTLEMENTINFO for value: INVALID_SETTLEMENT_INFO
            /// </summary>
            [EnumMember(Value = "INVALID_SETTLEMENT_INFO")]
            INVALIDSETTLEMENTINFO = 26,

            /// <summary>
            /// Enum INVALIDSETTLETIME for value: INVALID_SETTLE_TIME
            /// </summary>
            [EnumMember(Value = "INVALID_SETTLE_TIME")]
            INVALIDSETTLETIME = 27

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayPcreditHuabeiAuthSettleApplyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayPcreditHuabeiAuthSettleApplyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayPcreditHuabeiAuthSettleApplyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayPcreditHuabeiAuthSettleApplyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayPcreditHuabeiAuthSettleApplyErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayPcreditHuabeiAuthSettleApplyErrorResponseModel {\n");
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
            return this.Equals(input as AlipayPcreditHuabeiAuthSettleApplyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayPcreditHuabeiAuthSettleApplyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayPcreditHuabeiAuthSettleApplyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayPcreditHuabeiAuthSettleApplyErrorResponseModel input)
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
