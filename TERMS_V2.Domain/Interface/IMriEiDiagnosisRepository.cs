using System;
using System.Collections.Generic;
using System.Text;
using TERMS_V2.Domain.Entity;

namespace TERMS_V2.Domain.Interface
{
    public interface IMriEiDiagnosisRepository
    {
        int Add(MriEiDiagnosis mriEiDiagnosis);
    }
}
