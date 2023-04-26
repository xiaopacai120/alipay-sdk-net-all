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
    /// AlipayEbppInvoiceApplyResultSyncModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceApplyResultSyncModel")]
    public partial class AlipayEbppInvoiceApplyResultSyncModel : IEquatable<AlipayEbppInvoiceApplyResultSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceApplyResultSyncModel" /> class.
        /// </summary>
        /// <param name="applyId">支付宝发起开票申请的id，该id具有唯一性，该字段由支付宝向税控发起申请的时候带过去，作为支付宝向税控开票申请的唯一标志.</param>
        /// <param name="result">支付宝向税控商或ISV发起发票申请后，对应这笔申请的发票开具结果。  取值如下：  SUCCESS:成功;FAIL:失败.</param>
        /// <param name="resultCode">结果码，支付宝向税控商或ISV发起发票申请后，对应这笔申请的发票开具结果进行详细说明的结果码。  取值如下：  成功(SUCCESS),  参数不合法(PARAMETER_ILLEGAL),  商户税控设备异常(MERCHANT_TAX_DEVICE_ERROR)..</param>
        /// <param name="resultMsg">结果描述，支付宝向税控商或ISV发起发票申请后，对应这笔申请的发票开具结果描述信息。.</param>
        /// <param name="taxApplyId">该字段是税控商或ISV收到支付宝开票请求后生成的申请id，由税控商或isv自己生成，该id具有唯一性  当ISV接入时是按照tax_apply_id来查询发票信息时，该字段必填。.</param>
        public AlipayEbppInvoiceApplyResultSyncModel(string applyId = default(string), string result = default(string), string resultCode = default(string), string resultMsg = default(string), string taxApplyId = default(string))
        {
            this.ApplyId = applyId;
            this.Result = result;
            this.ResultCode = resultCode;
            this.ResultMsg = resultMsg;
            this.TaxApplyId = taxApplyId;
        }

        /// <summary>
        /// 支付宝发起开票申请的id，该id具有唯一性，该字段由支付宝向税控发起申请的时候带过去，作为支付宝向税控开票申请的唯一标志
        /// </summary>
        /// <value>支付宝发起开票申请的id，该id具有唯一性，该字段由支付宝向税控发起申请的时候带过去，作为支付宝向税控开票申请的唯一标志</value>
        [DataMember(Name = "apply_id", EmitDefaultValue = false)]
        public string ApplyId { get; set; }

        /// <summary>
        /// 支付宝向税控商或ISV发起发票申请后，对应这笔申请的发票开具结果。  取值如下：  SUCCESS:成功;FAIL:失败
        /// </summary>
        /// <value>支付宝向税控商或ISV发起发票申请后，对应这笔申请的发票开具结果。  取值如下：  SUCCESS:成功;FAIL:失败</value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public string Result { get; set; }

        /// <summary>
        /// 结果码，支付宝向税控商或ISV发起发票申请后，对应这笔申请的发票开具结果进行详细说明的结果码。  取值如下：  成功(SUCCESS),  参数不合法(PARAMETER_ILLEGAL),  商户税控设备异常(MERCHANT_TAX_DEVICE_ERROR).
        /// </summary>
        /// <value>结果码，支付宝向税控商或ISV发起发票申请后，对应这笔申请的发票开具结果进行详细说明的结果码。  取值如下：  成功(SUCCESS),  参数不合法(PARAMETER_ILLEGAL),  商户税控设备异常(MERCHANT_TAX_DEVICE_ERROR).</value>
        [DataMember(Name = "result_code", EmitDefaultValue = false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述，支付宝向税控商或ISV发起发票申请后，对应这笔申请的发票开具结果描述信息。
        /// </summary>
        /// <value>结果描述，支付宝向税控商或ISV发起发票申请后，对应这笔申请的发票开具结果描述信息。</value>
        [DataMember(Name = "result_msg", EmitDefaultValue = false)]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 该字段是税控商或ISV收到支付宝开票请求后生成的申请id，由税控商或isv自己生成，该id具有唯一性  当ISV接入时是按照tax_apply_id来查询发票信息时，该字段必填。
        /// </summary>
        /// <value>该字段是税控商或ISV收到支付宝开票请求后生成的申请id，由税控商或isv自己生成，该id具有唯一性  当ISV接入时是按照tax_apply_id来查询发票信息时，该字段必填。</value>
        [DataMember(Name = "tax_apply_id", EmitDefaultValue = false)]
        public string TaxApplyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceApplyResultSyncModel {\n");
            sb.Append("  ApplyId: ").Append(ApplyId).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  ResultMsg: ").Append(ResultMsg).Append("\n");
            sb.Append("  TaxApplyId: ").Append(TaxApplyId).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceApplyResultSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceApplyResultSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceApplyResultSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceApplyResultSyncModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyId == input.ApplyId ||
                    (this.ApplyId != null &&
                    this.ApplyId.Equals(input.ApplyId))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    (this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode))
                ) && 
                (
                    this.ResultMsg == input.ResultMsg ||
                    (this.ResultMsg != null &&
                    this.ResultMsg.Equals(input.ResultMsg))
                ) && 
                (
                    this.TaxApplyId == input.TaxApplyId ||
                    (this.TaxApplyId != null &&
                    this.TaxApplyId.Equals(input.TaxApplyId))
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
                if (this.ApplyId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyId.GetHashCode();
                }
                if (this.Result != null)
                {
                    hashCode = (hashCode * 59) + this.Result.GetHashCode();
                }
                if (this.ResultCode != null)
                {
                    hashCode = (hashCode * 59) + this.ResultCode.GetHashCode();
                }
                if (this.ResultMsg != null)
                {
                    hashCode = (hashCode * 59) + this.ResultMsg.GetHashCode();
                }
                if (this.TaxApplyId != null)
                {
                    hashCode = (hashCode * 59) + this.TaxApplyId.GetHashCode();
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
