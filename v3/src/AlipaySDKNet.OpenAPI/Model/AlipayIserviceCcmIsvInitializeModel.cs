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
    /// AlipayIserviceCcmIsvInitializeModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmIsvInitializeModel")]
    public partial class AlipayIserviceCcmIsvInitializeModel : IEquatable<AlipayIserviceCcmIsvInitializeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmIsvInitializeModel" /> class.
        /// </summary>
        /// <param name="isvPubKey">用于接入CCM iframe接口安全认证的 ISV 公钥，采用 base64 编码，秘钥对生成算法为 RSA2048。.</param>
        public AlipayIserviceCcmIsvInitializeModel(string isvPubKey = default(string))
        {
            this.IsvPubKey = isvPubKey;
        }

        /// <summary>
        /// 用于接入CCM iframe接口安全认证的 ISV 公钥，采用 base64 编码，秘钥对生成算法为 RSA2048。
        /// </summary>
        /// <value>用于接入CCM iframe接口安全认证的 ISV 公钥，采用 base64 编码，秘钥对生成算法为 RSA2048。</value>
        [DataMember(Name = "isv_pub_key", EmitDefaultValue = false)]
        public string IsvPubKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmIsvInitializeModel {\n");
            sb.Append("  IsvPubKey: ").Append(IsvPubKey).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmIsvInitializeModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmIsvInitializeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmIsvInitializeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmIsvInitializeModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsvPubKey == input.IsvPubKey ||
                    (this.IsvPubKey != null &&
                    this.IsvPubKey.Equals(input.IsvPubKey))
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
                if (this.IsvPubKey != null)
                {
                    hashCode = (hashCode * 59) + this.IsvPubKey.GetHashCode();
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
