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
    /// InvoiceModelContent
    /// </summary>
    [DataContract(Name = "InvoiceModelContent")]
    public partial class InvoiceModelContent : IEquatable<InvoiceModelContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceModelContent" /> class.
        /// </summary>
        /// <param name="applyId">支付宝端的申请id。如果在开票过程中，是通过支付宝提交的申请到机构端，支付宝会带上开票申请在支付宝生成的申请id，机构在回传发票的时候只需要回传这个申请id，不用获取用户的uid，支付宝可以根据申请id将发票归集到对应的用户名下.</param>
        /// <param name="extendFields">key&#x3D;value，每组键值对以回车分割.</param>
        /// <param name="fileDownloadType">下载的发票文件类型，可选值： pdf（发票原文件） ofd（发票原文件） jpg（发票原文件缩略图）.</param>
        /// <param name="fileDownloadUrl">发票原文件下载地址 1.当tax_type&#x3D;PLAIN、ALL_ELECTRONIC_GENERAL或ALL_ELECTRONIC_SPECIAL时， file_download_url必传 且file_download_type取值范围为pdf或ofd； 2.当tax_type&#x3D;SPECIAL时， file_download_url必传 file_download_type可以传入pdf，ofd，jpg 3.当其他票种时，file_download_url可以不传.</param>
        /// <param name="financialElectronicType">财政电子票据子类型，当tax_type&#x3D;FINANCIAL_ELECTRONIC_BILL时要求必填 可选值如下： 01:非税收入通用票据  02:非税收入专用票据 03:非税收入一般缴款书 04:资金往来结算票据 05:公益事业捐赠票据 06:医疗收费票据 07:社会团体会费票据 08:社会保险基金票据 09:工会经费收入票据 99:其他财政票据.</param>
        /// <param name="invoiceAmount">发票金额，大于0且精确到小数点两位，以元为单位  需要传入税价合计金额.</param>
        /// <param name="invoiceCode">发票代码，为国税局生成的唯一值，全电票时为空，其他情况不可为空.</param>
        /// <param name="invoiceContent">发票内容项.</param>
        /// <param name="invoiceDate">发票日期，用户填写，目前精确到日.</param>
        /// <param name="invoiceFakeCode">发票防伪码.</param>
        /// <param name="invoiceFileData">原始发票PDF/OFD文件流.</param>
        /// <param name="invoiceImgUrl">发票原始文件jpg文件地址.</param>
        /// <param name="invoiceNo">发票号码，国税局生成的唯一号码，不可为空串；  使用时请注意，invoice_no+invoice_code唯一，不能重复.</param>
        /// <param name="invoiceOperator">发票开具操作人.</param>
        /// <param name="invoiceTitle">invoiceTitle.</param>
        /// <param name="invoiceType">发票类型，按照可选值只传入英文部分，该字段严格要求大小写  可选值:  blue（蓝票）  red（红票）.</param>
        /// <param name="openId">支付宝用户id，支付宝端的申请id存在的时候也不需要传，其他情况下，当同步的是蓝票时，必传，红票时不需传。.</param>
        /// <param name="originalBlueInvoiceCode">仅用于同步红票，原始蓝票发票代码，同步红票时必传（全电票时为空）.</param>
        /// <param name="originalBlueInvoiceNo">仅用于同步红票，原始蓝票发票号码，同步红票时必传.</param>
        /// <param name="outBizNo">商户交易流水号，不可为空串;  传入红票时请注意，此字段的值要和蓝票保持一致.</param>
        /// <param name="outInvoiceId">商户唯一开票申请业务流水号，同一个isv下不能重复.</param>
        /// <param name="registerAddress">开票单位地址.</param>
        /// <param name="registerBankAccount">开票单位开户行账号.</param>
        /// <param name="registerBankName">开票单位开户行名称.</param>
        /// <param name="registerName">开票单位.</param>
        /// <param name="registerNo">纳税人识别号，不可为空串.</param>
        /// <param name="registerPhoneNo">开票人电话，支持座机和手机两种格式.</param>
        /// <param name="sumAmount">价税合计.</param>
        /// <param name="taxAmount">税额.</param>
        /// <param name="taxType">税种 可选值： PLAIN：增值税电子普通发票 ALL_ELECTRONIC_GENERAL：电子发票（普通发票） ALL_ELECTRONIC_SPECIAL：电子发票（增值税专用发票） SPECIAL：增值税专用发票 PLAIN_INVOICE:增值税普通发票 FINANCIAL_ELECTRONIC_BILL:财政电子票据.</param>
        /// <param name="userId">支付宝用户id，支付宝端的申请id存在的时候也不需要传，其他情况下，当同步的是蓝票时，必传，红票时不需传。.</param>
        public InvoiceModelContent(string applyId = default(string), string extendFields = default(string), string fileDownloadType = default(string), string fileDownloadUrl = default(string), string financialElectronicType = default(string), string invoiceAmount = default(string), string invoiceCode = default(string), List<InvoiceItemContent> invoiceContent = default(List<InvoiceItemContent>), string invoiceDate = default(string), string invoiceFakeCode = default(string), string invoiceFileData = default(string), string invoiceImgUrl = default(string), string invoiceNo = default(string), string invoiceOperator = default(string), InvoiceTitleModel invoiceTitle = default(InvoiceTitleModel), string invoiceType = default(string), string openId = default(string), string originalBlueInvoiceCode = default(string), string originalBlueInvoiceNo = default(string), string outBizNo = default(string), string outInvoiceId = default(string), string registerAddress = default(string), string registerBankAccount = default(string), string registerBankName = default(string), string registerName = default(string), string registerNo = default(string), string registerPhoneNo = default(string), string sumAmount = default(string), string taxAmount = default(string), string taxType = default(string), string userId = default(string))
        {
            this.ApplyId = applyId;
            this.ExtendFields = extendFields;
            this.FileDownloadType = fileDownloadType;
            this.FileDownloadUrl = fileDownloadUrl;
            this.FinancialElectronicType = financialElectronicType;
            this.InvoiceAmount = invoiceAmount;
            this.InvoiceCode = invoiceCode;
            this.InvoiceContent = invoiceContent;
            this.InvoiceDate = invoiceDate;
            this.InvoiceFakeCode = invoiceFakeCode;
            this.InvoiceFileData = invoiceFileData;
            this.InvoiceImgUrl = invoiceImgUrl;
            this.InvoiceNo = invoiceNo;
            this.InvoiceOperator = invoiceOperator;
            this.InvoiceTitle = invoiceTitle;
            this.InvoiceType = invoiceType;
            this.OpenId = openId;
            this.OriginalBlueInvoiceCode = originalBlueInvoiceCode;
            this.OriginalBlueInvoiceNo = originalBlueInvoiceNo;
            this.OutBizNo = outBizNo;
            this.OutInvoiceId = outInvoiceId;
            this.RegisterAddress = registerAddress;
            this.RegisterBankAccount = registerBankAccount;
            this.RegisterBankName = registerBankName;
            this.RegisterName = registerName;
            this.RegisterNo = registerNo;
            this.RegisterPhoneNo = registerPhoneNo;
            this.SumAmount = sumAmount;
            this.TaxAmount = taxAmount;
            this.TaxType = taxType;
            this.UserId = userId;
        }

        /// <summary>
        /// 支付宝端的申请id。如果在开票过程中，是通过支付宝提交的申请到机构端，支付宝会带上开票申请在支付宝生成的申请id，机构在回传发票的时候只需要回传这个申请id，不用获取用户的uid，支付宝可以根据申请id将发票归集到对应的用户名下
        /// </summary>
        /// <value>支付宝端的申请id。如果在开票过程中，是通过支付宝提交的申请到机构端，支付宝会带上开票申请在支付宝生成的申请id，机构在回传发票的时候只需要回传这个申请id，不用获取用户的uid，支付宝可以根据申请id将发票归集到对应的用户名下</value>
        [DataMember(Name = "apply_id", EmitDefaultValue = false)]
        public string ApplyId { get; set; }

        /// <summary>
        /// key&#x3D;value，每组键值对以回车分割
        /// </summary>
        /// <value>key&#x3D;value，每组键值对以回车分割</value>
        [DataMember(Name = "extend_fields", EmitDefaultValue = false)]
        public string ExtendFields { get; set; }

        /// <summary>
        /// 下载的发票文件类型，可选值： pdf（发票原文件） ofd（发票原文件） jpg（发票原文件缩略图）
        /// </summary>
        /// <value>下载的发票文件类型，可选值： pdf（发票原文件） ofd（发票原文件） jpg（发票原文件缩略图）</value>
        [DataMember(Name = "file_download_type", EmitDefaultValue = false)]
        public string FileDownloadType { get; set; }

        /// <summary>
        /// 发票原文件下载地址 1.当tax_type&#x3D;PLAIN、ALL_ELECTRONIC_GENERAL或ALL_ELECTRONIC_SPECIAL时， file_download_url必传 且file_download_type取值范围为pdf或ofd； 2.当tax_type&#x3D;SPECIAL时， file_download_url必传 file_download_type可以传入pdf，ofd，jpg 3.当其他票种时，file_download_url可以不传
        /// </summary>
        /// <value>发票原文件下载地址 1.当tax_type&#x3D;PLAIN、ALL_ELECTRONIC_GENERAL或ALL_ELECTRONIC_SPECIAL时， file_download_url必传 且file_download_type取值范围为pdf或ofd； 2.当tax_type&#x3D;SPECIAL时， file_download_url必传 file_download_type可以传入pdf，ofd，jpg 3.当其他票种时，file_download_url可以不传</value>
        [DataMember(Name = "file_download_url", EmitDefaultValue = false)]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 财政电子票据子类型，当tax_type&#x3D;FINANCIAL_ELECTRONIC_BILL时要求必填 可选值如下： 01:非税收入通用票据  02:非税收入专用票据 03:非税收入一般缴款书 04:资金往来结算票据 05:公益事业捐赠票据 06:医疗收费票据 07:社会团体会费票据 08:社会保险基金票据 09:工会经费收入票据 99:其他财政票据
        /// </summary>
        /// <value>财政电子票据子类型，当tax_type&#x3D;FINANCIAL_ELECTRONIC_BILL时要求必填 可选值如下： 01:非税收入通用票据  02:非税收入专用票据 03:非税收入一般缴款书 04:资金往来结算票据 05:公益事业捐赠票据 06:医疗收费票据 07:社会团体会费票据 08:社会保险基金票据 09:工会经费收入票据 99:其他财政票据</value>
        [DataMember(Name = "financial_electronic_type", EmitDefaultValue = false)]
        public string FinancialElectronicType { get; set; }

        /// <summary>
        /// 发票金额，大于0且精确到小数点两位，以元为单位  需要传入税价合计金额
        /// </summary>
        /// <value>发票金额，大于0且精确到小数点两位，以元为单位  需要传入税价合计金额</value>
        [DataMember(Name = "invoice_amount", EmitDefaultValue = false)]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票代码，为国税局生成的唯一值，全电票时为空，其他情况不可为空
        /// </summary>
        /// <value>发票代码，为国税局生成的唯一值，全电票时为空，其他情况不可为空</value>
        [DataMember(Name = "invoice_code", EmitDefaultValue = false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票内容项
        /// </summary>
        /// <value>发票内容项</value>
        [DataMember(Name = "invoice_content", EmitDefaultValue = false)]
        public List<InvoiceItemContent> InvoiceContent { get; set; }

        /// <summary>
        /// 发票日期，用户填写，目前精确到日
        /// </summary>
        /// <value>发票日期，用户填写，目前精确到日</value>
        [DataMember(Name = "invoice_date", EmitDefaultValue = false)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票防伪码
        /// </summary>
        /// <value>发票防伪码</value>
        [DataMember(Name = "invoice_fake_code", EmitDefaultValue = false)]
        public string InvoiceFakeCode { get; set; }

        /// <summary>
        /// 原始发票PDF/OFD文件流
        /// </summary>
        /// <value>原始发票PDF/OFD文件流</value>
        [DataMember(Name = "invoice_file_data", EmitDefaultValue = false)]
        public string InvoiceFileData { get; set; }

        /// <summary>
        /// 发票原始文件jpg文件地址
        /// </summary>
        /// <value>发票原始文件jpg文件地址</value>
        [DataMember(Name = "invoice_img_url", EmitDefaultValue = false)]
        public string InvoiceImgUrl { get; set; }

        /// <summary>
        /// 发票号码，国税局生成的唯一号码，不可为空串；  使用时请注意，invoice_no+invoice_code唯一，不能重复
        /// </summary>
        /// <value>发票号码，国税局生成的唯一号码，不可为空串；  使用时请注意，invoice_no+invoice_code唯一，不能重复</value>
        [DataMember(Name = "invoice_no", EmitDefaultValue = false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票开具操作人
        /// </summary>
        /// <value>发票开具操作人</value>
        [DataMember(Name = "invoice_operator", EmitDefaultValue = false)]
        public string InvoiceOperator { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceTitle
        /// </summary>
        [DataMember(Name = "invoice_title", EmitDefaultValue = false)]
        public InvoiceTitleModel InvoiceTitle { get; set; }

        /// <summary>
        /// 发票类型，按照可选值只传入英文部分，该字段严格要求大小写  可选值:  blue（蓝票）  red（红票）
        /// </summary>
        /// <value>发票类型，按照可选值只传入英文部分，该字段严格要求大小写  可选值:  blue（蓝票）  red（红票）</value>
        [DataMember(Name = "invoice_type", EmitDefaultValue = false)]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 支付宝用户id，支付宝端的申请id存在的时候也不需要传，其他情况下，当同步的是蓝票时，必传，红票时不需传。
        /// </summary>
        /// <value>支付宝用户id，支付宝端的申请id存在的时候也不需要传，其他情况下，当同步的是蓝票时，必传，红票时不需传。</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 仅用于同步红票，原始蓝票发票代码，同步红票时必传（全电票时为空）
        /// </summary>
        /// <value>仅用于同步红票，原始蓝票发票代码，同步红票时必传（全电票时为空）</value>
        [DataMember(Name = "original_blue_invoice_code", EmitDefaultValue = false)]
        public string OriginalBlueInvoiceCode { get; set; }

        /// <summary>
        /// 仅用于同步红票，原始蓝票发票号码，同步红票时必传
        /// </summary>
        /// <value>仅用于同步红票，原始蓝票发票号码，同步红票时必传</value>
        [DataMember(Name = "original_blue_invoice_no", EmitDefaultValue = false)]
        public string OriginalBlueInvoiceNo { get; set; }

        /// <summary>
        /// 商户交易流水号，不可为空串;  传入红票时请注意，此字段的值要和蓝票保持一致
        /// </summary>
        /// <value>商户交易流水号，不可为空串;  传入红票时请注意，此字段的值要和蓝票保持一致</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户唯一开票申请业务流水号，同一个isv下不能重复
        /// </summary>
        /// <value>商户唯一开票申请业务流水号，同一个isv下不能重复</value>
        [DataMember(Name = "out_invoice_id", EmitDefaultValue = false)]
        public string OutInvoiceId { get; set; }

        /// <summary>
        /// 开票单位地址
        /// </summary>
        /// <value>开票单位地址</value>
        [DataMember(Name = "register_address", EmitDefaultValue = false)]
        public string RegisterAddress { get; set; }

        /// <summary>
        /// 开票单位开户行账号
        /// </summary>
        /// <value>开票单位开户行账号</value>
        [DataMember(Name = "register_bank_account", EmitDefaultValue = false)]
        public string RegisterBankAccount { get; set; }

        /// <summary>
        /// 开票单位开户行名称
        /// </summary>
        /// <value>开票单位开户行名称</value>
        [DataMember(Name = "register_bank_name", EmitDefaultValue = false)]
        public string RegisterBankName { get; set; }

        /// <summary>
        /// 开票单位
        /// </summary>
        /// <value>开票单位</value>
        [DataMember(Name = "register_name", EmitDefaultValue = false)]
        public string RegisterName { get; set; }

        /// <summary>
        /// 纳税人识别号，不可为空串
        /// </summary>
        /// <value>纳税人识别号，不可为空串</value>
        [DataMember(Name = "register_no", EmitDefaultValue = false)]
        public string RegisterNo { get; set; }

        /// <summary>
        /// 开票人电话，支持座机和手机两种格式
        /// </summary>
        /// <value>开票人电话，支持座机和手机两种格式</value>
        [DataMember(Name = "register_phone_no", EmitDefaultValue = false)]
        public string RegisterPhoneNo { get; set; }

        /// <summary>
        /// 价税合计
        /// </summary>
        /// <value>价税合计</value>
        [DataMember(Name = "sum_amount", EmitDefaultValue = false)]
        public string SumAmount { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        /// <value>税额</value>
        [DataMember(Name = "tax_amount", EmitDefaultValue = false)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 税种 可选值： PLAIN：增值税电子普通发票 ALL_ELECTRONIC_GENERAL：电子发票（普通发票） ALL_ELECTRONIC_SPECIAL：电子发票（增值税专用发票） SPECIAL：增值税专用发票 PLAIN_INVOICE:增值税普通发票 FINANCIAL_ELECTRONIC_BILL:财政电子票据
        /// </summary>
        /// <value>税种 可选值： PLAIN：增值税电子普通发票 ALL_ELECTRONIC_GENERAL：电子发票（普通发票） ALL_ELECTRONIC_SPECIAL：电子发票（增值税专用发票） SPECIAL：增值税专用发票 PLAIN_INVOICE:增值税普通发票 FINANCIAL_ELECTRONIC_BILL:财政电子票据</value>
        [DataMember(Name = "tax_type", EmitDefaultValue = false)]
        public string TaxType { get; set; }

        /// <summary>
        /// 支付宝用户id，支付宝端的申请id存在的时候也不需要传，其他情况下，当同步的是蓝票时，必传，红票时不需传。
        /// </summary>
        /// <value>支付宝用户id，支付宝端的申请id存在的时候也不需要传，其他情况下，当同步的是蓝票时，必传，红票时不需传。</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceModelContent {\n");
            sb.Append("  ApplyId: ").Append(ApplyId).Append("\n");
            sb.Append("  ExtendFields: ").Append(ExtendFields).Append("\n");
            sb.Append("  FileDownloadType: ").Append(FileDownloadType).Append("\n");
            sb.Append("  FileDownloadUrl: ").Append(FileDownloadUrl).Append("\n");
            sb.Append("  FinancialElectronicType: ").Append(FinancialElectronicType).Append("\n");
            sb.Append("  InvoiceAmount: ").Append(InvoiceAmount).Append("\n");
            sb.Append("  InvoiceCode: ").Append(InvoiceCode).Append("\n");
            sb.Append("  InvoiceContent: ").Append(InvoiceContent).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  InvoiceFakeCode: ").Append(InvoiceFakeCode).Append("\n");
            sb.Append("  InvoiceFileData: ").Append(InvoiceFileData).Append("\n");
            sb.Append("  InvoiceImgUrl: ").Append(InvoiceImgUrl).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  InvoiceOperator: ").Append(InvoiceOperator).Append("\n");
            sb.Append("  InvoiceTitle: ").Append(InvoiceTitle).Append("\n");
            sb.Append("  InvoiceType: ").Append(InvoiceType).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OriginalBlueInvoiceCode: ").Append(OriginalBlueInvoiceCode).Append("\n");
            sb.Append("  OriginalBlueInvoiceNo: ").Append(OriginalBlueInvoiceNo).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  OutInvoiceId: ").Append(OutInvoiceId).Append("\n");
            sb.Append("  RegisterAddress: ").Append(RegisterAddress).Append("\n");
            sb.Append("  RegisterBankAccount: ").Append(RegisterBankAccount).Append("\n");
            sb.Append("  RegisterBankName: ").Append(RegisterBankName).Append("\n");
            sb.Append("  RegisterName: ").Append(RegisterName).Append("\n");
            sb.Append("  RegisterNo: ").Append(RegisterNo).Append("\n");
            sb.Append("  RegisterPhoneNo: ").Append(RegisterPhoneNo).Append("\n");
            sb.Append("  SumAmount: ").Append(SumAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
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
            return this.Equals(input as InvoiceModelContent);
        }

        /// <summary>
        /// Returns true if InvoiceModelContent instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceModelContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceModelContent input)
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
                    this.ExtendFields == input.ExtendFields ||
                    (this.ExtendFields != null &&
                    this.ExtendFields.Equals(input.ExtendFields))
                ) && 
                (
                    this.FileDownloadType == input.FileDownloadType ||
                    (this.FileDownloadType != null &&
                    this.FileDownloadType.Equals(input.FileDownloadType))
                ) && 
                (
                    this.FileDownloadUrl == input.FileDownloadUrl ||
                    (this.FileDownloadUrl != null &&
                    this.FileDownloadUrl.Equals(input.FileDownloadUrl))
                ) && 
                (
                    this.FinancialElectronicType == input.FinancialElectronicType ||
                    (this.FinancialElectronicType != null &&
                    this.FinancialElectronicType.Equals(input.FinancialElectronicType))
                ) && 
                (
                    this.InvoiceAmount == input.InvoiceAmount ||
                    (this.InvoiceAmount != null &&
                    this.InvoiceAmount.Equals(input.InvoiceAmount))
                ) && 
                (
                    this.InvoiceCode == input.InvoiceCode ||
                    (this.InvoiceCode != null &&
                    this.InvoiceCode.Equals(input.InvoiceCode))
                ) && 
                (
                    this.InvoiceContent == input.InvoiceContent ||
                    this.InvoiceContent != null &&
                    input.InvoiceContent != null &&
                    this.InvoiceContent.SequenceEqual(input.InvoiceContent)
                ) && 
                (
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
                ) && 
                (
                    this.InvoiceFakeCode == input.InvoiceFakeCode ||
                    (this.InvoiceFakeCode != null &&
                    this.InvoiceFakeCode.Equals(input.InvoiceFakeCode))
                ) && 
                (
                    this.InvoiceFileData == input.InvoiceFileData ||
                    (this.InvoiceFileData != null &&
                    this.InvoiceFileData.Equals(input.InvoiceFileData))
                ) && 
                (
                    this.InvoiceImgUrl == input.InvoiceImgUrl ||
                    (this.InvoiceImgUrl != null &&
                    this.InvoiceImgUrl.Equals(input.InvoiceImgUrl))
                ) && 
                (
                    this.InvoiceNo == input.InvoiceNo ||
                    (this.InvoiceNo != null &&
                    this.InvoiceNo.Equals(input.InvoiceNo))
                ) && 
                (
                    this.InvoiceOperator == input.InvoiceOperator ||
                    (this.InvoiceOperator != null &&
                    this.InvoiceOperator.Equals(input.InvoiceOperator))
                ) && 
                (
                    this.InvoiceTitle == input.InvoiceTitle ||
                    (this.InvoiceTitle != null &&
                    this.InvoiceTitle.Equals(input.InvoiceTitle))
                ) && 
                (
                    this.InvoiceType == input.InvoiceType ||
                    (this.InvoiceType != null &&
                    this.InvoiceType.Equals(input.InvoiceType))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OriginalBlueInvoiceCode == input.OriginalBlueInvoiceCode ||
                    (this.OriginalBlueInvoiceCode != null &&
                    this.OriginalBlueInvoiceCode.Equals(input.OriginalBlueInvoiceCode))
                ) && 
                (
                    this.OriginalBlueInvoiceNo == input.OriginalBlueInvoiceNo ||
                    (this.OriginalBlueInvoiceNo != null &&
                    this.OriginalBlueInvoiceNo.Equals(input.OriginalBlueInvoiceNo))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.OutInvoiceId == input.OutInvoiceId ||
                    (this.OutInvoiceId != null &&
                    this.OutInvoiceId.Equals(input.OutInvoiceId))
                ) && 
                (
                    this.RegisterAddress == input.RegisterAddress ||
                    (this.RegisterAddress != null &&
                    this.RegisterAddress.Equals(input.RegisterAddress))
                ) && 
                (
                    this.RegisterBankAccount == input.RegisterBankAccount ||
                    (this.RegisterBankAccount != null &&
                    this.RegisterBankAccount.Equals(input.RegisterBankAccount))
                ) && 
                (
                    this.RegisterBankName == input.RegisterBankName ||
                    (this.RegisterBankName != null &&
                    this.RegisterBankName.Equals(input.RegisterBankName))
                ) && 
                (
                    this.RegisterName == input.RegisterName ||
                    (this.RegisterName != null &&
                    this.RegisterName.Equals(input.RegisterName))
                ) && 
                (
                    this.RegisterNo == input.RegisterNo ||
                    (this.RegisterNo != null &&
                    this.RegisterNo.Equals(input.RegisterNo))
                ) && 
                (
                    this.RegisterPhoneNo == input.RegisterPhoneNo ||
                    (this.RegisterPhoneNo != null &&
                    this.RegisterPhoneNo.Equals(input.RegisterPhoneNo))
                ) && 
                (
                    this.SumAmount == input.SumAmount ||
                    (this.SumAmount != null &&
                    this.SumAmount.Equals(input.SumAmount))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
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
                if (this.ApplyId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyId.GetHashCode();
                }
                if (this.ExtendFields != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendFields.GetHashCode();
                }
                if (this.FileDownloadType != null)
                {
                    hashCode = (hashCode * 59) + this.FileDownloadType.GetHashCode();
                }
                if (this.FileDownloadUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FileDownloadUrl.GetHashCode();
                }
                if (this.FinancialElectronicType != null)
                {
                    hashCode = (hashCode * 59) + this.FinancialElectronicType.GetHashCode();
                }
                if (this.InvoiceAmount != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceAmount.GetHashCode();
                }
                if (this.InvoiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceCode.GetHashCode();
                }
                if (this.InvoiceContent != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceContent.GetHashCode();
                }
                if (this.InvoiceDate != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceDate.GetHashCode();
                }
                if (this.InvoiceFakeCode != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceFakeCode.GetHashCode();
                }
                if (this.InvoiceFileData != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceFileData.GetHashCode();
                }
                if (this.InvoiceImgUrl != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceImgUrl.GetHashCode();
                }
                if (this.InvoiceNo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNo.GetHashCode();
                }
                if (this.InvoiceOperator != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceOperator.GetHashCode();
                }
                if (this.InvoiceTitle != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceTitle.GetHashCode();
                }
                if (this.InvoiceType != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceType.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OriginalBlueInvoiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalBlueInvoiceCode.GetHashCode();
                }
                if (this.OriginalBlueInvoiceNo != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalBlueInvoiceNo.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.OutInvoiceId != null)
                {
                    hashCode = (hashCode * 59) + this.OutInvoiceId.GetHashCode();
                }
                if (this.RegisterAddress != null)
                {
                    hashCode = (hashCode * 59) + this.RegisterAddress.GetHashCode();
                }
                if (this.RegisterBankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.RegisterBankAccount.GetHashCode();
                }
                if (this.RegisterBankName != null)
                {
                    hashCode = (hashCode * 59) + this.RegisterBankName.GetHashCode();
                }
                if (this.RegisterName != null)
                {
                    hashCode = (hashCode * 59) + this.RegisterName.GetHashCode();
                }
                if (this.RegisterNo != null)
                {
                    hashCode = (hashCode * 59) + this.RegisterNo.GetHashCode();
                }
                if (this.RegisterPhoneNo != null)
                {
                    hashCode = (hashCode * 59) + this.RegisterPhoneNo.GetHashCode();
                }
                if (this.SumAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SumAmount.GetHashCode();
                }
                if (this.TaxAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TaxAmount.GetHashCode();
                }
                if (this.TaxType != null)
                {
                    hashCode = (hashCode * 59) + this.TaxType.GetHashCode();
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
