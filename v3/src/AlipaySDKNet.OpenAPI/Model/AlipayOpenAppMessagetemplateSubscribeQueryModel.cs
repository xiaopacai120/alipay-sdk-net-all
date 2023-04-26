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
    /// AlipayOpenAppMessagetemplateSubscribeQueryModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAppMessagetemplateSubscribeQueryModel")]
    public partial class AlipayOpenAppMessagetemplateSubscribeQueryModel : IEquatable<AlipayOpenAppMessagetemplateSubscribeQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAppMessagetemplateSubscribeQueryModel" /> class.
        /// </summary>
        /// <param name="openId">支付宝openId，用于支付宝用户在当前应用下的用户标识。.</param>
        /// <param name="templateIdList">消息模板id，可以填写多个，最多不超过3个。模板id需要保持同一个应用主体，并且展示在同一个订阅组件中的模板id。 模板id获取详情参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/01rnqx\&quot;&gt;模板消息&lt;/a&gt;。.</param>
        /// <param name="userId">订阅消息模板用户的支付宝唯一标识，2088开头。.</param>
        public AlipayOpenAppMessagetemplateSubscribeQueryModel(string openId = default(string), List<string> templateIdList = default(List<string>), string userId = default(string))
        {
            this.OpenId = openId;
            this.TemplateIdList = templateIdList;
            this.UserId = userId;
        }

        /// <summary>
        /// 支付宝openId，用于支付宝用户在当前应用下的用户标识。
        /// </summary>
        /// <value>支付宝openId，用于支付宝用户在当前应用下的用户标识。</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 消息模板id，可以填写多个，最多不超过3个。模板id需要保持同一个应用主体，并且展示在同一个订阅组件中的模板id。 模板id获取详情参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/01rnqx\&quot;&gt;模板消息&lt;/a&gt;。
        /// </summary>
        /// <value>消息模板id，可以填写多个，最多不超过3个。模板id需要保持同一个应用主体，并且展示在同一个订阅组件中的模板id。 模板id获取详情参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/01rnqx\&quot;&gt;模板消息&lt;/a&gt;。</value>
        [DataMember(Name = "template_id_list", EmitDefaultValue = false)]
        public List<string> TemplateIdList { get; set; }

        /// <summary>
        /// 订阅消息模板用户的支付宝唯一标识，2088开头。
        /// </summary>
        /// <value>订阅消息模板用户的支付宝唯一标识，2088开头。</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAppMessagetemplateSubscribeQueryModel {\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  TemplateIdList: ").Append(TemplateIdList).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as AlipayOpenAppMessagetemplateSubscribeQueryModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAppMessagetemplateSubscribeQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAppMessagetemplateSubscribeQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAppMessagetemplateSubscribeQueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.TemplateIdList == input.TemplateIdList ||
                    this.TemplateIdList != null &&
                    input.TemplateIdList != null &&
                    this.TemplateIdList.SequenceEqual(input.TemplateIdList)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.TemplateIdList != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateIdList.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
