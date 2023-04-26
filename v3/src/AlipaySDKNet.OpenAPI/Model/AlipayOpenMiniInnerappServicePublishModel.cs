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
    /// AlipayOpenMiniInnerappServicePublishModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerappServicePublishModel")]
    public partial class AlipayOpenMiniInnerappServicePublishModel : IEquatable<AlipayOpenMiniInnerappServicePublishModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerappServicePublishModel" /> class.
        /// </summary>
        /// <param name="appLogo">服务发布logo.</param>
        /// <param name="appOrigin">业务来源.</param>
        /// <param name="miniAppId">小程序ID，仅特殊场景使用，普通业务方无需关注该参数。.</param>
        /// <param name="pid">小程序模板所属PID.</param>
        /// <param name="subTitle">服务子标题.</param>
        /// <param name="title">服务名称.</param>
        public AlipayOpenMiniInnerappServicePublishModel(string appLogo = default(string), string appOrigin = default(string), string miniAppId = default(string), string pid = default(string), string subTitle = default(string), string title = default(string))
        {
            this.AppLogo = appLogo;
            this.AppOrigin = appOrigin;
            this.MiniAppId = miniAppId;
            this.Pid = pid;
            this.SubTitle = subTitle;
            this.Title = title;
        }

        /// <summary>
        /// 服务发布logo
        /// </summary>
        /// <value>服务发布logo</value>
        [DataMember(Name = "app_logo", EmitDefaultValue = false)]
        public string AppLogo { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        /// <value>业务来源</value>
        [DataMember(Name = "app_origin", EmitDefaultValue = false)]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序ID，仅特殊场景使用，普通业务方无需关注该参数。
        /// </summary>
        /// <value>小程序ID，仅特殊场景使用，普通业务方无需关注该参数。</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序模板所属PID
        /// </summary>
        /// <value>小程序模板所属PID</value>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// 服务子标题
        /// </summary>
        /// <value>服务子标题</value>
        [DataMember(Name = "sub_title", EmitDefaultValue = false)]
        public string SubTitle { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        /// <value>服务名称</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerappServicePublishModel {\n");
            sb.Append("  AppLogo: ").Append(AppLogo).Append("\n");
            sb.Append("  AppOrigin: ").Append(AppOrigin).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
            sb.Append("  SubTitle: ").Append(SubTitle).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniInnerappServicePublishModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerappServicePublishModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerappServicePublishModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerappServicePublishModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppLogo == input.AppLogo ||
                    (this.AppLogo != null &&
                    this.AppLogo.Equals(input.AppLogo))
                ) && 
                (
                    this.AppOrigin == input.AppOrigin ||
                    (this.AppOrigin != null &&
                    this.AppOrigin.Equals(input.AppOrigin))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
                ) && 
                (
                    this.SubTitle == input.SubTitle ||
                    (this.SubTitle != null &&
                    this.SubTitle.Equals(input.SubTitle))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.AppLogo != null)
                {
                    hashCode = (hashCode * 59) + this.AppLogo.GetHashCode();
                }
                if (this.AppOrigin != null)
                {
                    hashCode = (hashCode * 59) + this.AppOrigin.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.Pid != null)
                {
                    hashCode = (hashCode * 59) + this.Pid.GetHashCode();
                }
                if (this.SubTitle != null)
                {
                    hashCode = (hashCode * 59) + this.SubTitle.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
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
