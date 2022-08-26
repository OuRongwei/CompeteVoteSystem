using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VTMS.DbManager;
using VTMS.Models;

namespace VTMS.Service
{
    /// <summary>
    /// 歌手信息修改类
    /// </summary>
    public class SingerServiceImp : ISingerService
    {
        private readonly VoteContext m_Db;

        // 构造函数注入
        public SingerServiceImp(VoteContext voteContext)
        {
            m_Db = voteContext;
        }

        /// <summary>
        /// 通过Id查找歌手信息
        /// </summary>
        /// <param name="id">歌手Id</param>
        /// <returns></returns>
        public Singer GetSingerById(int id)
        {
            var query = from o in m_Db.Singers
                        where o.Id == id
                        select o;

            return query.FirstOrDefault();
        }

        /// <summary>
        /// 查找所有歌手信息
        /// </summary>
        /// <returns></returns>
        public IQueryable<Singer> GetSingers()
        {
            var result = m_Db.Singers;

            return result;
        }

        /// <summary>
        /// 删除歌手
        /// </summary>
        /// <param name="singerId">歌手Id</param>
        /// <returns></returns>
        public bool RemovesSinger(int singerId)
        {
            var item = (from o in m_Db.Singers.Include(c => c.CompeteAndSingers).Include(c => c.VoteLists)
                        where o.Id == singerId
                        select o).FirstOrDefault();

            if(item != null)
            {
                m_Db.Singers.Remove(item);
                m_Db.SaveChanges();

                return true;
            }

            return false;
        }

        /// <summary>
        /// 保存歌手
        /// </summary>
        /// <param name="singer">歌手信息</param>
        /// <returns></returns>
        public bool SaveSinger(Singer singer)
        {
            var item = m_Db.Singers.Where(c => c.Id == singer.Id).FirstOrDefault();

            if(item == null)
            {
                m_Db.Singers.Add(singer);
            }
            else
            {
                item.Name = singer.Name;
                item.Title = singer.Title;
                item.Age = singer.Age;
                item.Marry = singer.Marry;
                item.Brief = singer.Brief;
                item.ImageUrl = singer.ImageUrl;
            }

            m_Db.SaveChanges();

            return true;
        }
    }
}
