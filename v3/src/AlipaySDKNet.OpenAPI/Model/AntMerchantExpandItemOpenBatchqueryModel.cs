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
    /// AntMerchantExpandItemOpenBatchqueryModel
    /// </summary>
    [DataContract(Name = "AntMerchantExpandItemOpenBatchqueryModel")]
    public partial class AntMerchantExpandItemOpenBatchqueryModel : IEquatable<AntMerchantExpandItemOpenBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandItemOpenBatchqueryModel" /> class.
        /// </summary>
        /// <param name="itemIdList">商品ID列表，单次查询上限为 20。.</param>
        public AntMerchantExpandItemOpenBatchqueryModel(List<string> itemIdList = default(List<string>))
        {
            this.ItemIdList = itemIdList;
        }

        /// <summary>
        /// 商品ID列表，单次查询上限为 20。
        /// </summary>
        /// <value>商品ID列表，单次查询上限为 20。</value>
        [DataMember(Name = "item_id_list", EmitDefaultValue = false)]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AntMerchantExpandItemOpenBatchqueryModel {\n");
            sb.Append("  ItemIdList: ").Append(ItemIdList).Append("\n");
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
            return this.Equals(input as AntMerchantExpandItemOpenBatchqueryModel);
        }

        /// <summary>
        /// Returns true if AntMerchantExpandItemOpenBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AntMerchantExpandItemOpenBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntMerchantExpandItemOpenBatchqueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemIdList == input.ItemIdList ||
                    this.ItemIdList != null &&
                    input.ItemIdList != null &&
                    this.ItemIdList.SequenceEqual(input.ItemIdList)
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
                if (this.ItemIdList != null)
                {
                    hashCode = (hashCode * 59) + this.ItemIdList.GetHashCode();
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
