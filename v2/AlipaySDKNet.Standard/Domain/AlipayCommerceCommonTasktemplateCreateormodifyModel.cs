using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonTasktemplateCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonTasktemplateCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 小程序跳转链接
        /// </summary>
        [XmlElement("applet_id")]
        public string AppletId { get; set; }

        /// <summary>
        /// 商户侧任务模板号，新建模板的时候必传，修改模板时，create_biz_no 与任务模板id至少一个必填
        /// </summary>
        [XmlElement("create_biz_no")]
        public string CreateBizNo { get; set; }

        /// <summary>
        /// 出资方的id
        /// </summary>
        [XmlElement("funder_id")]
        public string FunderId { get; set; }

        /// <summary>
        /// 激励规则
        /// </summary>
        [XmlElement("incentive_rule")]
        public RealAmountRatioIncentiveRule IncentiveRule { get; set; }

        /// <summary>
        /// 任务最大领取数量
        /// </summary>
        [XmlElement("max_receive_num")]
        public long MaxReceiveNum { get; set; }

        /// <summary>
        /// 代运营的商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 操作者openId
        /// </summary>
        [XmlElement("operate_open_id")]
        public string OperateOpenId { get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        [XmlElement("operate_user_id")]
        public string OperateUserId { get; set; }

        /// <summary>
        /// 活动方id
        /// </summary>
        [XmlElement("organizer_id")]
        public string OrganizerId { get; set; }

        /// <summary>
        /// 活动方名称
        /// </summary>
        [XmlElement("organizer_name")]
        public string OrganizerName { get; set; }

        /// <summary>
        /// 任务模板描述
        /// </summary>
        [XmlElement("task_desc")]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 任务结束时间
        /// </summary>
        [XmlElement("task_end_time")]
        public string TaskEndTime { get; set; }

        /// <summary>
        /// 任务模板名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务生效时间
        /// </summary>
        [XmlElement("task_start_time")]
        public string TaskStartTime { get; set; }

        /// <summary>
        /// 创建模板时，返回参数任务模板id， 修改模板时，任务模板id与外部模板号必传一个
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }
    }
}
