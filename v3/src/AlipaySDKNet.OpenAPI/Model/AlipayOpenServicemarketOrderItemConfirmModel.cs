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
    /// AlipayOpenServicemarketOrderItemConfirmModel
    /// </summary>
    [DataContract(Name = "AlipayOpenServicemarketOrderItemConfirmModel")]
    public partial class AlipayOpenServicemarketOrderItemConfirmModel : IEquatable<AlipayOpenServicemarketOrderItemConfirmModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenServicemarketOrderItemConfirmModel" /> class.
        /// </summary>
        /// <param name="commodityOrderId">订购服务插件订单号.</param>
        /// <param name="miniAppId">商家订购服务选择的某一小程序的APPID，如果该订单为蚂蚁服务市场发布的小程序插件服务所产生的订单，则此字段必填.</param>
        /// <param name="shopId">商家订购服务选择的某一门店的ID。若该订单：  为支付宝(蚂蚁)服务市场发布的服务所产生订单则该参数可选。  为口碑服务市场发布的服务所产生的订单，则此字段必填。口碑服务市场参见 http://fuwu.koubei.com/commodity/v2/merchandise/index.htm。.</param>
        public AlipayOpenServicemarketOrderItemConfirmModel(string commodityOrderId = default(string), string miniAppId = default(string), string shopId = default(string))
        {
            this.CommodityOrderId = commodityOrderId;
            this.MiniAppId = miniAppId;
            this.ShopId = shopId;
        }

        /// <summary>
        /// 订购服务插件订单号
        /// </summary>
        /// <value>订购服务插件订单号</value>
        [DataMember(Name = "commodity_order_id", EmitDefaultValue = false)]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 商家订购服务选择的某一小程序的APPID，如果该订单为蚂蚁服务市场发布的小程序插件服务所产生的订单，则此字段必填
        /// </summary>
        /// <value>商家订购服务选择的某一小程序的APPID，如果该订单为蚂蚁服务市场发布的小程序插件服务所产生的订单，则此字段必填</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 商家订购服务选择的某一门店的ID。若该订单：  为支付宝(蚂蚁)服务市场发布的服务所产生订单则该参数可选。  为口碑服务市场发布的服务所产生的订单，则此字段必填。口碑服务市场参见 http://fuwu.koubei.com/commodity/v2/merchandise/index.htm。
        /// </summary>
        /// <value>商家订购服务选择的某一门店的ID。若该订单：  为支付宝(蚂蚁)服务市场发布的服务所产生订单则该参数可选。  为口碑服务市场发布的服务所产生的订单，则此字段必填。口碑服务市场参见 http://fuwu.koubei.com/commodity/v2/merchandise/index.htm。</value>
        [DataMember(Name = "shop_id", EmitDefaultValue = false)]
        public string ShopId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenServicemarketOrderItemConfirmModel {\n");
            sb.Append("  CommodityOrderId: ").Append(CommodityOrderId).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  ShopId: ").Append(ShopId).Append("\n");
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
            return this.Equals(input as AlipayOpenServicemarketOrderItemConfirmModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenServicemarketOrderItemConfirmModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenServicemarketOrderItemConfirmModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenServicemarketOrderItemConfirmModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CommodityOrderId == input.CommodityOrderId ||
                    (this.CommodityOrderId != null &&
                    this.CommodityOrderId.Equals(input.CommodityOrderId))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.ShopId == input.ShopId ||
                    (this.ShopId != null &&
                    this.ShopId.Equals(input.ShopId))
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
                if (this.CommodityOrderId != null)
                {
                    hashCode = (hashCode * 59) + this.CommodityOrderId.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.ShopId != null)
                {
                    hashCode = (hashCode * 59) + this.ShopId.GetHashCode();
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
