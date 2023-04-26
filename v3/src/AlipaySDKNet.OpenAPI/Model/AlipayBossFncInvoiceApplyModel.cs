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
    /// AlipayBossFncInvoiceApplyModel
    /// </summary>
    [DataContract(Name = "AlipayBossFncInvoiceApplyModel")]
    public partial class AlipayBossFncInvoiceApplyModel : IEquatable<AlipayBossFncInvoiceApplyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayBossFncInvoiceApplyModel" /> class.
        /// </summary>
        /// <param name="bizId">调用方身份识别标记(应用名称) 与业务单据号联合唯一.</param>
        /// <param name="bizNo">业务单据号，业务流水号.</param>
        /// <param name="invoiceAmt">invoiceAmt.</param>
        /// <param name="invoiceType">申请开票类型，01：专票；02：普票.</param>
        /// <param name="memo">备注.</param>
        /// <param name="mthtlyBillNos">需开票的应收月账单号.</param>
        /// <param name="_operator">申请人的uid号.</param>
        /// <param name="outBizType">01主站，02芝麻，03金融云.</param>
        public AlipayBossFncInvoiceApplyModel(string bizId = default(string), string bizNo = default(string), MultiCurrencyMoneyOpenApi invoiceAmt = default(MultiCurrencyMoneyOpenApi), string invoiceType = default(string), string memo = default(string), List<string> mthtlyBillNos = default(List<string>), string _operator = default(string), string outBizType = default(string))
        {
            this.BizId = bizId;
            this.BizNo = bizNo;
            this.InvoiceAmt = invoiceAmt;
            this.InvoiceType = invoiceType;
            this.Memo = memo;
            this.MthtlyBillNos = mthtlyBillNos;
            this.Operator = _operator;
            this.OutBizType = outBizType;
        }

        /// <summary>
        /// 调用方身份识别标记(应用名称) 与业务单据号联合唯一
        /// </summary>
        /// <value>调用方身份识别标记(应用名称) 与业务单据号联合唯一</value>
        [DataMember(Name = "biz_id", EmitDefaultValue = false)]
        public string BizId { get; set; }

        /// <summary>
        /// 业务单据号，业务流水号
        /// </summary>
        /// <value>业务单据号，业务流水号</value>
        [DataMember(Name = "biz_no", EmitDefaultValue = false)]
        public string BizNo { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceAmt
        /// </summary>
        [DataMember(Name = "invoice_amt", EmitDefaultValue = false)]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 申请开票类型，01：专票；02：普票
        /// </summary>
        /// <value>申请开票类型，01：专票；02：普票</value>
        [DataMember(Name = "invoice_type", EmitDefaultValue = false)]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        /// <value>备注</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 需开票的应收月账单号
        /// </summary>
        /// <value>需开票的应收月账单号</value>
        [DataMember(Name = "mthtly_bill_nos", EmitDefaultValue = false)]
        public List<string> MthtlyBillNos { get; set; }

        /// <summary>
        /// 申请人的uid号
        /// </summary>
        /// <value>申请人的uid号</value>
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public string Operator { get; set; }

        /// <summary>
        /// 01主站，02芝麻，03金融云
        /// </summary>
        /// <value>01主站，02芝麻，03金融云</value>
        [DataMember(Name = "out_biz_type", EmitDefaultValue = false)]
        public string OutBizType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayBossFncInvoiceApplyModel {\n");
            sb.Append("  BizId: ").Append(BizId).Append("\n");
            sb.Append("  BizNo: ").Append(BizNo).Append("\n");
            sb.Append("  InvoiceAmt: ").Append(InvoiceAmt).Append("\n");
            sb.Append("  InvoiceType: ").Append(InvoiceType).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  MthtlyBillNos: ").Append(MthtlyBillNos).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  OutBizType: ").Append(OutBizType).Append("\n");
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
            return this.Equals(input as AlipayBossFncInvoiceApplyModel);
        }

        /// <summary>
        /// Returns true if AlipayBossFncInvoiceApplyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayBossFncInvoiceApplyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayBossFncInvoiceApplyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizId == input.BizId ||
                    (this.BizId != null &&
                    this.BizId.Equals(input.BizId))
                ) && 
                (
                    this.BizNo == input.BizNo ||
                    (this.BizNo != null &&
                    this.BizNo.Equals(input.BizNo))
                ) && 
                (
                    this.InvoiceAmt == input.InvoiceAmt ||
                    (this.InvoiceAmt != null &&
                    this.InvoiceAmt.Equals(input.InvoiceAmt))
                ) && 
                (
                    this.InvoiceType == input.InvoiceType ||
                    (this.InvoiceType != null &&
                    this.InvoiceType.Equals(input.InvoiceType))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.MthtlyBillNos == input.MthtlyBillNos ||
                    this.MthtlyBillNos != null &&
                    input.MthtlyBillNos != null &&
                    this.MthtlyBillNos.SequenceEqual(input.MthtlyBillNos)
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.OutBizType == input.OutBizType ||
                    (this.OutBizType != null &&
                    this.OutBizType.Equals(input.OutBizType))
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
                if (this.BizId != null)
                {
                    hashCode = (hashCode * 59) + this.BizId.GetHashCode();
                }
                if (this.BizNo != null)
                {
                    hashCode = (hashCode * 59) + this.BizNo.GetHashCode();
                }
                if (this.InvoiceAmt != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceAmt.GetHashCode();
                }
                if (this.InvoiceType != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceType.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.MthtlyBillNos != null)
                {
                    hashCode = (hashCode * 59) + this.MthtlyBillNos.GetHashCode();
                }
                if (this.Operator != null)
                {
                    hashCode = (hashCode * 59) + this.Operator.GetHashCode();
                }
                if (this.OutBizType != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizType.GetHashCode();
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
