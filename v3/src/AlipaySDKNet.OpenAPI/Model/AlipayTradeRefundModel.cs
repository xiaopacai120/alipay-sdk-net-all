/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-07-17
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
    /// AlipayTradeRefundModel
    /// </summary>
    [DataContract(Name = "AlipayTradeRefundModel")]
    public partial class AlipayTradeRefundModel : IEquatable<AlipayTradeRefundModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeRefundModel" /> class.
        /// </summary>
        /// <param name="goodsDetail">退款包含的商品列表信息，Json格式。.</param>
        /// <param name="operatorId">商户的操作员编号.</param>
        /// <param name="orgPid">银行间联模式下有用，其它场景请不要使用；  双联通过该参数指定需要退款的交易所属收单机构的pid;.</param>
        /// <param name="outRequestNo">退款请求号。 标识一次退款请求，需要保证在交易号下唯一，如需部分退款，则此参数必传。 注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款请求号不能变更，防止该笔交易重复退款。支付宝会保证同样的退款请求号多次请求只会退一次。.</param>
        /// <param name="outTradeNo">商户订单号。 订单支付时传入的商户订单号，商家自定义且保证商家系统中唯一。与支付宝交易号 trade_no 不能同时为空。.</param>
        /// <param name="queryOptions">查询选项。 商户通过上送该参数来定制同步需要额外返回的信息字段，数组格式。支持：refund_detail_item_list：退款使用的资金渠道；deposit_back_info：触发银行卡冲退信息通知；.</param>
        /// <param name="refundAdvanceAccount">指定垫资退款账号主体，可能是用户id或登录名.</param>
        /// <param name="refundAdvanceAccountType">指定垫资退款账号的类型，取值范围：default，userId，loginName.</param>
        /// <param name="refundAmount">退款金额。 需要退款的金额，该金额不能大于订单金额，单位为元，支持两位小数。 注：如果正向交易使用了营销，该退款金额包含营销金额，支付宝会按业务规则分配营销和买家自有资金分别退多少，默认优先退买家的自有资金。如交易总金额100元，用户支付时使用了80元自有资金和20元无资金流的营销券，商家实际收款80元。如果首次请求退款60元，则60元全部从商家收款资金扣除退回给用户自有资产；如果再请求退款40元，则从商家收款资金扣除20元退回用户资产以及把20元的营销券退回给用户（券是否可再使用取决于券的规则配置）。.</param>
        /// <param name="refundCurrency">订单退款币种信息。支持英镑：GBP、港币：HKD、美元：USD、新加坡元：SGD、日元：JPY、加拿大元：CAD、澳元：AUD、欧元：EUR、新西兰元：NZD、韩元：KRW、泰铢：THB、瑞士法郎：CHF、瑞典克朗：SEK、丹麦克朗：DKK、挪威克朗：NOK、马来西亚林吉特：MYR、印尼卢比：IDR、菲律宾比索：PHP、毛里求斯卢比：MUR、以色列新谢克尔：ILS、斯里兰卡卢比：LKR、俄罗斯卢布：RUB、阿联酋迪拉姆：AED、捷克克朗：CZK、南非兰特：ZAR、人民币：CNY.</param>
        /// <param name="refundGoodsDetail">退款包含的商品列表信息.</param>
        /// <param name="refundReason">退款原因说明。 商家自定义，将在会在商户和用户的pc退款账单详情中展示.</param>
        /// <param name="refundRoyaltyParameters">退分账明细信息。  注： 1.当面付且非直付通模式无需传入退分账明细，系统自动按退款金额与订单金额的比率，从收款方和分账收入方退款，不支持指定退款金额与退款方。  2.直付通模式，电脑网站支付，手机 APP 支付，手机网站支付产品，须在退款请求中明确是否退分账，从哪个分账收入方退，退多少分账金额；如不明确，默认从收款方退款，收款方余额不足退款失败。不支持系统按比率退款。.</param>
        /// <param name="storeId">商户门店编号，由商家自定义。需保证当前商户下唯一。.</param>
        /// <param name="terminalId">商户的终端编号.</param>
        /// <param name="tradeNo">支付宝交易号。 和商户订单号 out_trade_no 不能同时为空。.</param>
        public AlipayTradeRefundModel(List<GoodsDetail> goodsDetail = default(List<GoodsDetail>), string operatorId = default(string), string orgPid = default(string), string outRequestNo = default(string), string outTradeNo = default(string), List<string> queryOptions = default(List<string>), string refundAdvanceAccount = default(string), string refundAdvanceAccountType = default(string), string refundAmount = default(string), string refundCurrency = default(string), List<RefundGoodsDetail> refundGoodsDetail = default(List<RefundGoodsDetail>), string refundReason = default(string), List<OpenApiRoyaltyDetailInfoPojo> refundRoyaltyParameters = default(List<OpenApiRoyaltyDetailInfoPojo>), string storeId = default(string), string terminalId = default(string), string tradeNo = default(string))
        {
            this.GoodsDetail = goodsDetail;
            this.OperatorId = operatorId;
            this.OrgPid = orgPid;
            this.OutRequestNo = outRequestNo;
            this.OutTradeNo = outTradeNo;
            this.QueryOptions = queryOptions;
            this.RefundAdvanceAccount = refundAdvanceAccount;
            this.RefundAdvanceAccountType = refundAdvanceAccountType;
            this.RefundAmount = refundAmount;
            this.RefundCurrency = refundCurrency;
            this.RefundGoodsDetail = refundGoodsDetail;
            this.RefundReason = refundReason;
            this.RefundRoyaltyParameters = refundRoyaltyParameters;
            this.StoreId = storeId;
            this.TerminalId = terminalId;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// 退款包含的商品列表信息，Json格式。
        /// </summary>
        /// <value>退款包含的商品列表信息，Json格式。</value>
        [DataMember(Name = "goods_detail", EmitDefaultValue = false)]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 商户的操作员编号
        /// </summary>
        /// <value>商户的操作员编号</value>
        [DataMember(Name = "operator_id", EmitDefaultValue = false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 银行间联模式下有用，其它场景请不要使用；  双联通过该参数指定需要退款的交易所属收单机构的pid;
        /// </summary>
        /// <value>银行间联模式下有用，其它场景请不要使用；  双联通过该参数指定需要退款的交易所属收单机构的pid;</value>
        [DataMember(Name = "org_pid", EmitDefaultValue = false)]
        public string OrgPid { get; set; }

        /// <summary>
        /// 退款请求号。 标识一次退款请求，需要保证在交易号下唯一，如需部分退款，则此参数必传。 注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款请求号不能变更，防止该笔交易重复退款。支付宝会保证同样的退款请求号多次请求只会退一次。
        /// </summary>
        /// <value>退款请求号。 标识一次退款请求，需要保证在交易号下唯一，如需部分退款，则此参数必传。 注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款请求号不能变更，防止该笔交易重复退款。支付宝会保证同样的退款请求号多次请求只会退一次。</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号。 订单支付时传入的商户订单号，商家自定义且保证商家系统中唯一。与支付宝交易号 trade_no 不能同时为空。
        /// </summary>
        /// <value>商户订单号。 订单支付时传入的商户订单号，商家自定义且保证商家系统中唯一。与支付宝交易号 trade_no 不能同时为空。</value>
        [DataMember(Name = "out_trade_no", EmitDefaultValue = false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 查询选项。 商户通过上送该参数来定制同步需要额外返回的信息字段，数组格式。支持：refund_detail_item_list：退款使用的资金渠道；deposit_back_info：触发银行卡冲退信息通知；
        /// </summary>
        /// <value>查询选项。 商户通过上送该参数来定制同步需要额外返回的信息字段，数组格式。支持：refund_detail_item_list：退款使用的资金渠道；deposit_back_info：触发银行卡冲退信息通知；</value>
        [DataMember(Name = "query_options", EmitDefaultValue = false)]
        public List<string> QueryOptions { get; set; }

        /// <summary>
        /// 指定垫资退款账号主体，可能是用户id或登录名
        /// </summary>
        /// <value>指定垫资退款账号主体，可能是用户id或登录名</value>
        [DataMember(Name = "refund_advance_account", EmitDefaultValue = false)]
        public string RefundAdvanceAccount { get; set; }

        /// <summary>
        /// 指定垫资退款账号的类型，取值范围：default，userId，loginName
        /// </summary>
        /// <value>指定垫资退款账号的类型，取值范围：default，userId，loginName</value>
        [DataMember(Name = "refund_advance_account_type", EmitDefaultValue = false)]
        public string RefundAdvanceAccountType { get; set; }

        /// <summary>
        /// 退款金额。 需要退款的金额，该金额不能大于订单金额，单位为元，支持两位小数。 注：如果正向交易使用了营销，该退款金额包含营销金额，支付宝会按业务规则分配营销和买家自有资金分别退多少，默认优先退买家的自有资金。如交易总金额100元，用户支付时使用了80元自有资金和20元无资金流的营销券，商家实际收款80元。如果首次请求退款60元，则60元全部从商家收款资金扣除退回给用户自有资产；如果再请求退款40元，则从商家收款资金扣除20元退回用户资产以及把20元的营销券退回给用户（券是否可再使用取决于券的规则配置）。
        /// </summary>
        /// <value>退款金额。 需要退款的金额，该金额不能大于订单金额，单位为元，支持两位小数。 注：如果正向交易使用了营销，该退款金额包含营销金额，支付宝会按业务规则分配营销和买家自有资金分别退多少，默认优先退买家的自有资金。如交易总金额100元，用户支付时使用了80元自有资金和20元无资金流的营销券，商家实际收款80元。如果首次请求退款60元，则60元全部从商家收款资金扣除退回给用户自有资产；如果再请求退款40元，则从商家收款资金扣除20元退回用户资产以及把20元的营销券退回给用户（券是否可再使用取决于券的规则配置）。</value>
        [DataMember(Name = "refund_amount", EmitDefaultValue = false)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 订单退款币种信息。支持英镑：GBP、港币：HKD、美元：USD、新加坡元：SGD、日元：JPY、加拿大元：CAD、澳元：AUD、欧元：EUR、新西兰元：NZD、韩元：KRW、泰铢：THB、瑞士法郎：CHF、瑞典克朗：SEK、丹麦克朗：DKK、挪威克朗：NOK、马来西亚林吉特：MYR、印尼卢比：IDR、菲律宾比索：PHP、毛里求斯卢比：MUR、以色列新谢克尔：ILS、斯里兰卡卢比：LKR、俄罗斯卢布：RUB、阿联酋迪拉姆：AED、捷克克朗：CZK、南非兰特：ZAR、人民币：CNY
        /// </summary>
        /// <value>订单退款币种信息。支持英镑：GBP、港币：HKD、美元：USD、新加坡元：SGD、日元：JPY、加拿大元：CAD、澳元：AUD、欧元：EUR、新西兰元：NZD、韩元：KRW、泰铢：THB、瑞士法郎：CHF、瑞典克朗：SEK、丹麦克朗：DKK、挪威克朗：NOK、马来西亚林吉特：MYR、印尼卢比：IDR、菲律宾比索：PHP、毛里求斯卢比：MUR、以色列新谢克尔：ILS、斯里兰卡卢比：LKR、俄罗斯卢布：RUB、阿联酋迪拉姆：AED、捷克克朗：CZK、南非兰特：ZAR、人民币：CNY</value>
        [DataMember(Name = "refund_currency", EmitDefaultValue = false)]
        public string RefundCurrency { get; set; }

        /// <summary>
        /// 退款包含的商品列表信息
        /// </summary>
        /// <value>退款包含的商品列表信息</value>
        [DataMember(Name = "refund_goods_detail", EmitDefaultValue = false)]
        public List<RefundGoodsDetail> RefundGoodsDetail { get; set; }

        /// <summary>
        /// 退款原因说明。 商家自定义，将在会在商户和用户的pc退款账单详情中展示
        /// </summary>
        /// <value>退款原因说明。 商家自定义，将在会在商户和用户的pc退款账单详情中展示</value>
        [DataMember(Name = "refund_reason", EmitDefaultValue = false)]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退分账明细信息。  注： 1.当面付且非直付通模式无需传入退分账明细，系统自动按退款金额与订单金额的比率，从收款方和分账收入方退款，不支持指定退款金额与退款方。  2.直付通模式，电脑网站支付，手机 APP 支付，手机网站支付产品，须在退款请求中明确是否退分账，从哪个分账收入方退，退多少分账金额；如不明确，默认从收款方退款，收款方余额不足退款失败。不支持系统按比率退款。
        /// </summary>
        /// <value>退分账明细信息。  注： 1.当面付且非直付通模式无需传入退分账明细，系统自动按退款金额与订单金额的比率，从收款方和分账收入方退款，不支持指定退款金额与退款方。  2.直付通模式，电脑网站支付，手机 APP 支付，手机网站支付产品，须在退款请求中明确是否退分账，从哪个分账收入方退，退多少分账金额；如不明确，默认从收款方退款，收款方余额不足退款失败。不支持系统按比率退款。</value>
        [DataMember(Name = "refund_royalty_parameters", EmitDefaultValue = false)]
        public List<OpenApiRoyaltyDetailInfoPojo> RefundRoyaltyParameters { get; set; }

        /// <summary>
        /// 商户门店编号，由商家自定义。需保证当前商户下唯一。
        /// </summary>
        /// <value>商户门店编号，由商家自定义。需保证当前商户下唯一。</value>
        [DataMember(Name = "store_id", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// 商户的终端编号
        /// </summary>
        /// <value>商户的终端编号</value>
        [DataMember(Name = "terminal_id", EmitDefaultValue = false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// 支付宝交易号。 和商户订单号 out_trade_no 不能同时为空。
        /// </summary>
        /// <value>支付宝交易号。 和商户订单号 out_trade_no 不能同时为空。</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeRefundModel {\n");
            sb.Append("  GoodsDetail: ").Append(GoodsDetail).Append("\n");
            sb.Append("  OperatorId: ").Append(OperatorId).Append("\n");
            sb.Append("  OrgPid: ").Append(OrgPid).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  OutTradeNo: ").Append(OutTradeNo).Append("\n");
            sb.Append("  QueryOptions: ").Append(QueryOptions).Append("\n");
            sb.Append("  RefundAdvanceAccount: ").Append(RefundAdvanceAccount).Append("\n");
            sb.Append("  RefundAdvanceAccountType: ").Append(RefundAdvanceAccountType).Append("\n");
            sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
            sb.Append("  RefundCurrency: ").Append(RefundCurrency).Append("\n");
            sb.Append("  RefundGoodsDetail: ").Append(RefundGoodsDetail).Append("\n");
            sb.Append("  RefundReason: ").Append(RefundReason).Append("\n");
            sb.Append("  RefundRoyaltyParameters: ").Append(RefundRoyaltyParameters).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
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
            return this.Equals(input as AlipayTradeRefundModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeRefundModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeRefundModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeRefundModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GoodsDetail == input.GoodsDetail ||
                    this.GoodsDetail != null &&
                    input.GoodsDetail != null &&
                    this.GoodsDetail.SequenceEqual(input.GoodsDetail)
                ) && 
                (
                    this.OperatorId == input.OperatorId ||
                    (this.OperatorId != null &&
                    this.OperatorId.Equals(input.OperatorId))
                ) && 
                (
                    this.OrgPid == input.OrgPid ||
                    (this.OrgPid != null &&
                    this.OrgPid.Equals(input.OrgPid))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
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
                    this.RefundAdvanceAccount == input.RefundAdvanceAccount ||
                    (this.RefundAdvanceAccount != null &&
                    this.RefundAdvanceAccount.Equals(input.RefundAdvanceAccount))
                ) && 
                (
                    this.RefundAdvanceAccountType == input.RefundAdvanceAccountType ||
                    (this.RefundAdvanceAccountType != null &&
                    this.RefundAdvanceAccountType.Equals(input.RefundAdvanceAccountType))
                ) && 
                (
                    this.RefundAmount == input.RefundAmount ||
                    (this.RefundAmount != null &&
                    this.RefundAmount.Equals(input.RefundAmount))
                ) && 
                (
                    this.RefundCurrency == input.RefundCurrency ||
                    (this.RefundCurrency != null &&
                    this.RefundCurrency.Equals(input.RefundCurrency))
                ) && 
                (
                    this.RefundGoodsDetail == input.RefundGoodsDetail ||
                    this.RefundGoodsDetail != null &&
                    input.RefundGoodsDetail != null &&
                    this.RefundGoodsDetail.SequenceEqual(input.RefundGoodsDetail)
                ) && 
                (
                    this.RefundReason == input.RefundReason ||
                    (this.RefundReason != null &&
                    this.RefundReason.Equals(input.RefundReason))
                ) && 
                (
                    this.RefundRoyaltyParameters == input.RefundRoyaltyParameters ||
                    this.RefundRoyaltyParameters != null &&
                    input.RefundRoyaltyParameters != null &&
                    this.RefundRoyaltyParameters.SequenceEqual(input.RefundRoyaltyParameters)
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.TerminalId == input.TerminalId ||
                    (this.TerminalId != null &&
                    this.TerminalId.Equals(input.TerminalId))
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
                if (this.GoodsDetail != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsDetail.GetHashCode();
                }
                if (this.OperatorId != null)
                {
                    hashCode = (hashCode * 59) + this.OperatorId.GetHashCode();
                }
                if (this.OrgPid != null)
                {
                    hashCode = (hashCode * 59) + this.OrgPid.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.OutTradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutTradeNo.GetHashCode();
                }
                if (this.QueryOptions != null)
                {
                    hashCode = (hashCode * 59) + this.QueryOptions.GetHashCode();
                }
                if (this.RefundAdvanceAccount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundAdvanceAccount.GetHashCode();
                }
                if (this.RefundAdvanceAccountType != null)
                {
                    hashCode = (hashCode * 59) + this.RefundAdvanceAccountType.GetHashCode();
                }
                if (this.RefundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundAmount.GetHashCode();
                }
                if (this.RefundCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.RefundCurrency.GetHashCode();
                }
                if (this.RefundGoodsDetail != null)
                {
                    hashCode = (hashCode * 59) + this.RefundGoodsDetail.GetHashCode();
                }
                if (this.RefundReason != null)
                {
                    hashCode = (hashCode * 59) + this.RefundReason.GetHashCode();
                }
                if (this.RefundRoyaltyParameters != null)
                {
                    hashCode = (hashCode * 59) + this.RefundRoyaltyParameters.GetHashCode();
                }
                if (this.StoreId != null)
                {
                    hashCode = (hashCode * 59) + this.StoreId.GetHashCode();
                }
                if (this.TerminalId != null)
                {
                    hashCode = (hashCode * 59) + this.TerminalId.GetHashCode();
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
