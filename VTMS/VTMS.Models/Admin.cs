using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VTMS.Models
{
    /// <summary>
    /// 管理员表
    /// </summary>
    [Table("TB_Admin")]
    public class Admin
    {
        // Id
        public int Id { get; set; }

        // 账号
        public string Account { get; set; }

        // 密码
        public string Password { get; set; }

        // 状态
        public int State { get; set; }
    }
}
