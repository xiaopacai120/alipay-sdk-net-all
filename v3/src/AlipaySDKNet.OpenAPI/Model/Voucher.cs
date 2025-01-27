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
    /// Voucher
    /// </summary>
    [DataContract(Name = "Voucher")]
    public partial class Voucher : IEquatable<Voucher>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Voucher" /> class.
        /// </summary>
        /// <param name="allowSplit">是否允许拆分，券在核销的时候是否允许券的面额拆分使用。(仅限渠道类型为ISV企业福利：ISV_ENTERPRISE_BENIFIT的场景使用).</param>
        /// <param name="availableAmount">券剩余面额，单位元  券详情查询接口返回，可拆分券中的券详情展示用.</param>
        /// <param name="brandName">券副标题.</param>
        /// <param name="clauseTerms">券的说明条款.</param>
        /// <param name="delayInfo">delayInfo.</param>
        /// <param name="desc">券详细说明  最多包含500个字符.</param>
        /// <param name="descDetailList">券使用说明描述列表.</param>
        /// <param name="displayConfig">displayConfig.</param>
        /// <param name="donateFlag">券是否可转赠，默认为可转赠.</param>
        /// <param name="effectType">券生效的方式，目前支持以下方式  立即生效：IMMEDIATELY  延迟生效：DELAY  仅在券有效期类型为相对有效期时生效.</param>
        /// <param name="endTime">券有效期的结束时间  仅在券有效期类型为绝对有效期时生效  必须晚于活动结束时间.</param>
        /// <param name="extInfo">券的扩展信息.</param>
        /// <param name="itemInfo">itemInfo.</param>
        /// <param name="logo">券LOGO文件ID，调用图片上传接口alipay.offline.material.image.upload获得.</param>
        /// <param name="maxAmount">最高优惠金额，单位元  指用券最高可以优惠的金额  必须为合法金额类型字符串仅当券类型为折扣券（RATE），每满减券（PER_FULL_CUT）有效.</param>
        /// <param name="multiUseMode">券叠加的属性，  仅全场券可设置该选项；  NO_MULTI:不可与其他全场券和单品券叠加;  MULTI_USE_WITH_SINGLE:  该全场优惠和单品优惠的叠加  ；MULTI_USE_WITH_OTHE  RS:该全场优惠和其他所有优惠都可以叠加.</param>
        /// <param name="name">名称.</param>
        /// <param name="rate">折扣率  仅当券类型为折扣券时有效  有效折扣率取值范围0.11-0.99  仅允许保留小数点后两位.</param>
        /// <param name="relativeTime">券相对有效期，单位天  仅在券有效期类型为相对有效期时生效  如，设5表示领券领取后5日内有效.</param>
        /// <param name="roundingRule">券核销时，抹零方式，目前支持： NOT_AUTO_ROUNDING:不自动抹零 AUTO_ROUNDING_YUAN:自动抹零到元 AUTO_ROUNDING_JIAO:自动抹零到角 ROUNDING_UP_YUAN:四舍五入到元 ROUNDING_UP_JIAO:四舍五入到角.</param>
        /// <param name="startTime">券有效期的开始时间  仅在券有效期类型为绝对有效期时生效.</param>
        /// <param name="type">券类型，目前支持以下类型：  EXCHANGE：兑换券；  MONEY：代金券；  REDUCETO：减至券；  RATE：折扣券；  PER_FULL_CUT：每满减券.</param>
        /// <param name="useInstructions">券的使用说明  使用须知最多6条，且每条最多100字.</param>
        /// <param name="useRule">useRule.</param>
        /// <param name="validateType">券有效期类型，目前支持以下类型：  RELATIVE：相对有效期  FIXED：绝对有效期.</param>
        /// <param name="verifyMode">该字段仅在兑换券条件下(即券类型为EXCHANGE)，用于设置兑换券的核销方式  USER_CLICK:用户自己点击券上的按钮核销  MERCHANT_SCAN：商户通过APP扫码核销  其他情况下此字段为空.</param>
        /// <param name="voucherImg">券图片文件ID,调用上传图片接口alipay.offline.material.image.upload获得.</param>
        /// <param name="voucherNote">券的备注    用于收银系统识别指定券使用；如备注中传入“123”，券发出后核销时将在当面付接口将该值传回，供收银系统识别.</param>
        /// <param name="worthValue">券面额，单位元必须为合法金额类型字符串券类型为代金券（MONEY）、减至券（REDUCETO）、每满减券（PER_FULL_CUT）时必填  如：  代金券：10元代金券中的10为券面额；  每满减券：毎满100减10元，其中的10为券面额；  减至券：单品原价100，现价10元，其中10为券面额，单品减至券的券面额必须低于单品原价.</param>
        public Voucher(bool allowSplit = default(bool), string availableAmount = default(string), string brandName = default(string), List<ClauseTerm> clauseTerms = default(List<ClauseTerm>), DelayInfo delayInfo = default(DelayInfo), string desc = default(string), List<VoucherDescDetail> descDetailList = default(List<VoucherDescDetail>), DisplayConfig displayConfig = default(DisplayConfig), string donateFlag = default(string), string effectType = default(string), string endTime = default(string), string extInfo = default(string), ItemInfo itemInfo = default(ItemInfo), string logo = default(string), string maxAmount = default(string), string multiUseMode = default(string), string name = default(string), string rate = default(string), string relativeTime = default(string), string roundingRule = default(string), string startTime = default(string), string type = default(string), List<string> useInstructions = default(List<string>), UseRule useRule = default(UseRule), string validateType = default(string), string verifyMode = default(string), string voucherImg = default(string), string voucherNote = default(string), string worthValue = default(string))
        {
            this.AllowSplit = allowSplit;
            this.AvailableAmount = availableAmount;
            this.BrandName = brandName;
            this.ClauseTerms = clauseTerms;
            this.DelayInfo = delayInfo;
            this.Desc = desc;
            this.DescDetailList = descDetailList;
            this.DisplayConfig = displayConfig;
            this.DonateFlag = donateFlag;
            this.EffectType = effectType;
            this.EndTime = endTime;
            this.ExtInfo = extInfo;
            this.ItemInfo = itemInfo;
            this.Logo = logo;
            this.MaxAmount = maxAmount;
            this.MultiUseMode = multiUseMode;
            this.Name = name;
            this.Rate = rate;
            this.RelativeTime = relativeTime;
            this.RoundingRule = roundingRule;
            this.StartTime = startTime;
            this.Type = type;
            this.UseInstructions = useInstructions;
            this.UseRule = useRule;
            this.ValidateType = validateType;
            this.VerifyMode = verifyMode;
            this.VoucherImg = voucherImg;
            this.VoucherNote = voucherNote;
            this.WorthValue = worthValue;
        }

        /// <summary>
        /// 是否允许拆分，券在核销的时候是否允许券的面额拆分使用。(仅限渠道类型为ISV企业福利：ISV_ENTERPRISE_BENIFIT的场景使用)
        /// </summary>
        /// <value>是否允许拆分，券在核销的时候是否允许券的面额拆分使用。(仅限渠道类型为ISV企业福利：ISV_ENTERPRISE_BENIFIT的场景使用)</value>
        [DataMember(Name = "allow_split", EmitDefaultValue = true)]
        public bool AllowSplit { get; set; }

        /// <summary>
        /// 券剩余面额，单位元  券详情查询接口返回，可拆分券中的券详情展示用
        /// </summary>
        /// <value>券剩余面额，单位元  券详情查询接口返回，可拆分券中的券详情展示用</value>
        [DataMember(Name = "available_amount", EmitDefaultValue = false)]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 券副标题
        /// </summary>
        /// <value>券副标题</value>
        [DataMember(Name = "brand_name", EmitDefaultValue = false)]
        public string BrandName { get; set; }

        /// <summary>
        /// 券的说明条款
        /// </summary>
        /// <value>券的说明条款</value>
        [DataMember(Name = "clause_terms", EmitDefaultValue = false)]
        public List<ClauseTerm> ClauseTerms { get; set; }

        /// <summary>
        /// Gets or Sets DelayInfo
        /// </summary>
        [DataMember(Name = "delay_info", EmitDefaultValue = false)]
        public DelayInfo DelayInfo { get; set; }

        /// <summary>
        /// 券详细说明  最多包含500个字符
        /// </summary>
        /// <value>券详细说明  最多包含500个字符</value>
        [DataMember(Name = "desc", EmitDefaultValue = false)]
        public string Desc { get; set; }

        /// <summary>
        /// 券使用说明描述列表
        /// </summary>
        /// <value>券使用说明描述列表</value>
        [DataMember(Name = "desc_detail_list", EmitDefaultValue = false)]
        public List<VoucherDescDetail> DescDetailList { get; set; }

        /// <summary>
        /// Gets or Sets DisplayConfig
        /// </summary>
        [DataMember(Name = "display_config", EmitDefaultValue = false)]
        public DisplayConfig DisplayConfig { get; set; }

        /// <summary>
        /// 券是否可转赠，默认为可转赠
        /// </summary>
        /// <value>券是否可转赠，默认为可转赠</value>
        [DataMember(Name = "donate_flag", EmitDefaultValue = false)]
        public string DonateFlag { get; set; }

        /// <summary>
        /// 券生效的方式，目前支持以下方式  立即生效：IMMEDIATELY  延迟生效：DELAY  仅在券有效期类型为相对有效期时生效
        /// </summary>
        /// <value>券生效的方式，目前支持以下方式  立即生效：IMMEDIATELY  延迟生效：DELAY  仅在券有效期类型为相对有效期时生效</value>
        [DataMember(Name = "effect_type", EmitDefaultValue = false)]
        public string EffectType { get; set; }

        /// <summary>
        /// 券有效期的结束时间  仅在券有效期类型为绝对有效期时生效  必须晚于活动结束时间
        /// </summary>
        /// <value>券有效期的结束时间  仅在券有效期类型为绝对有效期时生效  必须晚于活动结束时间</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 券的扩展信息
        /// </summary>
        /// <value>券的扩展信息</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// Gets or Sets ItemInfo
        /// </summary>
        [DataMember(Name = "item_info", EmitDefaultValue = false)]
        public ItemInfo ItemInfo { get; set; }

        /// <summary>
        /// 券LOGO文件ID，调用图片上传接口alipay.offline.material.image.upload获得
        /// </summary>
        /// <value>券LOGO文件ID，调用图片上传接口alipay.offline.material.image.upload获得</value>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; set; }

        /// <summary>
        /// 最高优惠金额，单位元  指用券最高可以优惠的金额  必须为合法金额类型字符串仅当券类型为折扣券（RATE），每满减券（PER_FULL_CUT）有效
        /// </summary>
        /// <value>最高优惠金额，单位元  指用券最高可以优惠的金额  必须为合法金额类型字符串仅当券类型为折扣券（RATE），每满减券（PER_FULL_CUT）有效</value>
        [DataMember(Name = "max_amount", EmitDefaultValue = false)]
        public string MaxAmount { get; set; }

        /// <summary>
        /// 券叠加的属性，  仅全场券可设置该选项；  NO_MULTI:不可与其他全场券和单品券叠加;  MULTI_USE_WITH_SINGLE:  该全场优惠和单品优惠的叠加  ；MULTI_USE_WITH_OTHE  RS:该全场优惠和其他所有优惠都可以叠加
        /// </summary>
        /// <value>券叠加的属性，  仅全场券可设置该选项；  NO_MULTI:不可与其他全场券和单品券叠加;  MULTI_USE_WITH_SINGLE:  该全场优惠和单品优惠的叠加  ；MULTI_USE_WITH_OTHE  RS:该全场优惠和其他所有优惠都可以叠加</value>
        [DataMember(Name = "multi_use_mode", EmitDefaultValue = false)]
        public string MultiUseMode { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        /// <value>名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 折扣率  仅当券类型为折扣券时有效  有效折扣率取值范围0.11-0.99  仅允许保留小数点后两位
        /// </summary>
        /// <value>折扣率  仅当券类型为折扣券时有效  有效折扣率取值范围0.11-0.99  仅允许保留小数点后两位</value>
        [DataMember(Name = "rate", EmitDefaultValue = false)]
        public string Rate { get; set; }

        /// <summary>
        /// 券相对有效期，单位天  仅在券有效期类型为相对有效期时生效  如，设5表示领券领取后5日内有效
        /// </summary>
        /// <value>券相对有效期，单位天  仅在券有效期类型为相对有效期时生效  如，设5表示领券领取后5日内有效</value>
        [DataMember(Name = "relative_time", EmitDefaultValue = false)]
        public string RelativeTime { get; set; }

        /// <summary>
        /// 券核销时，抹零方式，目前支持： NOT_AUTO_ROUNDING:不自动抹零 AUTO_ROUNDING_YUAN:自动抹零到元 AUTO_ROUNDING_JIAO:自动抹零到角 ROUNDING_UP_YUAN:四舍五入到元 ROUNDING_UP_JIAO:四舍五入到角
        /// </summary>
        /// <value>券核销时，抹零方式，目前支持： NOT_AUTO_ROUNDING:不自动抹零 AUTO_ROUNDING_YUAN:自动抹零到元 AUTO_ROUNDING_JIAO:自动抹零到角 ROUNDING_UP_YUAN:四舍五入到元 ROUNDING_UP_JIAO:四舍五入到角</value>
        [DataMember(Name = "rounding_rule", EmitDefaultValue = false)]
        public string RoundingRule { get; set; }

        /// <summary>
        /// 券有效期的开始时间  仅在券有效期类型为绝对有效期时生效
        /// </summary>
        /// <value>券有效期的开始时间  仅在券有效期类型为绝对有效期时生效</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 券类型，目前支持以下类型：  EXCHANGE：兑换券；  MONEY：代金券；  REDUCETO：减至券；  RATE：折扣券；  PER_FULL_CUT：每满减券
        /// </summary>
        /// <value>券类型，目前支持以下类型：  EXCHANGE：兑换券；  MONEY：代金券；  REDUCETO：减至券；  RATE：折扣券；  PER_FULL_CUT：每满减券</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// 券的使用说明  使用须知最多6条，且每条最多100字
        /// </summary>
        /// <value>券的使用说明  使用须知最多6条，且每条最多100字</value>
        [DataMember(Name = "use_instructions", EmitDefaultValue = false)]
        public List<string> UseInstructions { get; set; }

        /// <summary>
        /// Gets or Sets UseRule
        /// </summary>
        [DataMember(Name = "use_rule", EmitDefaultValue = false)]
        public UseRule UseRule { get; set; }

        /// <summary>
        /// 券有效期类型，目前支持以下类型：  RELATIVE：相对有效期  FIXED：绝对有效期
        /// </summary>
        /// <value>券有效期类型，目前支持以下类型：  RELATIVE：相对有效期  FIXED：绝对有效期</value>
        [DataMember(Name = "validate_type", EmitDefaultValue = false)]
        public string ValidateType { get; set; }

        /// <summary>
        /// 该字段仅在兑换券条件下(即券类型为EXCHANGE)，用于设置兑换券的核销方式  USER_CLICK:用户自己点击券上的按钮核销  MERCHANT_SCAN：商户通过APP扫码核销  其他情况下此字段为空
        /// </summary>
        /// <value>该字段仅在兑换券条件下(即券类型为EXCHANGE)，用于设置兑换券的核销方式  USER_CLICK:用户自己点击券上的按钮核销  MERCHANT_SCAN：商户通过APP扫码核销  其他情况下此字段为空</value>
        [DataMember(Name = "verify_mode", EmitDefaultValue = false)]
        public string VerifyMode { get; set; }

        /// <summary>
        /// 券图片文件ID,调用上传图片接口alipay.offline.material.image.upload获得
        /// </summary>
        /// <value>券图片文件ID,调用上传图片接口alipay.offline.material.image.upload获得</value>
        [DataMember(Name = "voucher_img", EmitDefaultValue = false)]
        public string VoucherImg { get; set; }

        /// <summary>
        /// 券的备注    用于收银系统识别指定券使用；如备注中传入“123”，券发出后核销时将在当面付接口将该值传回，供收银系统识别
        /// </summary>
        /// <value>券的备注    用于收银系统识别指定券使用；如备注中传入“123”，券发出后核销时将在当面付接口将该值传回，供收银系统识别</value>
        [DataMember(Name = "voucher_note", EmitDefaultValue = false)]
        public string VoucherNote { get; set; }

        /// <summary>
        /// 券面额，单位元必须为合法金额类型字符串券类型为代金券（MONEY）、减至券（REDUCETO）、每满减券（PER_FULL_CUT）时必填  如：  代金券：10元代金券中的10为券面额；  每满减券：毎满100减10元，其中的10为券面额；  减至券：单品原价100，现价10元，其中10为券面额，单品减至券的券面额必须低于单品原价
        /// </summary>
        /// <value>券面额，单位元必须为合法金额类型字符串券类型为代金券（MONEY）、减至券（REDUCETO）、每满减券（PER_FULL_CUT）时必填  如：  代金券：10元代金券中的10为券面额；  每满减券：毎满100减10元，其中的10为券面额；  减至券：单品原价100，现价10元，其中10为券面额，单品减至券的券面额必须低于单品原价</value>
        [DataMember(Name = "worth_value", EmitDefaultValue = false)]
        public string WorthValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Voucher {\n");
            sb.Append("  AllowSplit: ").Append(AllowSplit).Append("\n");
            sb.Append("  AvailableAmount: ").Append(AvailableAmount).Append("\n");
            sb.Append("  BrandName: ").Append(BrandName).Append("\n");
            sb.Append("  ClauseTerms: ").Append(ClauseTerms).Append("\n");
            sb.Append("  DelayInfo: ").Append(DelayInfo).Append("\n");
            sb.Append("  Desc: ").Append(Desc).Append("\n");
            sb.Append("  DescDetailList: ").Append(DescDetailList).Append("\n");
            sb.Append("  DisplayConfig: ").Append(DisplayConfig).Append("\n");
            sb.Append("  DonateFlag: ").Append(DonateFlag).Append("\n");
            sb.Append("  EffectType: ").Append(EffectType).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  ItemInfo: ").Append(ItemInfo).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
            sb.Append("  MultiUseMode: ").Append(MultiUseMode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  RelativeTime: ").Append(RelativeTime).Append("\n");
            sb.Append("  RoundingRule: ").Append(RoundingRule).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UseInstructions: ").Append(UseInstructions).Append("\n");
            sb.Append("  UseRule: ").Append(UseRule).Append("\n");
            sb.Append("  ValidateType: ").Append(ValidateType).Append("\n");
            sb.Append("  VerifyMode: ").Append(VerifyMode).Append("\n");
            sb.Append("  VoucherImg: ").Append(VoucherImg).Append("\n");
            sb.Append("  VoucherNote: ").Append(VoucherNote).Append("\n");
            sb.Append("  WorthValue: ").Append(WorthValue).Append("\n");
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
            return this.Equals(input as Voucher);
        }

        /// <summary>
        /// Returns true if Voucher instances are equal
        /// </summary>
        /// <param name="input">Instance of Voucher to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Voucher input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowSplit == input.AllowSplit ||
                    this.AllowSplit.Equals(input.AllowSplit)
                ) && 
                (
                    this.AvailableAmount == input.AvailableAmount ||
                    (this.AvailableAmount != null &&
                    this.AvailableAmount.Equals(input.AvailableAmount))
                ) && 
                (
                    this.BrandName == input.BrandName ||
                    (this.BrandName != null &&
                    this.BrandName.Equals(input.BrandName))
                ) && 
                (
                    this.ClauseTerms == input.ClauseTerms ||
                    this.ClauseTerms != null &&
                    input.ClauseTerms != null &&
                    this.ClauseTerms.SequenceEqual(input.ClauseTerms)
                ) && 
                (
                    this.DelayInfo == input.DelayInfo ||
                    (this.DelayInfo != null &&
                    this.DelayInfo.Equals(input.DelayInfo))
                ) && 
                (
                    this.Desc == input.Desc ||
                    (this.Desc != null &&
                    this.Desc.Equals(input.Desc))
                ) && 
                (
                    this.DescDetailList == input.DescDetailList ||
                    this.DescDetailList != null &&
                    input.DescDetailList != null &&
                    this.DescDetailList.SequenceEqual(input.DescDetailList)
                ) && 
                (
                    this.DisplayConfig == input.DisplayConfig ||
                    (this.DisplayConfig != null &&
                    this.DisplayConfig.Equals(input.DisplayConfig))
                ) && 
                (
                    this.DonateFlag == input.DonateFlag ||
                    (this.DonateFlag != null &&
                    this.DonateFlag.Equals(input.DonateFlag))
                ) && 
                (
                    this.EffectType == input.EffectType ||
                    (this.EffectType != null &&
                    this.EffectType.Equals(input.EffectType))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    (this.ExtInfo != null &&
                    this.ExtInfo.Equals(input.ExtInfo))
                ) && 
                (
                    this.ItemInfo == input.ItemInfo ||
                    (this.ItemInfo != null &&
                    this.ItemInfo.Equals(input.ItemInfo))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.MaxAmount == input.MaxAmount ||
                    (this.MaxAmount != null &&
                    this.MaxAmount.Equals(input.MaxAmount))
                ) && 
                (
                    this.MultiUseMode == input.MultiUseMode ||
                    (this.MultiUseMode != null &&
                    this.MultiUseMode.Equals(input.MultiUseMode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.RelativeTime == input.RelativeTime ||
                    (this.RelativeTime != null &&
                    this.RelativeTime.Equals(input.RelativeTime))
                ) && 
                (
                    this.RoundingRule == input.RoundingRule ||
                    (this.RoundingRule != null &&
                    this.RoundingRule.Equals(input.RoundingRule))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UseInstructions == input.UseInstructions ||
                    this.UseInstructions != null &&
                    input.UseInstructions != null &&
                    this.UseInstructions.SequenceEqual(input.UseInstructions)
                ) && 
                (
                    this.UseRule == input.UseRule ||
                    (this.UseRule != null &&
                    this.UseRule.Equals(input.UseRule))
                ) && 
                (
                    this.ValidateType == input.ValidateType ||
                    (this.ValidateType != null &&
                    this.ValidateType.Equals(input.ValidateType))
                ) && 
                (
                    this.VerifyMode == input.VerifyMode ||
                    (this.VerifyMode != null &&
                    this.VerifyMode.Equals(input.VerifyMode))
                ) && 
                (
                    this.VoucherImg == input.VoucherImg ||
                    (this.VoucherImg != null &&
                    this.VoucherImg.Equals(input.VoucherImg))
                ) && 
                (
                    this.VoucherNote == input.VoucherNote ||
                    (this.VoucherNote != null &&
                    this.VoucherNote.Equals(input.VoucherNote))
                ) && 
                (
                    this.WorthValue == input.WorthValue ||
                    (this.WorthValue != null &&
                    this.WorthValue.Equals(input.WorthValue))
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
                hashCode = (hashCode * 59) + this.AllowSplit.GetHashCode();
                if (this.AvailableAmount != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableAmount.GetHashCode();
                }
                if (this.BrandName != null)
                {
                    hashCode = (hashCode * 59) + this.BrandName.GetHashCode();
                }
                if (this.ClauseTerms != null)
                {
                    hashCode = (hashCode * 59) + this.ClauseTerms.GetHashCode();
                }
                if (this.DelayInfo != null)
                {
                    hashCode = (hashCode * 59) + this.DelayInfo.GetHashCode();
                }
                if (this.Desc != null)
                {
                    hashCode = (hashCode * 59) + this.Desc.GetHashCode();
                }
                if (this.DescDetailList != null)
                {
                    hashCode = (hashCode * 59) + this.DescDetailList.GetHashCode();
                }
                if (this.DisplayConfig != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayConfig.GetHashCode();
                }
                if (this.DonateFlag != null)
                {
                    hashCode = (hashCode * 59) + this.DonateFlag.GetHashCode();
                }
                if (this.EffectType != null)
                {
                    hashCode = (hashCode * 59) + this.EffectType.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.ItemInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ItemInfo.GetHashCode();
                }
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
                }
                if (this.MaxAmount != null)
                {
                    hashCode = (hashCode * 59) + this.MaxAmount.GetHashCode();
                }
                if (this.MultiUseMode != null)
                {
                    hashCode = (hashCode * 59) + this.MultiUseMode.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Rate != null)
                {
                    hashCode = (hashCode * 59) + this.Rate.GetHashCode();
                }
                if (this.RelativeTime != null)
                {
                    hashCode = (hashCode * 59) + this.RelativeTime.GetHashCode();
                }
                if (this.RoundingRule != null)
                {
                    hashCode = (hashCode * 59) + this.RoundingRule.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.UseInstructions != null)
                {
                    hashCode = (hashCode * 59) + this.UseInstructions.GetHashCode();
                }
                if (this.UseRule != null)
                {
                    hashCode = (hashCode * 59) + this.UseRule.GetHashCode();
                }
                if (this.ValidateType != null)
                {
                    hashCode = (hashCode * 59) + this.ValidateType.GetHashCode();
                }
                if (this.VerifyMode != null)
                {
                    hashCode = (hashCode * 59) + this.VerifyMode.GetHashCode();
                }
                if (this.VoucherImg != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherImg.GetHashCode();
                }
                if (this.VoucherNote != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherNote.GetHashCode();
                }
                if (this.WorthValue != null)
                {
                    hashCode = (hashCode * 59) + this.WorthValue.GetHashCode();
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
