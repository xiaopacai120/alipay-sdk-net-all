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
    /// ShopCommentInfo
    /// </summary>
    [DataContract(Name = "ShopCommentInfo")]
    public partial class ShopCommentInfo : IEquatable<ShopCommentInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopCommentInfo" /> class.
        /// </summary>
        /// <param name="avgPopularity">店铺30天平均人气值.</param>
        /// <param name="avgPopularityName">avg_popularity字段展示文案.</param>
        /// <param name="score">门店评分，评分越高，门店质量越高.</param>
        /// <param name="star">门店星级，0~5,越高，店铺质量越高.</param>
        public ShopCommentInfo(string avgPopularity = default(string), string avgPopularityName = default(string), string score = default(string), string star = default(string))
        {
            this.AvgPopularity = avgPopularity;
            this.AvgPopularityName = avgPopularityName;
            this.Score = score;
            this.Star = star;
        }

        /// <summary>
        /// 店铺30天平均人气值
        /// </summary>
        /// <value>店铺30天平均人气值</value>
        [DataMember(Name = "avg_popularity", EmitDefaultValue = false)]
        public string AvgPopularity { get; set; }

        /// <summary>
        /// avg_popularity字段展示文案
        /// </summary>
        /// <value>avg_popularity字段展示文案</value>
        [DataMember(Name = "avg_popularity_name", EmitDefaultValue = false)]
        public string AvgPopularityName { get; set; }

        /// <summary>
        /// 门店评分，评分越高，门店质量越高
        /// </summary>
        /// <value>门店评分，评分越高，门店质量越高</value>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public string Score { get; set; }

        /// <summary>
        /// 门店星级，0~5,越高，店铺质量越高
        /// </summary>
        /// <value>门店星级，0~5,越高，店铺质量越高</value>
        [DataMember(Name = "star", EmitDefaultValue = false)]
        public string Star { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShopCommentInfo {\n");
            sb.Append("  AvgPopularity: ").Append(AvgPopularity).Append("\n");
            sb.Append("  AvgPopularityName: ").Append(AvgPopularityName).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Star: ").Append(Star).Append("\n");
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
            return this.Equals(input as ShopCommentInfo);
        }

        /// <summary>
        /// Returns true if ShopCommentInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopCommentInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopCommentInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvgPopularity == input.AvgPopularity ||
                    (this.AvgPopularity != null &&
                    this.AvgPopularity.Equals(input.AvgPopularity))
                ) && 
                (
                    this.AvgPopularityName == input.AvgPopularityName ||
                    (this.AvgPopularityName != null &&
                    this.AvgPopularityName.Equals(input.AvgPopularityName))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.Star == input.Star ||
                    (this.Star != null &&
                    this.Star.Equals(input.Star))
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
                if (this.AvgPopularity != null)
                {
                    hashCode = (hashCode * 59) + this.AvgPopularity.GetHashCode();
                }
                if (this.AvgPopularityName != null)
                {
                    hashCode = (hashCode * 59) + this.AvgPopularityName.GetHashCode();
                }
                if (this.Score != null)
                {
                    hashCode = (hashCode * 59) + this.Score.GetHashCode();
                }
                if (this.Star != null)
                {
                    hashCode = (hashCode * 59) + this.Star.GetHashCode();
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
