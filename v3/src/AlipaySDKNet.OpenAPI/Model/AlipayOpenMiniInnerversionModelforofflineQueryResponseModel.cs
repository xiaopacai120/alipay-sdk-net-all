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
    /// AlipayOpenMiniInnerversionModelforofflineQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerversionModelforofflineQueryResponseModel")]
    public partial class AlipayOpenMiniInnerversionModelforofflineQueryResponseModel : IEquatable<AlipayOpenMiniInnerversionModelforofflineQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionModelforofflineQueryResponseModel" /> class.
        /// </summary>
        /// <param name="modelJson">线上版本包数据.</param>
        /// <param name="syncId">同步ID，同步失败时便于去线上追溯.</param>
        public AlipayOpenMiniInnerversionModelforofflineQueryResponseModel(string modelJson = default(string), string syncId = default(string))
        {
            this.ModelJson = modelJson;
            this.SyncId = syncId;
        }

        /// <summary>
        /// 线上版本包数据
        /// </summary>
        /// <value>线上版本包数据</value>
        [DataMember(Name = "model_json", EmitDefaultValue = false)]
        public string ModelJson { get; set; }

        /// <summary>
        /// 同步ID，同步失败时便于去线上追溯
        /// </summary>
        /// <value>同步ID，同步失败时便于去线上追溯</value>
        [DataMember(Name = "sync_id", EmitDefaultValue = false)]
        public string SyncId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerversionModelforofflineQueryResponseModel {\n");
            sb.Append("  ModelJson: ").Append(ModelJson).Append("\n");
            sb.Append("  SyncId: ").Append(SyncId).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniInnerversionModelforofflineQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionModelforofflineQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionModelforofflineQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionModelforofflineQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ModelJson == input.ModelJson ||
                    (this.ModelJson != null &&
                    this.ModelJson.Equals(input.ModelJson))
                ) && 
                (
                    this.SyncId == input.SyncId ||
                    (this.SyncId != null &&
                    this.SyncId.Equals(input.SyncId))
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
                if (this.ModelJson != null)
                {
                    hashCode = (hashCode * 59) + this.ModelJson.GetHashCode();
                }
                if (this.SyncId != null)
                {
                    hashCode = (hashCode * 59) + this.SyncId.GetHashCode();
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
