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
    /// AntMerchantExpandShopCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AntMerchantExpandShopCreateErrorResponseModel")]
    public partial class AntMerchantExpandShopCreateErrorResponseModel : IEquatable<AntMerchantExpandShopCreateErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum NOTALLOWEDSETTLE for value: NOT_ALLOWED_SETTLE
            /// </summary>
            [EnumMember(Value = "NOT_ALLOWED_SETTLE")]
            NOTALLOWEDSETTLE = 1,

            /// <summary>
            /// Enum SHOPCATEGORYISILLEGAL for value: SHOP_CATEGORY_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SHOP_CATEGORY_IS_ILLEGAL")]
            SHOPCATEGORYISILLEGAL = 2,

            /// <summary>
            /// Enum ISVNOTEXIST for value: ISV_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ISV_NOT_EXIST")]
            ISVNOTEXIST = 3,

            /// <summary>
            /// Enum SHOPACCOUNTNOISILLEGAL for value: SHOP_ACCOUNT_NO_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SHOP_ACCOUNT_NO_IS_ILLEGAL")]
            SHOPACCOUNTNOISILLEGAL = 4,

            /// <summary>
            /// Enum SHOPSHOPNOISEMPTY for value: SHOP_SHOPNO_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SHOP_SHOPNO_IS_EMPTY")]
            SHOPSHOPNOISEMPTY = 5,

            /// <summary>
            /// Enum INDUSTRYQUALIFICATIONISEMPTY for value: INDUSTRY_QUALIFICATION_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "INDUSTRY_QUALIFICATION_IS_EMPTY")]
            INDUSTRYQUALIFICATIONISEMPTY = 6,

            /// <summary>
            /// Enum SETTLEDOUTDOORIMAGEEMPTY for value: SETTLED_OUTDOORIMAGE_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_OUTDOORIMAGE_EMPTY")]
            SETTLEDOUTDOORIMAGEEMPTY = 7,

            /// <summary>
            /// Enum SHOPSHOPNAMEISEMPTY for value: SHOP_SHOPNAME_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SHOP_SHOPNAME_IS_EMPTY")]
            SHOPSHOPNAMEISEMPTY = 8,

            /// <summary>
            /// Enum SETTLEDBIZADDRESSILLEGAL for value: SETTLED_BIZ_ADDRESS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SETTLED_BIZ_ADDRESS_ILLEGAL")]
            SETTLEDBIZADDRESSILLEGAL = 9,

            /// <summary>
            /// Enum SHOPCATEGORYISEMPTY for value: SHOP_CATEGORY_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SHOP_CATEGORY_IS_EMPTY")]
            SHOPCATEGORYISEMPTY = 10,

            /// <summary>
            /// Enum CONTACTWAYVALUENULL for value: CONTACT_WAY_VALUE_NULL
            /// </summary>
            [EnumMember(Value = "CONTACT_WAY_VALUE_NULL")]
            CONTACTWAYVALUENULL = 11,

            /// <summary>
            /// Enum ADDRESSPROVINCECODEILLEGAL for value: ADDRESS_PROVINCE_CODE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ADDRESS_PROVINCE_CODE_ILLEGAL")]
            ADDRESSPROVINCECODEILLEGAL = 12,

            /// <summary>
            /// Enum ADDRESSCITYCODEILLEGAL for value: ADDRESS_CITY_CODE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ADDRESS_CITY_CODE_ILLEGAL")]
            ADDRESSCITYCODEILLEGAL = 13,

            /// <summary>
            /// Enum ADDRESSDISTRICTCODEILLEGAL for value: ADDRESS_DISTRICT_CODE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ADDRESS_DISTRICT_CODE_ILLEGAL")]
            ADDRESSDISTRICTCODEILLEGAL = 14,

            /// <summary>
            /// Enum SHOPALREADYEXIST for value: SHOP_ALREADY_EXIST
            /// </summary>
            [EnumMember(Value = "SHOP_ALREADY_EXIST")]
            SHOPALREADYEXIST = 15,

            /// <summary>
            /// Enum GONGANCHECKFAIL for value: GONGAN_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "GONGAN_CHECK_FAIL")]
            GONGANCHECKFAIL = 16,

            /// <summary>
            /// Enum GONGSHANGCHECKFAIL for value: GONGSHANG_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "GONGSHANG_CHECK_FAIL")]
            GONGSHANGCHECKFAIL = 17,

            /// <summary>
            /// Enum MERCHANTINPUTARGUMENTILLEGAL for value: MERCHANT_INPUT_ARGUMENT_ILLEGAL
            /// </summary>
            [EnumMember(Value = "MERCHANT_INPUT_ARGUMENT_ILLEGAL")]
            MERCHANTINPUTARGUMENTILLEGAL = 18,

            /// <summary>
            /// Enum CONTACTPERSONNAMENULL for value: CONTACT_PERSON_NAME_NULL
            /// </summary>
            [EnumMember(Value = "CONTACT_PERSON_NAME_NULL")]
            CONTACTPERSONNAMENULL = 19,

            /// <summary>
            /// Enum USERILLEGAL for value: USER_ILLEGAL
            /// </summary>
            [EnumMember(Value = "USER_ILLEGAL")]
            USERILLEGAL = 20,

            /// <summary>
            /// Enum BRANDILLEGAL for value: BRAND_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BRAND_ILLEGAL")]
            BRANDILLEGAL = 21,

            /// <summary>
            /// Enum PROFILEKEYILLEGAL for value: PROFILE_KEY_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PROFILE_KEY_ILLEGAL")]
            PROFILEKEYILLEGAL = 22,

            /// <summary>
            /// Enum SETTLEDBANKCARDNOISEMPTY for value: SETTLED_BANKCARD_NO_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_BANKCARD_NO_IS_EMPTY")]
            SETTLEDBANKCARDNOISEMPTY = 23,

            /// <summary>
            /// Enum SETTLEDACCOUNTHOLDERNAMEEMPTY for value: SETTLED_ACCOUNTHOLDERNAME_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_ACCOUNTHOLDERNAME_EMPTY")]
            SETTLEDACCOUNTHOLDERNAMEEMPTY = 24,

            /// <summary>
            /// Enum SETTLEDACCOUNTBRANCHNAMEEMPTY for value: SETTLED_ACCOUNTBRANCHNAME_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_ACCOUNTBRANCHNAME_EMPTY")]
            SETTLEDACCOUNTBRANCHNAMEEMPTY = 25,

            /// <summary>
            /// Enum SETTLEDACCOUNTINSTNAMEEMPTY for value: SETTLED_ACCOUNTINSTNAME_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_ACCOUNTINSTNAME_EMPTY")]
            SETTLEDACCOUNTINSTNAMEEMPTY = 26,

            /// <summary>
            /// Enum SETTLEDUSAGETYPEISEMPTY for value: SETTLED_USAGETYPE_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_USAGETYPE_IS_EMPTY")]
            SETTLEDUSAGETYPEISEMPTY = 27,

            /// <summary>
            /// Enum BANKBRANCHNAMEILLEGAL for value: BANK_BRANCH_NAME_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BANK_BRANCH_NAME_ILLEGAL")]
            BANKBRANCHNAMEILLEGAL = 28,

            /// <summary>
            /// Enum SETTLEDUSAGETYPEILLEGAL for value: SETTLED_USAGETYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SETTLED_USAGETYPE_ILLEGAL")]
            SETTLEDUSAGETYPEILLEGAL = 29,

            /// <summary>
            /// Enum SETTLEDCARDACCOUNTINSTIDEMPTY for value: SETTLED_CARD_ACCOUNTINSTID_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_CARD_ACCOUNTINSTID_EMPTY")]
            SETTLEDCARDACCOUNTINSTIDEMPTY = 30,

            /// <summary>
            /// Enum SETTLEDCARDACCOUNTTYPEEMPTY for value: SETTLED_CARD_ACCOUNTTYPE_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_CARD_ACCOUNTTYPE_EMPTY")]
            SETTLEDCARDACCOUNTTYPEEMPTY = 31,

            /// <summary>
            /// Enum BANKACCOUNTINSTIDILLEGAL for value: BANK_ACCOUNTINSTID_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BANK_ACCOUNTINSTID_ILLEGAL")]
            BANKACCOUNTINSTIDILLEGAL = 32,

            /// <summary>
            /// Enum SETTLEDCARDACCOUNTTYPEILLEGAL for value: SETTLED_CARD_ACCOUNTTYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SETTLED_CARD_ACCOUNTTYPE_ILLEGAL")]
            SETTLEDCARDACCOUNTTYPEILLEGAL = 33,

            /// <summary>
            /// Enum BANKACCOUNTINSTNAMEILLEGAL for value: BANK_ACCOUNTINSTNAME_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BANK_ACCOUNTINSTNAME_ILLEGAL")]
            BANKACCOUNTINSTNAMEILLEGAL = 34,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 35,

            /// <summary>
            /// Enum GONGSHANGLICENSEILLEGAL for value: GONGSHANG_LICENSE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "GONGSHANG_LICENSE_ILLEGAL")]
            GONGSHANGLICENSEILLEGAL = 36,

            /// <summary>
            /// Enum BUSINESSLICENSEEMPTY for value: BUSINESS_LICENSE_EMPTY
            /// </summary>
            [EnumMember(Value = "BUSINESS_LICENSE_EMPTY")]
            BUSINESSLICENSEEMPTY = 37,

            /// <summary>
            /// Enum MERARGUMENTNULL for value: MER_ARGUMENT_NULL
            /// </summary>
            [EnumMember(Value = "MER_ARGUMENT_NULL")]
            MERARGUMENTNULL = 38,

            /// <summary>
            /// Enum MERCHANTNOTEXIST for value: MERCHANT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "MERCHANT_NOT_EXIST")]
            MERCHANTNOTEXIST = 39,

            /// <summary>
            /// Enum ATTACHMENTTYPEILLEGAL for value: ATTACHMENT_TYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ATTACHMENT_TYPE_ILLEGAL")]
            ATTACHMENTTYPEILLEGAL = 40,

            /// <summary>
            /// Enum SHOPNOTEXIST for value: SHOP_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SHOP_NOT_EXIST")]
            SHOPNOTEXIST = 41,

            /// <summary>
            /// Enum ATTACHMENTURLNULL for value: ATTACHMENT_URL_NULL
            /// </summary>
            [EnumMember(Value = "ATTACHMENT_URL_NULL")]
            ATTACHMENTURLNULL = 42,

            /// <summary>
            /// Enum LOCATIONCHECKFAIL for value: LOCATION_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "LOCATION_CHECK_FAIL")]
            LOCATIONCHECKFAIL = 43,

            /// <summary>
            /// Enum ATTACHMENTCHECKFAIL for value: ATTACHMENT_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "ATTACHMENT_CHECK_FAIL")]
            ATTACHMENTCHECKFAIL = 44,

            /// <summary>
            /// Enum BUSINESSTIMEILLEGAL for value: BUSINESS_TIME_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BUSINESS_TIME_ILLEGAL")]
            BUSINESSTIMEILLEGAL = 45,

            /// <summary>
            /// Enum SHOPAUDITREJECT for value: SHOP_AUDIT_REJECT
            /// </summary>
            [EnumMember(Value = "SHOP_AUDIT_REJECT")]
            SHOPAUDITREJECT = 46

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandShopCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AntMerchantExpandShopCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandShopCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AntMerchantExpandShopCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AntMerchantExpandShopCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AntMerchantExpandShopCreateErrorResponseModel {\n");
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
            return this.Equals(input as AntMerchantExpandShopCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AntMerchantExpandShopCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AntMerchantExpandShopCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntMerchantExpandShopCreateErrorResponseModel input)
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
