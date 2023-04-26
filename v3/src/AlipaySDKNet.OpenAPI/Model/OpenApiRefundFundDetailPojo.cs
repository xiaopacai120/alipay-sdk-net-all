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
    /// OpenApiRefundFundDetailPojo
    /// </summary>
    [DataContract(Name = "OpenApiRefundFundDetailPojo")]
    public partial class OpenApiRefundFundDetailPojo : IEquatable<OpenApiRefundFundDetailPojo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenApiRefundFundDetailPojo" /> class.
        /// </summary>
        /// <param name="funds">退款资金明细  详：  若type为paySerialNo则funds为  [{\&quot;paySerialNo\&quot;:\&quot;支付流水1\&quot;,\&quot;refundFee\&quot;:\&quot;退款金额1\&quot;},{\&quot;paySerialNo\&quot;:\&quot;支付流水2\&quot;,\&quot;refundFee\&quot;:\&quot;退款金额2\&quot;}].</param>
        /// <param name="transIn">收入方账户  为空则原路退回.</param>
        /// <param name="transInType">收入方账户类型.</param>
        /// <param name="type">描述资金明细类型  详：若type为paySerialNo  则funds参数中体现的都为对应支付流水的退款明细.</param>
        public OpenApiRefundFundDetailPojo(List<string> funds = default(List<string>), string transIn = default(string), string transInType = default(string), string type = default(string))
        {
            this.Funds = funds;
            this.TransIn = transIn;
            this.TransInType = transInType;
            this.Type = type;
        }

        /// <summary>
        /// 退款资金明细  详：  若type为paySerialNo则funds为  [{\&quot;paySerialNo\&quot;:\&quot;支付流水1\&quot;,\&quot;refundFee\&quot;:\&quot;退款金额1\&quot;},{\&quot;paySerialNo\&quot;:\&quot;支付流水2\&quot;,\&quot;refundFee\&quot;:\&quot;退款金额2\&quot;}]
        /// </summary>
        /// <value>退款资金明细  详：  若type为paySerialNo则funds为  [{\&quot;paySerialNo\&quot;:\&quot;支付流水1\&quot;,\&quot;refundFee\&quot;:\&quot;退款金额1\&quot;},{\&quot;paySerialNo\&quot;:\&quot;支付流水2\&quot;,\&quot;refundFee\&quot;:\&quot;退款金额2\&quot;}]</value>
        [DataMember(Name = "funds", EmitDefaultValue = false)]
        public List<string> Funds { get; set; }

        /// <summary>
        /// 收入方账户  为空则原路退回
        /// </summary>
        /// <value>收入方账户  为空则原路退回</value>
        [DataMember(Name = "trans_in", EmitDefaultValue = false)]
        public string TransIn { get; set; }

        /// <summary>
        /// 收入方账户类型
        /// </summary>
        /// <value>收入方账户类型</value>
        [DataMember(Name = "trans_in_type", EmitDefaultValue = false)]
        public string TransInType { get; set; }

        /// <summary>
        /// 描述资金明细类型  详：若type为paySerialNo  则funds参数中体现的都为对应支付流水的退款明细
        /// </summary>
        /// <value>描述资金明细类型  详：若type为paySerialNo  则funds参数中体现的都为对应支付流水的退款明细</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OpenApiRefundFundDetailPojo {\n");
            sb.Append("  Funds: ").Append(Funds).Append("\n");
            sb.Append("  TransIn: ").Append(TransIn).Append("\n");
            sb.Append("  TransInType: ").Append(TransInType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as OpenApiRefundFundDetailPojo);
        }

        /// <summary>
        /// Returns true if OpenApiRefundFundDetailPojo instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenApiRefundFundDetailPojo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenApiRefundFundDetailPojo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Funds == input.Funds ||
                    this.Funds != null &&
                    input.Funds != null &&
                    this.Funds.SequenceEqual(input.Funds)
                ) && 
                (
                    this.TransIn == input.TransIn ||
                    (this.TransIn != null &&
                    this.TransIn.Equals(input.TransIn))
                ) && 
                (
                    this.TransInType == input.TransInType ||
                    (this.TransInType != null &&
                    this.TransInType.Equals(input.TransInType))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Funds != null)
                {
                    hashCode = (hashCode * 59) + this.Funds.GetHashCode();
                }
                if (this.TransIn != null)
                {
                    hashCode = (hashCode * 59) + this.TransIn.GetHashCode();
                }
                if (this.TransInType != null)
                {
                    hashCode = (hashCode * 59) + this.TransInType.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
