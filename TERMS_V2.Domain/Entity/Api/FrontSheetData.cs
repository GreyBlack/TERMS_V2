using System;
using System.Collections.Generic;
using System.Text;

namespace TERMS_V2.Domain.Entity
{
    public class FrontSheetData
    {
        /// <summary>
        /// 机构名称
        /// </summary>
        public long NBdHoiOrganizationId { get; set; }
        /// <summary>
        /// 医疗付款方式,此字段取附录医疗付款方式代码字典相应ID
        /// </summary>
        public long NMedicalPaymentTypeCode { get; set; }
        /// <summary>
        /// 健康卡号
        /// </summary>
        public string VHealthCardId { get; set; }
        /// <summary>
        /// 住院次数
        /// </summary>
        public int NInNumber { get; set; }
        /// <summary>
        /// 病案号
        /// </summary>
        public string VMedicalRecordNumber { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string VPatientName { get; set; }
        /// <summary>
        /// 性别,此字段取附录性别代码字典相应ID
        /// </summary>
        public int NGenderCode { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime DBirthday { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int NAge { get; set; }
        /// <summary>
        /// 国籍,此字段取附录国籍代码字典相应ID
        /// </summary>
        public long NNationalityCode { get; set; }
        /// <summary>
        /// (年龄不足1周岁的)年龄(月)
        /// </summary>
        public long NAgeMonth { get; set; }
        /// <summary>
        /// 新生儿出生体重(克)
        /// </summary>
        public int NBirthWeight { get; set; }
        /// <summary>
        /// 新生儿入院体重(克）
        /// </summary>
        public int NAdmWeight { get; set; }
        /// <summary>
        /// 民族,此字段取附录民族代码字典相应ID
        /// </summary>
        public long NNationCode { get; set; }
        /// <summary>
        /// 身份证号,如果身份证号码尾号为X，请大写X
        /// </summary>
        public string VIdNumber { get; set; }
        /// <summary>
        /// 职业,此字段取附录职业代码字典相应ID
        /// </summary>
        public long NOccupationCode { get; set; }
        /// <summary>
        /// 婚姻,此字段取附录婚姻状况代码字典相应ID
        /// </summary>
        public long NMarriageCode { get; set; }
        /// <summary>
        /// 现住址
        /// </summary>
        public string VCurrentAddress { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string VPhone { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public string VCurrentZipcode { get; set; }
        /// <summary>
        /// 户口地址
        /// </summary>
        public string VRegisteredAddress { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public string VRegisteredZipCode { get; set; }
        /// <summary>
        /// 工作单位及地址
        /// </summary>
        public string VCompany { get; set; }
        /// <summary>
        /// 单位电话
        /// </summary>
        public string VCompanyPhone { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public string VCompanyZipCode { get; set; }
        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string VContactPersonName { get; set; }
        /// <summary>
        /// 关系,此字段取附录联系人关系代码字典相应ID
        /// </summary>
        public long NContactPersonCode { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string VContactPersonAddress { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string VContactPersonPhone { get; set; }
        /// <summary>
        /// 入院途径,此字段取附录入院途径字典相应ID
        /// </summary>
        public long NAdmWayCode { get; set; }
        /// <summary>
        /// 入院时间
        /// </summary>
        public DateTime DAdmDatetime { get; set; }
        /// <summary>
        /// 入院科别,此字段取科室代码字典相应ID
        /// </summary>
        public long NAdmDeptId { get; set; }
        /// <summary>
        /// 入院病房
        /// </summary>
        public long NAdmWardId { get; set; }
        /// <summary>
        /// 转科科别,此字段取科室代码字典相应ID
        /// </summary>
        public long NTransDeptId { get; set; }
        /// <summary>
        /// 出院时间
        /// </summary>
        public DateTime DDisDatetime { get; set; }
        /// <summary>
        /// 出院科别,此字段取科室代码字典相应ID
        /// </summary>
        public long NDisDeptId { get; set; }
        /// <summary>
        /// 出院病房
        /// </summary>
        public long NDisWardId { get; set; }
        /// <summary>
        /// 实际住院(天)
        /// </summary>
        public int NActuallyInDays { get; set; }
        /// <summary>
        /// 中毒的外部原因
        /// </summary>
        public string VExternalReason { get; set; }
        /// <summary>
        /// 疾病编码,此字段取附录疾病分类代码字典相应ID
        /// </summary>
        public long NExternalReasonCode { get; set; }
        /// <summary>
        /// 病理号
        /// </summary>
        public string VPathologicalNumber { get; set; }
        /// <summary>
        /// 药物过敏
        /// </summary>
        public string CAllergy { get; set; }
        /// <summary>
        /// 过敏药物疾病
        /// </summary>
        public string VAllergyMaterial { get; set; }
        /// <summary>
        /// 死亡患者尸检
        /// </summary>
        public string CAutopsy { get; set; }
        /// <summary>
        /// 血型,此字段取附录血型编码字典相应ID
        /// </summary>
        public long NBloodTypeCode { get; set; }
        /// <summary>
        /// Rh,此字段取附录Rh字典相应ID
        /// </summary>
        public long NRhBloodTypeCode { get; set; }
        /// <summary>
        /// 科主任
        /// </summary>
        public long NDeptManagerId { get; set; }
        /// <summary>
        /// 主任（副主任）医师
        /// </summary>
        public long NSenDocId { get; set; }
        /// <summary>
        /// 主治医师
        /// </summary>
        public long NAttDocId { get; set; }
        /// <summary>
        /// 住院医师
        /// </summary>
        public long NInDocId { get; set; }
        /// <summary>
        /// 责任护士
        /// </summary>
        public long NPrimaryNurseId { get; set; }
        /// <summary>
        /// 进修医师
        /// </summary>
        public long NTraineeDocId { get; set; }
        /// <summary>
        /// 实习医师
        /// </summary>
        public long NInternshipDocId { get; set; }
        /// <summary>
        /// 编码员
        /// </summary>
        public long NCataloguerId { get; set; }
        /// <summary>
        /// 病案质量,此字段取病案质量字典相应ID
        /// </summary>
        public long NBdMmQualityId { get; set; }
        /// <summary>
        /// 质控医师
        /// </summary>
        public long NQualityDocId { get; set; }
        /// <summary>
        /// 质控护士
        /// </summary>
        public long NQualityNurseId { get; set; }
        /// <summary>
        /// 质控日期
        /// </summary>
        public DateTime DQualityCheckDatetime { get; set; }
        /// <summary>
        /// 离院方式,此字段取附录离院方式字典相应ID
        /// </summary>
        public long NDepartureWayCode { get; set; }
        /// <summary>
        /// 医嘱转院，拟接收医疗机构名称
        /// </summary>
        public string VReceivingHospital { get; set; }
        /// <summary>
        /// 医嘱转社区卫生服务机构/乡镇卫生院，拟接收医疗机构名称
        /// </summary>
        public string VReceivingTownshipHospital { get; set; }
        /// <summary>
        /// 是否有出院31天内再住院计划手术情况，1-无；2-有。
        /// </summary>
        public string CReAdmPlan { get; set; }
        /// <summary>
        /// 目的
        /// </summary>
        public string VReAdmPurpose { get; set; }
        /// <summary>
        /// 颅脑损伤患者昏迷入院前时间：分
        /// </summary>
        public long NComaTimeBefore { get; set; }
        /// <summary>
        /// 颅脑损伤患者昏迷入院后时间：分
        /// </summary>
        public long NComaTimeIn { get; set; }
        /// <summary>
        /// 住院费用(元)：总费用
        /// </summary>
        public double N00TotalFee { get; set; }
        /// <summary>
        /// 自付金额
        /// </summary>
        public double N00SelfPayFee { get; set; }
        /// <summary>
        /// 综合医疗服务类：(1)一般医疗服务费
        /// </summary>
        public double N01Ybylfwf { get; set; }
        /// <summary>
        /// 一般治疗操作费
        /// </summary>
        public double N02Ybzlczf { get; set; }
        /// <summary>
        /// 护理费住院费
        /// </summary>
        public double N03Hlf { get; set; }
        /// <summary>
        /// 其他费用
        /// </summary>
        public double N04Qtfy { get; set; }
        /// <summary>
        /// 诊断类：(5)病理诊断费
        /// </summary>
        public double N05Blzdf { get; set; }
        /// <summary>
        /// 实验室诊断费
        /// </summary>
        public double N06Syszdf { get; set; }
        /// <summary>
        /// 影像学诊断费
        /// </summary>
        public double N07Yxxzdf { get; set; }
        /// <summary>
        /// 临床诊断项目费
        /// </summary>
        public double N08Lczdxmf { get; set; }
        /// <summary>
        /// 治疗类：(9)非手术治疗项目费
        /// </summary>
        public double N09Fsszlf { get; set; }
        /// <summary>
        /// 临床物理治疗费
        /// </summary>
        public double N0901Lcwlzlf { get; set; }
        /// <summary>
        /// 手术治疗费
        /// </summary>
        public double N10Sszlf { get; set; }
        /// <summary>
        /// 麻醉费
        /// </summary>
        public double N1001Mzf { get; set; }
        /// <summary>
        /// 手术费
        /// </summary>
        public double N1002Ssf { get; set; }
        /// <summary>
        /// 康复类：(11)康复费
        /// </summary>
        public double N11Kff { get; set; }
        /// <summary>
        /// 中医类:(12)中医治疗费
        /// </summary>
        public double N12Zyzlf { get; set; }
        /// <summary>
        /// 西药类:(13)西药费
        /// </summary>
        public double N13Xyf { get; set; }
        /// <summary>
        /// 抗菌药物费
        /// </summary>
        public double N1301Kjywf { get; set; }
        /// <summary>
        /// 中药类:(14)中成药费
        /// </summary>
        public double N14Zchyf { get; set; }
        /// <summary>
        /// 中草药费
        /// </summary>
        public double N15Zcyf { get; set; }
        /// <summary>
        /// 血液和血液制品类:(16)血费
        /// </summary>
        public double N16Xf { get; set; }
        /// <summary>
        /// 白蛋白类制品费
        /// </summary>
        public double N17Bdblf { get; set; }
        /// <summary>
        /// 球蛋白类制品费
        /// </summary>
        public double N18Qdblf { get; set; }
        /// <summary>
        /// 凝血因子类制品费
        /// </summary>
        public double N19Nxyzf { get; set; }
        /// <summary>
        /// 细胞因子类制品费
        /// </summary>
        public double N20Xbyzf { get; set; }
        /// <summary>
        /// 耗材类:(21)检查用一次性医用材料费
        /// </summary>
        public double N21Jcyycxclf { get; set; }
        /// <summary>
        /// (22)治疗用一次性医用材料费
        /// </summary>
        public double N22Zlyycxclf { get; set; }
        /// <summary>
        /// (23)手术用一次性医用材料费
        /// </summary>
        public double N23Ssyycxclf { get; set; }
        /// <summary>
        /// 其他类：(24)其他费
        /// </summary>
        public double N24Qtf { get; set; }
        /// <summary>
        /// 第三方系统患者ID
        /// </summary>
        public string VSourcePatientId { get; set; }
        /// <summary>
        /// 第三方系统就诊ID
        /// </summary>
        public string VSourceEpisodeId { get; set; }
        /// <summary>
        /// 第三方系统患者信息主索引ID
        /// </summary>
        public string VSourceEmpiId { get; set; }
        /// <summary>
        /// 来源产商
        /// </summary>
        public long NAbdAiProductorId { get; set; }
        /// <summary>
        /// 当前状态，0-未编目；1-已编目
        /// </summary>
        public string CStatus { get; set; }
        /// <summary>
        /// 创建日期时间
        /// </summary>
        public DateTime DCreateDatetime { get; set; }
        /// <summary>
        /// 最后修改日期时间
        /// </summary>
        public DateTime DLastModifyDatetime { get; set; }
        /// <summary>
        /// 是否有效判别 0无效 1有效
        /// </summary>
        public string CActive { get; set; }
        /// <summary>
        /// 就诊基本信息ID
        /// </summary>
        public long NMriEiMasterInfoId { get; set; }
        /// <summary>
        /// 患者基本信息表ID
        /// </summary>
        public long NMriPiMasterInfoId { get; set; }
        /// <summary>
        /// 病案基本信息表ID
        /// </summary>
        public long NMriMiMasterInfoId { get; set; }
        public long NBirthProvenceCode { get; set; }
        public long NBirthCityCode { get; set; }
        public long NBirthCountyCode { get; set; }
        public long NNativeProvenceCode { get; set; }
        public long NNativeCityCode { get; set; }
        public string NOccupationName { get; set; }
    }
}
