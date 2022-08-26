using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VoteSystem.Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    [Table("TB_User")]
    public class User
    {
        // Id
        public int Id { get; set; }

        // 电话号码
        public string PhoneNo { get; set; }

        // 密码
        public string Password { get; set; }

        // 判断是否投票
        public bool Ticket { get; set; }

        // 一对多关系，一个选手只能选择一个歌手
        public ICollection<VoteList> VoteLists { get; set; } = new HashSet<VoteList>();
    }
}
