using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Sephiroth_IDao;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/*************************************************************************************
    * CLR 版本：       4.0.30319.33440
    * 类 名 称：       SYS_USER
    * 机器名称：       DESKTOP-BBO396R
    * 命名空间：       Entity
    * 文 件 名：       SYS_USER
    * 创建时间：       2016/7/18 10:54:30
    * 作    者：       
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace Entity
{
    /// <summary>
    /// 用户表
    /// </summary>
    [Table("SYS_USER")]
    public class SYS_USER: BaseEntity
    {
        

        
        /// <summary>
        /// 主键
        /// </summary>
        [Column("ROW_ID")]
        [MaxLength(50)]
        [Key]
        [Required]
        [DisplayName("主键")]
        public string ROW_ID { get; set; }

        
        /// <summary>
        /// 用户名
        /// </summary>
        [Column("USERNAME")]
        [MaxLength(50)]
        [DisplayName("用户名")]
        public string USERNAME { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("USERCODE")]
        [MaxLength(50)]
        public string USERCODE { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("PASSWORD")]
        [MaxLength(50)]
        public string PASSWORD { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("REMARK")]
        [MaxLength(50)]
        public string REMARK { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("CREATEDATE")]
        [MaxLength(23)]
        public DateTime? CREATEDATE { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("CREATEUSER")]
        [MaxLength(50)]
        public string CREATEUSER { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("LASTUSER")]
        [MaxLength(50)]
        public string LASTUSER { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [Column("LASTDATE")]
        [MaxLength(23)]
        public DateTime? LASTDATE { get; set; }

    }
}

