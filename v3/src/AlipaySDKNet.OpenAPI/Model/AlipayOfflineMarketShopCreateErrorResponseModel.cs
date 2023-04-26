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
    /// AlipayOfflineMarketShopCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOfflineMarketShopCreateErrorResponseModel")]
    public partial class AlipayOfflineMarketShopCreateErrorResponseModel : IEquatable<AlipayOfflineMarketShopCreateErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum SHOPCREATESYSTEMERROR for value: SHOP_CREATE_SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_SYSTEM_ERROR")]
            SHOPCREATESYSTEMERROR = 1,

            /// <summary>
            /// Enum SHOPCREATEINVALIDPARAM for value: SHOP_CREATE_INVALID_PARAM
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_INVALID_PARAM")]
            SHOPCREATEINVALIDPARAM = 2,

            /// <summary>
            /// Enum SHOPCREATEUNIQUECONSTRAINTSHOPERROR for value: SHOP_CREATE_UNIQUE_CONSTRAINT_SHOP_ERROR
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_UNIQUE_CONSTRAINT_SHOP_ERROR")]
            SHOPCREATEUNIQUECONSTRAINTSHOPERROR = 3,

            /// <summary>
            /// Enum SHOPCREATEUNIQUECONSTRAINTIMPLEMENTIDERROR for value: SHOP_CREATE_UNIQUE_CONSTRAINT_IMPLEMENTID_ERROR
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_UNIQUE_CONSTRAINT_IMPLEMENTID_ERROR")]
            SHOPCREATEUNIQUECONSTRAINTIMPLEMENTIDERROR = 4,

            /// <summary>
            /// Enum SHOPCREATEUNIQUECONSTRAINTOUTSHOPIDERROR for value: SHOP_CREATE_UNIQUE_CONSTRAINT_OUTSHOPID_ERROR
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_UNIQUE_CONSTRAINT_OUTSHOPID_ERROR")]
            SHOPCREATEUNIQUECONSTRAINTOUTSHOPIDERROR = 5,

            /// <summary>
            /// Enum SHOPCREATECATOGORYNOTEXISTS for value: SHOP_CREATE_CATOGORY_NOT_EXISTS
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_CATOGORY_NOT_EXISTS")]
            SHOPCREATECATOGORYNOTEXISTS = 6,

            /// <summary>
            /// Enum SHOPCREATENOCONTRACT for value: SHOP_CREATE_NO_CONTRACT
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_NO_CONTRACT")]
            SHOPCREATENOCONTRACT = 7,

            /// <summary>
            /// Enum SHOPCREATENOPROVIDERCONTRACT for value: SHOP_CREATE_NO_PROVIDER_CONTRACT
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_NO_PROVIDER_CONTRACT")]
            SHOPCREATENOPROVIDERCONTRACT = 8,

            /// <summary>
            /// Enum SHOPCREATENOPROVIDERMERCHANTRELATION for value: SHOP_CREATE_NO_PROVIDER_MERCHANT_RELATION
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_NO_PROVIDER_MERCHANT_RELATION")]
            SHOPCREATENOPROVIDERMERCHANTRELATION = 9,

            /// <summary>
            /// Enum SHOPCREATEINVALIDPROVIDERSTAFF for value: SHOP_CREATE_INVALID_PROVIDER_STAFF
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_INVALID_PROVIDER_STAFF")]
            SHOPCREATEINVALIDPROVIDERSTAFF = 10,

            /// <summary>
            /// Enum SHOPCREATESHOPJUDGEFAIL for value: SHOP_CREATE_SHOP_JUDGE_FAIL
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_SHOP_JUDGE_FAIL")]
            SHOPCREATESHOPJUDGEFAIL = 11,

            /// <summary>
            /// Enum SHOPCREATELICENSEEXPIRES for value: SHOP_CREATE_LICENSE_EXPIRES
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_LICENSE_EXPIRES")]
            SHOPCREATELICENSEEXPIRES = 12,

            /// <summary>
            /// Enum SHOPCREATECTUFAIL for value: SHOP_CREATE_CTU_FAIL
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_CTU_FAIL")]
            SHOPCREATECTUFAIL = 13,

            /// <summary>
            /// Enum LICENSEISREQUIRED for value: LICENSE_IS_REQUIRED
            /// </summary>
            [EnumMember(Value = "LICENSE_IS_REQUIRED")]
            LICENSEISREQUIRED = 14,

            /// <summary>
            /// Enum CERTIFICATEISREQUIRED for value: CERTIFICATE_IS_REQUIRED
            /// </summary>
            [EnumMember(Value = "CERTIFICATE_IS_REQUIRED")]
            CERTIFICATEISREQUIRED = 15,

            /// <summary>
            /// Enum SHOPCATEGORYNOTMATCHCITY for value: SHOP_CATEGORY_NOT_MATCH_CITY
            /// </summary>
            [EnumMember(Value = "SHOP_CATEGORY_NOT_MATCH_CITY")]
            SHOPCATEGORYNOTMATCHCITY = 16,

            /// <summary>
            /// Enum BRANDCATEGORYNOTMATCH for value: BRAND_CATEGORY_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "BRAND_CATEGORY_NOT_MATCH")]
            BRANDCATEGORYNOTMATCH = 17,

            /// <summary>
            /// Enum IMPLEMENTIDINVALID for value: IMPLEMENT_ID_INVALID
            /// </summary>
            [EnumMember(Value = "IMPLEMENT_ID_INVALID")]
            IMPLEMENTIDINVALID = 18,

            /// <summary>
            /// Enum EXISTFORBIDDENWORD for value: EXIST_FORBIDDEN_WORD
            /// </summary>
            [EnumMember(Value = "EXIST_FORBIDDEN_WORD")]
            EXISTFORBIDDENWORD = 19,

            /// <summary>
            /// Enum MERCHANTNOTEXIST for value: MERCHANT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "MERCHANT_NOT_EXIST")]
            MERCHANTNOTEXIST = 20,

            /// <summary>
            /// Enum LICENSECODEREPEATERROR for value: LICENSE_CODE_REPEAT_ERROR
            /// </summary>
            [EnumMember(Value = "LICENSE_CODE_REPEAT_ERROR")]
            LICENSECODEREPEATERROR = 21,

            /// <summary>
            /// Enum SHOPCREATELICENSEPRINCIPALNOTMATCH for value: SHOP_CREATE_LICENSE_PRINCIPAL_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_LICENSE_PRINCIPAL_NOT_MATCH")]
            SHOPCREATELICENSEPRINCIPALNOTMATCH = 22,

            /// <summary>
            /// Enum SHOPCREATELOCATIONVALIDATEFAIL for value: SHOP_CREATE_LOCATION_VALIDATE_FAIL
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_LOCATION_VALIDATE_FAIL")]
            SHOPCREATELOCATIONVALIDATEFAIL = 23,

            /// <summary>
            /// Enum MERCHANTNOTACERTIFIED for value: MERCHANT_NOT_A_CERTIFIED
            /// </summary>
            [EnumMember(Value = "MERCHANT_NOT_A_CERTIFIED")]
            MERCHANTNOTACERTIFIED = 24,

            /// <summary>
            /// Enum SHOPCREATEREPEATREQUEST for value: SHOP_CREATE_REPEAT_REQUEST
            /// </summary>
            [EnumMember(Value = "SHOP_CREATE_REPEAT_REQUEST")]
            SHOPCREATEREPEATREQUEST = 25,

            /// <summary>
            /// Enum MERCHANTCANNOTSIGNKOUBEI for value: MERCHANT_CAN_NOT_SIGN_KOUBEI
            /// </summary>
            [EnumMember(Value = "MERCHANT_CAN_NOT_SIGN_KOUBEI")]
            MERCHANTCANNOTSIGNKOUBEI = 26,

            /// <summary>
            /// Enum AREACANNOTNULL for value: AREA_CAN_NOT_NULL
            /// </summary>
            [EnumMember(Value = "AREA_CAN_NOT_NULL")]
            AREACANNOTNULL = 27,

            /// <summary>
            /// Enum AREANOTLEGALITY for value: AREA_NOT_LEGALITY
            /// </summary>
            [EnumMember(Value = "AREA_NOT_LEGALITY")]
            AREANOTLEGALITY = 28,

            /// <summary>
            /// Enum LICENSENORULEERROR for value: LICENSE_NO_RULE_ERROR
            /// </summary>
            [EnumMember(Value = "LICENSE_NO_RULE_ERROR")]
            LICENSENORULEERROR = 29,

            /// <summary>
            /// Enum BUSINESSTIMERULEERROR for value: BUSINESS_TIME_RULE_ERROR
            /// </summary>
            [EnumMember(Value = "BUSINESS_TIME_RULE_ERROR")]
            BUSINESSTIMERULEERROR = 30,

            /// <summary>
            /// Enum OUTSHOPIDRULEERROR for value: OUT_SHOP_ID_RULE_ERROR
            /// </summary>
            [EnumMember(Value = "OUT_SHOP_ID_RULE_ERROR")]
            OUTSHOPIDRULEERROR = 31,

            /// <summary>
            /// Enum VALIDITYDATERULEERROR for value: VALIDITYDATE_RULE_ERROR
            /// </summary>
            [EnumMember(Value = "VALIDITYDATE_RULE_ERROR")]
            VALIDITYDATERULEERROR = 32,

            /// <summary>
            /// Enum RATESTANDARDNOTEXIST for value: RATE_STANDARD_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "RATE_STANDARD_NOT_EXIST")]
            RATESTANDARDNOTEXIST = 33,

            /// <summary>
            /// Enum RATEEXCEEDSTANDARDRANGE for value: RATE_EXCEED_STANDARD_RANGE
            /// </summary>
            [EnumMember(Value = "RATE_EXCEED_STANDARD_RANGE")]
            RATEEXCEEDSTANDARDRANGE = 34,

            /// <summary>
            /// Enum SUBJECTNOSUPPORTRATE for value: SUBJECT_NO_SUPPORT_RATE
            /// </summary>
            [EnumMember(Value = "SUBJECT_NO_SUPPORT_RATE")]
            SUBJECTNOSUPPORTRATE = 35,

            /// <summary>
            /// Enum RATEPATTERNERROR for value: RATE_PATTERN_ERROR
            /// </summary>
            [EnumMember(Value = "RATE_PATTERN_ERROR")]
            RATEPATTERNERROR = 36,

            /// <summary>
            /// Enum RATEPAYCATEGORYERROR for value: RATE_PAY_CATEGORY_ERROR
            /// </summary>
            [EnumMember(Value = "RATE_PAY_CATEGORY_ERROR")]
            RATEPAYCATEGORYERROR = 37

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOfflineMarketShopCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOfflineMarketShopCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOfflineMarketShopCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOfflineMarketShopCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOfflineMarketShopCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOfflineMarketShopCreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOfflineMarketShopCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOfflineMarketShopCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOfflineMarketShopCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOfflineMarketShopCreateErrorResponseModel input)
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
