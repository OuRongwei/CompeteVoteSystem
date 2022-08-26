using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VoteSystem.Model
{
    /// <summary>
    /// 投票记录表
    /// </summary>
    [Table("TB_VoteList")]
    public class VoteList
    {
        // Id
        public int Id { get; set; }

        // 用户Id
        public int UserId { get; set; }

        // 歌手Id
        public int SingerId { get; set; }

        // 比赛Id
        public int CompeteId { get; set; }

        // 用户
        public User User { get; set; }

        // 歌手
        public Singer Singer { get; set; }

        // 比赛
        public Compete Compete { get; set; }
    }
}
