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
    /// WaybillInvoiceQueryIstd
    /// </summary>
    [DataContract(Name = "WaybillInvoiceQueryIstd")]
    public partial class WaybillInvoiceQueryIstd : IEquatable<WaybillInvoiceQueryIstd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaybillInvoiceQueryIstd" /> class.
        /// </summary>
        /// <param name="reason">失败原因，需要传单个即时配送运单的驳回原因.</param>
        /// <param name="shopNo">商家门店编号.</param>
        /// <param name="waybillAmount">即时配送运单金额，waybill_invoce_status为1的情况下不能为空.</param>
        /// <param name="waybillInvoiceStatus">明细的运单开票状态，1：开票成功 2：不可开票 3：可开票；整体开票状态为0的情况下，无开票明细；整体开票状态为1，明细开票状态全部是1；整体开票状态为2，明细开票状态全部为2.</param>
        /// <param name="waybillNo">即时配送运单编号.</param>
        public WaybillInvoiceQueryIstd(string reason = default(string), string shopNo = default(string), string waybillAmount = default(string), int waybillInvoiceStatus = default(int), string waybillNo = default(string))
        {
            this.Reason = reason;
            this.ShopNo = shopNo;
            this.WaybillAmount = waybillAmount;
            this.WaybillInvoiceStatus = waybillInvoiceStatus;
            this.WaybillNo = waybillNo;
        }

        /// <summary>
        /// 失败原因，需要传单个即时配送运单的驳回原因
        /// </summary>
        /// <value>失败原因，需要传单个即时配送运单的驳回原因</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// 商家门店编号
        /// </summary>
        /// <value>商家门店编号</value>
        [DataMember(Name = "shop_no", EmitDefaultValue = false)]
        public string ShopNo { get; set; }

        /// <summary>
        /// 即时配送运单金额，waybill_invoce_status为1的情况下不能为空
        /// </summary>
        /// <value>即时配送运单金额，waybill_invoce_status为1的情况下不能为空</value>
        [DataMember(Name = "waybill_amount", EmitDefaultValue = false)]
        public string WaybillAmount { get; set; }

        /// <summary>
        /// 明细的运单开票状态，1：开票成功 2：不可开票 3：可开票；整体开票状态为0的情况下，无开票明细；整体开票状态为1，明细开票状态全部是1；整体开票状态为2，明细开票状态全部为2
        /// </summary>
        /// <value>明细的运单开票状态，1：开票成功 2：不可开票 3：可开票；整体开票状态为0的情况下，无开票明细；整体开票状态为1，明细开票状态全部是1；整体开票状态为2，明细开票状态全部为2</value>
        [DataMember(Name = "waybill_invoice_status", EmitDefaultValue = false)]
        public int WaybillInvoiceStatus { get; set; }

        /// <summary>
        /// 即时配送运单编号
        /// </summary>
        /// <value>即时配送运单编号</value>
        [DataMember(Name = "waybill_no", EmitDefaultValue = false)]
        public string WaybillNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WaybillInvoiceQueryIstd {\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ShopNo: ").Append(ShopNo).Append("\n");
            sb.Append("  WaybillAmount: ").Append(WaybillAmount).Append("\n");
            sb.Append("  WaybillInvoiceStatus: ").Append(WaybillInvoiceStatus).Append("\n");
            sb.Append("  WaybillNo: ").Append(WaybillNo).Append("\n");
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
            return this.Equals(input as WaybillInvoiceQueryIstd);
        }

        /// <summary>
        /// Returns true if WaybillInvoiceQueryIstd instances are equal
        /// </summary>
        /// <param name="input">Instance of WaybillInvoiceQueryIstd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaybillInvoiceQueryIstd input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.ShopNo == input.ShopNo ||
                    (this.ShopNo != null &&
                    this.ShopNo.Equals(input.ShopNo))
                ) && 
                (
                    this.WaybillAmount == input.WaybillAmount ||
                    (this.WaybillAmount != null &&
                    this.WaybillAmount.Equals(input.WaybillAmount))
                ) && 
                (
                    this.WaybillInvoiceStatus == input.WaybillInvoiceStatus ||
                    this.WaybillInvoiceStatus.Equals(input.WaybillInvoiceStatus)
                ) && 
                (
                    this.WaybillNo == input.WaybillNo ||
                    (this.WaybillNo != null &&
                    this.WaybillNo.Equals(input.WaybillNo))
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
                if (this.Reason != null)
                {
                    hashCode = (hashCode * 59) + this.Reason.GetHashCode();
                }
                if (this.ShopNo != null)
                {
                    hashCode = (hashCode * 59) + this.ShopNo.GetHashCode();
                }
                if (this.WaybillAmount != null)
                {
                    hashCode = (hashCode * 59) + this.WaybillAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.WaybillInvoiceStatus.GetHashCode();
                if (this.WaybillNo != null)
                {
                    hashCode = (hashCode * 59) + this.WaybillNo.GetHashCode();
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
