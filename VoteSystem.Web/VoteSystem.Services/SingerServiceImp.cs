using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VoteSystem.Model;
using VoteSystem.Dal;
namespace VoteSystem.Services
{
    public class SingerServiceImp : ISingerService
    {
        private readonly TPContext m_Db;

        public SingerServiceImp(TPContext tPContext)
        {
            m_Db = tPContext;
        }


        /// <summary>
        /// 获取所以歌手信息
        /// </summary>
        /// <returns></returns>
        public IQueryable<SingerAndSocreViewModel> GetSingers()
        {
            var query = from o in m_Db.Singers.Include(c => c.VoteLists).ThenInclude(c => c.User)
                        orderby o.VoteLists.Count descending
                        select new SingerAndSocreViewModel
                        {
                            Id = o.Id,
                            Age = o.Age,
                            Title = o.Title,
                            ImageUrl = o.ImageUrl,
                            Marry = o.Marry,
                            Name = o.Name,
                            PiaoShu = o.VoteLists.Count
                        };

            return query;
        }


        /// <summary>
        /// 获取单个歌手
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Singer GetSingerByID(int id)
        {
            var query = from o in m_Db.Singers
                        where o.Id == id
                        select o;

            return query.FirstOrDefault();
        }

        /// <summary>
        /// 保存歌手
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public bool SaveSinger(Singer singer)
        {
            var item = m_Db.Singers.Where(c => c.Id == singer.Id).FirstOrDefault();
            if (item == null)
            {
                m_Db.Singers.Add(singer);
            }
            else
            {
                item.Age = singer.Age;
                item.Title = singer.Title;
                item.Name = singer.Name;
                item.Marry = singer.Marry;
                item.ImageUrl = singer.ImageUrl;
            }
            m_Db.SaveChanges();

            return true;
        }


        /// <summary>
        /// 删除歌手
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public bool RemoveSinger(int singerId)
        {
            var item = (from o in m_Db.Singers.Include(c => c.CompeteAndSingers).Include(c => c.VoteLists) // 删除用户时联带其角色关系表的数据一起删除
                        where o.Id == singerId
                        select o).FirstOrDefault();

            if (item != null)
            {
                m_Db.Singers.Remove(item);
                m_Db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
