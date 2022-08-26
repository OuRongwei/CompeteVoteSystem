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
    /// 比赛操作类
    /// </summary>
    public class CompeteServiceImp : ICompeteService
    {
        private readonly VoteContext m_Db;

        public CompeteServiceImp(VoteContext voteContext)
        {
            m_Db = voteContext;
        }

        /// <summary>
        /// 通过Id获取比赛信息
        /// </summary>
        /// <param name="id">比赛Id</param>
        /// <returns></returns>
        public Compete GetCompeteById(int id)
        {
            var qury = from o in m_Db.Competes
                       where o.Id == id
                       select o;

            return qury.FirstOrDefault();
        }

        /// <summary>
        /// 获取所有比赛信息
        /// </summary>
        /// <returns></returns>
        public IQueryable<Compete> GetQueryable()
        {
            var result = m_Db.Competes;
            return result;
        }

        /// <summary>
        /// 删除比赛
        /// </summary>
        /// <param name="competeId">比赛Id</param>
        /// <returns></returns>
        public bool RemoveCompete(int competeId)
        {
            var item = (from o in m_Db.Competes.Include(c => c.CompeteAndSingers)
                        where o.Id == competeId
                        select o).FirstOrDefault();

            if(item != null)
            {
                m_Db.Competes.Remove(item);
                m_Db.SaveChanges();
                return true;
            }

            return false;
        }

        /// <summary>
        /// 保存比赛
        /// </summary>
        /// <param name="compete">比赛</param>
        /// <returns></returns>
        public bool SaveCompete(Compete compete)
        {
            var item = m_Db.Competes.Where(c => c.Id == compete.Id).FirstOrDefault();

            // 判断是此Id是否有数据，若有数据则进行修改，若没有直接添加

            // 添加数据
            if(item == null)
            {
                m_Db.Competes.Add(compete);
            }
            else  // 修改数据
            {
                item.Name = compete.Name;
                item.Brief = compete.Brief;
                item.StartTime = compete.StartTime;
                item.EndTime = compete.EndTime;
            }

            m_Db.SaveChanges();

            return true;
        }
    }
}
