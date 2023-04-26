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
    /// DeliveryChannelInfo
    /// </summary>
    [DataContract(Name = "DeliveryChannelInfo")]
    public partial class DeliveryChannelInfo : IEquatable<DeliveryChannelInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryChannelInfo" /> class.
        /// </summary>
        /// <param name="boothCode">展位码:boothCode表达的是具体渠道所属的展位码。例如：支付结果页PAY_RESULT.</param>
        /// <param name="channel">可投放的渠道标识.  说明： 针对不同的boot_code，channel值各不相同.接口使用者可以认为channel是不同booth_code展位下的渠道的唯一标识。  例如： booth_code为PAYMENT_RESULT。 channel为某个商户的pid。.</param>
        /// <param name="channelName">渠道的名称。  说明： booth_code：PAYMENT_RESULT，channel_name为商户名称。.</param>
        public DeliveryChannelInfo(string boothCode = default(string), string channel = default(string), string channelName = default(string))
        {
            this.BoothCode = boothCode;
            this.Channel = channel;
            this.ChannelName = channelName;
        }

        /// <summary>
        /// 展位码:boothCode表达的是具体渠道所属的展位码。例如：支付结果页PAY_RESULT
        /// </summary>
        /// <value>展位码:boothCode表达的是具体渠道所属的展位码。例如：支付结果页PAY_RESULT</value>
        [DataMember(Name = "booth_code", EmitDefaultValue = false)]
        public string BoothCode { get; set; }

        /// <summary>
        /// 可投放的渠道标识.  说明： 针对不同的boot_code，channel值各不相同.接口使用者可以认为channel是不同booth_code展位下的渠道的唯一标识。  例如： booth_code为PAYMENT_RESULT。 channel为某个商户的pid。
        /// </summary>
        /// <value>可投放的渠道标识.  说明： 针对不同的boot_code，channel值各不相同.接口使用者可以认为channel是不同booth_code展位下的渠道的唯一标识。  例如： booth_code为PAYMENT_RESULT。 channel为某个商户的pid。</value>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string Channel { get; set; }

        /// <summary>
        /// 渠道的名称。  说明： booth_code：PAYMENT_RESULT，channel_name为商户名称。
        /// </summary>
        /// <value>渠道的名称。  说明： booth_code：PAYMENT_RESULT，channel_name为商户名称。</value>
        [DataMember(Name = "channel_name", EmitDefaultValue = false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryChannelInfo {\n");
            sb.Append("  BoothCode: ").Append(BoothCode).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
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
            return this.Equals(input as DeliveryChannelInfo);
        }

        /// <summary>
        /// Returns true if DeliveryChannelInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryChannelInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryChannelInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BoothCode == input.BoothCode ||
                    (this.BoothCode != null &&
                    this.BoothCode.Equals(input.BoothCode))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.ChannelName == input.ChannelName ||
                    (this.ChannelName != null &&
                    this.ChannelName.Equals(input.ChannelName))
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
                if (this.BoothCode != null)
                {
                    hashCode = (hashCode * 59) + this.BoothCode.GetHashCode();
                }
                if (this.Channel != null)
                {
                    hashCode = (hashCode * 59) + this.Channel.GetHashCode();
                }
                if (this.ChannelName != null)
                {
                    hashCode = (hashCode * 59) + this.ChannelName.GetHashCode();
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
