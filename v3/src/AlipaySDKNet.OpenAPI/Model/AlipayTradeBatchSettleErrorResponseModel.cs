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
    /// AlipayTradeBatchSettleErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeBatchSettleErrorResponseModel")]
    public partial class AlipayTradeBatchSettleErrorResponseModel : IEquatable<AlipayTradeBatchSettleErrorResponseModel>, IValidatableObject
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
            /// Enum REQUESTIDREPEAT for value: REQUEST_ID_REPEAT
            /// </summary>
            [EnumMember(Value = "REQUEST_ID_REPEAT")]
            REQUESTIDREPEAT = 3,

            /// <summary>
            /// Enum USERBALANCENOTENOUGH for value: USER_BALANCE_NOT_ENOUGH
            /// </summary>
            [EnumMember(Value = "USER_BALANCE_NOT_ENOUGH")]
            USERBALANCENOTENOUGH = 4,

            /// <summary>
            /// Enum CARDBINCHECKERERROR for value: CARD_BIN_CHECKER_ERROR
            /// </summary>
            [EnumMember(Value = "CARD_BIN_CHECKER_ERROR")]
            CARDBINCHECKERERROR = 5,

            /// <summary>
            /// Enum DEFAULTSETTLERULENOTEXIST for value: DEFAULT_SETTLE_RULE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "DEFAULT_SETTLE_RULE_NOT_EXIST")]
            DEFAULTSETTLERULENOTEXIST = 6,

            /// <summary>
            /// Enum INVALIDSTOREID for value: INVALID_STORE_ID
            /// </summary>
            [EnumMember(Value = "INVALID_STORE_ID")]
            INVALIDSTOREID = 7,

            /// <summary>
            /// Enum SECONDARYMERCHANTIDINVALID for value: SECONDARY_MERCHANT_ID_INVALID
            /// </summary>
            [EnumMember(Value = "SECONDARY_MERCHANT_ID_INVALID")]
            SECONDARYMERCHANTIDINVALID = 8,

            /// <summary>
            /// Enum SETTLEENTITYIDINVALID for value: SETTLE_ENTITY_ID_INVALID
            /// </summary>
            [EnumMember(Value = "SETTLE_ENTITY_ID_INVALID")]
            SETTLEENTITYIDINVALID = 9,

            /// <summary>
            /// Enum SETTLEACCOUNTNOUSERINFO for value: SETTLE_ACCOUNT_NO_USER_INFO
            /// </summary>
            [EnumMember(Value = "SETTLE_ACCOUNT_NO_USER_INFO")]
            SETTLEACCOUNTNOUSERINFO = 10,

            /// <summary>
            /// Enum CREDITNOTALLOW for value: CREDIT_NOT_ALLOW
            /// </summary>
            [EnumMember(Value = "CREDIT_NOT_ALLOW")]
            CREDITNOTALLOW = 11,

            /// <summary>
            /// Enum NOSIGNQUICKSETTLEMENT for value: NO_SIGN_QUICK_SETTLEMENT
            /// </summary>
            [EnumMember(Value = "NO_SIGN_QUICK_SETTLEMENT")]
            NOSIGNQUICKSETTLEMENT = 12,

            /// <summary>
            /// Enum CUSTOMERVALIDATEERROR for value: CUSTOMER_VALIDATE_ERROR
            /// </summary>
            [EnumMember(Value = "CUSTOMER_VALIDATE_ERROR")]
            CUSTOMERVALIDATEERROR = 13,

            /// <summary>
            /// Enum SETTLEACCOUNTINVALID for value: SETTLE_ACCOUNT_INVALID
            /// </summary>
            [EnumMember(Value = "SETTLE_ACCOUNT_INVALID")]
            SETTLEACCOUNTINVALID = 14,

            /// <summary>
            /// Enum USERLOGONIDDUP for value: USER_LOGONID_DUP
            /// </summary>
            [EnumMember(Value = "USER_LOGONID_DUP")]
            USERLOGONIDDUP = 15,

            /// <summary>
            /// Enum QUICKSETTLEMENTLEFTCREDITQUOTANOTENOUGH for value: QUICK_SETTLEMENT_LEFT_CREDIT_QUOTA_NOT_ENOUGH
            /// </summary>
            [EnumMember(Value = "QUICK_SETTLEMENT_LEFT_CREDIT_QUOTA_NOT_ENOUGH")]
            QUICKSETTLEMENTLEFTCREDITQUOTANOTENOUGH = 16,

            /// <summary>
            /// Enum SETTLEACCOUNTNOTCERTIFY for value: SETTLE_ACCOUNT_NOT_CERTIFY
            /// </summary>
            [EnumMember(Value = "SETTLE_ACCOUNT_NOT_CERTIFY")]
            SETTLEACCOUNTNOTCERTIFY = 17,

            /// <summary>
            /// Enum SETTLEACCOUNTNOTEXIST for value: SETTLE_ACCOUNT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SETTLE_ACCOUNT_NOT_EXIST")]
            SETTLEACCOUNTNOTEXIST = 18,

            /// <summary>
            /// Enum SETTLEACCOUNTNOBALANCE for value: SETTLE_ACCOUNT_NO_BALANCE
            /// </summary>
            [EnumMember(Value = "SETTLE_ACCOUNT_NO_BALANCE")]
            SETTLEACCOUNTNOBALANCE = 19,

            /// <summary>
            /// Enum RISKSETTLESUSPEND for value: RISK_SETTLE_SUSPEND
            /// </summary>
            [EnumMember(Value = "RISK_SETTLE_SUSPEND")]
            RISKSETTLESUSPEND = 20,

            /// <summary>
            /// Enum FREQUENCYLIMITED for value: FREQUENCY_LIMITED
            /// </summary>
            [EnumMember(Value = "FREQUENCY_LIMITED")]
            FREQUENCYLIMITED = 21,

            /// <summary>
            /// Enum SUBMERCHANTBELONGERROR for value: SUB_MERCHANT_BELONG_ERROR
            /// </summary>
            [EnumMember(Value = "SUB_MERCHANT_BELONG_ERROR")]
            SUBMERCHANTBELONGERROR = 22

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeBatchSettleErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayTradeBatchSettleErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeBatchSettleErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayTradeBatchSettleErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayTradeBatchSettleErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayTradeBatchSettleErrorResponseModel {\n");
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
            return this.Equals(input as AlipayTradeBatchSettleErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeBatchSettleErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeBatchSettleErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeBatchSettleErrorResponseModel input)
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
