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
    /// EcConsumeInfo
    /// </summary>
    [DataContract(Name = "EcConsumeInfo")]
    public partial class EcConsumeInfo : IEquatable<EcConsumeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcConsumeInfo" /> class.
        /// </summary>
        /// <param name="accountId">共同账户ID.</param>
        /// <param name="agreementPeerPayerId">协议出资支付宝账号.</param>
        /// <param name="benefitAmount">员工优惠金额，单位：元.</param>
        /// <param name="bizOutNo">外部交易流水号.</param>
        /// <param name="categoryName">账单分类名称，比如：餐饮美食，交通出行，酒店旅游等.</param>
        /// <param name="consumeAmount">账单金额，单位：元，不包含营销资产.</param>
        /// <param name="consumeCategory">员工消费记账分类.</param>
        /// <param name="consumeFeeWithDiscount">订单原价，单位：元，包含营销资产.</param>
        /// <param name="consumeMemo">员工消费记账备注.</param>
        /// <param name="consumeType">账单类型 -消费账单：CONSUME -退款账单：REFUND -转账账单：TRANSFER.</param>
        /// <param name="employeeId">员工账号ID.</param>
        /// <param name="enterpriseId">企业ID.</param>
        /// <param name="expenseRuleGroupId">使用规则ID.</param>
        /// <param name="expenseSceneCode">费用场景.</param>
        /// <param name="expenseType">费用类型.</param>
        /// <param name="expenseTypeSubCategory">费用类型子类目.</param>
        /// <param name="extInfos">账单扩展信息，Json格式 汇总信息.</param>
        /// <param name="fundBizType">出资模式 个人出资：PERSONAL 企业出资：ENTERPRISE 三方垫资合作伙伴出资：TP 记账：ACCOUNTING.</param>
        /// <param name="gmtBizCreate">账单创建时间，格式：yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="gmtReceivePay">账单支付时间，格式：yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="invoiceOpenMode">开票模式 企业汇总开：ENTERPRISE_AUTO_BATCH.</param>
        /// <param name="merchantId">商户ID.</param>
        /// <param name="merchantName">商户名称.</param>
        /// <param name="openId">员工支付宝UID.</param>
        /// <param name="orderCompleteLabel">订单完结标识 0：未完结 1：已完结.</param>
        /// <param name="orderCompleteTime">2022-01-01 01:01:02 订单完结时间.</param>
        /// <param name="payNo">交易流水号.</param>
        /// <param name="peerPayAmount">企业代付金额，单位：元.</param>
        /// <param name="peerPayerCardNo">实际出资支付宝账号.</param>
        /// <param name="peerRefundAmount">消费账单企业代付部分退款金额，单位：元。退款账单该值无意义，值为0。.</param>
        /// <param name="peerRefundStatus">消费账单企业代付部分退款状态，默认为INIT。当消费账单有退款，该值会变为REFUND_PART或REFUND_FULL；退款账单该值无意义，为初始值INIT。 未退款：INIT， 部分退款：REFUND_PART， 全额退款：REFUND_FULL.</param>
        /// <param name="relatedPayNo">退款账单关联的消费账单交易流水号，退款账单才有值.</param>
        /// <param name="sceneCode">账单场景 TAKE_AWAY：外卖 METRO：地铁 OTHER：其他.</param>
        /// <param name="sellerId">卖家ID.</param>
        /// <param name="shopId">门店ID.</param>
        /// <param name="storeId">外部门店ID.</param>
        /// <param name="summaryApplyId">汇总批次ID.</param>
        /// <param name="userId">员工支付宝UID.</param>
        public EcConsumeInfo(string accountId = default(string), string agreementPeerPayerId = default(string), string benefitAmount = default(string), string bizOutNo = default(string), string categoryName = default(string), string consumeAmount = default(string), string consumeCategory = default(string), string consumeFeeWithDiscount = default(string), string consumeMemo = default(string), string consumeType = default(string), string employeeId = default(string), string enterpriseId = default(string), string expenseRuleGroupId = default(string), string expenseSceneCode = default(string), string expenseType = default(string), string expenseTypeSubCategory = default(string), string extInfos = default(string), string fundBizType = default(string), string gmtBizCreate = default(string), string gmtReceivePay = default(string), string invoiceOpenMode = default(string), string merchantId = default(string), string merchantName = default(string), string openId = default(string), string orderCompleteLabel = default(string), string orderCompleteTime = default(string), string payNo = default(string), string peerPayAmount = default(string), string peerPayerCardNo = default(string), string peerRefundAmount = default(string), string peerRefundStatus = default(string), string relatedPayNo = default(string), string sceneCode = default(string), string sellerId = default(string), string shopId = default(string), string storeId = default(string), string summaryApplyId = default(string), string userId = default(string))
        {
            this.AccountId = accountId;
            this.AgreementPeerPayerId = agreementPeerPayerId;
            this.BenefitAmount = benefitAmount;
            this.BizOutNo = bizOutNo;
            this.CategoryName = categoryName;
            this.ConsumeAmount = consumeAmount;
            this.ConsumeCategory = consumeCategory;
            this.ConsumeFeeWithDiscount = consumeFeeWithDiscount;
            this.ConsumeMemo = consumeMemo;
            this.ConsumeType = consumeType;
            this.EmployeeId = employeeId;
            this.EnterpriseId = enterpriseId;
            this.ExpenseRuleGroupId = expenseRuleGroupId;
            this.ExpenseSceneCode = expenseSceneCode;
            this.ExpenseType = expenseType;
            this.ExpenseTypeSubCategory = expenseTypeSubCategory;
            this.ExtInfos = extInfos;
            this.FundBizType = fundBizType;
            this.GmtBizCreate = gmtBizCreate;
            this.GmtReceivePay = gmtReceivePay;
            this.InvoiceOpenMode = invoiceOpenMode;
            this.MerchantId = merchantId;
            this.MerchantName = merchantName;
            this.OpenId = openId;
            this.OrderCompleteLabel = orderCompleteLabel;
            this.OrderCompleteTime = orderCompleteTime;
            this.PayNo = payNo;
            this.PeerPayAmount = peerPayAmount;
            this.PeerPayerCardNo = peerPayerCardNo;
            this.PeerRefundAmount = peerRefundAmount;
            this.PeerRefundStatus = peerRefundStatus;
            this.RelatedPayNo = relatedPayNo;
            this.SceneCode = sceneCode;
            this.SellerId = sellerId;
            this.ShopId = shopId;
            this.StoreId = storeId;
            this.SummaryApplyId = summaryApplyId;
            this.UserId = userId;
        }

        /// <summary>
        /// 共同账户ID
        /// </summary>
        /// <value>共同账户ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 协议出资支付宝账号
        /// </summary>
        /// <value>协议出资支付宝账号</value>
        [DataMember(Name = "agreement_peer_payer_id", EmitDefaultValue = false)]
        public string AgreementPeerPayerId { get; set; }

        /// <summary>
        /// 员工优惠金额，单位：元
        /// </summary>
        /// <value>员工优惠金额，单位：元</value>
        [DataMember(Name = "benefit_amount", EmitDefaultValue = false)]
        public string BenefitAmount { get; set; }

        /// <summary>
        /// 外部交易流水号
        /// </summary>
        /// <value>外部交易流水号</value>
        [DataMember(Name = "biz_out_no", EmitDefaultValue = false)]
        public string BizOutNo { get; set; }

        /// <summary>
        /// 账单分类名称，比如：餐饮美食，交通出行，酒店旅游等
        /// </summary>
        /// <value>账单分类名称，比如：餐饮美食，交通出行，酒店旅游等</value>
        [DataMember(Name = "category_name", EmitDefaultValue = false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// 账单金额，单位：元，不包含营销资产
        /// </summary>
        /// <value>账单金额，单位：元，不包含营销资产</value>
        [DataMember(Name = "consume_amount", EmitDefaultValue = false)]
        public string ConsumeAmount { get; set; }

        /// <summary>
        /// 员工消费记账分类
        /// </summary>
        /// <value>员工消费记账分类</value>
        [DataMember(Name = "consume_category", EmitDefaultValue = false)]
        public string ConsumeCategory { get; set; }

        /// <summary>
        /// 订单原价，单位：元，包含营销资产
        /// </summary>
        /// <value>订单原价，单位：元，包含营销资产</value>
        [DataMember(Name = "consume_fee_with_discount", EmitDefaultValue = false)]
        public string ConsumeFeeWithDiscount { get; set; }

        /// <summary>
        /// 员工消费记账备注
        /// </summary>
        /// <value>员工消费记账备注</value>
        [DataMember(Name = "consume_memo", EmitDefaultValue = false)]
        public string ConsumeMemo { get; set; }

        /// <summary>
        /// 账单类型 -消费账单：CONSUME -退款账单：REFUND -转账账单：TRANSFER
        /// </summary>
        /// <value>账单类型 -消费账单：CONSUME -退款账单：REFUND -转账账单：TRANSFER</value>
        [DataMember(Name = "consume_type", EmitDefaultValue = false)]
        public string ConsumeType { get; set; }

        /// <summary>
        /// 员工账号ID
        /// </summary>
        /// <value>员工账号ID</value>
        [DataMember(Name = "employee_id", EmitDefaultValue = false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 使用规则ID
        /// </summary>
        /// <value>使用规则ID</value>
        [DataMember(Name = "expense_rule_group_id", EmitDefaultValue = false)]
        public string ExpenseRuleGroupId { get; set; }

        /// <summary>
        /// 费用场景
        /// </summary>
        /// <value>费用场景</value>
        [DataMember(Name = "expense_scene_code", EmitDefaultValue = false)]
        public string ExpenseSceneCode { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        /// <value>费用类型</value>
        [DataMember(Name = "expense_type", EmitDefaultValue = false)]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 费用类型子类目
        /// </summary>
        /// <value>费用类型子类目</value>
        [DataMember(Name = "expense_type_sub_category", EmitDefaultValue = false)]
        public string ExpenseTypeSubCategory { get; set; }

        /// <summary>
        /// 账单扩展信息，Json格式 汇总信息
        /// </summary>
        /// <value>账单扩展信息，Json格式 汇总信息</value>
        [DataMember(Name = "ext_infos", EmitDefaultValue = false)]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 出资模式 个人出资：PERSONAL 企业出资：ENTERPRISE 三方垫资合作伙伴出资：TP 记账：ACCOUNTING
        /// </summary>
        /// <value>出资模式 个人出资：PERSONAL 企业出资：ENTERPRISE 三方垫资合作伙伴出资：TP 记账：ACCOUNTING</value>
        [DataMember(Name = "fund_biz_type", EmitDefaultValue = false)]
        public string FundBizType { get; set; }

        /// <summary>
        /// 账单创建时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>账单创建时间，格式：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "gmt_biz_create", EmitDefaultValue = false)]
        public string GmtBizCreate { get; set; }

        /// <summary>
        /// 账单支付时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>账单支付时间，格式：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "gmt_receive_pay", EmitDefaultValue = false)]
        public string GmtReceivePay { get; set; }

        /// <summary>
        /// 开票模式 企业汇总开：ENTERPRISE_AUTO_BATCH
        /// </summary>
        /// <value>开票模式 企业汇总开：ENTERPRISE_AUTO_BATCH</value>
        [DataMember(Name = "invoice_open_mode", EmitDefaultValue = false)]
        public string InvoiceOpenMode { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        /// <value>商户ID</value>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        /// <value>商户名称</value>
        [DataMember(Name = "merchant_name", EmitDefaultValue = false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// 员工支付宝UID
        /// </summary>
        /// <value>员工支付宝UID</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单完结标识 0：未完结 1：已完结
        /// </summary>
        /// <value>订单完结标识 0：未完结 1：已完结</value>
        [DataMember(Name = "order_complete_label", EmitDefaultValue = false)]
        public string OrderCompleteLabel { get; set; }

        /// <summary>
        /// 2022-01-01 01:01:02 订单完结时间
        /// </summary>
        /// <value>2022-01-01 01:01:02 订单完结时间</value>
        [DataMember(Name = "order_complete_time", EmitDefaultValue = false)]
        public string OrderCompleteTime { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        /// <value>交易流水号</value>
        [DataMember(Name = "pay_no", EmitDefaultValue = false)]
        public string PayNo { get; set; }

        /// <summary>
        /// 企业代付金额，单位：元
        /// </summary>
        /// <value>企业代付金额，单位：元</value>
        [DataMember(Name = "peer_pay_amount", EmitDefaultValue = false)]
        public string PeerPayAmount { get; set; }

        /// <summary>
        /// 实际出资支付宝账号
        /// </summary>
        /// <value>实际出资支付宝账号</value>
        [DataMember(Name = "peer_payer_card_no", EmitDefaultValue = false)]
        public string PeerPayerCardNo { get; set; }

        /// <summary>
        /// 消费账单企业代付部分退款金额，单位：元。退款账单该值无意义，值为0。
        /// </summary>
        /// <value>消费账单企业代付部分退款金额，单位：元。退款账单该值无意义，值为0。</value>
        [DataMember(Name = "peer_refund_amount", EmitDefaultValue = false)]
        public string PeerRefundAmount { get; set; }

        /// <summary>
        /// 消费账单企业代付部分退款状态，默认为INIT。当消费账单有退款，该值会变为REFUND_PART或REFUND_FULL；退款账单该值无意义，为初始值INIT。 未退款：INIT， 部分退款：REFUND_PART， 全额退款：REFUND_FULL
        /// </summary>
        /// <value>消费账单企业代付部分退款状态，默认为INIT。当消费账单有退款，该值会变为REFUND_PART或REFUND_FULL；退款账单该值无意义，为初始值INIT。 未退款：INIT， 部分退款：REFUND_PART， 全额退款：REFUND_FULL</value>
        [DataMember(Name = "peer_refund_status", EmitDefaultValue = false)]
        public string PeerRefundStatus { get; set; }

        /// <summary>
        /// 退款账单关联的消费账单交易流水号，退款账单才有值
        /// </summary>
        /// <value>退款账单关联的消费账单交易流水号，退款账单才有值</value>
        [DataMember(Name = "related_pay_no", EmitDefaultValue = false)]
        public string RelatedPayNo { get; set; }

        /// <summary>
        /// 账单场景 TAKE_AWAY：外卖 METRO：地铁 OTHER：其他
        /// </summary>
        /// <value>账单场景 TAKE_AWAY：外卖 METRO：地铁 OTHER：其他</value>
        [DataMember(Name = "scene_code", EmitDefaultValue = false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// 卖家ID
        /// </summary>
        /// <value>卖家ID</value>
        [DataMember(Name = "seller_id", EmitDefaultValue = false)]
        public string SellerId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        /// <value>门店ID</value>
        [DataMember(Name = "shop_id", EmitDefaultValue = false)]
        public string ShopId { get; set; }

        /// <summary>
        /// 外部门店ID
        /// </summary>
        /// <value>外部门店ID</value>
        [DataMember(Name = "store_id", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// 汇总批次ID
        /// </summary>
        /// <value>汇总批次ID</value>
        [DataMember(Name = "summary_apply_id", EmitDefaultValue = false)]
        public string SummaryApplyId { get; set; }

        /// <summary>
        /// 员工支付宝UID
        /// </summary>
        /// <value>员工支付宝UID</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EcConsumeInfo {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AgreementPeerPayerId: ").Append(AgreementPeerPayerId).Append("\n");
            sb.Append("  BenefitAmount: ").Append(BenefitAmount).Append("\n");
            sb.Append("  BizOutNo: ").Append(BizOutNo).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  ConsumeAmount: ").Append(ConsumeAmount).Append("\n");
            sb.Append("  ConsumeCategory: ").Append(ConsumeCategory).Append("\n");
            sb.Append("  ConsumeFeeWithDiscount: ").Append(ConsumeFeeWithDiscount).Append("\n");
            sb.Append("  ConsumeMemo: ").Append(ConsumeMemo).Append("\n");
            sb.Append("  ConsumeType: ").Append(ConsumeType).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  ExpenseRuleGroupId: ").Append(ExpenseRuleGroupId).Append("\n");
            sb.Append("  ExpenseSceneCode: ").Append(ExpenseSceneCode).Append("\n");
            sb.Append("  ExpenseType: ").Append(ExpenseType).Append("\n");
            sb.Append("  ExpenseTypeSubCategory: ").Append(ExpenseTypeSubCategory).Append("\n");
            sb.Append("  ExtInfos: ").Append(ExtInfos).Append("\n");
            sb.Append("  FundBizType: ").Append(FundBizType).Append("\n");
            sb.Append("  GmtBizCreate: ").Append(GmtBizCreate).Append("\n");
            sb.Append("  GmtReceivePay: ").Append(GmtReceivePay).Append("\n");
            sb.Append("  InvoiceOpenMode: ").Append(InvoiceOpenMode).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OrderCompleteLabel: ").Append(OrderCompleteLabel).Append("\n");
            sb.Append("  OrderCompleteTime: ").Append(OrderCompleteTime).Append("\n");
            sb.Append("  PayNo: ").Append(PayNo).Append("\n");
            sb.Append("  PeerPayAmount: ").Append(PeerPayAmount).Append("\n");
            sb.Append("  PeerPayerCardNo: ").Append(PeerPayerCardNo).Append("\n");
            sb.Append("  PeerRefundAmount: ").Append(PeerRefundAmount).Append("\n");
            sb.Append("  PeerRefundStatus: ").Append(PeerRefundStatus).Append("\n");
            sb.Append("  RelatedPayNo: ").Append(RelatedPayNo).Append("\n");
            sb.Append("  SceneCode: ").Append(SceneCode).Append("\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  ShopId: ").Append(ShopId).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  SummaryApplyId: ").Append(SummaryApplyId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as EcConsumeInfo);
        }

        /// <summary>
        /// Returns true if EcConsumeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of EcConsumeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcConsumeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AgreementPeerPayerId == input.AgreementPeerPayerId ||
                    (this.AgreementPeerPayerId != null &&
                    this.AgreementPeerPayerId.Equals(input.AgreementPeerPayerId))
                ) && 
                (
                    this.BenefitAmount == input.BenefitAmount ||
                    (this.BenefitAmount != null &&
                    this.BenefitAmount.Equals(input.BenefitAmount))
                ) && 
                (
                    this.BizOutNo == input.BizOutNo ||
                    (this.BizOutNo != null &&
                    this.BizOutNo.Equals(input.BizOutNo))
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.ConsumeAmount == input.ConsumeAmount ||
                    (this.ConsumeAmount != null &&
                    this.ConsumeAmount.Equals(input.ConsumeAmount))
                ) && 
                (
                    this.ConsumeCategory == input.ConsumeCategory ||
                    (this.ConsumeCategory != null &&
                    this.ConsumeCategory.Equals(input.ConsumeCategory))
                ) && 
                (
                    this.ConsumeFeeWithDiscount == input.ConsumeFeeWithDiscount ||
                    (this.ConsumeFeeWithDiscount != null &&
                    this.ConsumeFeeWithDiscount.Equals(input.ConsumeFeeWithDiscount))
                ) && 
                (
                    this.ConsumeMemo == input.ConsumeMemo ||
                    (this.ConsumeMemo != null &&
                    this.ConsumeMemo.Equals(input.ConsumeMemo))
                ) && 
                (
                    this.ConsumeType == input.ConsumeType ||
                    (this.ConsumeType != null &&
                    this.ConsumeType.Equals(input.ConsumeType))
                ) && 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.ExpenseRuleGroupId == input.ExpenseRuleGroupId ||
                    (this.ExpenseRuleGroupId != null &&
                    this.ExpenseRuleGroupId.Equals(input.ExpenseRuleGroupId))
                ) && 
                (
                    this.ExpenseSceneCode == input.ExpenseSceneCode ||
                    (this.ExpenseSceneCode != null &&
                    this.ExpenseSceneCode.Equals(input.ExpenseSceneCode))
                ) && 
                (
                    this.ExpenseType == input.ExpenseType ||
                    (this.ExpenseType != null &&
                    this.ExpenseType.Equals(input.ExpenseType))
                ) && 
                (
                    this.ExpenseTypeSubCategory == input.ExpenseTypeSubCategory ||
                    (this.ExpenseTypeSubCategory != null &&
                    this.ExpenseTypeSubCategory.Equals(input.ExpenseTypeSubCategory))
                ) && 
                (
                    this.ExtInfos == input.ExtInfos ||
                    (this.ExtInfos != null &&
                    this.ExtInfos.Equals(input.ExtInfos))
                ) && 
                (
                    this.FundBizType == input.FundBizType ||
                    (this.FundBizType != null &&
                    this.FundBizType.Equals(input.FundBizType))
                ) && 
                (
                    this.GmtBizCreate == input.GmtBizCreate ||
                    (this.GmtBizCreate != null &&
                    this.GmtBizCreate.Equals(input.GmtBizCreate))
                ) && 
                (
                    this.GmtReceivePay == input.GmtReceivePay ||
                    (this.GmtReceivePay != null &&
                    this.GmtReceivePay.Equals(input.GmtReceivePay))
                ) && 
                (
                    this.InvoiceOpenMode == input.InvoiceOpenMode ||
                    (this.InvoiceOpenMode != null &&
                    this.InvoiceOpenMode.Equals(input.InvoiceOpenMode))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.MerchantName == input.MerchantName ||
                    (this.MerchantName != null &&
                    this.MerchantName.Equals(input.MerchantName))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OrderCompleteLabel == input.OrderCompleteLabel ||
                    (this.OrderCompleteLabel != null &&
                    this.OrderCompleteLabel.Equals(input.OrderCompleteLabel))
                ) && 
                (
                    this.OrderCompleteTime == input.OrderCompleteTime ||
                    (this.OrderCompleteTime != null &&
                    this.OrderCompleteTime.Equals(input.OrderCompleteTime))
                ) && 
                (
                    this.PayNo == input.PayNo ||
                    (this.PayNo != null &&
                    this.PayNo.Equals(input.PayNo))
                ) && 
                (
                    this.PeerPayAmount == input.PeerPayAmount ||
                    (this.PeerPayAmount != null &&
                    this.PeerPayAmount.Equals(input.PeerPayAmount))
                ) && 
                (
                    this.PeerPayerCardNo == input.PeerPayerCardNo ||
                    (this.PeerPayerCardNo != null &&
                    this.PeerPayerCardNo.Equals(input.PeerPayerCardNo))
                ) && 
                (
                    this.PeerRefundAmount == input.PeerRefundAmount ||
                    (this.PeerRefundAmount != null &&
                    this.PeerRefundAmount.Equals(input.PeerRefundAmount))
                ) && 
                (
                    this.PeerRefundStatus == input.PeerRefundStatus ||
                    (this.PeerRefundStatus != null &&
                    this.PeerRefundStatus.Equals(input.PeerRefundStatus))
                ) && 
                (
                    this.RelatedPayNo == input.RelatedPayNo ||
                    (this.RelatedPayNo != null &&
                    this.RelatedPayNo.Equals(input.RelatedPayNo))
                ) && 
                (
                    this.SceneCode == input.SceneCode ||
                    (this.SceneCode != null &&
                    this.SceneCode.Equals(input.SceneCode))
                ) && 
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
                ) && 
                (
                    this.ShopId == input.ShopId ||
                    (this.ShopId != null &&
                    this.ShopId.Equals(input.ShopId))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.SummaryApplyId == input.SummaryApplyId ||
                    (this.SummaryApplyId != null &&
                    this.SummaryApplyId.Equals(input.SummaryApplyId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.AgreementPeerPayerId != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementPeerPayerId.GetHashCode();
                }
                if (this.BenefitAmount != null)
                {
                    hashCode = (hashCode * 59) + this.BenefitAmount.GetHashCode();
                }
                if (this.BizOutNo != null)
                {
                    hashCode = (hashCode * 59) + this.BizOutNo.GetHashCode();
                }
                if (this.CategoryName != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryName.GetHashCode();
                }
                if (this.ConsumeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumeAmount.GetHashCode();
                }
                if (this.ConsumeCategory != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumeCategory.GetHashCode();
                }
                if (this.ConsumeFeeWithDiscount != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumeFeeWithDiscount.GetHashCode();
                }
                if (this.ConsumeMemo != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumeMemo.GetHashCode();
                }
                if (this.ConsumeType != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumeType.GetHashCode();
                }
                if (this.EmployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeId.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.ExpenseRuleGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseRuleGroupId.GetHashCode();
                }
                if (this.ExpenseSceneCode != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseSceneCode.GetHashCode();
                }
                if (this.ExpenseType != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseType.GetHashCode();
                }
                if (this.ExpenseTypeSubCategory != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseTypeSubCategory.GetHashCode();
                }
                if (this.ExtInfos != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfos.GetHashCode();
                }
                if (this.FundBizType != null)
                {
                    hashCode = (hashCode * 59) + this.FundBizType.GetHashCode();
                }
                if (this.GmtBizCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtBizCreate.GetHashCode();
                }
                if (this.GmtReceivePay != null)
                {
                    hashCode = (hashCode * 59) + this.GmtReceivePay.GetHashCode();
                }
                if (this.InvoiceOpenMode != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceOpenMode.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.MerchantName != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantName.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OrderCompleteLabel != null)
                {
                    hashCode = (hashCode * 59) + this.OrderCompleteLabel.GetHashCode();
                }
                if (this.OrderCompleteTime != null)
                {
                    hashCode = (hashCode * 59) + this.OrderCompleteTime.GetHashCode();
                }
                if (this.PayNo != null)
                {
                    hashCode = (hashCode * 59) + this.PayNo.GetHashCode();
                }
                if (this.PeerPayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PeerPayAmount.GetHashCode();
                }
                if (this.PeerPayerCardNo != null)
                {
                    hashCode = (hashCode * 59) + this.PeerPayerCardNo.GetHashCode();
                }
                if (this.PeerRefundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PeerRefundAmount.GetHashCode();
                }
                if (this.PeerRefundStatus != null)
                {
                    hashCode = (hashCode * 59) + this.PeerRefundStatus.GetHashCode();
                }
                if (this.RelatedPayNo != null)
                {
                    hashCode = (hashCode * 59) + this.RelatedPayNo.GetHashCode();
                }
                if (this.SceneCode != null)
                {
                    hashCode = (hashCode * 59) + this.SceneCode.GetHashCode();
                }
                if (this.SellerId != null)
                {
                    hashCode = (hashCode * 59) + this.SellerId.GetHashCode();
                }
                if (this.ShopId != null)
                {
                    hashCode = (hashCode * 59) + this.ShopId.GetHashCode();
                }
                if (this.StoreId != null)
                {
                    hashCode = (hashCode * 59) + this.StoreId.GetHashCode();
                }
                if (this.SummaryApplyId != null)
                {
                    hashCode = (hashCode * 59) + this.SummaryApplyId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
