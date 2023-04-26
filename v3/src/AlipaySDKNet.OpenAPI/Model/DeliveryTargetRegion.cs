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
    /// DeliveryTargetRegion
    /// </summary>
    [DataContract(Name = "DeliveryTargetRegion")]
    public partial class DeliveryTargetRegion : IEquatable<DeliveryTargetRegion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryTargetRegion" /> class.
        /// </summary>
        /// <param name="regionCode">区域编码，参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03fjbg\&quot; target&#x3D;\&quot;_blank\&quot;&gt;取值说明&lt;/a&gt;.</param>
        /// <param name="regionName">区域名，参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03fjbg\&quot; target&#x3D;\&quot;_blank\&quot;&gt;取值说明&lt;/a&gt;.</param>
        /// <param name="regionType">区域类型，1代表全国，2代表省级区域，3代表市级区域，参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03fjbg\&quot; target&#x3D;\&quot;_blank\&quot;&gt;取值说明&lt;/a&gt;.</param>
        public DeliveryTargetRegion(string regionCode = default(string), string regionName = default(string), string regionType = default(string))
        {
            this.RegionCode = regionCode;
            this.RegionName = regionName;
            this.RegionType = regionType;
        }

        /// <summary>
        /// 区域编码，参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03fjbg\&quot; target&#x3D;\&quot;_blank\&quot;&gt;取值说明&lt;/a&gt;
        /// </summary>
        /// <value>区域编码，参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03fjbg\&quot; target&#x3D;\&quot;_blank\&quot;&gt;取值说明&lt;/a&gt;</value>
        [DataMember(Name = "region_code", EmitDefaultValue = false)]
        public string RegionCode { get; set; }

        /// <summary>
        /// 区域名，参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03fjbg\&quot; target&#x3D;\&quot;_blank\&quot;&gt;取值说明&lt;/a&gt;
        /// </summary>
        /// <value>区域名，参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03fjbg\&quot; target&#x3D;\&quot;_blank\&quot;&gt;取值说明&lt;/a&gt;</value>
        [DataMember(Name = "region_name", EmitDefaultValue = false)]
        public string RegionName { get; set; }

        /// <summary>
        /// 区域类型，1代表全国，2代表省级区域，3代表市级区域，参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03fjbg\&quot; target&#x3D;\&quot;_blank\&quot;&gt;取值说明&lt;/a&gt;
        /// </summary>
        /// <value>区域类型，1代表全国，2代表省级区域，3代表市级区域，参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03fjbg\&quot; target&#x3D;\&quot;_blank\&quot;&gt;取值说明&lt;/a&gt;</value>
        [DataMember(Name = "region_type", EmitDefaultValue = false)]
        public string RegionType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryTargetRegion {\n");
            sb.Append("  RegionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  RegionName: ").Append(RegionName).Append("\n");
            sb.Append("  RegionType: ").Append(RegionType).Append("\n");
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
            return this.Equals(input as DeliveryTargetRegion);
        }

        /// <summary>
        /// Returns true if DeliveryTargetRegion instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryTargetRegion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryTargetRegion input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RegionCode == input.RegionCode ||
                    (this.RegionCode != null &&
                    this.RegionCode.Equals(input.RegionCode))
                ) && 
                (
                    this.RegionName == input.RegionName ||
                    (this.RegionName != null &&
                    this.RegionName.Equals(input.RegionName))
                ) && 
                (
                    this.RegionType == input.RegionType ||
                    (this.RegionType != null &&
                    this.RegionType.Equals(input.RegionType))
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
                if (this.RegionCode != null)
                {
                    hashCode = (hashCode * 59) + this.RegionCode.GetHashCode();
                }
                if (this.RegionName != null)
                {
                    hashCode = (hashCode * 59) + this.RegionName.GetHashCode();
                }
                if (this.RegionType != null)
                {
                    hashCode = (hashCode * 59) + this.RegionType.GetHashCode();
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
