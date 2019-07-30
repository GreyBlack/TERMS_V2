using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TERMS_V2.Domain.Entity
{
    public class BdUiUser : AggregateRoot
    {
        /// <summary>
        /// 唯一标识
        /// </summary>		
        public long NBdUiUserId { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>		
        public string VName { get; set; }

        /// <summary>
        /// 员工登录名
        /// </summary>		
        public string VInitials { get; set; }

        /// <summary>
        /// 默认登录科室ID （5.3.2 ID）
        /// </summary>		
        public long NDefaultBdHoiDepartmentId { get; set; }

        /// <summary>
        /// 默认员工组ID （5.4.2 ID）
        /// </summary>		
        public long NDefaultBdUiGroupId { get; set; }

        /// <summary>
        /// 是否医生判别
        /// </summary>		
        public string CIsDoctor { get; set; }

        /// <summary>
        /// 是否护士判别
        /// </summary>		
        public string CIsNurse { get; set; }

        /// <summary>
        /// 职称1代码
        /// </summary>		
        public string VTitleCode1 { get; set; }

        /// <summary>
        /// 职称1描述
        /// </summary>		
        public string VTitleDesc1 { get; set; }

        /// <summary>
        /// 职称2代码
        /// </summary>		
        public string VTitleCode2 { get; set; }

        /// <summary>
        /// 职称2描述
        /// </summary>		
        public string VTitleDesc2 { get; set; }

        /// <summary>
        /// 职称3代码
        /// </summary>		
        public string VTitleCode3 { get; set; }

        /// <summary>
        /// 职称3描述
        /// </summary>		
        public string VTitleDesc3 { get; set; }

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
        /// 介质序列号
        /// </summary>		
        public string VKeysn { get; set; }

        /// <summary>
        /// 身份唯一标识
        /// </summary>		
        public string VPaperid { get; set; }

        /// <summary>
        /// 移动协同签名系统用户ID
        /// </summary>		
        public string VMsspid { get; set; }

        /// <summary>
        /// 员工姓名全拼，比如张三，zhangsan
        /// </summary>		
        public string VPinyinFull { get; set; }

        /// <summary>
        /// 员工姓名拼音首字母，比如张三，zs
        /// </summary>		
        public string VPinyinInitial { get; set; }

        /// <summary>
        /// 密码hash值
        /// </summary>		
        public string VPasswordHash { get; set; }

        /// <summary>
        /// 用户来源厂商系统内ID，若来源于本系统则同n_bd_ui_user_id
        /// </summary>		
        public string VSourceId { get; set; }

        /// <summary>
        /// 来源厂商ID
        /// </summary>		
        public long NAbdAiProductorId { get; set; }
    }
}