using System;

namespace TERMS_V2.Domain.Entity
{
    public class MriEiMasterInfo
    {
        /// <summary>
        /// 唯一标识
        /// </summary>		
        public long NMriEiMasterInfoId { get; set; }

        /// <summary>
        /// 年龄（年）
        /// </summary>		
        public int NAge { get; set; }

        /// <summary>
        /// 年龄（月）
        /// </summary>		
        public int NAgeMonth { get; set; }

        /// <summary>
        /// 年龄（天）
        /// </summary>		
        public int NAgeDay { get; set; }

        /// <summary>
        /// 就诊总次数
        /// </summary>		
        public int NAdmNumber { get; set; }

        /// <summary>
        /// 住院总次数
        /// </summary>		
        public int NInNumber { get; set; }

        /// <summary>
        /// 住院天数
        /// </summary>		
        public int NInDays { get; set; }

        /// <summary>
        /// 实际住院天数
        /// </summary>		
        public int NActuallyInDays { get; set; }

        /// <summary>
        /// 就诊（入院）日期时间
        /// </summary>		
        public DateTime DAdmDatetime { get; set; }

        /// <summary>
        /// 出院日期时间
        /// </summary>		
        public DateTime DDisDatetime { get; set; }

        /// <summary>
        /// 死亡日期时间
        /// </summary>		
        public DateTime DDeathDatetime { get; set; }

        /// <summary>
        /// 入院科室ID （n_bd_hoi_department_id）
        /// </summary>		
        public long NAdmDeptId { get; set; }

        /// <summary>
        /// 入院病区ID （n_bd_hoi_ward_id）
        /// </summary>		
        public long NAdmWardId { get; set; }

        /// <summary>
        /// 出院科室ID （n_bd_hoi_department_id）
        /// </summary>		
        public long? NDisDeptId { get; set; }

        /// <summary>
        /// 出院病区ID （n_bd_hoi_ward_id）
        /// </summary>		
        public long NDisWardId { get; set; }

        /// <summary>
        /// 患者就诊类型代码，此字段取附录WS445.01.CV09.00.404.2013患者类型代码，n_bd_hei_health_id相应字典相应ID
        /// </summary>		
        public long? NAdmTypeCode { get; set; }

        /// <summary>
        /// 医保细分类类型，则此字段取附录WS445.01.CV02.01.204.2013 医疗保险类别代码，n_bd_hei_health_id相应字典相应ID
        /// </summary>		
        public long? NInsuranceTypeCode { get; set; }

        /// <summary>
        /// 非计划再次手术判别
        /// </summary>		
        public string CNoPlanAgainOperation { get; set; }

        /// <summary>
        /// 危重患者判别
        /// </summary>		
        public string CIsCritical { get; set; }

        /// <summary>
        /// 是否有出院31天内再住院计划判别
        /// </summary>		
        public string CReAdmPlan { get; set; }

        /// <summary>
        /// 颅内损伤患者昏迷时间（分钟），入院前
        /// </summary>		
        public long? NComaTimeBefore { get; set; }

        /// <summary>
        /// 颅内损伤患者昏迷时间（分钟），入院后
        /// </summary>		
        public long? NComaTimeIn { get; set; }

        /// <summary>
        /// 入院途径代码，则此字段取附录WS445.08.CV09.00.403.2013 入院途径代码，n_bd_hei_health_id相应字典相应ID
        /// </summary>		
        public long? NAdmWayCode { get; set; }

        /// <summary>
        /// 离院方式代码，则此字段取附录WS445.08.CV06.00.226.2013 离院方式代码，n_bd_hei_health_id相应字典相应ID
        /// </summary>		
        public long? NDepartureWayCode { get; set; }

        /// <summary>
        /// 损失中毒的外部原因编码（ICD10）(n_bd_hei_diagnose_icd_id)
        /// </summary>		
        public long? NExternalReasonCode { get; set; }

        /// <summary>
        /// 损失中毒的外部原因（可能没有编码，因此也需留存文字）
        /// </summary>		
        public string VExternalReason { get; set; }

        /// <summary>
        /// 药物过敏判别
        /// </summary>		
        public string CAllergy { get; set; }

        /// <summary>
        /// 过敏药物
        /// </summary>		
        public string VAllergyMaterial { get; set; }

        /// <summary>
        /// 死亡尸检判别
        /// </summary>		
        public string CAutopsy { get; set; }

        /// <summary>
        /// 患者就诊号（就诊信息来源厂商系统内ID）
        /// </summary>		
        public string VSourceId { get; set; }

        /// <summary>
        /// 来源厂商ID
        /// </summary>		
        public long NAbdAiProductorId { get; set; }

        /// <summary>
        /// 创建日期时间
        /// </summary>		
        public DateTime DCreateDatetime { get; set; }

        /// <summary>
        /// 最后修改日期时间
        /// </summary>		
        public DateTime? DLastModifyDatetime { get; set; }

        /// <summary>
        /// 是否有效判别 0无效 1有效
        /// </summary>		
        public string CActive { get; set; }
    }
}