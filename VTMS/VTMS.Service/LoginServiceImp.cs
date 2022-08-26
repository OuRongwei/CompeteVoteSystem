using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VTMS.DbManager;
using VTMS.Models;

namespace VTMS.Service
{
    /// <summary>
    /// 登录验证管理类
    /// </summary>
    public class LoginServiceImp : ILoginService
    {
        private readonly VoteContext m_Db;

        public LoginServiceImp(VoteContext voteContext)
        {
            m_Db = voteContext;
        }

        /// <summary>
        /// 通过账号获取管理员对象
        /// </summary>
        /// <param name="account">管理员账号</param>
        /// <returns></returns>
        public Admin GetAdmin(string account)
        {
            var admin = m_Db.Admins.Where(c => c.Account == account).FirstOrDefault();

            return admin;
        }
    }
}
