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
    /// AlipayOpenMiniWidgetGoodsQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniWidgetGoodsQueryResponseModel")]
    public partial class AlipayOpenMiniWidgetGoodsQueryResponseModel : IEquatable<AlipayOpenMiniWidgetGoodsQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniWidgetGoodsQueryResponseModel" /> class.
        /// </summary>
        /// <param name="dataList">商品信息列表.</param>
        /// <param name="pageNum">查询第几页.</param>
        /// <param name="pageSize">查询页面数量.</param>
        /// <param name="total">查询结果总数.</param>
        public AlipayOpenMiniWidgetGoodsQueryResponseModel(List<GoodsQueryResponse> dataList = default(List<GoodsQueryResponse>), int pageNum = default(int), int pageSize = default(int), int total = default(int))
        {
            this.DataList = dataList;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.Total = total;
        }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        /// <value>商品信息列表</value>
        [DataMember(Name = "data_list", EmitDefaultValue = false)]
        public List<GoodsQueryResponse> DataList { get; set; }

        /// <summary>
        /// 查询第几页
        /// </summary>
        /// <value>查询第几页</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 查询页面数量
        /// </summary>
        /// <value>查询页面数量</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 查询结果总数
        /// </summary>
        /// <value>查询结果总数</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniWidgetGoodsQueryResponseModel {\n");
            sb.Append("  DataList: ").Append(DataList).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniWidgetGoodsQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniWidgetGoodsQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniWidgetGoodsQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniWidgetGoodsQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DataList == input.DataList ||
                    this.DataList != null &&
                    input.DataList != null &&
                    this.DataList.SequenceEqual(input.DataList)
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
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
                if (this.DataList != null)
                {
                    hashCode = (hashCode * 59) + this.DataList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
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
