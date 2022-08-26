using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VMSystem.Model
{

    /// <summary>
    /// 成绩表
    /// </summary>
    [Table("TB_Score")]
    public class Score
    {
        public int Id { get; set; }
        /// <summary>
        /// 歌手拥有的总票数
        /// </summary>
        public string Tickets { get; set; }

        /// <summary>
        /// 评委打分
        /// </summary>
        public int JudgesScoring { get; set; }

        /// <summary>
        /// 歌手Id做外键
        /// </summary>
        public int SingerId { get; set; }

        /// <summary>
        /// 比赛Id做外键
        /// </summary>
        public int MatchId { get; set; }

        /// <summary>
        /// 一对多关系：一个分数只能属于一个选手，而一个选手可以有多个分数
        /// </summary>
        public Singer Singer { get; set; }

        /// <summary>
        /// 一对多关系：一个分数只能属于一场比赛，而一场比赛有多个分数
        /// </summary>
        public Match Match { get; set; }
    }
}
