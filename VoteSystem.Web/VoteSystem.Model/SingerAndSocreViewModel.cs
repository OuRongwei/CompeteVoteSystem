﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VoteSystem.Model
{
    public class SingerAndSocreViewModel
    {
        public int Id { get; set; }

        /// <summary>
        /// 照片
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 个人简介
        /// </summary>
        public string Brief { get; set; }

        /// <summary>
        /// 婚姻状况
        /// </summary>
        public int Marry { get; set; }

        /// <summary>
        /// 参赛资格：第一次比赛结束后，把淘汰的选手设置为false，这样就不显示为false的歌手信息。
        /// </summary>
        public bool IsCompetition { get; set; }

        /// <summary>
        /// 歌手票数
        /// </summary>
        public int PiaoShu { get; set; }

        /// <summary>
        /// 投票总人数
        /// </summary>
        public int TouPiaoZhongRenShu { get; set; }

        

        ///歌手总得分
        public double Score { get; set; }
    }
}
