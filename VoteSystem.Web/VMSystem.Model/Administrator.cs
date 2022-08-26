using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VoteSystem.Model
{

    [Table("TB_Administrator")]
    public class Administrator
    {
        public int Id { get; set; }

        /// <summary>
        /// 管理员的用户名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 管理员密码
        /// </summary>
        public string Password  { get; set; }
    }
}
