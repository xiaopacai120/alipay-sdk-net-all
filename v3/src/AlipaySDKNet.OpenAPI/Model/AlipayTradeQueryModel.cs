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
    /// AlipayTradeQueryModel
    /// </summary>
    [DataContract(Name = "AlipayTradeQueryModel")]
    public partial class AlipayTradeQueryModel : IEquatable<AlipayTradeQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeQueryModel" /> class.
        /// </summary>
        /// <param name="orgPid">银行间联模式下有用，其它场景请不要使用；  双联通过该参数指定需要查询的交易所属收单机构的pid;.</param>
        /// <param name="outTradeNo">订单支付时传入的商户订单号,和支付宝交易号不能同时为空。  trade_no,out_trade_no如果同时存在优先取trade_no.</param>
        /// <param name="queryOptions">查询选项，商户传入该参数可定制本接口同步响应额外返回的信息字段，数组格式。支持枚举如下：trade_settle_info：返回的交易结算信息，包含分账、补差等信息； fund_bill_list：交易支付使用的资金渠道； voucher_detail_list：交易支付时使用的所有优惠券信息； discount_goods_detail：交易支付所使用的单品券优惠的商品优惠信息； mdiscount_amount：商家优惠金额；.</param>
        /// <param name="tradeNo">支付宝交易号，和商户订单号不能同时为空.</param>
        public AlipayTradeQueryModel(string orgPid = default(string), string outTradeNo = default(string), List<string> queryOptions = default(List<string>), string tradeNo = default(string))
        {
            this.OrgPid = orgPid;
            this.OutTradeNo = outTradeNo;
            this.QueryOptions = queryOptions;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// 银行间联模式下有用，其它场景请不要使用；  双联通过该参数指定需要查询的交易所属收单机构的pid;
        /// </summary>
        /// <value>银行间联模式下有用，其它场景请不要使用；  双联通过该参数指定需要查询的交易所属收单机构的pid;</value>
        [DataMember(Name = "org_pid", EmitDefaultValue = false)]
        public string OrgPid { get; set; }

        /// <summary>
        /// 订单支付时传入的商户订单号,和支付宝交易号不能同时为空。  trade_no,out_trade_no如果同时存在优先取trade_no
        /// </summary>
        /// <value>订单支付时传入的商户订单号,和支付宝交易号不能同时为空。  trade_no,out_trade_no如果同时存在优先取trade_no</value>
        [DataMember(Name = "out_trade_no", EmitDefaultValue = false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 查询选项，商户传入该参数可定制本接口同步响应额外返回的信息字段，数组格式。支持枚举如下：trade_settle_info：返回的交易结算信息，包含分账、补差等信息； fund_bill_list：交易支付使用的资金渠道； voucher_detail_list：交易支付时使用的所有优惠券信息； discount_goods_detail：交易支付所使用的单品券优惠的商品优惠信息； mdiscount_amount：商家优惠金额；
        /// </summary>
        /// <value>查询选项，商户传入该参数可定制本接口同步响应额外返回的信息字段，数组格式。支持枚举如下：trade_settle_info：返回的交易结算信息，包含分账、补差等信息； fund_bill_list：交易支付使用的资金渠道； voucher_detail_list：交易支付时使用的所有优惠券信息； discount_goods_detail：交易支付所使用的单品券优惠的商品优惠信息； mdiscount_amount：商家优惠金额；</value>
        [DataMember(Name = "query_options", EmitDefaultValue = false)]
        public List<string> QueryOptions { get; set; }

        /// <summary>
        /// 支付宝交易号，和商户订单号不能同时为空
        /// </summary>
        /// <value>支付宝交易号，和商户订单号不能同时为空</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeQueryModel {\n");
            sb.Append("  OrgPid: ").Append(OrgPid).Append("\n");
            sb.Append("  OutTradeNo: ").Append(OutTradeNo).Append("\n");
            sb.Append("  QueryOptions: ").Append(QueryOptions).Append("\n");
            sb.Append("  TradeNo: ").Append(TradeNo).Append("\n");
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
            return this.Equals(input as AlipayTradeQueryModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeQueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrgPid == input.OrgPid ||
                    (this.OrgPid != null &&
                    this.OrgPid.Equals(input.OrgPid))
                ) && 
                (
                    this.OutTradeNo == input.OutTradeNo ||
                    (this.OutTradeNo != null &&
                    this.OutTradeNo.Equals(input.OutTradeNo))
                ) && 
                (
                    this.QueryOptions == input.QueryOptions ||
                    this.QueryOptions != null &&
                    input.QueryOptions != null &&
                    this.QueryOptions.SequenceEqual(input.QueryOptions)
                ) && 
                (
                    this.TradeNo == input.TradeNo ||
                    (this.TradeNo != null &&
                    this.TradeNo.Equals(input.TradeNo))
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
                if (this.OrgPid != null)
                {
                    hashCode = (hashCode * 59) + this.OrgPid.GetHashCode();
                }
                if (this.OutTradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutTradeNo.GetHashCode();
                }
                if (this.QueryOptions != null)
                {
                    hashCode = (hashCode * 59) + this.QueryOptions.GetHashCode();
                }
                if (this.TradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.TradeNo.GetHashCode();
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
