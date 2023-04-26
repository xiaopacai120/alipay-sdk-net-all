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
    /// AlipayTradePrecreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradePrecreateErrorResponseModel")]
    public partial class AlipayTradePrecreateErrorResponseModel : IEquatable<AlipayTradePrecreateErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum SYSTEMERROR for value: ACQ.SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.SYSTEM_ERROR")]
            SYSTEMERROR = 1,

            /// <summary>
            /// Enum INVALIDPARAMETER for value: ACQ.INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "ACQ.INVALID_PARAMETER")]
            INVALIDPARAMETER = 2,

            /// <summary>
            /// Enum ACCESSFORBIDDEN for value: ACQ.ACCESS_FORBIDDEN
            /// </summary>
            [EnumMember(Value = "ACQ.ACCESS_FORBIDDEN")]
            ACCESSFORBIDDEN = 3,

            /// <summary>
            /// Enum EXISTFORBIDDENWORD for value: ACQ.EXIST_FORBIDDEN_WORD
            /// </summary>
            [EnumMember(Value = "ACQ.EXIST_FORBIDDEN_WORD")]
            EXISTFORBIDDENWORD = 4,

            /// <summary>
            /// Enum PARTNERERROR for value: ACQ.PARTNER_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.PARTNER_ERROR")]
            PARTNERERROR = 5,

            /// <summary>
            /// Enum TOTALFEEEXCEED for value: ACQ.TOTAL_FEE_EXCEED
            /// </summary>
            [EnumMember(Value = "ACQ.TOTAL_FEE_EXCEED")]
            TOTALFEEEXCEED = 6,

            /// <summary>
            /// Enum CONTEXTINCONSISTENT for value: ACQ.CONTEXT_INCONSISTENT
            /// </summary>
            [EnumMember(Value = "ACQ.CONTEXT_INCONSISTENT")]
            CONTEXTINCONSISTENT = 7,

            /// <summary>
            /// Enum TRADEHASSUCCESS for value: ACQ.TRADE_HAS_SUCCESS
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_HAS_SUCCESS")]
            TRADEHASSUCCESS = 8,

            /// <summary>
            /// Enum TRADEHASCLOSE for value: ACQ.TRADE_HAS_CLOSE
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_HAS_CLOSE")]
            TRADEHASCLOSE = 9,

            /// <summary>
            /// Enum BUYERSELLEREQUAL for value: ACQ.BUYER_SELLER_EQUAL
            /// </summary>
            [EnumMember(Value = "ACQ.BUYER_SELLER_EQUAL")]
            BUYERSELLEREQUAL = 10,

            /// <summary>
            /// Enum TRADEBUYERNOTMATCH for value: ACQ.TRADE_BUYER_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_BUYER_NOT_MATCH")]
            TRADEBUYERNOTMATCH = 11,

            /// <summary>
            /// Enum BUYERENABLESTATUSFORBID for value: ACQ.BUYER_ENABLE_STATUS_FORBID
            /// </summary>
            [EnumMember(Value = "ACQ.BUYER_ENABLE_STATUS_FORBID")]
            BUYERENABLESTATUSFORBID = 12,

            /// <summary>
            /// Enum BUYERPAYMENTAMOUNTDAYLIMITERROR for value: ACQ.BUYER_PAYMENT_AMOUNT_DAY_LIMIT_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.BUYER_PAYMENT_AMOUNT_DAY_LIMIT_ERROR")]
            BUYERPAYMENTAMOUNTDAYLIMITERROR = 13,

            /// <summary>
            /// Enum BEYONDPAYRESTRICTION for value: ACQ.BEYOND_PAY_RESTRICTION
            /// </summary>
            [EnumMember(Value = "ACQ.BEYOND_PAY_RESTRICTION")]
            BEYONDPAYRESTRICTION = 14,

            /// <summary>
            /// Enum BEYONDPERRECEIPTRESTRICTION for value: ACQ.BEYOND_PER_RECEIPT_RESTRICTION
            /// </summary>
            [EnumMember(Value = "ACQ.BEYOND_PER_RECEIPT_RESTRICTION")]
            BEYONDPERRECEIPTRESTRICTION = 15,

            /// <summary>
            /// Enum BUYERPAYMENTAMOUNTMONTHLIMITERROR for value: ACQ.BUYER_PAYMENT_AMOUNT_MONTH_LIMIT_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.BUYER_PAYMENT_AMOUNT_MONTH_LIMIT_ERROR")]
            BUYERPAYMENTAMOUNTMONTHLIMITERROR = 16,

            /// <summary>
            /// Enum SELLERBEENBLOCKED for value: ACQ.SELLER_BEEN_BLOCKED
            /// </summary>
            [EnumMember(Value = "ACQ.SELLER_BEEN_BLOCKED")]
            SELLERBEENBLOCKED = 17,

            /// <summary>
            /// Enum ERRORBUYERCERTIFYLEVELLIMIT for value: ACQ.ERROR_BUYER_CERTIFY_LEVEL_LIMIT
            /// </summary>
            [EnumMember(Value = "ACQ.ERROR_BUYER_CERTIFY_LEVEL_LIMIT")]
            ERRORBUYERCERTIFYLEVELLIMIT = 18,

            /// <summary>
            /// Enum INVALIDSTOREID for value: ACQ.INVALID_STORE_ID
            /// </summary>
            [EnumMember(Value = "ACQ.INVALID_STORE_ID")]
            INVALIDSTOREID = 19,

            /// <summary>
            /// Enum APPLYPCMERCHANTCODEERROR for value: ACQ.APPLY_PC_MERCHANT_CODE_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.APPLY_PC_MERCHANT_CODE_ERROR")]
            APPLYPCMERCHANTCODEERROR = 20,

            /// <summary>
            /// Enum SECONDARYMERCHANTSTATUSERROR for value: ACQ.SECONDARY_MERCHANT_STATUS_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_STATUS_ERROR")]
            SECONDARYMERCHANTSTATUSERROR = 21,

            /// <summary>
            /// Enum BEYONDPERRECEIPTDAYRESTRICTION for value: ACQ.BEYOND_PER_RECEIPT_DAY_RESTRICTION
            /// </summary>
            [EnumMember(Value = "ACQ.BEYOND_PER_RECEIPT_DAY_RESTRICTION")]
            BEYONDPERRECEIPTDAYRESTRICTION = 22,

            /// <summary>
            /// Enum BEYONDPERRECEIPTSINGLERESTRICTION for value: ACQ.BEYOND_PER_RECEIPT_SINGLE_RESTRICTION
            /// </summary>
            [EnumMember(Value = "ACQ.BEYOND_PER_RECEIPT_SINGLE_RESTRICTION")]
            BEYONDPERRECEIPTSINGLERESTRICTION = 23,

            /// <summary>
            /// Enum TRADESETTLEERROR for value: ACQ.TRADE_SETTLE_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_SETTLE_ERROR")]
            TRADESETTLEERROR = 24,

            /// <summary>
            /// Enum SECONDARYMERCHANTIDINVALID for value: ACQ.SECONDARY_MERCHANT_ID_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_ID_INVALID")]
            SECONDARYMERCHANTIDINVALID = 25,

            /// <summary>
            /// Enum SECONDARYMERCHANTISVPUNISHINDIRECT for value: ACQ.SECONDARY_MERCHANT_ISV_PUNISH_INDIRECT
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_ISV_PUNISH_INDIRECT")]
            SECONDARYMERCHANTISVPUNISHINDIRECT = 26,

            /// <summary>
            /// Enum SELLERNOTEXIST for value: ACQ.SELLER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.SELLER_NOT_EXIST")]
            SELLERNOTEXIST = 27,

            /// <summary>
            /// Enum SECONDARYMERCHANTALIPAYACCOUNTINVALID for value: ACQ.SECONDARY_MERCHANT_ALIPAY_ACCOUNT_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_ALIPAY_ACCOUNT_INVALID")]
            SECONDARYMERCHANTALIPAYACCOUNTINVALID = 28,

            /// <summary>
            /// Enum INVALIDRECEIVEACCOUNT for value: ACQ.INVALID_RECEIVE_ACCOUNT
            /// </summary>
            [EnumMember(Value = "ACQ.INVALID_RECEIVE_ACCOUNT")]
            INVALIDRECEIVEACCOUNT = 29,

            /// <summary>
            /// Enum SECONDARYMERCHANTIDBLANK for value: ACQ.SECONDARY_MERCHANT_ID_BLANK
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_ID_BLANK")]
            SECONDARYMERCHANTIDBLANK = 30,

            /// <summary>
            /// Enum NOWTIMEAFTEREXPIRETIMEERROR for value: ACQ.NOW_TIME_AFTER_EXPIRE_TIME_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.NOW_TIME_AFTER_EXPIRE_TIME_ERROR")]
            NOWTIMEAFTEREXPIRETIMEERROR = 31,

            /// <summary>
            /// Enum SECONDARYMERCHANTNOTMATCH for value: ACQ.SECONDARY_MERCHANT_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_NOT_MATCH")]
            SECONDARYMERCHANTNOTMATCH = 32,

            /// <summary>
            /// Enum BUYERNOTEXIST for value: ACQ.BUYER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.BUYER_NOT_EXIST")]
            BUYERNOTEXIST = 33,

            /// <summary>
            /// Enum SUBGOODSSIZEMAXCOUNT for value: ACQ.SUB_GOODS_SIZE_MAX_COUNT
            /// </summary>
            [EnumMember(Value = "ACQ.SUB_GOODS_SIZE_MAX_COUNT")]
            SUBGOODSSIZEMAXCOUNT = 34,

            /// <summary>
            /// Enum DEFAULTSETTLERULENOTEXIST for value: ACQ.DEFAULT_SETTLE_RULE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.DEFAULT_SETTLE_RULE_NOT_EXIST")]
            DEFAULTSETTLERULENOTEXIST = 35,

            /// <summary>
            /// Enum MERCHANTPERMRECEIPTSUSPENDLIMIT for value: ACQ.MERCHANT_PERM_RECEIPT_SUSPEND_LIMIT
            /// </summary>
            [EnumMember(Value = "ACQ.MERCHANT_PERM_RECEIPT_SUSPEND_LIMIT")]
            MERCHANTPERMRECEIPTSUSPENDLIMIT = 36,

            /// <summary>
            /// Enum MERCHANTPERMRECEIPTSINGLELIMIT for value: ACQ.MERCHANT_PERM_RECEIPT_SINGLE_LIMIT
            /// </summary>
            [EnumMember(Value = "ACQ.MERCHANT_PERM_RECEIPT_SINGLE_LIMIT")]
            MERCHANTPERMRECEIPTSINGLELIMIT = 37,

            /// <summary>
            /// Enum MERCHANTPERMRECEIPTDAYLIMIT for value: ACQ.MERCHANT_PERM_RECEIPT_DAY_LIMIT
            /// </summary>
            [EnumMember(Value = "ACQ.MERCHANT_PERM_RECEIPT_DAY_LIMIT")]
            MERCHANTPERMRECEIPTDAYLIMIT = 38,

            /// <summary>
            /// Enum RISKMERCHANTIPNOTEXIST for value: ACQ.RISK_MERCHANT_IP_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.RISK_MERCHANT_IP_NOT_EXIST")]
            RISKMERCHANTIPNOTEXIST = 39

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradePrecreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayTradePrecreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradePrecreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayTradePrecreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayTradePrecreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayTradePrecreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayTradePrecreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradePrecreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradePrecreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradePrecreateErrorResponseModel input)
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
