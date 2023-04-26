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
    /// InvoiceContentInfo
    /// </summary>
    [DataContract(Name = "InvoiceContentInfo")]
    public partial class InvoiceContentInfo : IEquatable<InvoiceContentInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceContentInfo" /> class.
        /// </summary>
        /// <param name="amount">含税金额.</param>
        /// <param name="itemName">发票项目名称/货物名称.</param>
        /// <param name="itemNo">商品编码/税收分类编码.</param>
        /// <param name="itemUnit">单位.</param>
        /// <param name="price">单价.</param>
        /// <param name="quantity">商品数量.</param>
        /// <param name="rowType">发票行性质。0表示正常行，1表示折扣行，2表示被折扣行.</param>
        /// <param name="specification">规格型号.</param>
        /// <param name="sumPrice">不含税金额.</param>
        /// <param name="tax">税额.</param>
        /// <param name="taxRate">税率.</param>
        /// <param name="zeroRateFlag">税率标识，只有税率为0的情况才有值，0&#x3D;出口零税率，1&#x3D;免税，2&#x3D;不征收，3&#x3D;普通零税率.</param>
        public InvoiceContentInfo(string amount = default(string), string itemName = default(string), string itemNo = default(string), string itemUnit = default(string), string price = default(string), string quantity = default(string), string rowType = default(string), string specification = default(string), string sumPrice = default(string), string tax = default(string), string taxRate = default(string), string zeroRateFlag = default(string))
        {
            this.Amount = amount;
            this.ItemName = itemName;
            this.ItemNo = itemNo;
            this.ItemUnit = itemUnit;
            this.Price = price;
            this.Quantity = quantity;
            this.RowType = rowType;
            this.Specification = specification;
            this.SumPrice = sumPrice;
            this.Tax = tax;
            this.TaxRate = taxRate;
            this.ZeroRateFlag = zeroRateFlag;
        }

        /// <summary>
        /// 含税金额
        /// </summary>
        /// <value>含税金额</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 发票项目名称/货物名称
        /// </summary>
        /// <value>发票项目名称/货物名称</value>
        [DataMember(Name = "item_name", EmitDefaultValue = false)]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品编码/税收分类编码
        /// </summary>
        /// <value>商品编码/税收分类编码</value>
        [DataMember(Name = "item_no", EmitDefaultValue = false)]
        public string ItemNo { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        /// <value>单位</value>
        [DataMember(Name = "item_unit", EmitDefaultValue = false)]
        public string ItemUnit { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        /// <value>单价</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        /// <value>商品数量</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public string Quantity { get; set; }

        /// <summary>
        /// 发票行性质。0表示正常行，1表示折扣行，2表示被折扣行
        /// </summary>
        /// <value>发票行性质。0表示正常行，1表示折扣行，2表示被折扣行</value>
        [DataMember(Name = "row_type", EmitDefaultValue = false)]
        public string RowType { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        /// <value>规格型号</value>
        [DataMember(Name = "specification", EmitDefaultValue = false)]
        public string Specification { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        /// <value>不含税金额</value>
        [DataMember(Name = "sum_price", EmitDefaultValue = false)]
        public string SumPrice { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        /// <value>税额</value>
        [DataMember(Name = "tax", EmitDefaultValue = false)]
        public string Tax { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        /// <value>税率</value>
        [DataMember(Name = "tax_rate", EmitDefaultValue = false)]
        public string TaxRate { get; set; }

        /// <summary>
        /// 税率标识，只有税率为0的情况才有值，0&#x3D;出口零税率，1&#x3D;免税，2&#x3D;不征收，3&#x3D;普通零税率
        /// </summary>
        /// <value>税率标识，只有税率为0的情况才有值，0&#x3D;出口零税率，1&#x3D;免税，2&#x3D;不征收，3&#x3D;普通零税率</value>
        [DataMember(Name = "zero_rate_flag", EmitDefaultValue = false)]
        public string ZeroRateFlag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceContentInfo {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  ItemNo: ").Append(ItemNo).Append("\n");
            sb.Append("  ItemUnit: ").Append(ItemUnit).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  RowType: ").Append(RowType).Append("\n");
            sb.Append("  Specification: ").Append(Specification).Append("\n");
            sb.Append("  SumPrice: ").Append(SumPrice).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  ZeroRateFlag: ").Append(ZeroRateFlag).Append("\n");
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
            return this.Equals(input as InvoiceContentInfo);
        }

        /// <summary>
        /// Returns true if InvoiceContentInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceContentInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceContentInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ItemName == input.ItemName ||
                    (this.ItemName != null &&
                    this.ItemName.Equals(input.ItemName))
                ) && 
                (
                    this.ItemNo == input.ItemNo ||
                    (this.ItemNo != null &&
                    this.ItemNo.Equals(input.ItemNo))
                ) && 
                (
                    this.ItemUnit == input.ItemUnit ||
                    (this.ItemUnit != null &&
                    this.ItemUnit.Equals(input.ItemUnit))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.RowType == input.RowType ||
                    (this.RowType != null &&
                    this.RowType.Equals(input.RowType))
                ) && 
                (
                    this.Specification == input.Specification ||
                    (this.Specification != null &&
                    this.Specification.Equals(input.Specification))
                ) && 
                (
                    this.SumPrice == input.SumPrice ||
                    (this.SumPrice != null &&
                    this.SumPrice.Equals(input.SumPrice))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && 
                (
                    this.ZeroRateFlag == input.ZeroRateFlag ||
                    (this.ZeroRateFlag != null &&
                    this.ZeroRateFlag.Equals(input.ZeroRateFlag))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.ItemName != null)
                {
                    hashCode = (hashCode * 59) + this.ItemName.GetHashCode();
                }
                if (this.ItemNo != null)
                {
                    hashCode = (hashCode * 59) + this.ItemNo.GetHashCode();
                }
                if (this.ItemUnit != null)
                {
                    hashCode = (hashCode * 59) + this.ItemUnit.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.Quantity != null)
                {
                    hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                }
                if (this.RowType != null)
                {
                    hashCode = (hashCode * 59) + this.RowType.GetHashCode();
                }
                if (this.Specification != null)
                {
                    hashCode = (hashCode * 59) + this.Specification.GetHashCode();
                }
                if (this.SumPrice != null)
                {
                    hashCode = (hashCode * 59) + this.SumPrice.GetHashCode();
                }
                if (this.Tax != null)
                {
                    hashCode = (hashCode * 59) + this.Tax.GetHashCode();
                }
                if (this.TaxRate != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRate.GetHashCode();
                }
                if (this.ZeroRateFlag != null)
                {
                    hashCode = (hashCode * 59) + this.ZeroRateFlag.GetHashCode();
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
