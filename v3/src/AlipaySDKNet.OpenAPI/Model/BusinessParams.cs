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
    /// BusinessParams
    /// </summary>
    [DataContract(Name = "BusinessParams")]
    public partial class BusinessParams : IEquatable<BusinessParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessParams" /> class.
        /// </summary>
        /// <param name="actualOrderTime">实际订单时间，在乘车码场景，传入的是用户刷码乘车时间.</param>
        /// <param name="campusCard">校园卡编号.</param>
        /// <param name="cardType">虚拟卡卡类型.</param>
        /// <param name="enterprisePayAmount">因公付金额.</param>
        /// <param name="enterprisePayInfo">因公付业务信息.</param>
        /// <param name="goodTaxes">商户传入的交易税费。需要落地风控使用.</param>
        /// <param name="mcCreateTradeIp">商户端创建订单的 IP，须上传正确的用户端外网 IP，支持 ipv4/ipv6 格式； mc_create_trade_ip和mcCreateTradeIp（旧）参数描述相同，首选mc_create_trade_ip入参，请勿重复入参； 如已入参mcCreateTradeIp（旧），无需新增入参mc_create_trade_ip。.</param>
        public BusinessParams(string actualOrderTime = default(string), string campusCard = default(string), string cardType = default(string), string enterprisePayAmount = default(string), string enterprisePayInfo = default(string), string goodTaxes = default(string), string mcCreateTradeIp = default(string))
        {
            this.ActualOrderTime = actualOrderTime;
            this.CampusCard = campusCard;
            this.CardType = cardType;
            this.EnterprisePayAmount = enterprisePayAmount;
            this.EnterprisePayInfo = enterprisePayInfo;
            this.GoodTaxes = goodTaxes;
            this.McCreateTradeIp = mcCreateTradeIp;
        }

        /// <summary>
        /// 实际订单时间，在乘车码场景，传入的是用户刷码乘车时间
        /// </summary>
        /// <value>实际订单时间，在乘车码场景，传入的是用户刷码乘车时间</value>
        [DataMember(Name = "actual_order_time", EmitDefaultValue = false)]
        public string ActualOrderTime { get; set; }

        /// <summary>
        /// 校园卡编号
        /// </summary>
        /// <value>校园卡编号</value>
        [DataMember(Name = "campus_card", EmitDefaultValue = false)]
        public string CampusCard { get; set; }

        /// <summary>
        /// 虚拟卡卡类型
        /// </summary>
        /// <value>虚拟卡卡类型</value>
        [DataMember(Name = "card_type", EmitDefaultValue = false)]
        public string CardType { get; set; }

        /// <summary>
        /// 因公付金额
        /// </summary>
        /// <value>因公付金额</value>
        [DataMember(Name = "enterprise_pay_amount", EmitDefaultValue = false)]
        public string EnterprisePayAmount { get; set; }

        /// <summary>
        /// 因公付业务信息
        /// </summary>
        /// <value>因公付业务信息</value>
        [DataMember(Name = "enterprise_pay_info", EmitDefaultValue = false)]
        public string EnterprisePayInfo { get; set; }

        /// <summary>
        /// 商户传入的交易税费。需要落地风控使用
        /// </summary>
        /// <value>商户传入的交易税费。需要落地风控使用</value>
        [DataMember(Name = "good_taxes", EmitDefaultValue = false)]
        public string GoodTaxes { get; set; }

        /// <summary>
        /// 商户端创建订单的 IP，须上传正确的用户端外网 IP，支持 ipv4/ipv6 格式； mc_create_trade_ip和mcCreateTradeIp（旧）参数描述相同，首选mc_create_trade_ip入参，请勿重复入参； 如已入参mcCreateTradeIp（旧），无需新增入参mc_create_trade_ip。
        /// </summary>
        /// <value>商户端创建订单的 IP，须上传正确的用户端外网 IP，支持 ipv4/ipv6 格式； mc_create_trade_ip和mcCreateTradeIp（旧）参数描述相同，首选mc_create_trade_ip入参，请勿重复入参； 如已入参mcCreateTradeIp（旧），无需新增入参mc_create_trade_ip。</value>
        [DataMember(Name = "mc_create_trade_ip", EmitDefaultValue = false)]
        public string McCreateTradeIp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BusinessParams {\n");
            sb.Append("  ActualOrderTime: ").Append(ActualOrderTime).Append("\n");
            sb.Append("  CampusCard: ").Append(CampusCard).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  EnterprisePayAmount: ").Append(EnterprisePayAmount).Append("\n");
            sb.Append("  EnterprisePayInfo: ").Append(EnterprisePayInfo).Append("\n");
            sb.Append("  GoodTaxes: ").Append(GoodTaxes).Append("\n");
            sb.Append("  McCreateTradeIp: ").Append(McCreateTradeIp).Append("\n");
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
            return this.Equals(input as BusinessParams);
        }

        /// <summary>
        /// Returns true if BusinessParams instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActualOrderTime == input.ActualOrderTime ||
                    (this.ActualOrderTime != null &&
                    this.ActualOrderTime.Equals(input.ActualOrderTime))
                ) && 
                (
                    this.CampusCard == input.CampusCard ||
                    (this.CampusCard != null &&
                    this.CampusCard.Equals(input.CampusCard))
                ) && 
                (
                    this.CardType == input.CardType ||
                    (this.CardType != null &&
                    this.CardType.Equals(input.CardType))
                ) && 
                (
                    this.EnterprisePayAmount == input.EnterprisePayAmount ||
                    (this.EnterprisePayAmount != null &&
                    this.EnterprisePayAmount.Equals(input.EnterprisePayAmount))
                ) && 
                (
                    this.EnterprisePayInfo == input.EnterprisePayInfo ||
                    (this.EnterprisePayInfo != null &&
                    this.EnterprisePayInfo.Equals(input.EnterprisePayInfo))
                ) && 
                (
                    this.GoodTaxes == input.GoodTaxes ||
                    (this.GoodTaxes != null &&
                    this.GoodTaxes.Equals(input.GoodTaxes))
                ) && 
                (
                    this.McCreateTradeIp == input.McCreateTradeIp ||
                    (this.McCreateTradeIp != null &&
                    this.McCreateTradeIp.Equals(input.McCreateTradeIp))
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
                if (this.ActualOrderTime != null)
                {
                    hashCode = (hashCode * 59) + this.ActualOrderTime.GetHashCode();
                }
                if (this.CampusCard != null)
                {
                    hashCode = (hashCode * 59) + this.CampusCard.GetHashCode();
                }
                if (this.CardType != null)
                {
                    hashCode = (hashCode * 59) + this.CardType.GetHashCode();
                }
                if (this.EnterprisePayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.EnterprisePayAmount.GetHashCode();
                }
                if (this.EnterprisePayInfo != null)
                {
                    hashCode = (hashCode * 59) + this.EnterprisePayInfo.GetHashCode();
                }
                if (this.GoodTaxes != null)
                {
                    hashCode = (hashCode * 59) + this.GoodTaxes.GetHashCode();
                }
                if (this.McCreateTradeIp != null)
                {
                    hashCode = (hashCode * 59) + this.McCreateTradeIp.GetHashCode();
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
