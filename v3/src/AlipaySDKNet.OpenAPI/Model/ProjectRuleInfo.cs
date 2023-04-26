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
    /// ProjectRuleInfo
    /// </summary>
    [DataContract(Name = "ProjectRuleInfo")]
    public partial class ProjectRuleInfo : IEquatable<ProjectRuleInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRuleInfo" /> class.
        /// </summary>
        /// <param name="effectiveEndDate">有效期截止.</param>
        /// <param name="effectiveStartDate">有效期起始.</param>
        /// <param name="employeeList">切换open_id前请使用此字段：员工uid列表.</param>
        /// <param name="employeeOpenIdList">切换open_id后请使用此字段：员工open_id列表.</param>
        /// <param name="expenseCtrlRuleInfoGroupList">规则组列表.</param>
        /// <param name="projectId">项目id.</param>
        /// <param name="projectName">项目名称.</param>
        public ProjectRuleInfo(string effectiveEndDate = default(string), string effectiveStartDate = default(string), List<string> employeeList = default(List<string>), List<string> employeeOpenIdList = default(List<string>), List<ExpenseCtrRuleGroupInfo> expenseCtrlRuleInfoGroupList = default(List<ExpenseCtrRuleGroupInfo>), string projectId = default(string), string projectName = default(string))
        {
            this.EffectiveEndDate = effectiveEndDate;
            this.EffectiveStartDate = effectiveStartDate;
            this.EmployeeList = employeeList;
            this.EmployeeOpenIdList = employeeOpenIdList;
            this.ExpenseCtrlRuleInfoGroupList = expenseCtrlRuleInfoGroupList;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
        }

        /// <summary>
        /// 有效期截止
        /// </summary>
        /// <value>有效期截止</value>
        [DataMember(Name = "effective_end_date", EmitDefaultValue = false)]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 有效期起始
        /// </summary>
        /// <value>有效期起始</value>
        [DataMember(Name = "effective_start_date", EmitDefaultValue = false)]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 切换open_id前请使用此字段：员工uid列表
        /// </summary>
        /// <value>切换open_id前请使用此字段：员工uid列表</value>
        [DataMember(Name = "employee_list", EmitDefaultValue = false)]
        public List<string> EmployeeList { get; set; }

        /// <summary>
        /// 切换open_id后请使用此字段：员工open_id列表
        /// </summary>
        /// <value>切换open_id后请使用此字段：员工open_id列表</value>
        [DataMember(Name = "employee_open_id_list", EmitDefaultValue = false)]
        public List<string> EmployeeOpenIdList { get; set; }

        /// <summary>
        /// 规则组列表
        /// </summary>
        /// <value>规则组列表</value>
        [DataMember(Name = "expense_ctrl_rule_info_group_list", EmitDefaultValue = false)]
        public List<ExpenseCtrRuleGroupInfo> ExpenseCtrlRuleInfoGroupList { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        /// <value>项目id</value>
        [DataMember(Name = "project_id", EmitDefaultValue = false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        /// <value>项目名称</value>
        [DataMember(Name = "project_name", EmitDefaultValue = false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectRuleInfo {\n");
            sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
            sb.Append("  EffectiveStartDate: ").Append(EffectiveStartDate).Append("\n");
            sb.Append("  EmployeeList: ").Append(EmployeeList).Append("\n");
            sb.Append("  EmployeeOpenIdList: ").Append(EmployeeOpenIdList).Append("\n");
            sb.Append("  ExpenseCtrlRuleInfoGroupList: ").Append(ExpenseCtrlRuleInfoGroupList).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
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
            return this.Equals(input as ProjectRuleInfo);
        }

        /// <summary>
        /// Returns true if ProjectRuleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectRuleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectRuleInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EffectiveEndDate == input.EffectiveEndDate ||
                    (this.EffectiveEndDate != null &&
                    this.EffectiveEndDate.Equals(input.EffectiveEndDate))
                ) && 
                (
                    this.EffectiveStartDate == input.EffectiveStartDate ||
                    (this.EffectiveStartDate != null &&
                    this.EffectiveStartDate.Equals(input.EffectiveStartDate))
                ) && 
                (
                    this.EmployeeList == input.EmployeeList ||
                    this.EmployeeList != null &&
                    input.EmployeeList != null &&
                    this.EmployeeList.SequenceEqual(input.EmployeeList)
                ) && 
                (
                    this.EmployeeOpenIdList == input.EmployeeOpenIdList ||
                    this.EmployeeOpenIdList != null &&
                    input.EmployeeOpenIdList != null &&
                    this.EmployeeOpenIdList.SequenceEqual(input.EmployeeOpenIdList)
                ) && 
                (
                    this.ExpenseCtrlRuleInfoGroupList == input.ExpenseCtrlRuleInfoGroupList ||
                    this.ExpenseCtrlRuleInfoGroupList != null &&
                    input.ExpenseCtrlRuleInfoGroupList != null &&
                    this.ExpenseCtrlRuleInfoGroupList.SequenceEqual(input.ExpenseCtrlRuleInfoGroupList)
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
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
                if (this.EffectiveEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveEndDate.GetHashCode();
                }
                if (this.EffectiveStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveStartDate.GetHashCode();
                }
                if (this.EmployeeList != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeList.GetHashCode();
                }
                if (this.EmployeeOpenIdList != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeOpenIdList.GetHashCode();
                }
                if (this.ExpenseCtrlRuleInfoGroupList != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseCtrlRuleInfoGroupList.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.ProjectName != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectName.GetHashCode();
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
