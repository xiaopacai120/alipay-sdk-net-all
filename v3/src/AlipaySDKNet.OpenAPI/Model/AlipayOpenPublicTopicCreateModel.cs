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
    /// AlipayOpenPublicTopicCreateModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicTopicCreateModel")]
    public partial class AlipayOpenPublicTopicCreateModel : IEquatable<AlipayOpenPublicTopicCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicTopicCreateModel" /> class.
        /// </summary>
        /// <param name="imgUrl">营销位图片url, 尺寸为996*450，最大不超过5M，支持格式:.jpg、.png ，请先调用&lt;a href&#x3D;\&quot;https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload\&quot;&gt; 图片上传接口&lt;/a&gt;获得图片url。营销位需要展示头图时，必须填写该参数。.</param>
        /// <param name="linkType">跳转类型，网页:HTTP、小程序:APP，不传默认HTTP.</param>
        /// <param name="linkUrl">营销位跳转地址，点击营销位头图跳到的链接url。营销位需要展示头图时，必须填写该参数。.</param>
        /// <param name="subTitle">营销位描述。营销位需要展示头图时，必须填写该参数。.</param>
        /// <param name="title">营销位名称.</param>
        /// <param name="topicItems">营销位内容，数量限制：大于4个，小于8个.</param>
        public AlipayOpenPublicTopicCreateModel(string imgUrl = default(string), string linkType = default(string), string linkUrl = default(string), string subTitle = default(string), string title = default(string), List<TopicItem> topicItems = default(List<TopicItem>))
        {
            this.ImgUrl = imgUrl;
            this.LinkType = linkType;
            this.LinkUrl = linkUrl;
            this.SubTitle = subTitle;
            this.Title = title;
            this.TopicItems = topicItems;
        }

        /// <summary>
        /// 营销位图片url, 尺寸为996*450，最大不超过5M，支持格式:.jpg、.png ，请先调用&lt;a href&#x3D;\&quot;https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload\&quot;&gt; 图片上传接口&lt;/a&gt;获得图片url。营销位需要展示头图时，必须填写该参数。
        /// </summary>
        /// <value>营销位图片url, 尺寸为996*450，最大不超过5M，支持格式:.jpg、.png ，请先调用&lt;a href&#x3D;\&quot;https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload\&quot;&gt; 图片上传接口&lt;/a&gt;获得图片url。营销位需要展示头图时，必须填写该参数。</value>
        [DataMember(Name = "img_url", EmitDefaultValue = false)]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 跳转类型，网页:HTTP、小程序:APP，不传默认HTTP
        /// </summary>
        /// <value>跳转类型，网页:HTTP、小程序:APP，不传默认HTTP</value>
        [DataMember(Name = "link_type", EmitDefaultValue = false)]
        public string LinkType { get; set; }

        /// <summary>
        /// 营销位跳转地址，点击营销位头图跳到的链接url。营销位需要展示头图时，必须填写该参数。
        /// </summary>
        /// <value>营销位跳转地址，点击营销位头图跳到的链接url。营销位需要展示头图时，必须填写该参数。</value>
        [DataMember(Name = "link_url", EmitDefaultValue = false)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 营销位描述。营销位需要展示头图时，必须填写该参数。
        /// </summary>
        /// <value>营销位描述。营销位需要展示头图时，必须填写该参数。</value>
        [DataMember(Name = "sub_title", EmitDefaultValue = false)]
        public string SubTitle { get; set; }

        /// <summary>
        /// 营销位名称
        /// </summary>
        /// <value>营销位名称</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// 营销位内容，数量限制：大于4个，小于8个
        /// </summary>
        /// <value>营销位内容，数量限制：大于4个，小于8个</value>
        [DataMember(Name = "topic_items", EmitDefaultValue = false)]
        public List<TopicItem> TopicItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicTopicCreateModel {\n");
            sb.Append("  ImgUrl: ").Append(ImgUrl).Append("\n");
            sb.Append("  LinkType: ").Append(LinkType).Append("\n");
            sb.Append("  LinkUrl: ").Append(LinkUrl).Append("\n");
            sb.Append("  SubTitle: ").Append(SubTitle).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TopicItems: ").Append(TopicItems).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicTopicCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicTopicCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicTopicCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicTopicCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ImgUrl == input.ImgUrl ||
                    (this.ImgUrl != null &&
                    this.ImgUrl.Equals(input.ImgUrl))
                ) && 
                (
                    this.LinkType == input.LinkType ||
                    (this.LinkType != null &&
                    this.LinkType.Equals(input.LinkType))
                ) && 
                (
                    this.LinkUrl == input.LinkUrl ||
                    (this.LinkUrl != null &&
                    this.LinkUrl.Equals(input.LinkUrl))
                ) && 
                (
                    this.SubTitle == input.SubTitle ||
                    (this.SubTitle != null &&
                    this.SubTitle.Equals(input.SubTitle))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.TopicItems == input.TopicItems ||
                    this.TopicItems != null &&
                    input.TopicItems != null &&
                    this.TopicItems.SequenceEqual(input.TopicItems)
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
                if (this.ImgUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImgUrl.GetHashCode();
                }
                if (this.LinkType != null)
                {
                    hashCode = (hashCode * 59) + this.LinkType.GetHashCode();
                }
                if (this.LinkUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LinkUrl.GetHashCode();
                }
                if (this.SubTitle != null)
                {
                    hashCode = (hashCode * 59) + this.SubTitle.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.TopicItems != null)
                {
                    hashCode = (hashCode * 59) + this.TopicItems.GetHashCode();
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
