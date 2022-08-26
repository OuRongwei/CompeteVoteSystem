using System;
using System.Collections.Generic;
using System.Text;
using VoteSystem.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace VoteSystem.Services
{
    public class UserServiceImp:IUserService
    {
        private readonly VoteSystem.Dal.TPContext m_Db;

        public UserServiceImp(VoteSystem.Dal.TPContext tPContext)
        {
            m_Db = tPContext;
        }

        /// <summary>
        /// 获取单个歌手
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUserByID(int id)
        {
            var query = from o in m_Db.Users
                        where o.Id == id
                        select o;

            return query.FirstOrDefault();
        }


        /// <summary>
        /// 保存投票记录
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public bool SaveJiLu(int singerId,int userId,int competeId)
        {
            //先把投票记录保存
            var item = new VoteList() { SingerId = singerId, UserId = userId, CompeteId= competeId };
            m_Db.voteLists.Add(item);

            User user = m_Db.Users.Find(userId);
            user.Ticket = false;
            m_Db.SaveChanges();

            return true;
        }
    }
}
