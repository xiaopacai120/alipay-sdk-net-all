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
    /// TemplateCardLevelConfDTO
    /// </summary>
    [DataContract(Name = "TemplateCardLevelConfDTO")]
    public partial class TemplateCardLevelConfDTO : IEquatable<TemplateCardLevelConfDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateCardLevelConfDTO" /> class.
        /// </summary>
        /// <param name="level">会员级别 该级别和开卡接口中的level要一致.</param>
        /// <param name="levelDesc">会员级别描述.</param>
        /// <param name="levelIcon">会员级别对应icon， 通过接口（alipay.offline.material.image.upload）上传图片.</param>
        /// <param name="levelShowName">会员级别显示名称.</param>
        public TemplateCardLevelConfDTO(string level = default(string), string levelDesc = default(string), string levelIcon = default(string), string levelShowName = default(string))
        {
            this.Level = level;
            this.LevelDesc = levelDesc;
            this.LevelIcon = levelIcon;
            this.LevelShowName = levelShowName;
        }

        /// <summary>
        /// 会员级别 该级别和开卡接口中的level要一致
        /// </summary>
        /// <value>会员级别 该级别和开卡接口中的level要一致</value>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public string Level { get; set; }

        /// <summary>
        /// 会员级别描述
        /// </summary>
        /// <value>会员级别描述</value>
        [DataMember(Name = "level_desc", EmitDefaultValue = false)]
        public string LevelDesc { get; set; }

        /// <summary>
        /// 会员级别对应icon， 通过接口（alipay.offline.material.image.upload）上传图片
        /// </summary>
        /// <value>会员级别对应icon， 通过接口（alipay.offline.material.image.upload）上传图片</value>
        [DataMember(Name = "level_icon", EmitDefaultValue = false)]
        public string LevelIcon { get; set; }

        /// <summary>
        /// 会员级别显示名称
        /// </summary>
        /// <value>会员级别显示名称</value>
        [DataMember(Name = "level_show_name", EmitDefaultValue = false)]
        public string LevelShowName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateCardLevelConfDTO {\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  LevelDesc: ").Append(LevelDesc).Append("\n");
            sb.Append("  LevelIcon: ").Append(LevelIcon).Append("\n");
            sb.Append("  LevelShowName: ").Append(LevelShowName).Append("\n");
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
            return this.Equals(input as TemplateCardLevelConfDTO);
        }

        /// <summary>
        /// Returns true if TemplateCardLevelConfDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateCardLevelConfDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateCardLevelConfDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.LevelDesc == input.LevelDesc ||
                    (this.LevelDesc != null &&
                    this.LevelDesc.Equals(input.LevelDesc))
                ) && 
                (
                    this.LevelIcon == input.LevelIcon ||
                    (this.LevelIcon != null &&
                    this.LevelIcon.Equals(input.LevelIcon))
                ) && 
                (
                    this.LevelShowName == input.LevelShowName ||
                    (this.LevelShowName != null &&
                    this.LevelShowName.Equals(input.LevelShowName))
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
                if (this.Level != null)
                {
                    hashCode = (hashCode * 59) + this.Level.GetHashCode();
                }
                if (this.LevelDesc != null)
                {
                    hashCode = (hashCode * 59) + this.LevelDesc.GetHashCode();
                }
                if (this.LevelIcon != null)
                {
                    hashCode = (hashCode * 59) + this.LevelIcon.GetHashCode();
                }
                if (this.LevelShowName != null)
                {
                    hashCode = (hashCode * 59) + this.LevelShowName.GetHashCode();
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
