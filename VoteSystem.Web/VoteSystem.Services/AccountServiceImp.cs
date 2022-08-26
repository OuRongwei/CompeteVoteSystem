using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VoteSystem.Dal;
using VoteSystem.Model;

namespace VoteSystem.Services
{
    public class AccountServiceImp : IAccountService
    {
        private readonly TPContext m_Db;

        public AccountServiceImp(TPContext tPContext)
        {
            m_Db = tPContext;
        }

        public User GetOneUser(string phoneNo)
        {
            var user = m_Db.Users.Where(c => c.PhoneNo == phoneNo).FirstOrDefault();

            return user;
        }

        public bool RegisterUser(User user)
        {
            
            m_Db.Users.Add(user);
            m_Db.SaveChanges();
            return true;
        }
    }
}
