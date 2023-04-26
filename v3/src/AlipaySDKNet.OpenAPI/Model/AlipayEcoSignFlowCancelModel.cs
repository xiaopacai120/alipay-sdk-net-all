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
    /// AlipayEcoSignFlowCancelModel
    /// </summary>
    [DataContract(Name = "AlipayEcoSignFlowCancelModel")]
    public partial class AlipayEcoSignFlowCancelModel : IEquatable<AlipayEcoSignFlowCancelModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoSignFlowCancelModel" /> class.
        /// </summary>
        /// <param name="flowId">流程id，通过 &lt;a href &#x3D;\&quot;https://opendocs.alipay.com/apis/api_50/alipay.eco.contract.signflows.create\&quot;&gt;创建电子合同签署流程&lt;/a&gt;(alipay.eco.contract.signflows.create)接口获取。.</param>
        /// <param name="revokeReason">撤销原因，默认为\&quot;撤销\&quot;。商家可自定义。.</param>
        public AlipayEcoSignFlowCancelModel(string flowId = default(string), string revokeReason = default(string))
        {
            this.FlowId = flowId;
            this.RevokeReason = revokeReason;
        }

        /// <summary>
        /// 流程id，通过 &lt;a href &#x3D;\&quot;https://opendocs.alipay.com/apis/api_50/alipay.eco.contract.signflows.create\&quot;&gt;创建电子合同签署流程&lt;/a&gt;(alipay.eco.contract.signflows.create)接口获取。
        /// </summary>
        /// <value>流程id，通过 &lt;a href &#x3D;\&quot;https://opendocs.alipay.com/apis/api_50/alipay.eco.contract.signflows.create\&quot;&gt;创建电子合同签署流程&lt;/a&gt;(alipay.eco.contract.signflows.create)接口获取。</value>
        [DataMember(Name = "flow_id", EmitDefaultValue = false)]
        public string FlowId { get; set; }

        /// <summary>
        /// 撤销原因，默认为\&quot;撤销\&quot;。商家可自定义。
        /// </summary>
        /// <value>撤销原因，默认为\&quot;撤销\&quot;。商家可自定义。</value>
        [DataMember(Name = "revoke_reason", EmitDefaultValue = false)]
        public string RevokeReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoSignFlowCancelModel {\n");
            sb.Append("  FlowId: ").Append(FlowId).Append("\n");
            sb.Append("  RevokeReason: ").Append(RevokeReason).Append("\n");
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
            return this.Equals(input as AlipayEcoSignFlowCancelModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoSignFlowCancelModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoSignFlowCancelModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoSignFlowCancelModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FlowId == input.FlowId ||
                    (this.FlowId != null &&
                    this.FlowId.Equals(input.FlowId))
                ) && 
                (
                    this.RevokeReason == input.RevokeReason ||
                    (this.RevokeReason != null &&
                    this.RevokeReason.Equals(input.RevokeReason))
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
                if (this.FlowId != null)
                {
                    hashCode = (hashCode * 59) + this.FlowId.GetHashCode();
                }
                if (this.RevokeReason != null)
                {
                    hashCode = (hashCode * 59) + this.RevokeReason.GetHashCode();
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
