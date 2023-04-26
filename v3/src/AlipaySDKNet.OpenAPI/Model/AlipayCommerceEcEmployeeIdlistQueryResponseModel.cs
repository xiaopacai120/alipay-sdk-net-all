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
    /// AlipayCommerceEcEmployeeIdlistQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcEmployeeIdlistQueryResponseModel")]
    public partial class AlipayCommerceEcEmployeeIdlistQueryResponseModel : IEquatable<AlipayCommerceEcEmployeeIdlistQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcEmployeeIdlistQueryResponseModel" /> class.
        /// </summary>
        /// <param name="currentPage">当前页数.</param>
        /// <param name="employeeIdList">员工id列表.</param>
        /// <param name="totalNum">员工总数.</param>
        /// <param name="totalPages">总页数.</param>
        public AlipayCommerceEcEmployeeIdlistQueryResponseModel(int currentPage = default(int), List<string> employeeIdList = default(List<string>), int totalNum = default(int), int totalPages = default(int))
        {
            this.CurrentPage = currentPage;
            this.EmployeeIdList = employeeIdList;
            this.TotalNum = totalNum;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// 当前页数
        /// </summary>
        /// <value>当前页数</value>
        [DataMember(Name = "current_page", EmitDefaultValue = false)]
        public int CurrentPage { get; set; }

        /// <summary>
        /// 员工id列表
        /// </summary>
        /// <value>员工id列表</value>
        [DataMember(Name = "employee_id_list", EmitDefaultValue = false)]
        public List<string> EmployeeIdList { get; set; }

        /// <summary>
        /// 员工总数
        /// </summary>
        /// <value>员工总数</value>
        [DataMember(Name = "total_num", EmitDefaultValue = false)]
        public int TotalNum { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        /// <value>总页数</value>
        [DataMember(Name = "total_pages", EmitDefaultValue = false)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcEmployeeIdlistQueryResponseModel {\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  EmployeeIdList: ").Append(EmployeeIdList).Append("\n");
            sb.Append("  TotalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcEmployeeIdlistQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcEmployeeIdlistQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcEmployeeIdlistQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcEmployeeIdlistQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurrentPage == input.CurrentPage ||
                    this.CurrentPage.Equals(input.CurrentPage)
                ) && 
                (
                    this.EmployeeIdList == input.EmployeeIdList ||
                    this.EmployeeIdList != null &&
                    input.EmployeeIdList != null &&
                    this.EmployeeIdList.SequenceEqual(input.EmployeeIdList)
                ) && 
                (
                    this.TotalNum == input.TotalNum ||
                    this.TotalNum.Equals(input.TotalNum)
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    this.TotalPages.Equals(input.TotalPages)
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
                hashCode = (hashCode * 59) + this.CurrentPage.GetHashCode();
                if (this.EmployeeIdList != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeIdList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalNum.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPages.GetHashCode();
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
