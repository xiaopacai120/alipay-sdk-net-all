using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionDetailinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceInstitutionDetailinfoQueryModel : AopObject
    {
        /// <summary>
        /// 企业共同账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }
    }
}
