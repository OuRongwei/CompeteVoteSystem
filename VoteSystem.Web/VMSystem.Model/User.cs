using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VMSystem.Model
{
    [Table("TB_User")]
    public class User
    {

        public int Id { get; set; }
        /// <summary>
        /// 电话号码：作为用户的登录账号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 是否有投票权
        /// </summary>
        public bool Ticket { get; set; }
        /// <summary>
        /// 歌手Id，当用户和歌手关系的外键
        /// </summary>
        public int SingerId { get; set; }

        /// <summary>
        /// 一对多关系：一个用户只能选择一个歌手
        /// </summary>
        public Singer Singer { get; set; }
    }
}
