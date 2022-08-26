using System;
using System.Collections.Generic;
using System.Text;
using VoteSystem.Model;
using System.Linq;
using VoteSystem.Dal;

namespace VoteSystem.Services
{
    public class CompeteServiceImp:ICompeteService
    {
        private readonly TPContext m_Db;

        public CompeteServiceImp(TPContext tPContext)
        {
            m_Db = tPContext;
        }

        /// <summary>
        /// 获取单场比赛信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Compete GetOneCompeteInfo()
        {
            var query = from o in m_Db.Competes
                        where o.Id==1
                        select o;

            return query.FirstOrDefault();
        }
    }
}
