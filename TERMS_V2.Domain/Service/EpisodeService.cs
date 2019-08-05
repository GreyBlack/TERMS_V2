using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TERMS_V2.Domain.Entity;
using TERMS_V2.Domain.Interface;

namespace TERMS_V2.Domain.Service
{
    public class EpisodeService
    {
        public IMriEiDiagnosisRepository MriEiDiagnosisRepository { get; set; }

        public void CreateDiagnosis(List<MriEiDiagnosis> diagnosis)
        {
            foreach (MriEiDiagnosis d in diagnosis)
            {
                MriEiDiagnosisRepository.Add(d);

            }
        }
    }
}
