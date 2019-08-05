using System;
using System.Collections.Generic;

namespace TERMS_V2.Domain.Entity
{
    public class BdHeiDiagnoseIcd : AggregateRoot
    {
        /// <summary>
        /// 唯一标识
        /// </summary>		
        public long NBdHeiDiagnoseIcdId { get; set; }

        /// <summary>
        /// ICD代码版本（ICD10）
        /// </summary>		
        public string VCodeVersion { get; set; }

        /// <summary>
        /// ICD疾病分类编码
        /// </summary>		
        public string VCode { get; set; }

        /// <summary>
        /// ICD疾病分类编码描述
        /// </summary>		
        public string VDescription { get; set; }

        /// <summary>
        /// ICD疾病分类编码简述
        /// </summary>		
        public string VShortDesc { get; set; }

        /// <summary>
        /// ICD编码
        /// </summary>		
        public string VIcdCode { get; set; }

        /// <summary>
        /// 扩充编码标识
        /// </summary>		
        public string CExpansionFlag { get; set; }

        /// <summary>
        /// 启用起始日期
        /// </summary>		
        public DateTime DDateActiveFrom { get; set; }

        /// <summary>
        /// 启用终止日期
        /// </summary>		
        public DateTime DDateActiveTo { get; set; }

        /// <summary>
        /// 是否有效判别 0无效 1有效
        /// </summary>		
        public string CActive { get; set; }

        /// <summary>
        /// 诊断名称拼音首字母，比如咽喉疣，yhy
        /// </summary>		
        public string VPinyinInitial { get; set; }
    }
}