using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VTMS.Models
{
    /// <summary>
    /// 比赛表
    /// </summary>
    [Table("TB_Compete")]
    public class Compete
    {
        // Id
        public int Id { get; set; }

        // 比赛名称
        public string Name { get; set; }

        // 简介
        public string Brief { get; set; }

        // 图片
        public string ImageUrl { get; set; }

        // 开始时间
        public DateTime StartTime { get; set; }

        // 结束时间
        public DateTime EndTime { get; set; }

        // 一对多关系，一场比赛有多个歌手参加
        public ICollection<CompeteAndSinger> CompeteAndSingers { get; set; } = new HashSet<CompeteAndSinger>();

        // 一对多关系，一场比赛有多个投票纪录
        public ICollection<VoteList> VoteLists { get; set; } = new HashSet<VoteList>();
    }
}
