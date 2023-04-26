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
    /// UserIdentityInfo
    /// </summary>
    [DataContract(Name = "UserIdentityInfo")]
    public partial class UserIdentityInfo : IEquatable<UserIdentityInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdentityInfo" /> class.
        /// </summary>
        /// <param name="hSchoolInfo">hSchoolInfo.</param>
        public UserIdentityInfo(HSchoolInfo hSchoolInfo = default(HSchoolInfo))
        {
            this.HSchoolInfo = hSchoolInfo;
        }

        /// <summary>
        /// Gets or Sets HSchoolInfo
        /// </summary>
        [DataMember(Name = "h_school_info", EmitDefaultValue = false)]
        public HSchoolInfo HSchoolInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserIdentityInfo {\n");
            sb.Append("  HSchoolInfo: ").Append(HSchoolInfo).Append("\n");
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
            return this.Equals(input as UserIdentityInfo);
        }

        /// <summary>
        /// Returns true if UserIdentityInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of UserIdentityInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserIdentityInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HSchoolInfo == input.HSchoolInfo ||
                    (this.HSchoolInfo != null &&
                    this.HSchoolInfo.Equals(input.HSchoolInfo))
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
                if (this.HSchoolInfo != null)
                {
                    hashCode = (hashCode * 59) + this.HSchoolInfo.GetHashCode();
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
