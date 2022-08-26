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
    /// 用户操作类
    /// </summary>
    public class UserServiceImp : IUserService
    {
        private readonly VoteContext m_Db;

        public UserServiceImp(VoteContext voteContext)
        {
            m_Db = voteContext;
        }

        /// <summary>
        /// 通过Id获取用户信息
        /// </summary>
        /// <param name="id">用户Id</param>
        /// <returns></returns>
        public User GeTUserById(int id)
        {
            var query = from o in m_Db.Users
                        where o.Id == id
                        select o;

            return query.FirstOrDefault();
        }

        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        public IQueryable<User> GetUsers()
        {
            var result = m_Db.Users;

            return result;
        }

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        public bool RemoveUser(int userId)
        {
            var item = (from o in m_Db.Users.Include(c => c.VoteLists)
                         where o.Id == userId
                         select o).FirstOrDefault();

            if(item != null)
            {
                m_Db.Users.Remove(item);
                m_Db.SaveChanges();
                return true;
            }
            return false;
        }

        /// <summary>
        /// 保存用户
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns></returns>
        public bool SaveUser(User user)
        {
            var item = m_Db.Users.Where(c => c.Id == user.Id).FirstOrDefault();

            if(item == null)
            {
                m_Db.Users.Add(user);
            }
            else
            {
                item.PhoneNo = user.PhoneNo;
                item.Password = user.Password;
            }

            m_Db.SaveChanges();

            return true;
        }
    }
}
