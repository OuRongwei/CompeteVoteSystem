using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VoteSystem.Model
{
    [Table("TB_CompeteAndSinger")]
    public class CompeteAndSinger
    {
        // Id
        public int Id { get; set; }

        // 歌手Id
        public int SingerId { get; set; }

        // 比赛Id
        public int CompeteId { get; set; }

        // 歌手
        public Singer Singer { get; set; }

        // 比赛
        public Compete Compete { get; set; }

    }
}
