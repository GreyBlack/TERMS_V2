using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TERMS_V2.Domain.Entity
{
    public enum DiagnosisTypeEnum
    {
        [Description("主要诊断")]
        MAIN = 1,
        [Description("其他诊断")]
        OTHER = 2,
        [Description("门急诊诊断")]
        OUT = 3,
        [Description("入院诊断")]
        ADM = 4,
        [Description("病理诊断")]
        PIS = 5,
    }
}
