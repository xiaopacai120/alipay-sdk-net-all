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
    /// ShopBusinessTime
    /// </summary>
    [DataContract(Name = "ShopBusinessTime")]
    public partial class ShopBusinessTime : IEquatable<ShopBusinessTime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopBusinessTime" /> class.
        /// </summary>
        /// <param name="closeTime">关门时间 格式：HH:mm.</param>
        /// <param name="openTime">开门时间 格式：HH:mm.</param>
        /// <param name="weekDay">本对象表示周几的营业时间。1~6表示周一到周六，7表示周日.</param>
        public ShopBusinessTime(string closeTime = default(string), string openTime = default(string), int weekDay = default(int))
        {
            this.CloseTime = closeTime;
            this.OpenTime = openTime;
            this.WeekDay = weekDay;
        }

        /// <summary>
        /// 关门时间 格式：HH:mm
        /// </summary>
        /// <value>关门时间 格式：HH:mm</value>
        [DataMember(Name = "close_time", EmitDefaultValue = false)]
        public string CloseTime { get; set; }

        /// <summary>
        /// 开门时间 格式：HH:mm
        /// </summary>
        /// <value>开门时间 格式：HH:mm</value>
        [DataMember(Name = "open_time", EmitDefaultValue = false)]
        public string OpenTime { get; set; }

        /// <summary>
        /// 本对象表示周几的营业时间。1~6表示周一到周六，7表示周日
        /// </summary>
        /// <value>本对象表示周几的营业时间。1~6表示周一到周六，7表示周日</value>
        [DataMember(Name = "week_day", EmitDefaultValue = false)]
        public int WeekDay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShopBusinessTime {\n");
            sb.Append("  CloseTime: ").Append(CloseTime).Append("\n");
            sb.Append("  OpenTime: ").Append(OpenTime).Append("\n");
            sb.Append("  WeekDay: ").Append(WeekDay).Append("\n");
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
            return this.Equals(input as ShopBusinessTime);
        }

        /// <summary>
        /// Returns true if ShopBusinessTime instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopBusinessTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopBusinessTime input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CloseTime == input.CloseTime ||
                    (this.CloseTime != null &&
                    this.CloseTime.Equals(input.CloseTime))
                ) && 
                (
                    this.OpenTime == input.OpenTime ||
                    (this.OpenTime != null &&
                    this.OpenTime.Equals(input.OpenTime))
                ) && 
                (
                    this.WeekDay == input.WeekDay ||
                    this.WeekDay.Equals(input.WeekDay)
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
                if (this.CloseTime != null)
                {
                    hashCode = (hashCode * 59) + this.CloseTime.GetHashCode();
                }
                if (this.OpenTime != null)
                {
                    hashCode = (hashCode * 59) + this.OpenTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.WeekDay.GetHashCode();
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
