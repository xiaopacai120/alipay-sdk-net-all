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
    /// AlipayPcreditHuabeiAuthOrderUnfreezeModel
    /// </summary>
    [DataContract(Name = "AlipayPcreditHuabeiAuthOrderUnfreezeModel")]
    public partial class AlipayPcreditHuabeiAuthOrderUnfreezeModel : IEquatable<AlipayPcreditHuabeiAuthOrderUnfreezeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayPcreditHuabeiAuthOrderUnfreezeModel" /> class.
        /// </summary>
        /// <param name="agreementNo">支付宝系统中用以唯一标识用户签约记录的编号，即花呗先享协议号.</param>
        /// <param name="alipayUserId">买家在支付宝的用户id.</param>
        /// <param name="needTerminated">true表示需要解约。false或者不填写表示仅解冻。.</param>
        /// <param name="openId">买家在支付宝的用户id.</param>
        /// <param name="orderTitle">商户业务订单的简单描述，如商品名称等，长度不超过100个字母或50个汉字.</param>
        /// <param name="outRequestNo">商户本次操作的请求流水号，用于标识请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。.</param>
        /// <param name="sellerId">商户的支付宝用户id。如果该值为空，则默认为商户签约账号对应的支付宝用户ID。.</param>
        /// <param name="unfreezeAmount">需要解冻的金额，单位为：元（人民币），精确到小数点后两位.</param>
        public AlipayPcreditHuabeiAuthOrderUnfreezeModel(string agreementNo = default(string), string alipayUserId = default(string), string needTerminated = default(string), string openId = default(string), string orderTitle = default(string), string outRequestNo = default(string), string sellerId = default(string), string unfreezeAmount = default(string))
        {
            this.AgreementNo = agreementNo;
            this.AlipayUserId = alipayUserId;
            this.NeedTerminated = needTerminated;
            this.OpenId = openId;
            this.OrderTitle = orderTitle;
            this.OutRequestNo = outRequestNo;
            this.SellerId = sellerId;
            this.UnfreezeAmount = unfreezeAmount;
        }

        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号，即花呗先享协议号
        /// </summary>
        /// <value>支付宝系统中用以唯一标识用户签约记录的编号，即花呗先享协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        /// <value>买家在支付宝的用户id</value>
        [DataMember(Name = "alipay_user_id", EmitDefaultValue = false)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// true表示需要解约。false或者不填写表示仅解冻。
        /// </summary>
        /// <value>true表示需要解约。false或者不填写表示仅解冻。</value>
        [DataMember(Name = "need_terminated", EmitDefaultValue = false)]
        public string NeedTerminated { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        /// <value>买家在支付宝的用户id</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户业务订单的简单描述，如商品名称等，长度不超过100个字母或50个汉字
        /// </summary>
        /// <value>商户业务订单的简单描述，如商品名称等，长度不超过100个字母或50个汉字</value>
        [DataMember(Name = "order_title", EmitDefaultValue = false)]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标识请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。
        /// </summary>
        /// <value>商户本次操作的请求流水号，用于标识请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户的支付宝用户id。如果该值为空，则默认为商户签约账号对应的支付宝用户ID。
        /// </summary>
        /// <value>商户的支付宝用户id。如果该值为空，则默认为商户签约账号对应的支付宝用户ID。</value>
        [DataMember(Name = "seller_id", EmitDefaultValue = false)]
        public string SellerId { get; set; }

        /// <summary>
        /// 需要解冻的金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        /// <value>需要解冻的金额，单位为：元（人民币），精确到小数点后两位</value>
        [DataMember(Name = "unfreeze_amount", EmitDefaultValue = false)]
        public string UnfreezeAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayPcreditHuabeiAuthOrderUnfreezeModel {\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  AlipayUserId: ").Append(AlipayUserId).Append("\n");
            sb.Append("  NeedTerminated: ").Append(NeedTerminated).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OrderTitle: ").Append(OrderTitle).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  UnfreezeAmount: ").Append(UnfreezeAmount).Append("\n");
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
            return this.Equals(input as AlipayPcreditHuabeiAuthOrderUnfreezeModel);
        }

        /// <summary>
        /// Returns true if AlipayPcreditHuabeiAuthOrderUnfreezeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayPcreditHuabeiAuthOrderUnfreezeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayPcreditHuabeiAuthOrderUnfreezeModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.AlipayUserId == input.AlipayUserId ||
                    (this.AlipayUserId != null &&
                    this.AlipayUserId.Equals(input.AlipayUserId))
                ) && 
                (
                    this.NeedTerminated == input.NeedTerminated ||
                    (this.NeedTerminated != null &&
                    this.NeedTerminated.Equals(input.NeedTerminated))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OrderTitle == input.OrderTitle ||
                    (this.OrderTitle != null &&
                    this.OrderTitle.Equals(input.OrderTitle))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
                ) && 
                (
                    this.UnfreezeAmount == input.UnfreezeAmount ||
                    (this.UnfreezeAmount != null &&
                    this.UnfreezeAmount.Equals(input.UnfreezeAmount))
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
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.AlipayUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayUserId.GetHashCode();
                }
                if (this.NeedTerminated != null)
                {
                    hashCode = (hashCode * 59) + this.NeedTerminated.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OrderTitle != null)
                {
                    hashCode = (hashCode * 59) + this.OrderTitle.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.SellerId != null)
                {
                    hashCode = (hashCode * 59) + this.SellerId.GetHashCode();
                }
                if (this.UnfreezeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.UnfreezeAmount.GetHashCode();
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
