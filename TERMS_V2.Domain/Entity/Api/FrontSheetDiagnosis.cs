using System;
using System.Collections.Generic;
using System.Text;

namespace TERMS_V2.Domain.Entity
{
    public class FrontSheetDiagnosis
    {
        /// <summary>
        /// 诊断类别 MAIN-主要诊断,OTHER-其他诊断，OUT-门急诊诊断,ADM-入院诊断，PIS-病理诊断
        /// </summary>
        public string DiagnosisType { get; set; }
        /// <summary>
        /// 诊断编码 ICD-10
        /// </summary>
        public string DiagnosisICD { get; set; }
        /// <summary>
        /// 诊断附加编码 ICD-10
        /// </summary>
        public string DiagnosisExtraICD { get; set; }
        /// <summary>
        /// 诊断描述
        /// </summary>
        public string DiagnosisDesc { get; set; }
        /// <summary>
        /// 病情描述
        /// </summary>
        public string DiagnosisStateDesc { get; set; }
        /// <summary>
        /// 病情代码 1-有，2-临床未确定，3-情况不明，4-无
        /// </summary>
        public string DiagnosisStateCode { get; set; }
        /// <summary>
        /// 诊断唯一ID
        /// </summary>
        public string DiagnosisID { get; set; }
        /// <summary>
        /// 诊断关联ID（比如病理诊断关联的病理号）
        /// </summary>
        public string DiagnosisLinkedID { get; set; }
        /// <summary>
        /// 顺序号（其他诊断有先后顺序，用于表示先后顺序）
        /// </summary>
        public string DiagnosisSequence { get; set; }
    }
}
