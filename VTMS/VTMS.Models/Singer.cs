using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VTMS.Models
{
    /// <summary>
    /// 歌手表
    /// </summary>
    [Table("TB_Singer")]
    public class Singer
    {
        // Id
        public int Id { get; set; }

        // 名字
        public string Name { get; set; }

        // 头衔
        public string Title { get; set; }

        // 年龄
        public int Age { get; set; }

        // 婚姻状况
        public int Marry { get; set; }

        // 简介
        public string Brief { get; set; }

        // 图片链接
        public string ImageUrl { get; set; }

        // 一对多关系，一个歌手可以有多人投票
        public ICollection<CompeteAndSinger> CompeteAndSingers { get; set; } = new HashSet<CompeteAndSinger>();

        // 一对多关系,一个歌手可以有多个投票纪录
        public ICollection<VoteList> VoteLists { get; set; } = new HashSet<VoteList>();
    }
}
