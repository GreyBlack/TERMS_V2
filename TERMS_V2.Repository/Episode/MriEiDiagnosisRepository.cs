using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TERMS_V2.Domain.Entity;
using TERMS_V2.Domain.Interface;
using Dapper;

namespace TERMS_V2.Repository
{
    public class MriEiDiagnosisRepository : BaseRepository<MriEiDiagnosis>, IMriEiDiagnosisRepository
    {
        public MriEiDiagnosisRepository(IDbContext context) : base(context) { }

        //public int Add(MriEiDiagnosis mriEiDiagnosis)
        //{
        //    return Context.Execute(
        //        @"INSERT INTO MRI_EI_DIAGNOSIS 
        //        (N_MRI_EI_DIAGNOSIS_ID, N_MRI_EI_MASTER_INFO_ID, N_DIAGNOSIS_TYPE_CODE, V_CLINICAL_DIAGNOSIS, N_DIAGNOSIS_ICD_ID, V_DIAGNOSIS_DESC, N_DIAGNOSIS_CODE, N_SEQUENCE, N_ABD_AI_PRODUCTOR_ID, D_CREATE_DATETIME, D_LAST_MODIFY_DATETIME, V_DIAGNOSIS_EXTRA_ICD_ID) 
        //        VALUES(:NMriEiDiagnosisId,:NMriEiMasterInfoId,:NDiagnosisTypeCode,:VClinicalDiagnosis,:NDiagnosisIcdId,:VDiagnosisDesc,:NDiagnosisCode,:NSequence,:NAbdAiProductorId,:DCreateDatetime,:DLastModifyDatetime,:VDiagnosisExtraIcdId)",
        //        mriEiDiagnosis,
        //        transaction: Transaction);
        //}
    }
}
