using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VMSystem.Model
{

    /// <summary>
    /// 比赛信息表
    /// </summary>
    [Table("TB_Match")]
    public class Match
    {
        public int Id { get; set; }
        /// <summary>
        /// 比赛说明
        /// </summary>
        public string CompetitionDescription { get; set; }
        /// <summary>
        /// 基本主题
        /// </summary>
        public string BasicTheme { get; set; }

        /// <summary>
        /// 比赛开始时间
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 比赛结束时间
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 一对多关系：一个分数只能属于一场比赛，而一场比赛有多个分数
        /// </summary>
        public ICollection<Score> Scores { get; set; } = new HashSet<Score>();


        /// <summary>
        /// 多对多关系:歌手可参加多个比赛，比赛可有多个歌手参加
        /// </summary>
        public ICollection<SingerAndMatch> SingerAndMatchs { get; set; } = new HashSet<SingerAndMatch>();
    }
}
