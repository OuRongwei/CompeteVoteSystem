using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VMSystem.Model
{
    [Table("TB_Singer")]
    public class Singer
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public int Age { get; set; }

        public string Sex { get; set; }

        /// <summary>
        /// 个人简介
        /// </summary>
        public string PersonalProfile { get; set; }

        public string Phone { get; set; }

        /// <summary>
        /// 座右铭
        /// </summary>
        public string Motto { get; set; }

        /// <summary>
        /// 照片
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// 是否有资格参赛：第一次比赛结束后，把淘汰的选手设置为false，这样就不显示为false的歌手信息。
        /// </summary>
        public bool IsCompetition { get; set; }

        /// <summary>
        /// 一对多关系：一个歌手用很多的粉丝
        /// </summary>
        public ICollection<User> Users { get; set; } = new HashSet<User>();

        /// <summary>
        /// 一对多关系：一个歌手可以有多个成绩，一场比赛一个成绩，如果歌手进入总决赛就又有一个成绩了。
        /// </summary>
        public ICollection<Score> Scores { get; set; } = new HashSet<Score>();

        /// <summary>
        /// 多对多关系:歌手可参加多个比赛，比赛可有多个歌手参加
        /// </summary>
        public ICollection<SingerAndMatch> SingerAndMatchs { get; set; } = new HashSet<SingerAndMatch>();
    }
}
