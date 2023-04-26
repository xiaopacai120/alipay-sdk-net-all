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
    /// ContactModel
    /// </summary>
    [DataContract(Name = "ContactModel")]
    public partial class ContactModel : IEquatable<ContactModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactModel" /> class.
        /// </summary>
        /// <param name="contactEmail">联系人邮箱.</param>
        /// <param name="contactMobile">联系人手机号码.</param>
        /// <param name="contactName">联系人名称.</param>
        public ContactModel(string contactEmail = default(string), string contactMobile = default(string), string contactName = default(string))
        {
            this.ContactEmail = contactEmail;
            this.ContactMobile = contactMobile;
            this.ContactName = contactName;
        }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        /// <value>联系人邮箱</value>
        [DataMember(Name = "contact_email", EmitDefaultValue = false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人手机号码
        /// </summary>
        /// <value>联系人手机号码</value>
        [DataMember(Name = "contact_mobile", EmitDefaultValue = false)]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        /// <value>联系人名称</value>
        [DataMember(Name = "contact_name", EmitDefaultValue = false)]
        public string ContactName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContactModel {\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  ContactMobile: ").Append(ContactMobile).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
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
            return this.Equals(input as ContactModel);
        }

        /// <summary>
        /// Returns true if ContactModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContactEmail == input.ContactEmail ||
                    (this.ContactEmail != null &&
                    this.ContactEmail.Equals(input.ContactEmail))
                ) && 
                (
                    this.ContactMobile == input.ContactMobile ||
                    (this.ContactMobile != null &&
                    this.ContactMobile.Equals(input.ContactMobile))
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
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
                if (this.ContactEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ContactEmail.GetHashCode();
                }
                if (this.ContactMobile != null)
                {
                    hashCode = (hashCode * 59) + this.ContactMobile.GetHashCode();
                }
                if (this.ContactName != null)
                {
                    hashCode = (hashCode * 59) + this.ContactName.GetHashCode();
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
