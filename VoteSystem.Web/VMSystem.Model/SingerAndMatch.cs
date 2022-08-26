using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VMSystem.Model
{

    /// <summary>
    /// 歌手和比赛的中间表
    /// </summary>
    [Table("TB_SingerAndMatch")]
    public class SingerAndMatch
    {
        public int Id { get; set; }

        public int SingerId { get; set; }

        public int MatchId { get; set; }


        public Singer Singer { get; set; }

        public Match Match { get; set; }

    }
}
