using System;

namespace TERMS_V2.Domain.Entity
{
    /// <summary>
    /// 诊断信息
    /// </summary>
    [Serializable]
    public class MriEiDiagnosis : AggregateRoot
    {
        /// <summary>
        /// 唯一标识
        /// </summary>		
        public long NMriEiDiagnosisId { get; set; }

        /// <summary>
        /// 患者就诊基本信息表ID
        /// </summary>		
        public long NMriEiMasterInfoId { get; set; }

        /// <summary>
        /// 编目诊断类别ID（n_bd_hei_diagnosis_type_id）
        /// </summary>		
        public long NDiagnosisTypeCode { get; set; }

        /// <summary>
        /// 临床诊断
        /// </summary>		
        public string VClinicalDiagnosis { get; set; }

        /// <summary>
        /// 诊断编码（ICD10）(n_bd_hei_diagnose_icd_id)
        /// </summary>		
        public long? NDiagnosisIcdId { get; set; }

        /// <summary>
        /// 附加诊断编码 (n_bd_hei_diagnose_icd_id)
        /// </summary>		
        public string VDiagnosisExtraIcdId { get; set; }

        /// <summary>
        /// 诊断描述
        /// </summary>		
        public string VDiagnosisDesc { get; set; }

        /// <summary>
        /// 入院病情代码，则此字段取附录WS445.10.CV05.10.019.2013 入院病情代码，n_bd_hei_health_id相应字典相应ID
        /// </summary>		
        public long? NDiagnosisCode { get; set; }

        /// <summary>
        /// 顺序号（其他诊断有先后顺序，用于表示先后顺序）
        /// </summary>
        public long NSequence { get; set; }

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
    }
}