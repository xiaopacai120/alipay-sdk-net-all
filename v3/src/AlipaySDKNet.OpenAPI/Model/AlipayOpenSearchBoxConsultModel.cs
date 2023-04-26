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
    /// AlipayOpenSearchBoxConsultModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSearchBoxConsultModel")]
    public partial class AlipayOpenSearchBoxConsultModel : IEquatable<AlipayOpenSearchBoxConsultModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSearchBoxConsultModel" /> class.
        /// </summary>
        /// <param name="areaKeywords">小程序直达配置的常用服务中带有门店信息时，可添加简称触发词.</param>
        /// <param name="boxDesc">品牌介绍，5-15个中文字符。  小程序直达不支持设置此项.</param>
        /// <param name="brandId">品牌id，参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/rules/029uy4\&quot;&gt;品牌认证说明&lt;/a&gt;.</param>
        /// <param name="businessBenefitSwitch">可通过配置来开启商圈权益模块，关闭后搜索直达不展示商圈权益模块.</param>
        /// <param name="businessDistrictIds">小程序已关联商圈时，可添加商圈id（目前仅对品牌直达开放，小程序直达暂未开放）.</param>
        /// <param name="customKeywords">自定义触发词，最多可配置6个，限1-8个中文字符。  小程序直达不支持设置此项.</param>
        /// <param name="imageId">氛围图片id，调用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03hvl1?ref&#x3D;api\&quot;&gt;支付宝文件上传接口&lt;/a&gt; 上传图片获取图片id(bizCode：search_box_atmosphere)。 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/b/03al6f\&quot;&gt;图片规范&lt;/a&gt;  小程序直达不支持设置此项。.</param>
        /// <param name="imageName">氛围图片名。  小程序直达不支持设置此项.</param>
        /// <param name="merchantId">商户id，代运营模式下传入。代运营模式，需要服务商已获得商家\&quot;运营支付宝小程序\&quot;授权。.</param>
        /// <param name="relatedAccounts">关联账号信息，1-2个。 内部字段均需设置。.</param>
        /// <param name="serviceInfos">服务信息，服务必须审核通过才能申请搜索直达。 内部字段均需设置。.</param>
        /// <param name="targetAppid">小程序id，小程序直达时必传，需要和申请的商户主体保持一致，且符合&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/b/03al6e\&quot;&gt;准入类目&lt;/a&gt;.</param>
        public AlipayOpenSearchBoxConsultModel(string areaKeywords = default(string), string boxDesc = default(string), string brandId = default(string), bool businessBenefitSwitch = default(bool), List<string> businessDistrictIds = default(List<string>), List<string> customKeywords = default(List<string>), string imageId = default(string), string imageName = default(string), string merchantId = default(string), List<SearchBoxAppInfo> relatedAccounts = default(List<SearchBoxAppInfo>), List<SearchBoxServiceInfo> serviceInfos = default(List<SearchBoxServiceInfo>), string targetAppid = default(string))
        {
            this.AreaKeywords = areaKeywords;
            this.BoxDesc = boxDesc;
            this.BrandId = brandId;
            this.BusinessBenefitSwitch = businessBenefitSwitch;
            this.BusinessDistrictIds = businessDistrictIds;
            this.CustomKeywords = customKeywords;
            this.ImageId = imageId;
            this.ImageName = imageName;
            this.MerchantId = merchantId;
            this.RelatedAccounts = relatedAccounts;
            this.ServiceInfos = serviceInfos;
            this.TargetAppid = targetAppid;
        }

        /// <summary>
        /// 小程序直达配置的常用服务中带有门店信息时，可添加简称触发词
        /// </summary>
        /// <value>小程序直达配置的常用服务中带有门店信息时，可添加简称触发词</value>
        [DataMember(Name = "area_keywords", EmitDefaultValue = false)]
        public string AreaKeywords { get; set; }

        /// <summary>
        /// 品牌介绍，5-15个中文字符。  小程序直达不支持设置此项
        /// </summary>
        /// <value>品牌介绍，5-15个中文字符。  小程序直达不支持设置此项</value>
        [DataMember(Name = "box_desc", EmitDefaultValue = false)]
        public string BoxDesc { get; set; }

        /// <summary>
        /// 品牌id，参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/rules/029uy4\&quot;&gt;品牌认证说明&lt;/a&gt;
        /// </summary>
        /// <value>品牌id，参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/rules/029uy4\&quot;&gt;品牌认证说明&lt;/a&gt;</value>
        [DataMember(Name = "brand_id", EmitDefaultValue = false)]
        public string BrandId { get; set; }

        /// <summary>
        /// 可通过配置来开启商圈权益模块，关闭后搜索直达不展示商圈权益模块
        /// </summary>
        /// <value>可通过配置来开启商圈权益模块，关闭后搜索直达不展示商圈权益模块</value>
        [DataMember(Name = "business_benefit_switch", EmitDefaultValue = true)]
        public bool BusinessBenefitSwitch { get; set; }

        /// <summary>
        /// 小程序已关联商圈时，可添加商圈id（目前仅对品牌直达开放，小程序直达暂未开放）
        /// </summary>
        /// <value>小程序已关联商圈时，可添加商圈id（目前仅对品牌直达开放，小程序直达暂未开放）</value>
        [DataMember(Name = "business_district_ids", EmitDefaultValue = false)]
        public List<string> BusinessDistrictIds { get; set; }

        /// <summary>
        /// 自定义触发词，最多可配置6个，限1-8个中文字符。  小程序直达不支持设置此项
        /// </summary>
        /// <value>自定义触发词，最多可配置6个，限1-8个中文字符。  小程序直达不支持设置此项</value>
        [DataMember(Name = "custom_keywords", EmitDefaultValue = false)]
        public List<string> CustomKeywords { get; set; }

        /// <summary>
        /// 氛围图片id，调用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03hvl1?ref&#x3D;api\&quot;&gt;支付宝文件上传接口&lt;/a&gt; 上传图片获取图片id(bizCode：search_box_atmosphere)。 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/b/03al6f\&quot;&gt;图片规范&lt;/a&gt;  小程序直达不支持设置此项。
        /// </summary>
        /// <value>氛围图片id，调用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03hvl1?ref&#x3D;api\&quot;&gt;支付宝文件上传接口&lt;/a&gt; 上传图片获取图片id(bizCode：search_box_atmosphere)。 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/b/03al6f\&quot;&gt;图片规范&lt;/a&gt;  小程序直达不支持设置此项。</value>
        [DataMember(Name = "image_id", EmitDefaultValue = false)]
        public string ImageId { get; set; }

        /// <summary>
        /// 氛围图片名。  小程序直达不支持设置此项
        /// </summary>
        /// <value>氛围图片名。  小程序直达不支持设置此项</value>
        [DataMember(Name = "image_name", EmitDefaultValue = false)]
        public string ImageName { get; set; }

        /// <summary>
        /// 商户id，代运营模式下传入。代运营模式，需要服务商已获得商家\&quot;运营支付宝小程序\&quot;授权。
        /// </summary>
        /// <value>商户id，代运营模式下传入。代运营模式，需要服务商已获得商家\&quot;运营支付宝小程序\&quot;授权。</value>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// 关联账号信息，1-2个。 内部字段均需设置。
        /// </summary>
        /// <value>关联账号信息，1-2个。 内部字段均需设置。</value>
        [DataMember(Name = "related_accounts", EmitDefaultValue = false)]
        public List<SearchBoxAppInfo> RelatedAccounts { get; set; }

        /// <summary>
        /// 服务信息，服务必须审核通过才能申请搜索直达。 内部字段均需设置。
        /// </summary>
        /// <value>服务信息，服务必须审核通过才能申请搜索直达。 内部字段均需设置。</value>
        [DataMember(Name = "service_infos", EmitDefaultValue = false)]
        public List<SearchBoxServiceInfo> ServiceInfos { get; set; }

        /// <summary>
        /// 小程序id，小程序直达时必传，需要和申请的商户主体保持一致，且符合&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/b/03al6e\&quot;&gt;准入类目&lt;/a&gt;
        /// </summary>
        /// <value>小程序id，小程序直达时必传，需要和申请的商户主体保持一致，且符合&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/b/03al6e\&quot;&gt;准入类目&lt;/a&gt;</value>
        [DataMember(Name = "target_appid", EmitDefaultValue = false)]
        public string TargetAppid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSearchBoxConsultModel {\n");
            sb.Append("  AreaKeywords: ").Append(AreaKeywords).Append("\n");
            sb.Append("  BoxDesc: ").Append(BoxDesc).Append("\n");
            sb.Append("  BrandId: ").Append(BrandId).Append("\n");
            sb.Append("  BusinessBenefitSwitch: ").Append(BusinessBenefitSwitch).Append("\n");
            sb.Append("  BusinessDistrictIds: ").Append(BusinessDistrictIds).Append("\n");
            sb.Append("  CustomKeywords: ").Append(CustomKeywords).Append("\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  ImageName: ").Append(ImageName).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  RelatedAccounts: ").Append(RelatedAccounts).Append("\n");
            sb.Append("  ServiceInfos: ").Append(ServiceInfos).Append("\n");
            sb.Append("  TargetAppid: ").Append(TargetAppid).Append("\n");
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
            return this.Equals(input as AlipayOpenSearchBoxConsultModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSearchBoxConsultModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSearchBoxConsultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSearchBoxConsultModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AreaKeywords == input.AreaKeywords ||
                    (this.AreaKeywords != null &&
                    this.AreaKeywords.Equals(input.AreaKeywords))
                ) && 
                (
                    this.BoxDesc == input.BoxDesc ||
                    (this.BoxDesc != null &&
                    this.BoxDesc.Equals(input.BoxDesc))
                ) && 
                (
                    this.BrandId == input.BrandId ||
                    (this.BrandId != null &&
                    this.BrandId.Equals(input.BrandId))
                ) && 
                (
                    this.BusinessBenefitSwitch == input.BusinessBenefitSwitch ||
                    this.BusinessBenefitSwitch.Equals(input.BusinessBenefitSwitch)
                ) && 
                (
                    this.BusinessDistrictIds == input.BusinessDistrictIds ||
                    this.BusinessDistrictIds != null &&
                    input.BusinessDistrictIds != null &&
                    this.BusinessDistrictIds.SequenceEqual(input.BusinessDistrictIds)
                ) && 
                (
                    this.CustomKeywords == input.CustomKeywords ||
                    this.CustomKeywords != null &&
                    input.CustomKeywords != null &&
                    this.CustomKeywords.SequenceEqual(input.CustomKeywords)
                ) && 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.ImageName == input.ImageName ||
                    (this.ImageName != null &&
                    this.ImageName.Equals(input.ImageName))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.RelatedAccounts == input.RelatedAccounts ||
                    this.RelatedAccounts != null &&
                    input.RelatedAccounts != null &&
                    this.RelatedAccounts.SequenceEqual(input.RelatedAccounts)
                ) && 
                (
                    this.ServiceInfos == input.ServiceInfos ||
                    this.ServiceInfos != null &&
                    input.ServiceInfos != null &&
                    this.ServiceInfos.SequenceEqual(input.ServiceInfos)
                ) && 
                (
                    this.TargetAppid == input.TargetAppid ||
                    (this.TargetAppid != null &&
                    this.TargetAppid.Equals(input.TargetAppid))
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
                if (this.AreaKeywords != null)
                {
                    hashCode = (hashCode * 59) + this.AreaKeywords.GetHashCode();
                }
                if (this.BoxDesc != null)
                {
                    hashCode = (hashCode * 59) + this.BoxDesc.GetHashCode();
                }
                if (this.BrandId != null)
                {
                    hashCode = (hashCode * 59) + this.BrandId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BusinessBenefitSwitch.GetHashCode();
                if (this.BusinessDistrictIds != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessDistrictIds.GetHashCode();
                }
                if (this.CustomKeywords != null)
                {
                    hashCode = (hashCode * 59) + this.CustomKeywords.GetHashCode();
                }
                if (this.ImageId != null)
                {
                    hashCode = (hashCode * 59) + this.ImageId.GetHashCode();
                }
                if (this.ImageName != null)
                {
                    hashCode = (hashCode * 59) + this.ImageName.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.RelatedAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.RelatedAccounts.GetHashCode();
                }
                if (this.ServiceInfos != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceInfos.GetHashCode();
                }
                if (this.TargetAppid != null)
                {
                    hashCode = (hashCode * 59) + this.TargetAppid.GetHashCode();
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
